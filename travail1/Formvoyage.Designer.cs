
namespace travail1
{
    partial class Formvoyage
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
            this.txt_voyage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_voyage
            // 
            this.txt_voyage.Location = new System.Drawing.Point(98, 20);
            this.txt_voyage.Name = "txt_voyage";
            this.txt_voyage.Size = new System.Drawing.Size(100, 20);
            this.txt_voyage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom du voyage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(159, 51);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // Formvoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 83);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_voyage);
            this.Name = "Formvoyage";
            this.Text = "voyage";
            this.Load += new System.EventHandler(this.voyage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_voyage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouter;
    }
}