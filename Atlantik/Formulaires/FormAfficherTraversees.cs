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
using static System.Windows.Forms.ListViewItem;

namespace Atlantik.Formulaires
{
    public partial class FormAfficherTraversees : Form
    {
        public FormAfficherTraversees()
        {
            InitializeComponent();
        }

        private void FormAfficherTraversees_Load(object sender, EventArgs e)
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
                    lblSecteurs.Items.Add(new Secteur(int.Parse(dataSecteur["nosecteur"].ToString()), dataSecteur["nom"].ToString()));
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
                var maCde = new MySqlCommand("select * from categorie ", maCnx);
                MySqlDataReader dataCat = maCde.ExecuteReader();

                while (dataCat.Read())
                {
                    ColumnHeader column = new ColumnHeader();
                    column.Tag = dataCat["lettrecategorie"].ToString();
                    column.Text = "Places " + dataCat["libelle"].ToString();
                    column.Width = 140;
                    lvTraversees.Columns.Add(column);
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

        private void lblSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secteur secteur = ((Secteur)lblSecteurs.SelectedItem);
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

        private void btnAfficherTraversees_Click(object sender, EventArgs e)
        {
            lvTraversees.Items.Clear();
            Liaison liaison = ((Liaison)cbxLiaisons.SelectedItem);
            if (liaison == null || dtpDateTrav.Text == String.Empty)
            {
                MessageBox.Show("Certains champs sont manquants", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<int> listNoVtraversees = new List<int>();

            MySqlConnection maCnx;
            maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
            try
            {
                maCnx.Open();
                var maCde = new MySqlCommand("select t.notraversee from traversee t, liaison l, secteur s where t.noliaison = l.noliaison and s.nosecteur = @NOSECTEUR and t.dateheuredepart like @DATE and l.noliaison = @NOLIAISON", maCnx);
                maCde.Parameters.AddWithValue("@NOSECTEUR", liaison.NoSecteur);
                maCde.Parameters.AddWithValue("@DATE", dtpDateTrav.Text + '%');
                maCde.Parameters.AddWithValue("@NOLIAISON", liaison.NoLiaison);
                MySqlDataReader dataNoTrav = maCde.ExecuteReader();

                while (dataNoTrav.Read())
                {
                    int notrav = int.Parse(dataNoTrav["notraversee"].ToString());

                    maCnx = new MySqlConnection("Server=127.0.0.1;Port=3306;" + "User Id=root;Password=;Database=atlantik-cv;");
                    try
                    {
                        maCnx.Open();
                        maCde = new MySqlCommand(
                            "select t.notraversee, bat.nom, t.dateheuredepart, cat.lettrecategorie, cat.libelle, c.capacitemax - sum(e.quantite) as 'places' " +
                            "from traversee t, reservation r, enregistrer e, bateau bat, liaison l, categorie cat, contenir c " +
                            "where t.notraversee = r.notraversee " +
                            "and cat.lettrecategorie = e.lettrecategorie " +
                            "and bat.nobateau = t.nobateau " +
                            "and l.noliaison = t.noliaison " +
                            "and c.nobateau = bat.nobateau " +
                            "and c.lettrecategorie = cat.lettrecategorie " +
                            "and e.noreservation = r.noreservation " +
                            "and t.notraversee = @NOTRAV " +
                            "group by e.lettrecategorie " +
                            "union " +
                            "SELECT t.notraversee, bat.nom, t.dateheuredepart, cat.lettrecategorie, cat.libelle, c.capacitemax " +
                            "FROM traversee t, bateau bat, contenir c, categorie cat " +
                            "WHERE t.nobateau = bat.nobateau " +
                            "and c.nobateau = bat.nobateau " +
                            "and c.lettrecategorie = cat.lettrecategorie " +
                            "and t.notraversee = @NOTRAV " +
                            "and cat.lettrecategorie not in (" +
                            "    select cat.lettrecategorie " +
                            "    from traversee t, reservation r, enregistrer e, bateau bat, liaison l, categorie cat, contenir c " +
                            "    where t.notraversee = r.notraversee " +
                            "    and cat.lettrecategorie = e.lettrecategorie " +
                            "    and bat.nobateau = t.nobateau " +
                            "    and l.noliaison = t.noliaison " +
                            "    and c.nobateau = bat.nobateau " +
                            "    and c.lettrecategorie = cat.lettrecategorie " +
                            "    and e.noreservation = r.noreservation " +
                            "    and t.notraversee = @NOTRAV " +
                            "    group by e.lettrecategorie)"
                            , maCnx);
                        maCde.Parameters.AddWithValue("@NOTRAV", notrav);
                        MySqlDataReader dataTrav = maCde.ExecuteReader();

                        while (dataTrav.Read())
                        {
                            string[] items = { dataTrav["notraversee"].ToString(), dataTrav["nom"].ToString(), DateTime.Parse(dataTrav["dateheuredepart"].ToString()).ToShortTimeString().ToString(), dataTrav["places"].ToString() };
                            if (lvTraversees.Items.Count > 0 && lvTraversees.Items[lvTraversees.Items.Count - 1].SubItems.Count > 0 && lvTraversees.Items[lvTraversees.Items.Count - 1].SubItems[0].Text == dataTrav["notraversee"].ToString())
                            {
                                lvTraversees.Items[lvTraversees.Items.Count - 1].SubItems.Add(dataTrav["places"].ToString()).Tag = dataTrav["lettrecategorie"];
                            }
                            else
                            {
                                ListViewItem item = new ListViewItem(items);
                                item.Tag = dataTrav["lettrecategorie"];
                                lvTraversees.Items.Add(item).Tag = dataTrav["notraversee"];
                            }
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

            if (lvTraversees.Items.Count == 0) MessageBox.Show("Aucunes traversées trouvées", "Atlantik Manager Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
