
namespace Atlantik.Formulaires
{
    partial class FormAjouterTarifs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecteurs = new System.Windows.Forms.ListBox();
            this.gbxCatType = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbxPeriodes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Secteurs :";
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.FormattingEnabled = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 42);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(188, 251);
            this.lblSecteurs.TabIndex = 9;
            this.lblSecteurs.SelectedIndexChanged += new System.EventHandler(this.lblSecteurs_SelectedIndexChanged);
            // 
            // gbxCatType
            // 
            this.gbxCatType.Location = new System.Drawing.Point(279, 18);
            this.gbxCatType.Name = "gbxCatType";
            this.gbxCatType.Size = new System.Drawing.Size(364, 384);
            this.gbxCatType.TabIndex = 11;
            this.gbxCatType.TabStop = false;
            this.gbxCatType.Text = "Tarifs par Catégorie - Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Liaison :";
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(12, 326);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(188, 21);
            this.cbxLiaison.TabIndex = 13;
            this.cbxLiaison.TextChanged += new System.EventHandler(this.cbxLiaison_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Période :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(568, 417);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbxPeriodes
            // 
            this.cbxPeriodes.FormattingEnabled = true;
            this.cbxPeriodes.Location = new System.Drawing.Point(15, 397);
            this.cbxPeriodes.Name = "cbxPeriodes";
            this.cbxPeriodes.Size = new System.Drawing.Size(185, 21);
            this.cbxPeriodes.TabIndex = 20;
            // 
            // FormAjouterTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.cbxPeriodes);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxCatType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSecteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAjouterTarifs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Ajouter Tarifs";
            this.Load += new System.EventHandler(this.FormAjouterTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lblSecteurs;
        private System.Windows.Forms.GroupBox gbxCatType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbxPeriodes;
    }
}