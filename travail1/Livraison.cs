using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travail1
{
    class Livraison
    {

        private int poidsDulivraison;
        private int volumeDuLivraison;
        private DateTime dateLivraison;

        public Livraison(int poidsDulivraison, int volumeDuLivraison, DateTime dateLivraison)
        {
            PoidsDuLivraisonInfo = poidsDulivraison;
            VolumeDuLivraisonInfo = volumeDuLivraison;
            DateLivraison = dateLivraison;
        }

        public int PoidsDuLivraisonInfo { get => poidsDulivraison; set => poidsDulivraison = value; }
        public int VolumeDuLivraisonInfo { get => volumeDuLivraison; set => volumeDuLivraison = value; }

        public DateTime DateLivraison { get => dateLivraison; set => dateLivraison = value; }

        public override string ToString()
        {
            return PoidsDuLivraisonInfo.ToString() + "Lbs , " + VolumeDuLivraisonInfo.ToString();
        }
    }
}
