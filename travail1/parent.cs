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
    public partial class parent : Form
    {
        BindingSource bindingSourceCamion = new BindingSource();
        BindingSource bindingSourceCamionneur = new BindingSource();
        List<Camion> camionsList = new List<Camion>();
        BindingSource bsLivraison = new BindingSource();
        List<Camionneur> CamionneursList = new List<Camionneur>();
        List<Livraison> LivraisonList = new List<Livraison>();


        public parent()
        {
            InitializeComponent();
        }

        private void parent_Load(object sender, EventArgs e)
        {
           
            bindingSourceCamionneur.DataSource = CamionneursList;
            cbox_Camionneur.DataSource = bindingSourceCamionneur;
            bindingSourceCamion.DataSource = camionsList;
            cbox_camion.DataSource = bindingSourceCamion;
            bsLivraison.DataSource = LivraisonList;
            lst_non_livraison.DataSource = bsLivraison;
           // camionInfo Camion = new camionInfo();
           //int poidDuCamion = Camion.VolumeDuCamionInfo;
           // camionsList.Add((travail1.camionInfo)poidDuCamion);

            // cbox_camion.Items.Add(camionsList);
        }

        private void btn_dans_Click(object sender, EventArgs e)
        {
            string LivraisonChoisi;
            LivraisonChoisi = lst_non_livraison.SelectedItem.ToString() ;
            bsLivraison.Clear();
            lst_non_livraison.Items.Remove(lst_non_livraison.SelectedItem);
            lst_livraison_incluse.Items.Add(LivraisonChoisi);
           
        }

        private void btn_hors_Click(object sender, EventArgs e)
        {
            string LivraisonChoisi;
            LivraisonChoisi = lst_livraison_incluse.SelectedItem.ToString();
            
            lst_livraison_incluse.Items.Remove(lst_livraison_incluse.SelectedItem);
            bsLivraison.Clear();
            bsLivraison.Remove(lst_non_livraison);
         
            lst_non_livraison.Items.Add(LivraisonChoisi);
            
        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCamion camionInfo = new FormCamion())
            {
                DialogResult resultat = camionInfo.ShowDialog();
                if (resultat == DialogResult.OK)
                {
                   Camion InfoCamion  = camionInfo.camion ;
                    camionsList.Add(InfoCamion);
                    //cbox_camion.Items.Add(InfoCamion);
                    bindingSourceCamion.ResetBindings(false);
                }
                bindingSourceCamion.ResetBindings(true);
                /*  camionInfo Camion = new camionInfo();
                  Camion.ShowDialog();

                  camionsList.Add( Camion);
                  bindingSource.ResetBindings(false);
                  cbox_camion.Items.Add(camionsList);*/
            }
        }
        private void camionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {


            using (FromCamionneur CamionneurInfo = new FromCamionneur())
            {
                DialogResult resultat = CamionneurInfo.ShowDialog();
                if (resultat == DialogResult.OK)
                {
                    Camionneur InfoCamionneur = CamionneurInfo.Camionneur;
                    CamionneursList.Add(InfoCamionneur);
                    //cbox_Camionneur.Items.Add(CamionneursList);
                    bindingSourceCamionneur.ResetBindings(false);

                }
            }
            //camionneur.ShowDialog();
           // camionneur.ShowDialog().DialogResult.OK;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void livraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FromLivraison livraisonInfo = new FromLivraison())
            {
                DialogResult resultat = livraisonInfo.ShowDialog();
                if (resultat == DialogResult.OK)
                {
                    Livraison livraison = livraisonInfo.livraison;
                    LivraisonList.Add(livraison);
                    //cbox_Camionneur.Items.Add(CamionneursList);
                    bsLivraison.ResetBindings(false);

                }
            }
        }
    }
}
