using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace monprojetDAL
{
    public class professeurDO
    {
        static List<professeur> ListeProfesseurs = new List<professeur>();
        
        public static void Ajouter(professeur newProfesseur)
        {
            ListeProfesseurs.Add(newProfesseur);
            personneDO.Ajouter(newProfesseur, "Professeur");
        }

        public static void Supprimer(professeur Pnew)
        {
            ListeProfesseurs.Remove(Pnew);
            personneDO.Supprimer(Pnew);
        }

        public static List<professeur> GetTous()
        {
            return ListeProfesseurs;
        }

        public static professeur trouver(string cni)
        {
            return ( professeurDO.GetTous().Find(delegate(professeur x) { return x.CNI == cni; }));
        }

        public static void modifier(professeur Prof, string CNI, string matiere, string nom, string prenom)
        {
            Prof.CNI = CNI;
            Prof.matiere = matiere;
            Prof.nom = nom;
            Prof.prenom = prenom;
            personneDO.modifier(Prof, CNI, nom, prenom, "Professeur");
        }
        public static void exporter(StreamWriter ligne, string fichier)
        {
            foreach (professeur p in ListeProfesseurs)
                ligne.WriteLine(p.CNI + "," + p.matiere + "," + p.nom + "," + p.prenom);
        }

    }
}
