using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_eleve
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleve e1, e2, e3;
            Eleve[] tabEleve;
            int i, ind;
            float somme;
            bool trouve;
            string nom;

            Console.Out.WriteLine("Nombre d'élèves : " + Eleve.GetNbEleve());
            
            e1 = new Eleve("Durand", "Paul", 12.5f);
            e2 = new Eleve("Dupond", "Jean", 9.5f);
            e3 = new Eleve("Durieux", "Julie", 14.5f);
            
            Console.Out.WriteLine("Nombre d'élèves : " + Eleve.GetNbEleve());
            
            tabEleve = new Eleve[10];
            
            tabEleve[0] = e1;
            tabEleve[1] = e2;
            tabEleve[2] = e3;
            tabEleve[3] = new Eleve("Martin", "Pierre", 10.8f);
            tabEleve[4] = new Eleve("Macron", "Zoé", 5.5f);
            
            // Calcul de la moyenne générale
            somme = 0;
            //for(i=0; i < tabEleve.Length; i++)
            for (i = 0; i < Eleve.GetNbEleve(); i++)
            {
                somme = somme + tabEleve[i].GetMoyenne();
            }
            if (Eleve.GetNbEleve() > 0)
                Console.Out.WriteLine("Moyenne générale : " + somme / Eleve.GetNbEleve());
            else
                Console.Out.WriteLine("Pas de moyenne car aucun élève !");

            // Recherche d'un eleve de nom saisi
            Console.Out.Write("Nom recherché : ");
            nom = Console.In.ReadLine();
            // Affichage de la moyenne de l'élève V1
            /*
            for (i = 0; i < Eleve.GetNbEleve(); i++)
            {
                if (tabEleve[i].GetNom() == nom)
                {
                    Console.Out.WriteLine("Moyenne de " + nom + " : " + tabEleve[i].GetMoyenne());
                }
           
                else
                {
                    Console.Out.WriteLine("Aucun élève de nom " + nom);
                }
            }*/
            // Affichage de la moyenne de l'élève V2
            /*
            trouve = false;
            ind = 0;
            for (i = 0; i < Eleve.GetNbEleve(); i++)
            {
                if (tabEleve[i].GetNom() == nom)
                {
                    trouve = true;
                    ind = i;
                }

            }
            if (trouve)
                Console.Out.WriteLine("Moyenne de " + nom + " : " + tabEleve[ind].GetMoyenne());
            else
                Console.Out.WriteLine("Aucun élève de nom " + nom);
            */
            
            i = 0;
            trouve = false;
            while (i < Eleve.GetNbEleve() && ! trouve)
            {
                if (tabEleve[i].GetNom() == nom)
                    trouve = true;
                else
                    i++;
            }
            if (trouve)
                Console.Out.WriteLine("Moyenne de " + nom + " : " +tabEleve[i].GetMoyenne());
            else
                Console.Out.WriteLine("Aucun élève de nom " + nom);
            
            Console.In.ReadLine();
        }
    }
}
