
namespace Atlantik.Formulaires
{
    partial class FormAjouterTraversee
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSecteurs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLiaisons = new System.Windows.Forms.ComboBox();
            this.cbxBateaux = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.dtpArrivee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secteurs :";
            // 
            // lbSecteurs
            // 
            this.lbSecteurs.FormattingEnabled = true;
            this.lbSecteurs.Location = new System.Drawing.Point(12, 25);
            this.lbSecteurs.Name = "lbSecteurs";
            this.lbSecteurs.Size = new System.Drawing.Size(175, 238);
            this.lbSecteurs.TabIndex = 1;
            this.lbSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbSecteurs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laisons :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom bateau :";
            // 
            // cbxLiaisons
            // 
            this.cbxLiaisons.FormattingEnabled = true;
            this.cbxLiaisons.Location = new System.Drawing.Point(15, 304);
            this.cbxLiaisons.Name = "cbxLiaisons";
            this.cbxLiaisons.Size = new System.Drawing.Size(172, 21);
            this.cbxLiaisons.TabIndex = 4;
            // 
            // cbxBateaux
            // 
            this.cbxBateaux.FormattingEnabled = true;
            this.cbxBateaux.Location = new System.Drawing.Point(292, 22);
            this.cbxBateaux.Name = "cbxBateaux";
            this.cbxBateaux.Size = new System.Drawing.Size(200, 21);
            this.cbxBateaux.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Départ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arrivée :";
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDepart.Location = new System.Drawing.Point(292, 85);
            this.dtpDepart.MaxDate = new System.DateTime(2099, 12, 18, 0, 0, 0, 0);
            this.dtpDepart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDepart.Size = new System.Drawing.Size(139, 20);
            this.dtpDepart.TabIndex = 8;
            this.dtpDepart.Value = new System.DateTime(2022, 3, 18, 0, 0, 0, 0);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(417, 302);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dtpArrivee
            // 
            this.dtpArrivee.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivee.Location = new System.Drawing.Point(292, 141);
            this.dtpArrivee.MaxDate = new System.DateTime(2099, 12, 18, 0, 0, 0, 0);
            this.dtpArrivee.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpArrivee.Name = "dtpArrivee";
            this.dtpArrivee.Size = new System.Drawing.Size(139, 20);
            this.dtpArrivee.TabIndex = 11;
            this.dtpArrivee.Value = new System.DateTime(2022, 3, 18, 0, 0, 0, 0);
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 366);
            this.Controls.Add(this.dtpArrivee);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxBateaux);
            this.Controls.Add(this.cbxLiaisons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSecteurs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAjouterTraversee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Ajouter Traversée";
            this.Load += new System.EventHandler(this.FormAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSecteurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLiaisons;
        private System.Windows.Forms.ComboBox cbxBateaux;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dtpArrivee;
    }
}