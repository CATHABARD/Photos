
namespace Photos
{
    partial class EditCommentairePhoto
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
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.ButtonAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DossierTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Location = new System.Drawing.Point(12, 119);
            this.textBoxCommentaire.MaxLength = 500;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(570, 20);
            this.textBoxCommentaire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Commentaire sur la ou les photos";
            // 
            // ButtonValider
            // 
            this.ButtonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonValider.Location = new System.Drawing.Point(385, 217);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(90, 27);
            this.ButtonValider.TabIndex = 2;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonAnnuler.Location = new System.Drawing.Point(492, 217);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Size = new System.Drawing.Size(90, 27);
            this.ButtonAnnuler.TabIndex = 3;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.UseVisualStyleBackColor = true;
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dossier";
            // 
            // DossierTextBox
            // 
            this.DossierTextBox.Location = new System.Drawing.Point(15, 45);
            this.DossierTextBox.MaxLength = 500;
            this.DossierTextBox.Name = "DossierTextBox";
            this.DossierTextBox.ReadOnly = true;
            this.DossierTextBox.Size = new System.Drawing.Size(570, 20);
            this.DossierTextBox.TabIndex = 4;
            // 
            // EditCommentairePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(597, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DossierTextBox);
            this.Controls.Add(this.ButtonAnnuler);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCommentaire);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EditCommentairePhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commentaire photo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Button ButtonAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DossierTextBox;
    }
}