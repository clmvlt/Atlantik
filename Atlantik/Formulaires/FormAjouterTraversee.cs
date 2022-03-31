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
    public partial class FormAjouterTraversee : Form
    {
        public FormAjouterTraversee()
        {
            InitializeComponent();
        }

        private void FormAjouterTraversee_Load(object sender, EventArgs e)
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
                var maCde = new MySqlCommand("select * from bateau", maCnx);

                MySqlDataReader dataBateau = maCde.ExecuteReader();

                while (dataBateau.Read())
                {
                    cbxBateaux.Items.Add(new Bateau(int.Parse(dataBateau["nobateau"].ToString()), dataBateau["nom"].ToString()));
                    cbxBateaux.SelectedIndex = 0;
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

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secteur secteur = ((Secteur)lbxSecteurs.SelectedItem);
            cbxLiaisons.Items.Clear();
            cbxLiaisons.Text = String.Empty;

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select l.noliaison, l.noport_depart, l.noport_arrivee, l.distance, pDep.nom as 'pDep', pArr.nom as 'pArr' from liaison l, port pDep, port pArr where nosecteur = @NOSECTEUR and l.noport_depart = pDep.noport and l.noport_arrivee = pArr.noport", maCnx);
                maCde.Parameters.AddWithValue("@NOSECTEUR", secteur.NoSecteur);

                MySqlDataReader dataLiaison = maCde.ExecuteReader();

                while (dataLiaison.Read())
                {
                    cbxLiaisons.Items.Add(new Liaison(int.Parse(dataLiaison["noliaison"].ToString()), secteur.NoSecteur, int.Parse(dataLiaison["noport_depart"].ToString()), int.Parse(dataLiaison["noport_arrivee"].ToString()), double.Parse(dataLiaison["distance"].ToString()), (string)dataLiaison["pDep"], (string)dataLiaison["pArr"]));
                    cbxLiaisons.SelectedIndex = 0;
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbxBateaux.SelectedItem == null || cbxLiaisons.SelectedItem == null)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Parse(dtpDepart.Text) > DateTime.Parse(dtpArrivee.Text))
            {
                MessageBox.Show("La date de départ doit être inférieure à celle d'arrivée!", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult drConfirmation = MessageBox.Show("Voulez-vous valider l'ajout ?", "Atlantik Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drConfirmation != DialogResult.Yes)
            {
                MessageBox.Show("L'ajout a été annulé!", "Atlantik Manager Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                
                var maCde = new MySqlCommand("insert into traversee (noliaison, nobateau, dateheuredepart, dateheurearrivee) values (@NOLIAISON, @NOBATEAU, @DATEDEPART, @DATEARRIVEE)", maCnx);
                maCde.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cbxLiaisons.SelectedItem).NoLiaison);
                maCde.Parameters.AddWithValue("@NOBATEAU", ((Bateau)cbxBateaux.SelectedItem).NoBateau);
                maCde.Parameters.AddWithValue("@DATEDEPART", dtpDepart.Text);
                maCde.Parameters.AddWithValue("@DATEARRIVEE", dtpArrivee.Text);

                maCde.ExecuteNonQuery();

                MessageBox.Show("Traversée ajoutée!", "Atlantik Information - Ajouter Tarif", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
