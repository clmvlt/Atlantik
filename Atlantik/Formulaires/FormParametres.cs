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
    public partial class FormParametres : Form
    {
        public FormParametres()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tbxId.Text == String.Empty || tbxRang.Text == String.Empty || tbxId.Text == String.Empty || rtbxCle.Text == String.Empty || tbxMelSite.Text == String.Empty)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxId.Text.HasLetters())
            {
                MessageBox.Show("Le champ ID ne doit pas contenir de lettres.", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("update parametres  set site_pb = @SITE, rang_pb = @RANG,  identifiant_pb = @ID, clehmac_pb = @CLE, enproduction = @PROD, melsite = @MELSITE where noidentifiant = 1", maCnx);
                maCde.Parameters.AddWithValue("@SITE", tbxSite.Text);
                maCde.Parameters.AddWithValue("@RANG", tbxRang.Text);
                maCde.Parameters.AddWithValue("@ID", int.Parse(tbxId.Text));
                maCde.Parameters.AddWithValue("@CLE", rtbxCle.Text);
                maCde.Parameters.AddWithValue("@PROD", cbEnProduction.Checked ? 1 : 0);
                maCde.Parameters.AddWithValue("@MELSITE", tbxMelSite.Text);

                int nbLignes = maCde.ExecuteNonQuery();

                if (nbLignes != 0)
                {
                    MessageBox.Show("Les paramtères ont bien été modifiés", "Atlantik Manager Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void FormParametres_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from parametres", maCnx);

                MySqlDataReader dataParametres = maCde.ExecuteReader();

                while (dataParametres.Read())
                {
                    tbxId.Text = dataParametres["identifiant_pb"].ToString();
                    tbxMelSite.Text = dataParametres["melsite"].ToString();
                    tbxRang.Text = dataParametres["rang_pb"].ToString();
                    tbxSite.Text = dataParametres["site_pb"].ToString();
                    rtbxCle.Text = dataParametres["clehmac_pb"].ToString();
                    cbEnProduction.Checked = Boolean.Parse(dataParametres["enproduction"].ToString());
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
    }
}
