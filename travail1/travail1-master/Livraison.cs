namespace travail1
{
    internal class Livraison
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