using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace monprojetDAL
{
   public class personneDO
    {
        static List<personne> ListePersonnes = new List<personne>();

        public static void Ajouter(personne newP, string statut)
        {
            newP.statut = statut;
            ListePersonnes.Add(newP);
        }

        public static void Supprimer(personne Pnew)
        {
            ListePersonnes.Remove(Pnew); 
        }

        public static List<personne> GetTous()
        {
            return ListePersonnes;
        }

        public static List<personne> chercher(string val)
        {
            List<personne> PersonneTrouver = new List<personne>();
            
            foreach (personne p in ListePersonnes)
            {
                  if (p.CNI == val || p.nom == val || p.prenom == val)
                    PersonneTrouver.Add(p);
              
            }
            
            return PersonneTrouver;
        
        }

        public static personne trouver(string cni)
        {
            return (personneDO.GetTous().Find(delegate(personne x) { return x.CNI == cni; }));
        }

        public static void modifier(personne Personne, string CNI, string nom, string prenom, string statut) 
        {
            Personne.CNI = CNI;
            Personne.nom = nom;
            Personne.prenom = prenom;
            Personne.statut = statut;
        }
        public static void exporter(StreamWriter ligne,string fichier)
        {
            foreach (personne p in ListePersonnes)
                ligne.WriteLine(p.CNI + "," + p.nom + "," + p.prenom + "," + p.statut);
        }
    }
}
