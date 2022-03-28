using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik.Formulaires
{
    public partial class FormAjouterBateau : Form
    {
        public FormAjouterBateau()
        {
            InitializeComponent();
        }

        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from categorie", maCnx);

                MySqlDataReader dataSecteur = maCde.ExecuteReader();

                int y = 0;
                while (dataSecteur.Read())
                {
                    y += 40;
                    Label label = new Label();
                    label.Text = dataSecteur["lettrecategorie"].ToString() + $" ({dataSecteur["libelle"]}) :";
                    label.Location = new Point(30, y);

                    TextBox textbox = new TextBox();
                    textbox.Tag = dataSecteur["lettrecategorie"];
                    textbox.Location = new Point(130, y - 3);

                    gbxCapMax.Controls.Add(textbox);
                    gbxCapMax.Controls.Add(label);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString(), "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbxNomBateau.Text == String.Empty)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (TextBox tbx in gbxCapMax.Controls.OfType<TextBox>())
            {
                if (tbx.Text == String.Empty)
                {
                    MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DialogResult drConfirmation = MessageBox.Show("Voulez-vous valider l'ajout ?", "Atlantik Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drConfirmation != DialogResult.Yes)
            {
                MessageBox.Show("L'ajout a été annulé!", "Atlantik Manager Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MySqlConnection maCnx;
            long idBat = -1;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("insert into bateau (nom) values (@NOMBATEAU)", maCnx);
                maCde.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);

                maCde.ExecuteNonQuery();
                idBat = maCde.LastInsertedId;

                foreach (TextBox textbox in gbxCapMax.Controls.OfType<TextBox>())
                {
                    maCde = new MySqlCommand("insert into contenir values (@LETTRECAT, @NOBATEAU, @CAPMAX)", maCnx);
                    maCde.Parameters.AddWithValue("@LETTRECAT", textbox.Tag.ToString());
                    maCde.Parameters.AddWithValue("@NOBATEAU", idBat);
                    maCde.Parameters.AddWithValue("@CAPMAX", int.Parse(textbox.Text));

                    maCde.ExecuteNonQuery();
                }

                MessageBox.Show("Bateau Ajouté!", "Atlantik Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.ToString(), "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
    }
}
