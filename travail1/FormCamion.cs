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
  
  
    public partial class FormCamion : Form
    { /*
       * il faut le poids, 
       * le volume du camion 
       * et l'ajouter à la forme parent
       */
        Camion camionInformation;

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
            //int PoidsDuCamionInfo = int.Parse(txt_poids.Text);
            //VolumeDuCamionInfo = int.Parse(txt_volume.Text);
            
            PoidsDuCamion = int.Parse(txt_poids.Text);
            VolumeDuCamion = int.Parse(txt_volume.Text);
            camion = new Camion(PoidsDuCamion,VolumeDuCamion);
           // CamionCree = "Poids : " + PoidsDuCamion.ToString() + " Lbs "  + " , Volume de : " + VolumeDuCamion.ToString();
            this.DialogResult = DialogResult.OK;
          //  CamionCree = "Camion de :" + PoidsDuCamionInfo + " Lbs " + volumeDuCamion.ToString() + " avec un volume de : " + VolumeDuCamionInfo;
            this.Close();
        }

       
      
    }
}
