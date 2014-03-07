using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monprojetDAL
{
   public class professeur:personne
    {
        public string _matiere;

        public string matiere
        {
            get { return _matiere; }
            set { _matiere = value; }
        }
    }
}
