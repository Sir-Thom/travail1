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

            //int PoidsDuCamionInfo = int.Parse(txt_poids.Text);
            //VolumeDuCamionInfo = int.Parse(txt_volume.Text);
            PoidsDuLivraison = int.Parse(txt_poids.Text);
            VolumeDuLivraison = int.Parse(txt_volume.Text);
            livraison = new Livraison(PoidsDuLivraison, VolumeDuLivraison);
            // CamionCree = "Poids : " + PoidsDuCamion.ToString() + " Lbs "  + " , Volume de : " + VolumeDuCamion.ToString();
            this.DialogResult = DialogResult.OK;
            //  CamionCree = "Camion de :" + PoidsDuCamionInfo + " Lbs " + volumeDuCamion.ToString() + " avec un volume de : " + VolumeDuCamionInfo;
            this.Close();
        }

        private void DtpDateLivraison_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}