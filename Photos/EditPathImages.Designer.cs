namespace Photos
{
    partial class EditPathImages
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
            this.AnnulerButton = new System.Windows.Forms.Button();
            this.ValiderButton = new System.Windows.Forms.Button();
            this.DefinitEmplacementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmplacementChoisiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emplacementActueltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnulerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AnnulerButton.Location = new System.Drawing.Point(238, 230);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(90, 24);
            this.AnnulerButton.TabIndex = 6;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            // 
            // ValiderButton
            // 
            this.ValiderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValiderButton.Location = new System.Drawing.Point(137, 230);
            this.ValiderButton.Name = "ValiderButton";
            this.ValiderButton.Size = new System.Drawing.Size(75, 23);
            this.ValiderButton.TabIndex = 5;
            this.ValiderButton.Text = "Valider";
            this.ValiderButton.UseVisualStyleBackColor = true;
            this.ValiderButton.Click += new System.EventHandler(this.ValiderButton_Click);
            // 
            // DefinitEmplacementButton
            // 
            this.DefinitEmplacementButton.Location = new System.Drawing.Point(174, 156);
            this.DefinitEmplacementButton.Name = "DefinitEmplacementButton";
            this.DefinitEmplacementButton.Size = new System.Drawing.Size(170, 23);
            this.DefinitEmplacementButton.TabIndex = 9;
            this.DefinitEmplacementButton.Text = "Sélectionner un autre chemin";
            this.DefinitEmplacementButton.UseVisualStyleBackColor = true;
            this.DefinitEmplacementButton.Click += new System.EventHandler(this.DefinitEmplacementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nouvel emplacement";
            // 
            // EmplacementChoisiTextBox
            // 
            this.EmplacementChoisiTextBox.Location = new System.Drawing.Point(12, 130);
            this.EmplacementChoisiTextBox.Name = "EmplacementChoisiTextBox";
            this.EmplacementChoisiTextBox.Size = new System.Drawing.Size(332, 20);
            this.EmplacementChoisiTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Emplacement actuel";
            // 
            // emplacementActueltextBox
            // 
            this.emplacementActueltextBox.Location = new System.Drawing.Point(12, 59);
            this.emplacementActueltextBox.Name = "emplacementActueltextBox";
            this.emplacementActueltextBox.ReadOnly = true;
            this.emplacementActueltextBox.Size = new System.Drawing.Size(331, 20);
            this.emplacementActueltextBox.TabIndex = 12;
            // 
            // EditPathImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(355, 289);
            this.Controls.Add(this.emplacementActueltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DefinitEmplacementButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmplacementChoisiTextBox);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ValiderButton);
            this.Name = "EditPathImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dossier Photos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnulerButton;
        private System.Windows.Forms.Button ValiderButton;
        private System.Windows.Forms.Button DefinitEmplacementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmplacementChoisiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emplacementActueltextBox;
    }
}