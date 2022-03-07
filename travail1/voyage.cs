using System;
using System.Collections.Generic;

namespace travail1
{
    internal class voyage
    {
        private int distance;
        private string nomVoyage;
        private Camion camion;
        private Camionneur camionneur;
        private Livraison livraison;
        private List<Livraison> listeLivraison = new List<Livraison>();
        private DateTime dateTime = new DateTime(2015, 12, 31, 5, 10, 20);

        public voyage(string nom)
        {
            nomVoyage = nom;
        }

        public DateTime Date { get => dateTime; set => dateTime = value; }
        public Camion Camion { get => camion; set => camion = value; }
        public Camionneur Camionneur { get => camionneur; set => camionneur = value; }
        public Livraison ListeLivraison { get => livraison; set => livraison = value; }
        public string NomVoyage { get => nomVoyage; set => nomVoyage = value; }
        public int Distance { get => distance; set => distance = value; }

        public string AjouterLivraison(Livraison nouvellelivraison)
        {
            listeLivraison.Add(livraison);
            if (Camion == null)
            {
                listeLivraison.Remove(livraison);
                return "un camion doit être selectionné";
            }
            int poidsmax = camion.PoidsDuCamionInfo;
            int volumemax = camion.VolumeDuCamionInfo;
            int totalpoids = 0;
            int totlavolume = 0;

            foreach (Livraison livraisoner in listeLivraison)
            {
                totalpoids = totalpoids + poidsmax;
                totlavolume = totlavolume + volumemax;
            }

            if (totalpoids > poidsmax && totlavolume > volumemax)
            {
                listeLivraison.Remove(livraison);
                return "poids ou volume trop lourd pour le camion";
            }
            listeLivraison.Remove(livraison);
            listeLivraison.Add(nouvellelivraison);

            return null;
        }

        public override string ToString()
        {
            return nomVoyage;
        }
    }
}