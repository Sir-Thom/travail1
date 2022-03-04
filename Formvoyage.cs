using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travail1
{
    public partial class Formvoyage : Form
    {
        voyage voyage;
        public Formvoyage()
        {
            InitializeComponent();
        }
        internal voyage Voyage { get => voyage; set => voyage = value; }
        private void voyage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string nom;
            nom = txt_voyage.Text;

            voyage = new voyage(nom);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
