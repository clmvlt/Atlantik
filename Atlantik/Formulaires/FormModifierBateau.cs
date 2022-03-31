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
using Atlantik.Class;

namespace Atlantik.Formulaires
{
    public partial class FormModifierBateau : Form
    {
        public FormModifierBateau()
        {
            InitializeComponent();
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from bateau", maCnx);

                MySqlDataReader dataBateau = maCde.ExecuteReader();

                while (dataBateau.Read())
                {
                    cbxNomsBateaux.Items.Add(new Bateau(int.Parse(dataBateau["nobateau"].ToString()), dataBateau["nom"].ToString()));
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

        private void cbxNomsBateaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxCapMax.Controls.Clear();
            Bateau bateau = ((Bateau)cbxNomsBateaux.SelectedItem);

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from categorie cat, contenir c where cat.lettrecategorie = c.lettrecategorie and c.nobateau = @NOBATEAU", maCnx);
                maCde.Parameters.AddWithValue("@NOBATEAU", bateau.NoBateau);

                MySqlDataReader dataCat = maCde.ExecuteReader();

                int y = 0;
                while (dataCat.Read())
                {
                    y += 40;
                    Label label = new Label();
                    label.Text = dataCat["lettrecategorie"].ToString() + $" ({dataCat["libelle"]}) :";
                    label.Location = new Point(30, y);

                    TextBox textbox = new TextBox();
                    textbox.Tag = dataCat["lettrecategorie"];
                    textbox.Text = dataCat["capacitemax"].ToString();
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Bateau bateau = ((Bateau)cbxNomsBateaux.SelectedItem);
            if (cbxNomsBateaux.SelectedItem == null)
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

                if (!tbx.Text.IsOnlyDigit())
                {
                    MessageBox.Show("Le champ " + tbx.Tag.ToString().Replace(";", "") + " ne doit pas contenir de lettres.", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            DialogResult drConfirmation = MessageBox.Show("Voulez-vous valider la modification ?", "Atlantik Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drConfirmation != DialogResult.Yes)
            {
                MessageBox.Show("La modification a été annulé!", "Atlantik Manager Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                MySqlCommand maCde;

                foreach (TextBox textbox in gbxCapMax.Controls.OfType<TextBox>())
                {
                    maCde = new MySqlCommand("update contenir set capacitemax = @CAPMAX where nobateau = @NOBATEAU and lettrecategorie = @LETTRECAT", maCnx);
                    maCde.Parameters.AddWithValue("@LETTRECAT", textbox.Tag.ToString());
                    maCde.Parameters.AddWithValue("@NOBATEAU", bateau.NoBateau);
                    maCde.Parameters.AddWithValue("@CAPMAX", int.Parse(textbox.Text));

                    maCde.ExecuteNonQuery();
                }

                MessageBox.Show("Bateau Modifié!", "Atlantik Information - Modifier Bateau", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
