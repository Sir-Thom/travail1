using System;
using System.Windows.Forms;

namespace travail1
{
    public partial class Formvoyage : Form
    {
        private voyage voyage;

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