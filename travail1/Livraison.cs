namespace travail1
{
    internal class Livraison
    {
        private int poidsDulivraison;
        private int volumeDuLivraison;

        public Livraison(int poidsDulivraison, int volumeDuLivraison)
        {
            PoidsDeLivraisonInfo = poidsDulivraison;
            VolumeDeLivraisonInfo = volumeDuLivraison;
        }

        public int PoidsDeLivraisonInfo { get => poidsDulivraison; set => poidsDulivraison = value; }
        public int VolumeDeLivraisonInfo { get => volumeDuLivraison; set => volumeDuLivraison = value; }

        public override string ToString()
        {
            return PoidsDeLivraisonInfo.ToString() + "Lbs , " + VolumeDeLivraisonInfo.ToString();
        }
    }
}