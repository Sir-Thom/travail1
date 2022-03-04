using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace travail1
{
    public partial class parent : Form
    {
        BindingSource bindingSourceCamion = new BindingSource();
        BindingSource bindingSourceCamionneur = new BindingSource();
        List<Camion> camionsList = new List<Camion>();
        BindingSource bsLivraison = new BindingSource();
        BindingSource bsLivraison2 = new BindingSource();
        List<Camionneur> CamionneursList = new List<Camionneur>();
        List<Livraison> LivraisonList = new List<Livraison>();
        List<Livraison> LivraisonList2 = new List<Livraison>();
        BindingSource bsVoyage = new BindingSource();
        List<voyage> listVoyages = new List<voyage>();

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

            bsVoyage.DataSource = listVoyages;
            lst_voyage.DataSource = bsVoyage;
            voyage nouveauvoyage = new voyage("Voyage1");
            listVoyages.Add(nouveauvoyage);
            bsVoyage.ResetBindings(false);
            voyage nouveauvoyage2 = new voyage("Voyage2");
            listVoyages.Add(nouveauvoyage2);
            bsVoyage.ResetBindings(false);
            

        
        }
        // met dans la liste inclus
        private void btn_dans_Click(object sender, EventArgs e) // ceci marche que en partie 
        {
            Livraison livraisonselect = (Livraison)lst_non_livraison.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            
            bsLivraison.Remove(livraisonselect);

            if (livraisonselect != null)
            {
                // en construction circuler
                //int retourLivraison = lst_livraison_incluse.Items.Add(livraisonselect);
                string messageretour = voyageselect.AjouterLivraison(livraisonselect);
                if (messageretour == null)// les camions reste null (note: à régler)
                {
                    int test = lst_livraison_incluse.Items.Add(livraisonselect);
                    //int test = lst_livraison_incluse.Items.Add(livraisonselect);
                    bsLivraison.Remove(livraisonselect);
                    bsLivraison = null;
                    
                    bsLivraison.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("erreur ajout");
                }

            }
        }

   
        //mets dans la liste non inclus
        private void btn_hors_Click(object sender, EventArgs e)
        {
            // en construction circuler
            Livraison livraisonselect = (Livraison)lst_livraison_incluse.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            /*LivraisonChoisi = lst_non_livraison.SelectedItem.ToString() ;
             voyage voyagselect = (voyage)lst_livraison_incluse.SelectedItem();*/


            if (livraisonselect != null)
            {
                bsLivraison.ResetBindings(false);
                LivraisonList.Add(livraisonselect);
                int retourLivraison = lst_non_livraison.Items.Add(livraisonselect);
                string messageretour = voyageselect.AjouterLivraison(livraisonselect);
                if (messageretour == null)
                {
                    int test = lst_non_livraison.Items.Add(livraisonselect);
                    bsLivraison.Remove(test);
                }
                else
                {
                    MessageBox.Show("erreur retrait");
                }

            }

        }

        private void camionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCamion camionInfo = new FormCamion())
            {
                DialogResult resultat = camionInfo.ShowDialog();
                if (resultat == DialogResult.OK)
                {
                    Camion InfoCamion = camionInfo.camion;
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

        private void voyageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Formvoyage formvoyage = new Formvoyage())
            {
                DialogResult resultat = formvoyage.ShowDialog();
                if (resultat == DialogResult.OK)
                {
                    voyage voyage = formvoyage.Voyage;
                    listVoyages.Add(voyage);
                    bsVoyage.ResetBindings(false);
                    //cbox_Camionneur.Items.Add(CamionneursList);
                    bsLivraison.ResetBindings(false);

                }
            }
        }
        // gère camion 
        private void cbox_camion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camion camionSelect = (Camion)cbox_camion.SelectedItem;
            if (camionSelect != null)
            {
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {
                    voyageselect.Camion = camionSelect;
                }
            }
        }
        // gère la liste voyage
        private void lst_voyage_SelectedIndexChanged(object sender, EventArgs e)
        {
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            if (voyageselect != null)
            {
                cbox_camion.SelectedItem = voyageselect.Camion;
                txt_distance.Text = voyageselect.Distance.ToString();
                
                dateTimePicker1.Value = voyageselect.Date;
            }
        }
        // gère les camionneur
        private void cbox_Camionneur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camionneur camionneurSelect = (Camionneur)cbox_camion.SelectedItem;
            if (camionneurSelect != null)
            {
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {
                    voyageselect.Camionneur = camionneurSelect;
                }
            }
        }
        // gère la  distance 
        private void txt_distance_Leave(object sender, EventArgs e)
        {
            string input = txt_distance.Text;
            int nvDist;
            bool parsesucess = int.TryParse(input, out nvDist);
            if (parsesucess)
            {
                
               
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {

                
                    voyageselect.Distance = nvDist;
                }
                
            }
            else
            {
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {

                    txt_distance.Text = voyageselect.Distance.ToString();
                }

                MessageBox.Show("nb invalid");
            }
        }
        // gère la date 
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            DateTime nouvelleDate = dateTimePicker1.Value;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            if (voyageselect != null)
            {
                
                voyageselect.Date = nouvelleDate;
            }
            else
            {
                MessageBox.Show("date invalid");
            }    
            
        }
    }
}
