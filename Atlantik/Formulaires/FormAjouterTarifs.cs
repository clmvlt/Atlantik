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
    public partial class FormAjouterTarifs : Form
    {
        public FormAjouterTarifs()
        {
            InitializeComponent();
        }

        private void FormAjouterTarifs_Load(object sender, EventArgs e)
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
                    lbSecteurs.Items.Add(new Secteur(int.Parse(dataSecteur["nosecteur"].ToString()), dataSecteur["nom"].ToString()));
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
                var maCde = new MySqlCommand("SELECT * FROM type", maCnx);

                MySqlDataReader dataType = maCde.ExecuteReader();

                int y = 5;
                while (dataType.Read())
                {
                    y += 40;
                    Label label = new Label();
                    label.Text = dataType["lettrecategorie"].ToString() + dataType["notype"].ToString() + $" ({dataType["libelle"]}) :";
                    label.Location = new Point(30, y);
                    label.Size = new Size(200, 20);

                    TextBox textbox = new TextBox();
                    textbox.Tag = dataType["lettrecategorie"].ToString() + ';' + dataType["notype"].ToString();
                    textbox.Location = new Point(200, y - 3);

                    gbxCatType.Controls.Add(textbox);
                    gbxCatType.Controls.Add(label);
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
                var maCde = new MySqlCommand("select * from periode", maCnx);

                MySqlDataReader dataPeriode = maCde.ExecuteReader();

                while (dataPeriode.Read())
                {
                    cbxPeriodes.Items.Add(new Periode(int.Parse(dataPeriode["noperiode"].ToString()), DateTime.Parse(dataPeriode["datedebut"].ToString()),  DateTime.Parse(dataPeriode["datefin"].ToString())));
                    cbxPeriodes.SelectedIndex = 0;
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

        private void lbSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secteur secteur = ((Secteur)lbSecteurs.SelectedItem);
            cbxLiaison.Items.Clear();
            cbxLiaison.Text = String.Empty;

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
                    cbxLiaison.Items.Add(new Liaison(int.Parse(dataLiaison["noliaison"].ToString()), secteur.NoSecteur, int.Parse(dataLiaison["noport_depart"].ToString()), int.Parse(dataLiaison["noport_arrivee"].ToString()), double.Parse(dataLiaison["distance"].ToString()), (string)dataLiaison["pDep"], (string)dataLiaison["pArr"]));
                    cbxLiaison.SelectedIndex = 0; 
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
            if (lbSecteurs.SelectedItem == null || cbxLiaison.SelectedItem == null || cbxPeriodes.SelectedItem == null)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (TextBox textbox in gbxCatType.Controls.OfType<TextBox>())
            {
                if (textbox.Text == String.Empty)
                {
                    MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textbox.Text.HasLetters())
                {
                    MessageBox.Show("Le champ " + textbox.Tag.ToString().Replace(";", "") + " ne doit pas contenir de lettres.", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select count(*) from tarifer where noperiode = @NOPERIODE and noliaison = @NOLIAISON", maCnx);
                maCde.Parameters.AddWithValue("@NOPERIODE", ((Periode)cbxPeriodes.SelectedItem).NoPeriode);
                maCde.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cbxLiaison.SelectedItem).NoLiaison);
                var count = maCde.ExecuteScalar();

                if (int.Parse(count.ToString()) > 0)
                {
                    MessageBox.Show("Les tarifs pour cette traversée sont déjà renseignés!", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                foreach (TextBox textbox in gbxCatType.Controls.OfType<TextBox>())
                {
                    if (textbox.Tag == null) continue;
                    string[] args = textbox.Tag.ToString().Split(';');
                    var lettre = args[0];
                    var notype = args[1];
                    var maCde = new MySqlCommand("insert into tarifer (noperiode, lettrecategorie, notype, noliaison, tarif) values (@NOPERIODE, @LETTRECAT, @NOTYPE, @NOLIAISON, @TARIF)", maCnx);
                    maCde.Parameters.AddWithValue("@NOPERIODE", ((Periode)cbxPeriodes.SelectedItem).NoPeriode);
                    maCde.Parameters.AddWithValue("@LETTRECAT", lettre);
                    maCde.Parameters.AddWithValue("@NOTYPE", notype);
                    maCde.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cbxLiaison.SelectedItem).NoLiaison);
                    maCde.Parameters.AddWithValue("@TARIF", textbox.Text);

                    maCde.ExecuteNonQuery();
                }

                MessageBox.Show("Tarification ajouté!", "Atlantik Information - Ajouter Tarif", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbxLiaison_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
