
namespace Atlantik
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.tsAccueil = new System.Windows.Forms.ToolStrip();
            this.tsddAjouter = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterPort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAjouterTarifs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAJouterTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddModifier = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddAfficher = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAfficherTraversees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddOption = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsAccueil
            // 
            this.tsAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddAjouter,
            this.tsddModifier,
            this.tsddAfficher,
            this.tsddOption});
            this.tsAccueil.Location = new System.Drawing.Point(0, 0);
            this.tsAccueil.Name = "tsAccueil";
            this.tsAccueil.Size = new System.Drawing.Size(632, 25);
            this.tsAccueil.TabIndex = 0;
            this.tsAccueil.Text = "toolStrip1";
            // 
            // tsddAjouter
            // 
            this.tsddAjouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSecteur,
            this.tsmiAjouterPort,
            this.tsmiAjouterLiaison,
            this.tsmiAjouterBateau,
            this.tsmiAjouterTarifs,
            this.tsmiAJouterTraversee});
            this.tsddAjouter.Image = ((System.Drawing.Image)(resources.GetObject("tsddAjouter.Image")));
            this.tsddAjouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddAjouter.Name = "tsddAjouter";
            this.tsddAjouter.Size = new System.Drawing.Size(59, 22);
            this.tsddAjouter.Text = "Ajouter";
            // 
            // tsmiSecteur
            // 
            this.tsmiSecteur.Name = "tsmiSecteur";
            this.tsmiSecteur.Size = new System.Drawing.Size(122, 22);
            this.tsmiSecteur.Text = "Secteur";
            this.tsmiSecteur.Click += new System.EventHandler(this.tsmiSecteur_Click);
            // 
            // tsmiAjouterPort
            // 
            this.tsmiAjouterPort.Name = "tsmiAjouterPort";
            this.tsmiAjouterPort.Size = new System.Drawing.Size(122, 22);
            this.tsmiAjouterPort.Text = "Port";
            this.tsmiAjouterPort.Click += new System.EventHandler(this.tsmiAjouterPort_Click);
            // 
            // tsmiAjouterLiaison
            // 
            this.tsmiAjouterLiaison.Name = "tsmiAjouterLiaison";
            this.tsmiAjouterLiaison.Size = new System.Drawing.Size(122, 22);
            this.tsmiAjouterLiaison.Text = "Liaison";
            this.tsmiAjouterLiaison.Click += new System.EventHandler(this.tsmiAjouterLiaison_Click);
            // 
            // tsmiAjouterBateau
            // 
            this.tsmiAjouterBateau.Name = "tsmiAjouterBateau";
            this.tsmiAjouterBateau.Size = new System.Drawing.Size(122, 22);
            this.tsmiAjouterBateau.Text = "Bateau";
            this.tsmiAjouterBateau.Click += new System.EventHandler(this.tsmiAjouterBateau_Click);
            // 
            // tsmiAjouterTarifs
            // 
            this.tsmiAjouterTarifs.Name = "tsmiAjouterTarifs";
            this.tsmiAjouterTarifs.Size = new System.Drawing.Size(122, 22);
            this.tsmiAjouterTarifs.Text = "Tarifs";
            this.tsmiAjouterTarifs.Click += new System.EventHandler(this.tsmiAjouterTarifs_Click);
            // 
            // tsmiAJouterTraversee
            // 
            this.tsmiAJouterTraversee.Name = "tsmiAJouterTraversee";
            this.tsmiAJouterTraversee.Size = new System.Drawing.Size(122, 22);
            this.tsmiAJouterTraversee.Text = "Traversée";
            this.tsmiAJouterTraversee.Click += new System.EventHandler(this.tsmiAJouterTraversee_Click);
            // 
            // tsddModifier
            // 
            this.tsddModifier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifierBateau});
            this.tsddModifier.Image = ((System.Drawing.Image)(resources.GetObject("tsddModifier.Image")));
            this.tsddModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddModifier.Name = "tsddModifier";
            this.tsddModifier.Size = new System.Drawing.Size(65, 22);
            this.tsddModifier.Text = "Modifier";
            // 
            // tsmiModifierBateau
            // 
            this.tsmiModifierBateau.Name = "tsmiModifierBateau";
            this.tsmiModifierBateau.Size = new System.Drawing.Size(110, 22);
            this.tsmiModifierBateau.Text = "Bateau";
            this.tsmiModifierBateau.Click += new System.EventHandler(this.tsmiModiferBateau_Click);
            // 
            // tsddAfficher
            // 
            this.tsddAfficher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAfficherTraversees,
            this.tsmiReservations});
            this.tsddAfficher.Image = ((System.Drawing.Image)(resources.GetObject("tsddAfficher.Image")));
            this.tsddAfficher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddAfficher.Name = "tsddAfficher";
            this.tsddAfficher.Size = new System.Drawing.Size(62, 22);
            this.tsddAfficher.Text = "Afficher";
            // 
            // tsmiAfficherTraversees
            // 
            this.tsmiAfficherTraversees.Name = "tsmiAfficherTraversees";
            this.tsmiAfficherTraversees.Size = new System.Drawing.Size(140, 22);
            this.tsmiAfficherTraversees.Text = "Traversées";
            this.tsmiAfficherTraversees.Click += new System.EventHandler(this.tsmiAfficherTraversees_Click);
            // 
            // tsmiReservations
            // 
            this.tsmiReservations.Name = "tsmiReservations";
            this.tsmiReservations.Size = new System.Drawing.Size(140, 22);
            this.tsmiReservations.Text = "Réservations";
            this.tsmiReservations.Click += new System.EventHandler(this.tsmiReservations_Click);
            // 
            // tsddOption
            // 
            this.tsddOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiParametres});
            this.tsddOption.Image = ((System.Drawing.Image)(resources.GetObject("tsddOption.Image")));
            this.tsddOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddOption.Name = "tsddOption";
            this.tsddOption.Size = new System.Drawing.Size(57, 22);
            this.tsddOption.Text = "Option";
            // 
            // tsmiParametres
            // 
            this.tsmiParametres.Name = "tsmiParametres";
            this.tsmiParametres.Size = new System.Drawing.Size(133, 22);
            this.tsmiParametres.Text = "Paramtères";
            this.tsmiParametres.Click += new System.EventHandler(this.tsmiParametres_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atlantik.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(80, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tsAccueil);
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atlantik Manager - Accueil";
            this.tsAccueil.ResumeLayout(false);
            this.tsAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAccueil;
        private System.Windows.Forms.ToolStripDropDownButton tsddAjouter;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecteur;
        private System.Windows.Forms.ToolStripDropDownButton tsddAfficher;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterPort;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterLiaison;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterBateau;
        private System.Windows.Forms.ToolStripMenuItem tsmiAfficherTraversees;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterTarifs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAJouterTraversee;
        private System.Windows.Forms.ToolStripDropDownButton tsddModifier;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem tsmiReservations;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton tsddOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiParametres;
    }
}

