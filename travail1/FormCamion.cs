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

            bool parsesucces1 = int.TryParse(txt_poids.Text, out PoidsDuCamion);
            bool parsesucces2 = int.TryParse(txt_volume.Text, out VolumeDuCamion);
            if (parsesucces1 && parsesucces2)
            {
                PoidsDuCamion = int.Parse(txt_poids.Text);
                VolumeDuCamion = int.Parse(txt_volume.Text);
                camion = new Camion(PoidsDuCamion, VolumeDuCamion);

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