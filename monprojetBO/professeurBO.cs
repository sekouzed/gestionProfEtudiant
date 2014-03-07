using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using monprojetDAL;
using System.IO;

namespace monprojetBO
{
    public class professeurBO
    {
        public static void Ajouter(string CNI, string CNE, string nom, string prenom)
        {
            professeur newP = new professeur();
            newP.matiere = CNE;
            newP.CNI = CNI;
            newP.nom = nom;
            newP.prenom = prenom;
            professeurDO.Ajouter(newP);
        }

        public static void Supprimer(string cni)
        {
            professeur P = new professeur();
            P = professeurDO.trouver(cni);
            professeurDO.Supprimer(P);
        }

        public static List<professeur> GetTous()
        {
            return professeurDO.GetTous();
        }

        public static professeur chercher(string cni)
        {
            professeur X = new professeur();
            X = professeurDO.trouver(cni);
            return X;
        }

        public static void modifier(string CNI, string newMatiere, string matiere, string nom, string prenom)
        {
            professeur newP = new professeur();
            newP = professeurDO.trouver(CNI);
            professeurDO.modifier(newP, newMatiere, matiere, nom, prenom);
        }
        public static void exporter(string fichier)
        {
            StreamWriter ligne = new StreamWriter(fichier);
            professeurDO.exporter(ligne, fichier);
            ligne.Close();
        }
    }
}
