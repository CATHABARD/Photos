
namespace Photos
{
    partial class NouveauJour
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
            this.components = new System.ComponentModel.Container();
            this.evenement = new System.Windows.Forms.ComboBox();
            this.evenementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhotosDBDataSet = new Photos.PhotosDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.evenementsTableAdapter = new Photos.PhotosDBDataSetTableAdapters.EvenementsTableAdapter();
            this.valider = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.remarques = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.joursTableAdapter1 = new Photos.PhotosDBDataSetTableAdapters.JoursTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.evenementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // evenement
            // 
            this.evenement.DataSource = this.evenementsBindingSource;
            this.evenement.DisplayMember = "Titre";
            this.evenement.FormattingEnabled = true;
            this.evenement.Location = new System.Drawing.Point(79, 28);
            this.evenement.Name = "evenement";
            this.evenement.Size = new System.Drawing.Size(360, 21);
            this.evenement.TabIndex = 0;
            this.evenement.ValueMember = "Id";
            // 
            // evenementsBindingSource
            // 
            this.evenementsBindingSource.DataMember = "Evenements";
            this.evenementsBindingSource.DataSource = this.PhotosDBDataSet;
            // 
            // PhotosDBDataSet
            // 
            this.PhotosDBDataSet.DataSetName = "PhotosDBDataSet";
            this.PhotosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evènement";
            // 
            // evenementsTableAdapter
            // 
            this.evenementsTableAdapter.ClearBeforeFill = true;
            // 
            // valider
            // 
            this.valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valider.Location = new System.Drawing.Point(313, 250);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 2;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // annuler
            // 
            this.annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(410, 250);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 3;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // remarques
            // 
            this.remarques.Location = new System.Drawing.Point(36, 116);
            this.remarques.MaxLength = 250;
            this.remarques.Multiline = true;
            this.remarques.Name = "remarques";
            this.remarques.Size = new System.Drawing.Size(449, 116);
            this.remarques.TabIndex = 5;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(79, 67);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(126, 20);
            this.date.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date";
            // 
            // joursTableAdapter1
            // 
            this.joursTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(43, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remarques";
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.id.Location = new System.Drawing.Point(36, 250);
            this.id.MaxLength = 30;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(247, 20);
            this.id.TabIndex = 11;
            this.id.Visible = false;
            // 
            // NouveauJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(527, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.id);
            this.Controls.Add(this.remarques);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evenement);
            this.Name = "NouveauJour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nouveau jour";
            this.Load += new System.EventHandler(this.NouveauJour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evenementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox evenement;
        private System.Windows.Forms.Label label1;
        private PhotosDBDataSet PhotosDBDataSet;
        private System.Windows.Forms.BindingSource evenementsBindingSource;
        private PhotosDBDataSetTableAdapters.EvenementsTableAdapter evenementsTableAdapter;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox remarques;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private PhotosDBDataSetTableAdapters.JoursTableAdapter joursTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
    }
}