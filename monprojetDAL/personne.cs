using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monprojetDAL
{
   public class personne
    {
       public string _nom;
       public string _prenom;
       public string _CNI;
       public string _statut;

       public string CNI
       {
           get { return _CNI; }
           set { _CNI = value; }
       }
       
       public string nom 
       {
           get { return _nom; }
           set { _nom = value; }
       }
       public string prenom
       {
           get { return _prenom; }
           set { _prenom = value; }
       }
       public string statut
       {
           get { return _statut; }
           set { _statut = value; }
       }

    }
}
