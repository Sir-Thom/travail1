using System;
using System.Windows.Forms;

namespace travail1
{
    public partial class FormCamion : Form
    {
        private Camion camionInformation;

        internal Camion camion { get => camionInformation; set => camionInformation = value; }

        public FormCamion()
        {
            InitializeComponent();
        }

        private void camion_Load(object sender, EventArgs e)
        {
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int PoidsDuCamion;
            int VolumeDuCamion;

            PoidsDuCamion = int.Parse(txt_poids.Text);
            VolumeDuCamion = int.Parse(txt_volume.Text);
            camion = new Camion(PoidsDuCamion, VolumeDuCamion);

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}