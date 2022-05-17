using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_eleve
{
    class Eleve
    {
        private string nom;
        private string prenom;
        private float moyenne;
        private static int nbEleve = 0;

        public Eleve(string nom, string prenom, float moyenne)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.moyenne = moyenne;
            Eleve.nbEleve = Eleve.nbEleve + 1;
        }
        public static int GetNbEleve()
        {
            return Eleve.nbEleve;
        }
        public void SetMoyenne(float moy)
        {
            this.moyenne = moy;
        }
        public float GetMoyenne()
        {
            return this.moyenne;
        }
        public string GetNom()
        {
            return this.nom;
        }

    }
}
