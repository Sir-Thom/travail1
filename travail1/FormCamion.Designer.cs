
namespace travail1
{
    partial class FormCamion
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
            this.lb_poids = new System.Windows.Forms.Label();
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_poids
            // 
            this.lb_poids.AutoSize = true;
            this.lb_poids.Location = new System.Drawing.Point(3, 67);
            this.lb_poids.Name = "lb_poids";
            this.lb_poids.Size = new System.Drawing.Size(33, 13);
            this.lb_poids.TabIndex = 0;
            this.lb_poids.Text = "Poids";
            // 
            // txt_poids
            // 
            this.txt_poids.Location = new System.Drawing.Point(51, 64);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(100, 20);
            this.txt_poids.TabIndex = 1;
            // 
            // txt_volume
            // 
            this.txt_volume.Location = new System.Drawing.Point(51, 90);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(100, 20);
            this.txt_volume.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(185, 112);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // FormLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 147);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_poids);
            this.Controls.Add(this.lb_poids);
            this.Name = "FormLivraison";
            this.Text = "FormCamion";
            this.Load += new System.EventHandler(this.camion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_poids;
        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouter;
    }
}