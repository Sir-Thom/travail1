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
        

        public Livraison(int poidsDulivraison, int volumeDuLivraison)
        {
            PoidsDuLivraisonInfo = poidsDulivraison;
            VolumeDuLivraisonInfo = volumeDuLivraison;
            
        }

        public int PoidsDuLivraisonInfo { get => poidsDulivraison; set => poidsDulivraison = value; }
        public int VolumeDuLivraisonInfo { get => volumeDuLivraison; set => volumeDuLivraison = value; }

        

        public override string ToString()
        {
            return PoidsDuLivraisonInfo.ToString() + "Lbs , " + VolumeDuLivraisonInfo.ToString();
        }
    }
}
