
namespace Atlantik.Formulaires
{
    partial class formAjouterLiaison
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
            this.lblSecteurs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDeparts = new System.Windows.Forms.ComboBox();
            this.cbxArrivees = new System.Windows.Forms.ComboBox();
            this.tbxDist = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.FormattingEnabled = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 38);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(188, 251);
            this.lblSecteurs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Départ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arrivée :";
            // 
            // cbxDeparts
            // 
            this.cbxDeparts.FormattingEnabled = true;
            this.cbxDeparts.Location = new System.Drawing.Point(281, 37);
            this.cbxDeparts.Name = "cbxDeparts";
            this.cbxDeparts.Size = new System.Drawing.Size(121, 21);
            this.cbxDeparts.TabIndex = 4;
            // 
            // cbxArrivees
            // 
            this.cbxArrivees.FormattingEnabled = true;
            this.cbxArrivees.Location = new System.Drawing.Point(499, 37);
            this.cbxArrivees.Name = "cbxArrivees";
            this.cbxArrivees.Size = new System.Drawing.Size(121, 21);
            this.cbxArrivees.TabIndex = 5;
            // 
            // tbxDist
            // 
            this.tbxDist.Location = new System.Drawing.Point(508, 175);
            this.tbxDist.Name = "tbxDist";
            this.tbxDist.Size = new System.Drawing.Size(100, 20);
            this.tbxDist.TabIndex = 6;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(533, 267);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Secteurs :";
            // 
            // formAjouterLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxDist);
            this.Controls.Add(this.cbxArrivees);
            this.Controls.Add(this.cbxDeparts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSecteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAjouterLiaison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Ajouter Liaison";
            this.Load += new System.EventHandler(this.formAjouterLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblSecteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDeparts;
        private System.Windows.Forms.ComboBox cbxArrivees;
        private System.Windows.Forms.TextBox tbxDist;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
    }
}