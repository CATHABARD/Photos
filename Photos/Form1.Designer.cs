
namespace Photos
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnÉvénementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.créerUnJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterUnePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carouselMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DéfinirUnDossierDeStockageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasférerToutesLesPhotosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JourTextBox = new System.Windows.Forms.TextBox();
            this.EvenementTextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFollowing = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.evenementsTableAdapter1 = new Photos.PhotosDBDataSetTableAdapters.EvenementsTableAdapter();
            this.joursTableAdapter1 = new Photos.PhotosDBDataSetTableAdapters.JoursTableAdapter();
            this.photosTableAdapter1 = new Photos.PhotosDBDataSetTableAdapters.PhotosTableAdapter();
            this.photosOrganiserDBDataSet1 = new Photos.PhotosDBDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosOrganiserDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1352, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnÉvénementToolStripMenuItem,
            this.toolStripSeparator4,
            this.créerUnJourToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.ajouterUnePhotoToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitterToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fichiersToolStripMenuItem.Text = "Fichiers";
            // 
            // créerUnÉvénementToolStripMenuItem
            // 
            this.créerUnÉvénementToolStripMenuItem.Name = "créerUnÉvénementToolStripMenuItem";
            this.créerUnÉvénementToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.créerUnÉvénementToolStripMenuItem.Text = "Créer un événement";
            this.créerUnÉvénementToolStripMenuItem.Click += new System.EventHandler(this.CréerUnÉvénementToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // créerUnJourToolStripMenuItem
            // 
            this.créerUnJourToolStripMenuItem.Name = "créerUnJourToolStripMenuItem";
            this.créerUnJourToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.créerUnJourToolStripMenuItem.Text = "Créer un jour";
            this.créerUnJourToolStripMenuItem.Click += new System.EventHandler(this.CréerUnJourToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // ajouterUnePhotoToolStripMenuItem
            // 
            this.ajouterUnePhotoToolStripMenuItem.Enabled = false;
            this.ajouterUnePhotoToolStripMenuItem.Name = "ajouterUnePhotoToolStripMenuItem";
            this.ajouterUnePhotoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouterUnePhotoToolStripMenuItem.Text = "Ajouter des photos";
            this.ajouterUnePhotoToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnePhotoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carouselMenuItem,
            this.DéfinirUnDossierDeStockageMenuItem,
            this.trasférerToutesLesPhotosMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // carouselMenuItem
            // 
            this.carouselMenuItem.Name = "carouselMenuItem";
            this.carouselMenuItem.Size = new System.Drawing.Size(232, 22);
            this.carouselMenuItem.Text = "Carousel";
            this.carouselMenuItem.Click += new System.EventHandler(this.CarouselMenuItem_Click);
            // 
            // DéfinirUnDossierDeStockageMenuItem
            // 
            this.DéfinirUnDossierDeStockageMenuItem.Name = "DéfinirUnDossierDeStockageMenuItem";
            this.DéfinirUnDossierDeStockageMenuItem.Size = new System.Drawing.Size(232, 22);
            this.DéfinirUnDossierDeStockageMenuItem.Text = "Définir un dossier de stockage";
            this.DéfinirUnDossierDeStockageMenuItem.Click += new System.EventHandler(this.DéfinirUnDossierDeStockageMenuItem_Click);
            // 
            // trasférerToutesLesPhotosMenuItem
            // 
            this.trasférerToutesLesPhotosMenuItem.Name = "trasférerToutesLesPhotosMenuItem";
            this.trasférerToutesLesPhotosMenuItem.Size = new System.Drawing.Size(232, 22);
            this.trasférerToutesLesPhotosMenuItem.Text = "Trasférer toutes les photos";
            this.trasférerToutesLesPhotosMenuItem.Click += new System.EventHandler(this.TrasférerToutesLesPhotosMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposMenuItem
            // 
            this.aProposMenuItem.Name = "aProposMenuItem";
            this.aProposMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aProposMenuItem.Text = "A propos du logiciel";
            this.aProposMenuItem.Click += new System.EventHandler(this.AProposMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 941);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.JourTextBox);
            this.panel2.Controls.Add(this.EvenementTextBox);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 941);
            this.panel2.TabIndex = 1;
            // 
            // JourTextBox
            // 
            this.JourTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.JourTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JourTextBox.Location = new System.Drawing.Point(0, 773);
            this.JourTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JourTextBox.Multiline = true;
            this.JourTextBox.Name = "JourTextBox";
            this.JourTextBox.ReadOnly = true;
            this.JourTextBox.Size = new System.Drawing.Size(209, 168);
            this.JourTextBox.TabIndex = 2;
            // 
            // EvenementTextBox
            // 
            this.EvenementTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EvenementTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvenementTextBox.Location = new System.Drawing.Point(0, 646);
            this.EvenementTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EvenementTextBox.Multiline = true;
            this.EvenementTextBox.Name = "EvenementTextBox";
            this.EvenementTextBox.ReadOnly = true;
            this.EvenementTextBox.Size = new System.Drawing.Size(209, 127);
            this.EvenementTextBox.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 646);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelPosition);
            this.splitContainer2.Panel2.Controls.Add(this.buttonLast);
            this.splitContainer2.Panel2.Controls.Add(this.buttonFollowing);
            this.splitContainer2.Panel2.Controls.Add(this.buttonPrevious);
            this.splitContainer2.Panel2.Controls.Add(this.buttonFirst);
            this.splitContainer2.Size = new System.Drawing.Size(1138, 941);
            this.splitContainer2.SplitterDistance = 880;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPosition.ForeColor = System.Drawing.Color.Yellow;
            this.labelPosition.Location = new System.Drawing.Point(300, 14);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(0, 20);
            this.labelPosition.TabIndex = 4;
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLast.Location = new System.Drawing.Point(223, 3);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(49, 45);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // buttonFollowing
            // 
            this.buttonFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFollowing.Location = new System.Drawing.Point(135, 3);
            this.buttonFollowing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFollowing.Name = "buttonFollowing";
            this.buttonFollowing.Size = new System.Drawing.Size(49, 45);
            this.buttonFollowing.TabIndex = 2;
            this.buttonFollowing.Text = ">";
            this.buttonFollowing.UseVisualStyleBackColor = true;
            this.buttonFollowing.Click += new System.EventHandler(this.ButtonFollowing_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(79, 3);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(49, 45);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(4, 3);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(49, 45);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "|<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.CausesValidation = false;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 941);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 0);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 936);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1352, 29);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // evenementsTableAdapter1
            // 
            this.evenementsTableAdapter1.ClearBeforeFill = true;
            // 
            // joursTableAdapter1
            // 
            this.joursTableAdapter1.ClearBeforeFill = true;
            // 
            // photosTableAdapter1
            // 
            this.photosTableAdapter1.ClearBeforeFill = true;
            // 
            // photosOrganiserDBDataSet1
            // 
            this.photosOrganiserDBDataSet1.DataSetName = "PhotosOrganiserDBDataSet";
            this.photosOrganiserDBDataSet1.Namespace = "http://tempuri.org/PhotosDBDataSet.xsd";
            this.photosOrganiserDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1352, 965);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Photos Organiseur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photosOrganiserDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnÉvénementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnePhotoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem créerUnJourToolStripMenuItem;
        private PhotosDBDataSetTableAdapters.EvenementsTableAdapter evenementsTableAdapter1;
        private PhotosDBDataSetTableAdapters.JoursTableAdapter joursTableAdapter1;
        private PhotosDBDataSetTableAdapters.PhotosTableAdapter photosTableAdapter1;
        private PhotosDBDataSet photosOrganiserDBDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carouselMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFollowing;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem DéfinirUnDossierDeStockageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasférerToutesLesPhotosMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox JourTextBox;
        private System.Windows.Forms.TextBox EvenementTextBox;
    }
}

