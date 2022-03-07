using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace travail1
{
    /*
    ████████╗██████╗░░█████╗░██╗░░░██╗░█████╗░██╗██╗░░░░░  ░░███╗░░
    ╚══██╔══╝██╔══██╗██╔══██╗██║░░░██║██╔══██╗██║██║░░░░░  ░████║░░
    ░░░██║░░░██████╔╝███████║╚██╗░██╔╝███████║██║██║░░░░░  ██╔██║░░
    ░░░██║░░░██╔══██╗██╔══██║░╚████╔╝░██╔══██║██║██║░░░░░  ╚═╝██║░░
    ░░░██║░░░██║░░██║██║░░██║░░╚██╔╝░░██║░░██║██║███████╗  ███████╗
    ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝╚══════╝  ╚══════╝

    ██████╗░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗███╗░░░███╗░█████╗░████████╗██╗░█████╗░███╗░░██╗
    ██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║████╗░████║██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║
    ██████╔╝██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║██╔████╔██║███████║░░░██║░░░██║██║░░██║██╔██╗██║
    ██╔═══╝░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║██║╚██╔╝██║██╔══██║░░░██║░░░██║██║░░██║██║╚████║
    ██║░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║██║░╚═╝░██║██║░░██║░░░██║░░░██║╚█████╔╝██║░╚███║
    ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝

    ░█████╗░██████╗░░░░░░██╗███████╗████████╗
    ██╔══██╗██╔══██╗░░░░░██║██╔════╝╚══██╔══╝
    ██║░░██║██████╦╝░░░░░██║█████╗░░░░░██║░░░
    ██║░░██║██╔══██╗██╗░░██║██╔══╝░░░░░██║░░░
    ╚█████╔╝██████╦╝╚█████╔╝███████╗░░░██║░░░
    ░╚════╝░╚═════╝░░╚════╝░╚══════╝░░░╚═╝░░░

    * Auteur : Thomas Toulouse
    *
    * Date : 07/03/2022
    *
    * Descrption: Application permettant de gérer un flotte de camion.
    */

    public partial class parent : Form
    {
        private BindingSource bindingSourceCamion = new BindingSource();
        private BindingSource bindingSourceCamionneur = new BindingSource();
        private List<Camion> camionsList = new List<Camion>();
        private BindingSource bsLivraisonNonAssigne = new BindingSource();
        private BindingSource bsLivraisonInclus = new BindingSource();
        private BindingSource bsLivraison3 = new BindingSource();
        private List<Camionneur> CamionneursList = new List<Camionneur>();
        private List<Livraison> LivraisonNonAssigneList = new List<Livraison>();
        private List<Livraison> LivraisonInclusList = new List<Livraison>();
        private List<Livraison> LivraisonList3 = new List<Livraison>();

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
            lst_non_livraison.DataSource = bsLivraisonNonAssigne;

            bsLivraisonInclus.DataSource = LivraisonInclusList;
            lst_livraison_incluse.DataSource = bsLivraisonInclus;

            bsVoyage.DataSource = listVoyages;
            lst_voyage.DataSource = bsVoyage;
            // 2 voyage
            voyage nouveauvoyage = new voyage("Voyage1");
            listVoyages.Add(nouveauvoyage);
            bsVoyage.ResetBindings(false);
            voyage nouveauvoyage2 = new voyage("Voyage2");
            listVoyages.Add(nouveauvoyage2);
            bsVoyage.ResetBindings(false);
            // 4 camions
            Camion camion1 = new Camion(500, 500);
            Camion camion2 = new Camion(100, 100);
            Camion camion3 = new Camion(1000, 1000);
            Camion camion4 = new Camion(700, 100);
            camionsList.Add(camion1);
            camionsList.Add(camion2);
            camionsList.Add(camion3);
            camionsList.Add(camion4);
            bindingSourceCamion.DataSource = camionsList;
            bindingSourceCamion.ResetBindings(false);

            // 3 camionneurs
            Camionneur camionneur1 = new Camionneur("Jean-Paul", "ptit");
            Camionneur camionneur2 = new Camionneur("Joe", "Blow");
            Camionneur camionneur3 = new Camionneur("Réjean", "Elgro");
            Camionneur camionneur4 = new Camionneur("Kevin", "Kevin");
            CamionneursList.Add(camionneur1);
            CamionneursList.Add(camionneur2);
            CamionneursList.Add(camionneur3);
            CamionneursList.Add(camionneur4);
            bindingSourceCamionneur.ResetBindings(false);
            // 4 livraisons
            Livraison livraison1 = new Livraison(100, 100);
            Livraison livraison2 = new Livraison(600, 600);
            Livraison livraison3 = new Livraison(100, 700);
            Livraison livraison4 = new Livraison(6000, 6000);
            LivraisonNonAssigneList.Add(livraison1);
            LivraisonNonAssigneList.Add(livraison2);
            LivraisonNonAssigneList.Add(livraison3);
            LivraisonNonAssigneList.Add(livraison4);

            bsLivraisonNonAssigne.DataSource = LivraisonNonAssigneList;
            bsLivraisonNonAssigne.ResetBindings(false);

            lst_voyage.SelectedItem = null;
        }

        // met dans la liste inclus
        private void btn_dans_Click(object sender, EventArgs e)
        {
            Livraison livraisonselect = (Livraison)lst_non_livraison.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;

            if (livraisonselect != null)
            {
                string messageretour = voyageselect.AjouterLivraison(livraisonselect);
                // permets d'afficher n'importe quel message d'erreur
                if (messageretour == messageretour)
                {
                    MessageBox.Show(messageretour);
                }
                // remplis la listbox
                else
                {
                    LivraisonInclusList.Add(livraisonselect);
                    LivraisonNonAssigneList.Remove(livraisonselect);

                    bsLivraisonInclus.ResetBindings(false);
                    bsLivraisonNonAssigne.ResetBindings(false);
                }
            }
        }

        //mets dans la liste non inclus
        private void btn_hors_Click(object sender, EventArgs e)
        {
            Livraison livraisonselect = (Livraison)lst_livraison_incluse.SelectedItem;
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;

            if (livraisonselect != null)
            {
                // remplis la listbox
                voyageselect.retirerInclus(livraisonselect);

                LivraisonInclusList.Remove(livraisonselect);
                LivraisonNonAssigneList.Add(livraisonselect);

                bsLivraisonInclus.ResetBindings(false);
                bsLivraisonNonAssigne.ResetBindings(false);
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

                    bindingSourceCamion.ResetBindings(false);
                }
                bindingSourceCamion.ResetBindings(true);
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

                    bindingSourceCamionneur.ResetBindings(false);
                }
            }
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
                    LivraisonNonAssigneList.Add(livraison);

                    bsLivraisonNonAssigne.ResetBindings(false);
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

                    bsLivraisonNonAssigne.ResetBindings(false);
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
            grbox_voyageSelecttioner.Hide();
            voyage voyageselect = (voyage)lst_voyage.SelectedItem;

            if (voyageselect != null)
            {
                lst_voyage.SelectedItem = voyageselect.NomVoyage;
                grbox_voyageSelecttioner.Show();
                cbox_camion.SelectedItem = voyageselect.Camion;
                txt_distance.Text = voyageselect.Distance.ToString();
                dateTimePicker1.Value = voyageselect.Date;
                // mets à jour la livraison
                bsLivraisonInclus.Clear();
                LivraisonInclusList.AddRange(voyageselect.ListeLivraison.ToArray());
                bsLivraisonInclus.ResetBindings(false);
            }
        }

        // gère les camionneur
        private void cbox_Camionneur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camionneur camionneurSelect = (Camionneur)cbox_Camionneur.SelectedItem;
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
                    //voyageselect.ListeLivraison = livraisonSelect ;
                }
            }
        }
    }
}