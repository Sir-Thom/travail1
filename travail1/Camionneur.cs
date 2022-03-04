namespace travail1
{
    internal class Camionneur
    {
        private string prenom;
        private string nom;

        public Camionneur(string prenomCamionneur, string nomCamionneur)
        {
            PrenomCamionneur = prenomCamionneur;
            NomCamionneur = nomCamionneur;
        }

        public string PrenomCamionneur { get => prenom; set => prenom = value; }
        public string NomCamionneur { get => nom; set => nom = value; }

        public override string ToString()
        {
            return PrenomCamionneur.ToString() + " " + NomCamionneur;
        }
    }
}