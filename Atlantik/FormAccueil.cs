using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlantik.Formulaires;

namespace Atlantik
{
    public partial class FormAccueil : Form
    {
        FormAjouterSecteur formAjouterSecteur;
        FormAjouterPort formAjouterPort;
        formAjouterLiaison formAjouterLiaison;
        FormAjouterBateau formAjouterBateau;
        FormModifierBateau formModifierBateau;
        FormAjouterTarifs formAjouterTarifs;
        FormAjouterTraversee formAjouterTraversee;
        FormAfficherTraversees formAfficherTraversees;
        FormAfficherReservations formAfficherReservations;
        FormParametres formParametres;

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void tsmiSecteur_Click(object sender, EventArgs e)
        {
            formAjouterSecteur = new FormAjouterSecteur();
            formAjouterSecteur.ShowDialog();
        }

        private void tsmiAjouterPort_Click(object sender, EventArgs e)
        {
            formAjouterPort = new FormAjouterPort();
            formAjouterPort.ShowDialog();
        }

        private void tsmiAjouterLiaison_Click(object sender, EventArgs e)
        {
            formAjouterLiaison = new formAjouterLiaison();
            formAjouterLiaison.ShowDialog();
        }

        private void tsmiAjouterBateau_Click(object sender, EventArgs e)
        {
            formAjouterBateau = new FormAjouterBateau();
            formAjouterBateau.ShowDialog();
        }

        private void tsmiModiferBateau_Click(object sender, EventArgs e)
        {
            formModifierBateau = new FormModifierBateau();
            formModifierBateau.ShowDialog();
        }

        private void tsmiAjouterTarifs_Click(object sender, EventArgs e)
        {
            formAjouterTarifs = new FormAjouterTarifs();
            formAjouterTarifs.ShowDialog();
        }

        private void tsmiAJouterTraversee_Click(object sender, EventArgs e)
        {
            formAjouterTraversee = new FormAjouterTraversee();
            formAjouterTraversee.ShowDialog();
        }

        private void tsmiAfficherTraversees_Click(object sender, EventArgs e)
        {
            formAfficherTraversees = new FormAfficherTraversees();
            formAfficherTraversees.ShowDialog();
        }

        private void tsmiReservations_Click(object sender, EventArgs e)
        {
            formAfficherReservations = new FormAfficherReservations();
            formAfficherReservations.ShowDialog();
        }

        private void tsmiParametres_Click(object sender, EventArgs e)
        {
            formParametres = new FormParametres();
            formParametres.ShowDialog();
        }
    }
}
