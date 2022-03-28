
namespace Atlantik.Formulaires
{
    partial class FormModifierBateau
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
            this.gbxCapMax = new System.Windows.Forms.GroupBox();
            this.lblSelBateau = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNomsBateaux = new System.Windows.Forms.ComboBox();
            this.gbxCapMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCapMax
            // 
            this.gbxCapMax.Controls.Add(this.lblSelBateau);
            this.gbxCapMax.Location = new System.Drawing.Point(228, 12);
            this.gbxCapMax.Name = "gbxCapMax";
            this.gbxCapMax.Size = new System.Drawing.Size(345, 162);
            this.gbxCapMax.TabIndex = 7;
            this.gbxCapMax.TabStop = false;
            this.gbxCapMax.Text = "Capacités Maximales";
            // 
            // lblSelBateau
            // 
            this.lblSelBateau.AutoSize = true;
            this.lblSelBateau.Location = new System.Drawing.Point(105, 99);
            this.lblSelBateau.Name = "lblSelBateau";
            this.lblSelBateau.Size = new System.Drawing.Size(122, 13);
            this.lblSelBateau.TabIndex = 0;
            this.lblSelBateau.Text = "Selectionnez un bateau.";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(147, 151);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom Bateau :";
            // 
            // cbxNomsBateaux
            // 
            this.cbxNomsBateaux.FormattingEnabled = true;
            this.cbxNomsBateaux.Location = new System.Drawing.Point(94, 38);
            this.cbxNomsBateaux.Name = "cbxNomsBateaux";
            this.cbxNomsBateaux.Size = new System.Drawing.Size(121, 21);
            this.cbxNomsBateaux.TabIndex = 8;
            this.cbxNomsBateaux.SelectedIndexChanged += new System.EventHandler(this.cbxNomsBateaux_SelectedIndexChanged);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 186);
            this.Controls.Add(this.cbxNomsBateaux);
            this.Controls.Add(this.gbxCapMax);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormModifierBateau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModifierBateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.gbxCapMax.ResumeLayout(false);
            this.gbxCapMax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapMax;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNomsBateaux;
        private System.Windows.Forms.Label lblSelBateau;
    }
}