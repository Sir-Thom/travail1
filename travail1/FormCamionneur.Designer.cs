
namespace travail1
{
    partial class FromCamionneur
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
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbPrénom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(61, 61);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(141, 20);
            this.txt_Prenom.TabIndex = 0;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(61, 91);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(141, 20);
            this.txt_Nom.TabIndex = 1;
            // 
            // lbPrénom
            // 
            this.lbPrénom.AutoSize = true;
            this.lbPrénom.Location = new System.Drawing.Point(12, 64);
            this.lbPrénom.Name = "lbPrénom";
            this.lbPrénom.Size = new System.Drawing.Size(43, 13);
            this.lbPrénom.TabIndex = 2;
            this.lbPrénom.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(209, 136);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // FromCamionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 171);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrénom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Prenom);
            this.Name = "FromCamionneur";
            this.Text = "Camionneur";
            this.Load += new System.EventHandler(this.FromCamionneur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbPrénom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ajouter;
    }
}