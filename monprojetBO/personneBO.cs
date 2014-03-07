using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using monprojetDAL;
using System.IO;

namespace monprojetBO
{
    public class personneBO
    {
        public static List<personne> GetTous()
        {
            return personneDO.GetTous();
        }


        public static List<personne> chercher(string val)
        {
            return personneDO.chercher(val);
        }

        public static personne trouver(string cni)
        {
            personne X = new personne();
            X = personneDO.trouver(cni);
            return X;
        }

        public static void exporter(string fichier)
        {
            StreamWriter ligne = new StreamWriter(fichier);
            personneDO.exporter(ligne, fichier);
            ligne.Close();
        }
    }
}
