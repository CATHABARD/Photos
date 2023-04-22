namespace Photos
{
    partial class MoveTo
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
            this.EmplacementTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DefinitEmplacementButton = new System.Windows.Forms.Button();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmplacementTextBox
            // 
            this.EmplacementTextBox.Location = new System.Drawing.Point(12, 51);
            this.EmplacementTextBox.Name = "EmplacementTextBox";
            this.EmplacementTextBox.Size = new System.Drawing.Size(332, 20);
            this.EmplacementTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emplacement";
            // 
            // DefinitEmplacementButton
            // 
            this.DefinitEmplacementButton.Location = new System.Drawing.Point(174, 77);
            this.DefinitEmplacementButton.Name = "DefinitEmplacementButton";
            this.DefinitEmplacementButton.Size = new System.Drawing.Size(170, 23);
            this.DefinitEmplacementButton.TabIndex = 2;
            this.DefinitEmplacementButton.Text = "Sélectionner un autre chemin";
            this.DefinitEmplacementButton.UseVisualStyleBackColor = true;
            this.DefinitEmplacementButton.Click += new System.EventHandler(this.DefinitEmplacementButton_Click);
            // 
            // ValiderButton
            // 
            this.ValiderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValiderButton.Location = new System.Drawing.Point(158, 136);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(75, 23);
            this.ValiderButton.TabIndex = 3;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnulerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerButton.Location = new System.Drawing.Point(259, 136);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(90, 24);
            this.AnnulerButton.TabIndex = 4;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            // 
            // MoveTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(356, 187);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ValiderButton);
            this.Controls.Add(this.DefinitEmplacementButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmplacementTextBox);
            this.Name = "MoveTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmplacementTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DefinitEmplacementButton;
        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button AnnulerButton;
    }
}