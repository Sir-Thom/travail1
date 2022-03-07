using System;
using System.Windows.Forms;

namespace travail1
{
    public partial class FromLivraison : Form
    {
        private Livraison infolivraison;

        public FromLivraison()
        {
            InitializeComponent();
        }

        private void FormLivraison_Load(object sender, EventArgs e)
        {
        }

        internal Livraison livraison { get => infolivraison; set => infolivraison = value; }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int PoidsDuLivraison;
            int VolumeDuLivraison;

            bool parsesucces1 = int.TryParse(txt_poids.Text, out PoidsDuLivraison);
            bool parsesucces2 = int.TryParse(txt_volume.Text, out VolumeDuLivraison);
            if (parsesucces1 && parsesucces2)
            {
                PoidsDuLivraison = int.Parse(txt_poids.Text);
                VolumeDuLivraison = int.Parse(txt_volume.Text);
                livraison = new Livraison(PoidsDuLivraison, VolumeDuLivraison);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Aucun mots n'est accepter, veuillez utiliser des chiffres.");
                txt_poids.Clear();
                txt_volume.Clear();
            }
        }
    }
}