﻿using System;
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
        private List<Livraison> Livraisons = new List<Livraison>();
        private DateTime dateTime = new DateTime(2022, 1, 1, 5, 10, 20);

        public voyage(string nom)
        {
            nomVoyage = nom;
        }

        public DateTime Date { get => dateTime; set => dateTime = value; }
        public Camion Camion { get => camion; set => camion = value; }
        public Camionneur Camionneur { get => camionneur; set => camionneur = value; }
        public Livraison Livraison { get => livraison; set => livraison = value; }
        public string NomVoyage { get => nomVoyage; set => nomVoyage = value; }
        public int Distance { get => distance; set => distance = value; }

        public string AjouterLivraison(Livraison nouvellelivraison)
        {
            //Livraisons.Add(nouvellelivraison);

            if (Camion == null)
            {
                return "un camion doit être selectionné";
            }
            int poidsmax = camion.PoidsDuCamionInfo;
            int volumemax = camion.VolumeDuCamionInfo;
            int totalpoids = 0;
            int totlavolume = 0;

            foreach (Livraison livraisoner in Livraisons)// select les deux colonnes à place de non-selectionner
            {
                int indexlivraison = Livraisons.Count;
                totalpoids = totalpoids + poidsmax;
            }
            /*for (int indexlivraison = 0; indexlivraison < Livraisons.Count; indexlivraison++)
            {
               totalpoids = totalpoids + Livraisons[indexlivraison].PoidsDuLivraisonInfo;
                totlavolume = totlavolume + Livraisons[indexlivraison].VolumeDuLivraisonInfo;
            }*/
            if (totalpoids > poidsmax)
            {
                return "poids trop lourd pour le camion";
            }
            Livraisons.Add(nouvellelivraison);
            //totalpoids = totalpoids + nouvellelivraison.PoidsDuLivraisonInfo;
            // totlavolume = totlavolume + nouvellelivraison.VolumeDuLivraisonInfo;
            return null;
        }

        public override string ToString()
        {
            return nomVoyage;
        }

        public void RetirerLivraison(Livraison livraisonretirer)
        {
            Livraisons.Remove(livraisonretirer);
        }
    }
}