using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monprojetDAL
{
    public class etudiant:personne
    {
        public string _CNE;
       
        public string CNE
        {
            get { return _CNE; }
            set { _CNE = value; }
        }

    }
}
