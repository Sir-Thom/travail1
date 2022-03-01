using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travail1
{
    class Camionneur
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
            return PrenomCamionneur.ToString()+" "+ NomCamionneur;
        }
    }
}
