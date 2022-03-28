
namespace Atlantik.Formulaires
{
    partial class FormAfficherReservations
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
            this.cbxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.chnores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chliaison = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chnotrav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdatedep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxDetailRes = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cbxClients
            // 
            this.cbxClients.FormattingEnabled = true;
            this.cbxClients.Location = new System.Drawing.Point(54, 34);
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(121, 21);
            this.cbxClients.TabIndex = 0;
            this.cbxClients.SelectedIndexChanged += new System.EventHandler(this.cbxClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client :";
            // 
            // lvReservations
            // 
            this.lvReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chnores,
            this.chliaison,
            this.chnotrav,
            this.chdatedep});
            this.lvReservations.FullRowSelect = true;
            this.lvReservations.GridLines = true;
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(259, 37);
            this.lvReservations.MultiSelect = false;
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(461, 218);
            this.lvReservations.TabIndex = 2;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.View = System.Windows.Forms.View.Details;
            this.lvReservations.SelectedIndexChanged += new System.EventHandler(this.lvReservations_SelectedIndexChanged);
            // 
            // chnores
            // 
            this.chnores.Text = "N° Réservation";
            this.chnores.Width = 100;
            // 
            // chliaison
            // 
            this.chliaison.Text = "Liaison";
            this.chliaison.Width = 164;
            // 
            // chnotrav
            // 
            this.chnotrav.Text = "N° Traversée";
            this.chnotrav.Width = 80;
            // 
            // chdatedep
            // 
            this.chdatedep.Text = "Date de départ";
            this.chdatedep.Width = 166;
            // 
            // gbxDetailRes
            // 
            this.gbxDetailRes.Location = new System.Drawing.Point(326, 261);
            this.gbxDetailRes.Name = "gbxDetailRes";
            this.gbxDetailRes.Size = new System.Drawing.Size(341, 265);
            this.gbxDetailRes.TabIndex = 3;
            this.gbxDetailRes.TabStop = false;
            this.gbxDetailRes.Text = "Détails réservation";
            // 
            // FormAfficherReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 538);
            this.Controls.Add(this.gbxDetailRes);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAfficherReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Réservations";
            this.Load += new System.EventHandler(this.FormAfficherReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvReservations;
        private System.Windows.Forms.ColumnHeader chnores;
        private System.Windows.Forms.ColumnHeader chliaison;
        private System.Windows.Forms.ColumnHeader chnotrav;
        private System.Windows.Forms.ColumnHeader chdatedep;
        private System.Windows.Forms.GroupBox gbxDetailRes;
    }
}