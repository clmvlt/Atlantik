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
    public partial class formAjouterLiaison : Form
    {
        public formAjouterLiaison()
        {
            InitializeComponent();
        }

        private void formAjouterLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from secteur", maCnx);

                MySqlDataReader dataSecteur = maCde.ExecuteReader();
                
                while (dataSecteur.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(dataSecteur["nosecteur"].ToString()), dataSecteur["nom"].ToString()));
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

            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select a.nom as nomDepart, a.noport as noDepart, d.nom as nomArrive, d.noport as noArrive from port a, port d where a.noport = d.noport", maCnx);

                MySqlDataReader dataPort = maCde.ExecuteReader();

                while (dataPort.Read())
                {
                    cbxDeparts.Items.Add(new Port(int.Parse(dataPort["noDepart"].ToString()), dataPort["nomDepart"].ToString()));
                    cbxArrivees.Items.Add(new Port(int.Parse(dataPort["noArrive"].ToString()), dataPort["nomArrive"].ToString()));
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
            if (lbxSecteurs.SelectedItem == null || cbxDeparts.SelectedItem == null || cbxArrivees.SelectedItem == null || tbxDist.Text == String.Empty)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!tbxDist.Text.IsDouble())
            {
                MessageBox.Show("La distance doit être un double.", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult drConfirmation = MessageBox.Show("Voulez-vous valider l'ajout ?", "Atlantik Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drConfirmation != DialogResult.Yes)
            {
                MessageBox.Show("L'ajout a été annulé!", "Atlantik Manager Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Secteur secteur = ((Secteur)lbxSecteurs.SelectedItem);

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("insert into liaison (nosecteur, noport_depart, noport_arrivee, distance) values (@NOSECTEUR, @PDEPART, @PARRIVE, @DIST)", maCnx);
                maCde.Parameters.AddWithValue("@NOSECTEUR", secteur.NoSecteur);
                maCde.Parameters.AddWithValue("@PDEPART", ((Port)cbxDeparts.SelectedItem).NoPort);
                maCde.Parameters.AddWithValue("@PARRIVE", ((Port)cbxArrivees.SelectedItem).NoPort);
                maCde.Parameters.AddWithValue("@DIST", double.Parse(tbxDist.Text.Replace('.', ',')));

                maCde.ExecuteNonQuery();
                MessageBox.Show("Liaison Ajouté!", "Atlantik Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
