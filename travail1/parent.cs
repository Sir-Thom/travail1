using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace travail1
{
    public partial class parent : Form
    {
        private BindingSource bindingSourceCamion = new BindingSource();
        private BindingSource bindingSourceCamionneur = new BindingSource();
        private List<Camion> camionsList = new List<Camion>(500);
        private BindingSource bsLivraison = new BindingSource();
        private BindingSource bsLivraison2 = new BindingSource();
        private List<Camionneur> CamionneursList = new List<Camionneur>();
        private List<Livraison> LivraisonList = new List<Livraison>();
        private List<Livraison> LivraisonList2 = new List<Livraison>();
        private BindingSource bsVoyage = new BindingSource();
        private List<voyage> listVoyages = new List<voyage>();

        public parent()
        {
            InitializeComponent();
        }

        private void parent_Load(object sender, EventArgs e)
        {
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            bindingSourceCamionneur.DataSource = CamionneursList;
            cbox_Camionneur.DataSource = bindingSourceCamionneur;
            bindingSourceCamion.DataSource = camionsList;
            cbox_camion.DataSource = bindingSourceCamion;
            bsLivraison.DataSource = LivraisonList;
            lst_non_livraison.DataSource = bsLivraison;
            bsLivraison2.DataSource = voyageselect;
            lst_livraison_incluse.DataSource = bsLivraison2;
            bsVoyage.DataSource = listVoyages;
            lst_voyage.DataSource = bsVoyage;
            voyage nouveauvoyage = new voyage("Voyage1");
            listVoyages.Add(nouveauvoyage);
            bsVoyage.ResetBindings(false);
            voyage nouveauvoyage2 = new voyage("Voyage2");
            listVoyages.Add(nouveauvoyage2);
            bsVoyage.ResetBindings(false);
            Camion camion1 = new Camion(500, 500);
            camionsList.Add(camion1);
            bindingSourceCamion.ResetBindings(false);
            Livraison livraison1 = new Livraison(100, 100);
            LivraisonList.Add(livraison1);
            bsLivraison.ResetBindings(false);
        }

        // met dans la liste inclus
        private void btn_dans_Click(object sender, EventArgs e)
        {
            Livraison livraisonselect = (Livraison)lst_non_livraison.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            voyageselect.Livraison = livraisonselect;
            // bsLivraison.Remove(livraisonselect);

            if (livraisonselect != null)
            {
                // MessageBox.Show(voyageselect.Livraison.ToString());
                // en construction circuler

                string messageretour = voyageselect.AjouterLivraison(livraisonselect);
                if (messageretour == null)// les camions reste null (note:régler)
                {
                    voyageselect.Livraison = livraisonselect;
                    /*
                     * note: il faut que voyage sont utiliser pour les inclus mais le problème est que la la list
                     * prend les  inclus est les non inclus. liste voyage semble ne pas delete l'autre livraison.
                     * le problème doit être les bindings source.
                     */
                    // bsVoyage.Remove(voyageselect);
                    int test = bsLivraison2.Add(voyageselect.Livraison);
                    // int test = lst_livraison_incluse.Items.Add(livraisonselect);

                    bsLivraison2.ResetBindings(false);
                    bsLivraison.Remove(livraisonselect);

                    bsLivraison.ResetBindings(false);
                }

                if (messageretour == "un camion doit être selectionné")
                {
                    MessageBox.Show("erreur un camion doit être ajouter");
                }
                if (messageretour == "poids trop lourd pour le camion")
                {
                    MessageBox.Show(messageretour);
                }

                //bsLivraison = null;
            }
        }

        //mets dans la liste non inclus
        private void btn_hors_Click(object sender, EventArgs e)
        { ///
            Livraison livraisonselect = (Livraison)lst_livraison_incluse.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;
            //voyageselect.Livraison = voyageselect.Livraison;
            // en construction circuler
            if (voyageselect.Livraison != null)
            {
                // MessageBox.Show(voyageselect.Livraison.ToString());
                // en construction circuler

                string messageretour = voyageselect.AjouterLivraison(livraisonselect);
                if (messageretour == null)// les camions reste null (note:régler)
                {
                    livraisonselect = voyageselect.Livraison;
                    /*
                     * note: il faut que voyage sont utiliser pour les inclus mais le problème est que la la list
                     * prend les  inclus est les non inclus. liste voyage semble ne pas delete l'autre livraison.
                     * le problème doit être les bindings source.
                     */
                    // bsVoyage.Remove(voyageselect);
                    ///object teste = bsLivraison.Add(livraisonselect);
                    // int test = lst_livraison_incluse.Items.Add(livraisonselect);

                    bsLivraison.ResetBindings(false);
                    bsLivraison2.Remove(livraisonselect);

                    bsLivraison2.ResetBindings(false);
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

                lst_livraison_incluse.SelectedItem = voyageselect.Livraison;
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

        private void lst_non_livraison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Livraison livraisonSelect = (Livraison)lst_non_livraison.SelectedItem;
            if (livraisonSelect != null)
            {
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {
                    voyageselect.Livraison = livraisonSelect;
                }
            }
        }

        private void lst_livraison_incluse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Livraison livraisonSelect = (Livraison)lst_non_livraison.SelectedItem;
            if (livraisonSelect != null)
            {
                voyage voyageselect = (voyage)lst_voyage.SelectedItem;
                if (voyageselect != null)
                {
                    voyageselect.Livraison = livraisonSelect;
                }
            }
        }
    }
}