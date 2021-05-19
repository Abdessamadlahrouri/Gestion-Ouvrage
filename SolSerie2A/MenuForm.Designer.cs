namespace GESTION_OUVRAGES
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmprToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmprunteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmprunteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherEmrpunteyrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerEmprunteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierEmprunteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOuvrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOuvrageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listOuvrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerOuvrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierOuvrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.empruntsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2268, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmprToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem1});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(148, 41);
            this.fileToolStripMenuItem.Text = "Option";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // ajouterEmprToolStripMenuItem
            // 
            this.ajouterEmprToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmprunteurToolStripMenuItem,
            this.listEmprunteurToolStripMenuItem1,
            this.chercherEmrpunteyrToolStripMenuItem,
            this.supprimerEmprunteurToolStripMenuItem1,
            this.modifierEmprunteurToolStripMenuItem});
            this.ajouterEmprToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterEmprToolStripMenuItem.Image")));
            this.ajouterEmprToolStripMenuItem.Name = "ajouterEmprToolStripMenuItem";
            this.ajouterEmprToolStripMenuItem.Size = new System.Drawing.Size(263, 42);
            this.ajouterEmprToolStripMenuItem.Text = "Emprunteur";
            this.ajouterEmprToolStripMenuItem.Click += new System.EventHandler(this.ajouterEmprToolStripMenuItem_Click);
            // 
            // ajouterEmprunteurToolStripMenuItem
            // 
            this.ajouterEmprunteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterEmprunteurToolStripMenuItem.Image")));
            this.ajouterEmprunteurToolStripMenuItem.Name = "ajouterEmprunteurToolStripMenuItem";
            this.ajouterEmprunteurToolStripMenuItem.Size = new System.Drawing.Size(393, 42);
            this.ajouterEmprunteurToolStripMenuItem.Text = "Ajouter Emprunteur";
            this.ajouterEmprunteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterEmprunteurToolStripMenuItem_Click);
            // 
            // listEmprunteurToolStripMenuItem1
            // 
            this.listEmprunteurToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listEmprunteurToolStripMenuItem1.Image")));
            this.listEmprunteurToolStripMenuItem1.Name = "listEmprunteurToolStripMenuItem1";
            this.listEmprunteurToolStripMenuItem1.Size = new System.Drawing.Size(393, 42);
            this.listEmprunteurToolStripMenuItem1.Text = "List Emprunteur";
            this.listEmprunteurToolStripMenuItem1.Click += new System.EventHandler(this.listEmprunteurToolStripMenuItem1_Click);
            // 
            // chercherEmrpunteyrToolStripMenuItem
            // 
            this.chercherEmrpunteyrToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chercherEmrpunteyrToolStripMenuItem.Image")));
            this.chercherEmrpunteyrToolStripMenuItem.Name = "chercherEmrpunteyrToolStripMenuItem";
            this.chercherEmrpunteyrToolStripMenuItem.Size = new System.Drawing.Size(393, 42);
            this.chercherEmrpunteyrToolStripMenuItem.Text = "Chercher Emprunteur";
            this.chercherEmrpunteyrToolStripMenuItem.Click += new System.EventHandler(this.chercherEmrpunteyrToolStripMenuItem_Click);
            // 
            // supprimerEmprunteurToolStripMenuItem1
            // 
            this.supprimerEmprunteurToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("supprimerEmprunteurToolStripMenuItem1.Image")));
            this.supprimerEmprunteurToolStripMenuItem1.Name = "supprimerEmprunteurToolStripMenuItem1";
            this.supprimerEmprunteurToolStripMenuItem1.Size = new System.Drawing.Size(393, 42);
            this.supprimerEmprunteurToolStripMenuItem1.Text = "Supprimer Emprunteur";
            this.supprimerEmprunteurToolStripMenuItem1.Click += new System.EventHandler(this.supprimerEmprunteurToolStripMenuItem1_Click);
            // 
            // modifierEmprunteurToolStripMenuItem
            // 
            this.modifierEmprunteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierEmprunteurToolStripMenuItem.Image")));
            this.modifierEmprunteurToolStripMenuItem.Name = "modifierEmprunteurToolStripMenuItem";
            this.modifierEmprunteurToolStripMenuItem.Size = new System.Drawing.Size(393, 42);
            this.modifierEmprunteurToolStripMenuItem.Text = "Modifier Emprunteur";
            this.modifierEmprunteurToolStripMenuItem.Click += new System.EventHandler(this.modifierEmprunteurToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterOuvrageToolStripMenuItem,
            this.ajouterOuvrageToolStripMenuItem1,
            this.listOuvrageToolStripMenuItem,
            this.supprimerOuvrageToolStripMenuItem,
            this.modifierOuvrageToolStripMenuItem});
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(263, 42);
            this.quitterToolStripMenuItem.Text = "Ouvrage";
            // 
            // ajouterOuvrageToolStripMenuItem
            // 
            this.ajouterOuvrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterAuteurToolStripMenuItem,
            this.listAuteurToolStripMenuItem,
            this.modifierAuteurToolStripMenuItem});
            this.ajouterOuvrageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterOuvrageToolStripMenuItem.Image")));
            this.ajouterOuvrageToolStripMenuItem.Name = "ajouterOuvrageToolStripMenuItem";
            this.ajouterOuvrageToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.ajouterOuvrageToolStripMenuItem.Text = "Auteur";
            this.ajouterOuvrageToolStripMenuItem.Click += new System.EventHandler(this.ajouterOuvrageToolStripMenuItem_Click);
            // 
            // ajouterAuteurToolStripMenuItem
            // 
            this.ajouterAuteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterAuteurToolStripMenuItem.Image")));
            this.ajouterAuteurToolStripMenuItem.Name = "ajouterAuteurToolStripMenuItem";
            this.ajouterAuteurToolStripMenuItem.Size = new System.Drawing.Size(311, 42);
            this.ajouterAuteurToolStripMenuItem.Text = "Ajouter Auteur";
            this.ajouterAuteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterAuteurToolStripMenuItem_Click);
            // 
            // listAuteurToolStripMenuItem
            // 
            this.listAuteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listAuteurToolStripMenuItem.Image")));
            this.listAuteurToolStripMenuItem.Name = "listAuteurToolStripMenuItem";
            this.listAuteurToolStripMenuItem.Size = new System.Drawing.Size(311, 42);
            this.listAuteurToolStripMenuItem.Text = "List Auteur";
            this.listAuteurToolStripMenuItem.Click += new System.EventHandler(this.listAuteurToolStripMenuItem_Click);
            // 
            // modifierAuteurToolStripMenuItem
            // 
            this.modifierAuteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierAuteurToolStripMenuItem.Image")));
            this.modifierAuteurToolStripMenuItem.Name = "modifierAuteurToolStripMenuItem";
            this.modifierAuteurToolStripMenuItem.Size = new System.Drawing.Size(311, 42);
            this.modifierAuteurToolStripMenuItem.Text = "Modifier Auteur";
            this.modifierAuteurToolStripMenuItem.Click += new System.EventHandler(this.modifierAuteurToolStripMenuItem_Click);
            // 
            // ajouterOuvrageToolStripMenuItem1
            // 
            this.ajouterOuvrageToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ajouterOuvrageToolStripMenuItem1.Image")));
            this.ajouterOuvrageToolStripMenuItem1.Name = "ajouterOuvrageToolStripMenuItem1";
            this.ajouterOuvrageToolStripMenuItem1.Size = new System.Drawing.Size(351, 42);
            this.ajouterOuvrageToolStripMenuItem1.Text = "Ajouter Ouvrage";
            this.ajouterOuvrageToolStripMenuItem1.Click += new System.EventHandler(this.ajouterOuvrageToolStripMenuItem1_Click);
            // 
            // listOuvrageToolStripMenuItem
            // 
            this.listOuvrageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listOuvrageToolStripMenuItem.Image")));
            this.listOuvrageToolStripMenuItem.Name = "listOuvrageToolStripMenuItem";
            this.listOuvrageToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.listOuvrageToolStripMenuItem.Text = "List Ouvrage";
            this.listOuvrageToolStripMenuItem.Click += new System.EventHandler(this.listOuvrageToolStripMenuItem_Click);
            // 
            // supprimerOuvrageToolStripMenuItem
            // 
            this.supprimerOuvrageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supprimerOuvrageToolStripMenuItem.Image")));
            this.supprimerOuvrageToolStripMenuItem.Name = "supprimerOuvrageToolStripMenuItem";
            this.supprimerOuvrageToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.supprimerOuvrageToolStripMenuItem.Text = "Supprimer ouvrage";
            this.supprimerOuvrageToolStripMenuItem.Click += new System.EventHandler(this.supprimerOuvrageToolStripMenuItem_Click);
            // 
            // modifierOuvrageToolStripMenuItem
            // 
            this.modifierOuvrageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierOuvrageToolStripMenuItem.Image")));
            this.modifierOuvrageToolStripMenuItem.Name = "modifierOuvrageToolStripMenuItem";
            this.modifierOuvrageToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.modifierOuvrageToolStripMenuItem.Text = "Modifier Ouvrage";
            this.modifierOuvrageToolStripMenuItem.Click += new System.EventHandler(this.modifierOuvrageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(260, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(263, 42);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click_1);
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.listEmpruntsToolStripMenuItem});
            this.empruntsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empruntsToolStripMenuItem.Image")));
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(275, 41);
            this.empruntsToolStripMenuItem.Text = "Gestion Emprunts";
            this.empruntsToolStripMenuItem.Click += new System.EventHandler(this.empruntsToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterToolStripMenuItem.Image")));
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(319, 42);
            this.ajouterToolStripMenuItem.Text = "Ajouter Emprunt";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // listEmpruntsToolStripMenuItem
            // 
            this.listEmpruntsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listEmpruntsToolStripMenuItem.Image")));
            this.listEmpruntsToolStripMenuItem.Name = "listEmpruntsToolStripMenuItem";
            this.listEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(319, 42);
            this.listEmpruntsToolStripMenuItem.Text = "List Emprunts";
            this.listEmpruntsToolStripMenuItem.Click += new System.EventHandler(this.listEmpruntsToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "téléchargement.png");
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2268, 1173);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmprToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmprunteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmprunteurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chercherEmrpunteyrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerEmprunteurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierEmprunteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterOuvrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterOuvrageToolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem listOuvrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerOuvrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierOuvrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}