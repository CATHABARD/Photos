
namespace Photos
{
    partial class PhotoControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.texte = new System.Windows.Forms.TextBox();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // date
            // 
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(9, 154);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(194, 23);
            this.date.TabIndex = 1;
            this.date.Text = "label1";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texte
            // 
            this.texte.Location = new System.Drawing.Point(3, 180);
            this.texte.Multiline = true;
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(198, 62);
            this.texte.TabIndex = 2;
            // 
            // buttonEditer
            // 
            this.buttonEditer.Location = new System.Drawing.Point(3, 253);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(75, 23);
            this.buttonEditer.TabIndex = 3;
            this.buttonEditer.Text = "Editer";
            this.buttonEditer.UseVisualStyleBackColor = true;
            this.buttonEditer.Click += new System.EventHandler(this.ButtonEditer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(126, 253);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.ButtonSupprimer_Click);
            // 
            // PhotoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PhotoControl";
            this.Size = new System.Drawing.Size(206, 285);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox texte;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
