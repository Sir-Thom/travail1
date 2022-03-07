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
        private Livraison Livraison;

        public voyage(string nom)
        {
            nomVoyage = nom;
        }

        public DateTime Date { get => dateTime; set => dateTime = value; }
        public Camion Camion { get => camion; set => camion = value; }
        public Camionneur Camionneur { get => camionneur; set => camionneur = value; }
        public List<Livraison> ListeLivraison { get => listeLivraison; set => listeLivraison = value; }
        public string NomVoyage { get => nomVoyage; set => nomVoyage = value; }
        public int Distance { get => distance; set => distance = value; }
        public Livraison Livraison1 { get => Livraison; set => Livraison = value; }

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
            int totalvolume = 0;
            // int livre = listeLivraison[].PoidsDeLivraisonInfo;
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            // Output: 9 99 3 33 5 55

            foreach (Livraison livraison in listeLivraison)
            {
                //camionDansListe = livraison;
                int livraisonIndex = listeLivraison.Count - 1;
                totalpoids = totalpoids + nouvellelivraison.PoidsDeLivraisonInfo;
                totalvolume = totalvolume + nouvellelivraison.VolumeDeLivraisonInfo;
            }
            if (totalpoids > poidsmax && totalvolume > volumemax)
            {
                listeLivraison.Remove(livraison);
                return "volume et le poids est trop lourd pour le camion";
            }
            if (totalpoids > poidsmax)
            {
                listeLivraison.Remove(livraison);
                return "poids trop est lourd pour le camion";
            }
            else if (totalvolume > volumemax)
            {
                listeLivraison.Remove(livraison);
                return "volume  trop lourd est pour le camion";
            }

            listeLivraison.Remove(livraison);
            listeLivraison.Add(nouvellelivraison);

            return null;
        }

        public void retirerInclus(Livraison livraisonRetirer)
        {
            listeLivraison.Remove(livraisonRetirer);
        }

        public override string ToString()
        {
            return nomVoyage;
        }
    }
}