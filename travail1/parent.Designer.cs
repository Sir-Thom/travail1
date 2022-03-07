
namespace travail1
{
    partial class parent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livraisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grboxAjoutvoyage = new System.Windows.Forms.GroupBox();
            this.lst_voyage = new System.Windows.Forms.ListBox();
            this.GrboxLivraisonNonAssigne = new System.Windows.Forms.GroupBox();
            this.lst_non_livraison = new System.Windows.Forms.ListBox();
            this.grbox_voyageSelecttioner = new System.Windows.Forms.GroupBox();
            this.txt_distance = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_livraisonIncluse = new System.Windows.Forms.Label();
            this.lb_Distance = new System.Windows.Forms.Label();
            this.lb_Camion = new System.Windows.Forms.Label();
            this.lb_Camionneur = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.cbox_Camionneur = new System.Windows.Forms.ComboBox();
            this.cbox_camion = new System.Windows.Forms.ComboBox();
            this.lst_livraison_incluse = new System.Windows.Forms.ListBox();
            this.btn_dans = new System.Windows.Forms.Button();
            this.btn_hors = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grboxAjoutvoyage.SuspendLayout();
            this.GrboxLivraisonNonAssigne.SuspendLayout();
            this.grbox_voyageSelecttioner.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionToolStripMenuItem,
            this.camionneurToolStripMenuItem,
            this.livraisonToolStripMenuItem,
            this.voyageToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // camionneurToolStripMenuItem
            // 
            this.camionneurToolStripMenuItem.Name = "camionneurToolStripMenuItem";
            this.camionneurToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.camionneurToolStripMenuItem.Text = "Camionneur";
            this.camionneurToolStripMenuItem.Click += new System.EventHandler(this.camionneurToolStripMenuItem_Click);
            // 
            // livraisonToolStripMenuItem
            // 
            this.livraisonToolStripMenuItem.Name = "livraisonToolStripMenuItem";
            this.livraisonToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.livraisonToolStripMenuItem.Text = "Livraison";
            this.livraisonToolStripMenuItem.Click += new System.EventHandler(this.livraisonToolStripMenuItem_Click);
            // 
            // voyageToolStripMenuItem
            // 
            this.voyageToolStripMenuItem.Name = "voyageToolStripMenuItem";
            this.voyageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.voyageToolStripMenuItem.Text = "Voyage";
            this.voyageToolStripMenuItem.Click += new System.EventHandler(this.voyageToolStripMenuItem_Click);
            // 
            // grboxAjoutvoyage
            // 
            this.grboxAjoutvoyage.Controls.Add(this.lst_voyage);
            this.grboxAjoutvoyage.Location = new System.Drawing.Point(12, 27);
            this.grboxAjoutvoyage.Name = "grboxAjoutvoyage";
            this.grboxAjoutvoyage.Size = new System.Drawing.Size(319, 173);
            this.grboxAjoutvoyage.TabIndex = 1;
            this.grboxAjoutvoyage.TabStop = false;
            this.grboxAjoutvoyage.Text = "Voyage";
            // 
            // lst_voyage
            // 
            this.lst_voyage.FormattingEnabled = true;
            this.lst_voyage.Location = new System.Drawing.Point(6, 19);
            this.lst_voyage.Name = "lst_voyage";
            this.lst_voyage.Size = new System.Drawing.Size(307, 147);
            this.lst_voyage.TabIndex = 0;
            this.lst_voyage.SelectedIndexChanged += new System.EventHandler(this.lst_voyage_SelectedIndexChanged);
            // 
            // GrboxLivraisonNonAssigne
            // 
            this.GrboxLivraisonNonAssigne.Controls.Add(this.lst_non_livraison);
            this.GrboxLivraisonNonAssigne.Location = new System.Drawing.Point(12, 206);
            this.GrboxLivraisonNonAssigne.Name = "GrboxLivraisonNonAssigne";
            this.GrboxLivraisonNonAssigne.Size = new System.Drawing.Size(319, 176);
            this.GrboxLivraisonNonAssigne.TabIndex = 2;
            this.GrboxLivraisonNonAssigne.TabStop = false;
            this.GrboxLivraisonNonAssigne.Text = "Livraison non-Assignées";
            // 
            // lst_non_livraison
            // 
            this.lst_non_livraison.FormattingEnabled = true;
            this.lst_non_livraison.Location = new System.Drawing.Point(6, 23);
            this.lst_non_livraison.Name = "lst_non_livraison";
            this.lst_non_livraison.Size = new System.Drawing.Size(307, 147);
            this.lst_non_livraison.TabIndex = 1;
            this.lst_non_livraison.SelectedIndexChanged += new System.EventHandler(this.lst_non_livraison_SelectedIndexChanged);
            // 
            // grbox_voyageSelecttioner
            // 
            this.grbox_voyageSelecttioner.Controls.Add(this.txt_distance);
            this.grbox_voyageSelecttioner.Controls.Add(this.dateTimePicker1);
            this.grbox_voyageSelecttioner.Controls.Add(this.lb_livraisonIncluse);
            this.grbox_voyageSelecttioner.Controls.Add(this.lb_Distance);
            this.grbox_voyageSelecttioner.Controls.Add(this.lb_Camion);
            this.grbox_voyageSelecttioner.Controls.Add(this.lb_Camionneur);
            this.grbox_voyageSelecttioner.Controls.Add(this.lb_date);
            this.grbox_voyageSelecttioner.Controls.Add(this.cbox_Camionneur);
            this.grbox_voyageSelecttioner.Controls.Add(this.cbox_camion);
            this.grbox_voyageSelecttioner.Controls.Add(this.lst_livraison_incluse);
            this.grbox_voyageSelecttioner.Location = new System.Drawing.Point(382, 27);
            this.grbox_voyageSelecttioner.Name = "grbox_voyageSelecttioner";
            this.grbox_voyageSelecttioner.Size = new System.Drawing.Size(321, 355);
            this.grbox_voyageSelecttioner.TabIndex = 2;
            this.grbox_voyageSelecttioner.TabStop = false;
            this.grbox_voyageSelecttioner.Text = "Voyage selectionné";
            // 
            // txt_distance
            // 
            this.txt_distance.Location = new System.Drawing.Point(179, 118);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(128, 20);
            this.txt_distance.TabIndex = 12;
            this.txt_distance.Leave += new System.EventHandler(this.txt_distance_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // lb_livraisonIncluse
            // 
            this.lb_livraisonIncluse.AutoSize = true;
            this.lb_livraisonIncluse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_livraisonIncluse.Location = new System.Drawing.Point(6, 179);
            this.lb_livraisonIncluse.Name = "lb_livraisonIncluse";
            this.lb_livraisonIncluse.Size = new System.Drawing.Size(90, 13);
            this.lb_livraisonIncluse.TabIndex = 10;
            this.lb_livraisonIncluse.Text = "Livraison incluses";
            // 
            // lb_Distance
            // 
            this.lb_Distance.AutoSize = true;
            this.lb_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Distance.Location = new System.Drawing.Point(6, 118);
            this.lb_Distance.Name = "lb_Distance";
            this.lb_Distance.Size = new System.Drawing.Size(49, 13);
            this.lb_Distance.TabIndex = 9;
            this.lb_Distance.Text = "Distance";
            // 
            // lb_Camion
            // 
            this.lb_Camion.AutoSize = true;
            this.lb_Camion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Camion.Location = new System.Drawing.Point(6, 90);
            this.lb_Camion.Name = "lb_Camion";
            this.lb_Camion.Size = new System.Drawing.Size(42, 13);
            this.lb_Camion.TabIndex = 8;
            this.lb_Camion.Text = "Camion";
            // 
            // lb_Camionneur
            // 
            this.lb_Camionneur.AutoSize = true;
            this.lb_Camionneur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Camionneur.Location = new System.Drawing.Point(6, 60);
            this.lb_Camionneur.Name = "lb_Camionneur";
            this.lb_Camionneur.Size = new System.Drawing.Size(63, 13);
            this.lb_Camionneur.TabIndex = 7;
            this.lb_Camionneur.Text = "Camionneur";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(6, 34);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(30, 13);
            this.lb_date.TabIndex = 6;
            this.lb_date.Text = "Date";
            // 
            // cbox_Camionneur
            // 
            this.cbox_Camionneur.FormattingEnabled = true;
            this.cbox_Camionneur.Location = new System.Drawing.Point(107, 60);
            this.cbox_Camionneur.Name = "cbox_Camionneur";
            this.cbox_Camionneur.Size = new System.Drawing.Size(200, 21);
            this.cbox_Camionneur.TabIndex = 5;
            this.cbox_Camionneur.SelectedIndexChanged += new System.EventHandler(this.cbox_Camionneur_SelectedIndexChanged);
            // 
            // cbox_camion
            // 
            this.cbox_camion.FormattingEnabled = true;
            this.cbox_camion.Location = new System.Drawing.Point(107, 87);
            this.cbox_camion.Name = "cbox_camion";
            this.cbox_camion.Size = new System.Drawing.Size(200, 21);
            this.cbox_camion.TabIndex = 4;
            this.cbox_camion.SelectedIndexChanged += new System.EventHandler(this.cbox_camion_SelectedIndexChanged);
            // 
            // lst_livraison_incluse
            // 
            this.lst_livraison_incluse.FormattingEnabled = true;
            this.lst_livraison_incluse.Location = new System.Drawing.Point(6, 202);
            this.lst_livraison_incluse.Name = "lst_livraison_incluse";
            this.lst_livraison_incluse.Size = new System.Drawing.Size(295, 147);
            this.lst_livraison_incluse.TabIndex = 2;
            // 
            // btn_dans
            // 
            this.btn_dans.Location = new System.Drawing.Point(337, 206);
            this.btn_dans.Name = "btn_dans";
            this.btn_dans.Size = new System.Drawing.Size(39, 81);
            this.btn_dans.TabIndex = 0;
            this.btn_dans.Text = ">";
            this.btn_dans.UseVisualStyleBackColor = true;
            this.btn_dans.Click += new System.EventHandler(this.btn_dans_Click);
            // 
            // btn_hors
            // 
            this.btn_hors.Location = new System.Drawing.Point(337, 301);
            this.btn_hors.Name = "btn_hors";
            this.btn_hors.Size = new System.Drawing.Size(39, 81);
            this.btn_hors.TabIndex = 3;
            this.btn_hors.Text = "<";
            this.btn_hors.UseVisualStyleBackColor = true;
            this.btn_hors.Click += new System.EventHandler(this.btn_hors_Click);
            // 
            // parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 394);
            this.Controls.Add(this.btn_hors);
            this.Controls.Add(this.btn_dans);
            this.Controls.Add(this.GrboxLivraisonNonAssigne);
            this.Controls.Add(this.grbox_voyageSelecttioner);
            this.Controls.Add(this.grboxAjoutvoyage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "parent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.parent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grboxAjoutvoyage.ResumeLayout(false);
            this.GrboxLivraisonNonAssigne.ResumeLayout(false);
            this.grbox_voyageSelecttioner.ResumeLayout(false);
            this.grbox_voyageSelecttioner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livraisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voyageToolStripMenuItem;
        private System.Windows.Forms.GroupBox grboxAjoutvoyage;
        private System.Windows.Forms.GroupBox GrboxLivraisonNonAssigne;
        private System.Windows.Forms.GroupBox grbox_voyageSelecttioner;
        private System.Windows.Forms.ListBox lst_voyage;
        private System.Windows.Forms.ListBox lst_non_livraison;
        private System.Windows.Forms.Label lb_livraisonIncluse;
        private System.Windows.Forms.Label lb_Distance;
        private System.Windows.Forms.Label lb_Camion;
        private System.Windows.Forms.Label lb_Camionneur;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox cbox_Camionneur;
        private System.Windows.Forms.ComboBox cbox_camion;
        private System.Windows.Forms.ListBox lst_livraison_incluse;
        private System.Windows.Forms.Button btn_dans;
        private System.Windows.Forms.Button btn_hors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_distance;
    }
}

