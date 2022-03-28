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
    public partial class FormAfficherReservations : Form
    {
        public FormAfficherReservations()
        {
            InitializeComponent();
        }

        private void FormAfficherReservations_Load(object sender, EventArgs e)
        {
            Label lblNoResSel = new Label();
            lblNoResSel.Text = "Aucune réservation selectionnée";
            lblNoResSel.Location = new Point(91, 123);
            lblNoResSel.Size = new Size(162, 13);
            gbxDetailRes.Controls.Add(lblNoResSel);

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from client", maCnx);

                MySqlDataReader dataClient = maCde.ExecuteReader();

                while (dataClient.Read())
                {
                    cbxClients.Items.Add(new Client((int)dataClient["noclient"], (int)dataClient["codepostal"], (string)dataClient["nom"], (string)dataClient["prenom"], (string)dataClient["adresse"], (string)dataClient["ville"], (string)dataClient["telephonefixe"], (string)dataClient["telephonemobile"], (string)dataClient["mel"], (string)dataClient["motdepasse"]));
                    cbxClients.SelectedIndex = 0;
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

        private void cbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvReservations.Items.Clear();
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select r.noreservation, pDep.noport as 'pNoDep', pDep.nom as 'pDep', pArr.noport as 'pNoArr', pArr.nom as 'pArr', t.dateheuredepart, t.notraversee from client c, reservation r, traversee t, liaison l, port pDep, port pArr where c.noclient = r.noreservation and r.notraversee = t.notraversee and l.noliaison = t.noliaison and l.noport_depart = pDep.noport and l.noport_arrivee = pArr.noport", maCnx);

                MySqlDataReader dataClient = maCde.ExecuteReader();

                while (dataClient.Read())
                {
                    Port depart = new Port((int)dataClient["pNoDep"], (string)dataClient["pDep"]);
                    Port arrive = new Port((int)dataClient["pNoArr"], (string)dataClient["pArr"]);
                    string[] items = { ((int)dataClient["noreservation"]).ToString(), depart.NomPort + " - " + arrive.NomPort, ((int)dataClient["notraversee"]).ToString(), dataClient["dateheuredepart"].ToString() };
                    lvReservations.Items.Add(new ListViewItem(items));
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

        private void lvReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxDetailRes.Controls.Clear();
            if (lvReservations.SelectedItems.Count == 0 || lvReservations.SelectedItems[0].SubItems.Count == 0)
            {
                Label lblNoResSel = new Label();
                lblNoResSel.Text = "Aucune réservation selectionnée";
                lblNoResSel.Location = new Point(91, 123);
                lblNoResSel.Size = new Size(162, 13);
                gbxDetailRes.Controls.Add(lblNoResSel);
                return;
            }
            int noRes = int.Parse(lvReservations.SelectedItems[0].SubItems[0].Text);

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select * from reservation r, enregistrer e, type t where r.noreservation = e.noreservation and e.lettrecategorie = t.lettrecategorie and e.notype = t.notype and r.noreservation = 1", maCnx);

                MySqlDataReader dataDetailRes = maCde.ExecuteReader();

                int y = 0;
                while (dataDetailRes.Read())
                {
                    y += 40;
                    Label lblCateType = new Label();
                    lblCateType.Text = dataDetailRes["libelle"].ToString() + " : ";
                    lblCateType.Location = new Point(30, y);

                    Label lblQuantite = new Label();
                    lblQuantite.Tag = dataDetailRes["lettrecategorie"].ToString() + dataDetailRes["notype"].ToString();
                    lblQuantite.Text = dataDetailRes["quantite"].ToString();
                    lblQuantite.Location = new Point(130, y);

                    gbxDetailRes.Controls.Add(lblQuantite);
                    gbxDetailRes.Controls.Add(lblCateType);
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
