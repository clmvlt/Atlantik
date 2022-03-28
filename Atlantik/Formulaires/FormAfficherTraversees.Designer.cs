
namespace Atlantik.Formulaires
{
    partial class FormAfficherTraversees
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
            this.cbxLiaisons = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSecteurs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateTrav = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAfficherTraversees = new System.Windows.Forms.Button();
            this.lvTraversees = new System.Windows.Forms.ListView();
            this.chnotrav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNomBateau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbxLiaisons
            // 
            this.cbxLiaisons.FormattingEnabled = true;
            this.cbxLiaisons.Location = new System.Drawing.Point(15, 306);
            this.cbxLiaisons.Name = "cbxLiaisons";
            this.cbxLiaisons.Size = new System.Drawing.Size(172, 21);
            this.cbxLiaisons.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Laisons :";
            // 
            // lbSecteurs
            // 
            this.lbSecteurs.FormattingEnabled = true;
            this.lbSecteurs.Location = new System.Drawing.Point(12, 27);
            this.lbSecteurs.Name = "lbSecteurs";
            this.lbSecteurs.Size = new System.Drawing.Size(175, 238);
            this.lbSecteurs.TabIndex = 6;
            this.lbSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbSecteurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Secteurs :";
            // 
            // dtpDateTrav
            // 
            this.dtpDateTrav.CustomFormat = "yyyy-MM-dd";
            this.dtpDateTrav.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTrav.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDateTrav.Location = new System.Drawing.Point(268, 27);
            this.dtpDateTrav.MaxDate = new System.DateTime(2099, 12, 18, 0, 0, 0, 0);
            this.dtpDateTrav.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateTrav.Name = "dtpDateTrav";
            this.dtpDateTrav.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateTrav.Size = new System.Drawing.Size(98, 20);
            this.dtpDateTrav.TabIndex = 9;
            this.dtpDateTrav.Value = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date :";
            // 
            // btnAfficherTraversees
            // 
            this.btnAfficherTraversees.Location = new System.Drawing.Point(236, 69);
            this.btnAfficherTraversees.Name = "btnAfficherTraversees";
            this.btnAfficherTraversees.Size = new System.Drawing.Size(156, 23);
            this.btnAfficherTraversees.TabIndex = 11;
            this.btnAfficherTraversees.Text = "Afficher les traversées";
            this.btnAfficherTraversees.UseVisualStyleBackColor = true;
            this.btnAfficherTraversees.Click += new System.EventHandler(this.btnAfficherTraversees_Click);
            // 
            // lvTraversees
            // 
            this.lvTraversees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chnotrav,
            this.chNomBateau,
            this.chHeure});
            this.lvTraversees.HideSelection = false;
            this.lvTraversees.Location = new System.Drawing.Point(236, 98);
            this.lvTraversees.Name = "lvTraversees";
            this.lvTraversees.Size = new System.Drawing.Size(749, 340);
            this.lvTraversees.TabIndex = 12;
            this.lvTraversees.UseCompatibleStateImageBehavior = false;
            this.lvTraversees.View = System.Windows.Forms.View.Details;
            // 
            // chnotrav
            // 
            this.chnotrav.Text = "Num Traversée";
            this.chnotrav.Width = 152;
            // 
            // chNomBateau
            // 
            this.chNomBateau.Text = "Bateau";
            this.chNomBateau.Width = 97;
            // 
            // chHeure
            // 
            this.chHeure.Text = "Heure";
            this.chHeure.Width = 82;
            // 
            // FormAfficherTraversees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.lvTraversees);
            this.Controls.Add(this.btnAfficherTraversees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateTrav);
            this.Controls.Add(this.cbxLiaisons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSecteurs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAfficherTraversees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Afficher Traversées";
            this.Load += new System.EventHandler(this.FormAfficherTraversees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLiaisons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSecteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTrav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfficherTraversees;
        private System.Windows.Forms.ListView lvTraversees;
        private System.Windows.Forms.ColumnHeader chnotrav;
        private System.Windows.Forms.ColumnHeader chNomBateau;
        private System.Windows.Forms.ColumnHeader chHeure;
    }
}