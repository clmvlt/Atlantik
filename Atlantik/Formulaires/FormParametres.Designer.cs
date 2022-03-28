
namespace Atlantik.Formulaires
{
    partial class FormParametres
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.rtbxCle = new System.Windows.Forms.RichTextBox();
            this.cbEnProduction = new System.Windows.Forms.CheckBox();
            this.tbxMelSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbxCle);
            this.groupBox1.Controls.Add(this.tbxId);
            this.groupBox1.Controls.Add(this.tbxRang);
            this.groupBox1.Controls.Add(this.tbxSite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identifiants PayBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clé HMAC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identifiant :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rang :";
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(136, 42);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(153, 20);
            this.tbxSite.TabIndex = 5;
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(136, 98);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(153, 20);
            this.tbxRang.TabIndex = 6;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(136, 155);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(153, 20);
            this.tbxId.TabIndex = 7;
            // 
            // rtbxCle
            // 
            this.rtbxCle.Location = new System.Drawing.Point(136, 198);
            this.rtbxCle.Name = "rtbxCle";
            this.rtbxCle.Size = new System.Drawing.Size(153, 70);
            this.rtbxCle.TabIndex = 9;
            this.rtbxCle.Text = "";
            // 
            // cbEnProduction
            // 
            this.cbEnProduction.AutoSize = true;
            this.cbEnProduction.Location = new System.Drawing.Point(311, 329);
            this.cbEnProduction.Name = "cbEnProduction";
            this.cbEnProduction.Size = new System.Drawing.Size(93, 17);
            this.cbEnProduction.TabIndex = 1;
            this.cbEnProduction.Text = "En Production";
            this.cbEnProduction.UseVisualStyleBackColor = true;
            // 
            // tbxMelSite
            // 
            this.tbxMelSite.Location = new System.Drawing.Point(251, 365);
            this.tbxMelSite.Name = "tbxMelSite";
            this.tbxMelSite.Size = new System.Drawing.Size(153, 20);
            this.tbxMelSite.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mel site :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(329, 415);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxMelSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEnProduction);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormParametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atlantik Manager - Option";
            this.Load += new System.EventHandler(this.FormParametres_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbxCle;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEnProduction;
        private System.Windows.Forms.TextBox tbxMelSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
    }
}