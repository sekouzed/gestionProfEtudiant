using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using monprojetDAL;
using System.IO;

namespace monprojetBO
{
    public class etudiantBO
    {
        public static void Ajouter(string CNI,string CNE,string nom,string prenom)
        {
            etudiant newE = new etudiant();
            // int intCNE = Convert.ToInt32(txt_CNE.Text);
            newE.CNE = CNE;
            newE.CNI = CNI;
            newE.nom = nom;
            newE.prenom = prenom;
            etudiantDO.Ajouter(newE);
        }

        public static void Supprimer(string cni)
        {
            etudiant E= new etudiant();
            E = etudiantDO.trouver(cni);
            etudiantDO.Supprimer(E);
        }

        public static List<etudiant> GetTous()
        {
            return etudiantDO.GetTous();
        }

        public static etudiant chercher(string cni)
        {
            etudiant X = new etudiant();
            X=etudiantDO.trouver(cni);
            return X;
        }

        public static void modifier(string CNI, string newCNI, string CNE, string nom, string prenom)
        {
            etudiant newE = new etudiant();
            newE = etudiantDO.trouver(CNI);
            etudiantDO.modifier(newE, newCNI, CNE, nom, prenom); 
        }
        public static void exporter(string fichier) 
        {
            StreamWriter ligne = new StreamWriter(fichier);
            etudiantDO.exporter(ligne,fichier);
            ligne.Close();
        }
    }
}
