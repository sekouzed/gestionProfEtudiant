using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace monprojetDAL
{
   public class etudiantDO
    {
        static List<etudiant> ListeEtudiants = new List<etudiant>();
        
        public static void Ajouter(etudiant newEtudiant)
        {
            ListeEtudiants.Add(newEtudiant);
            personneDO.Ajouter(newEtudiant, "Etudiant");
        }

        public static void Supprimer(etudiant Enew)
        {
            ListeEtudiants.Remove(Enew);
            personneDO.Supprimer(Enew);
        }

        public static List<etudiant> GetTous()
        {
            return ListeEtudiants;
        }

        public static etudiant trouver(string cni)
        {
             return (etudiantDO.GetTous().Find(delegate(etudiant x){ return x.CNI==cni;}));
        }

        public static void modifier(etudiant etudiant, string CNI, string CNE, string nom, string prenom) 
        {
            etudiant.CNI = CNI;
            etudiant.CNE = CNE;
            etudiant.nom = nom;
            etudiant.prenom = prenom;
            personneDO.modifier(etudiant, CNI, nom, prenom, "Etudiant");
        }
        public static void exporter(StreamWriter ligne,string fichier)
        {
            foreach (etudiant e in ListeEtudiants)
                ligne.WriteLine(e.CNI + "," + e.CNE + "," + e.nom + "," + e.prenom);
        }
     
    }
}
