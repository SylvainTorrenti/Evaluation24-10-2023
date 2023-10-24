using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation24_10_2023
{
    public abstract class Personne
    {
        internal long numSecu { get; set; }
        internal string name { get; set; }
        internal string prenom { get; set; }
        internal DateTime dateDeNaissance { get; set; }       
    }
}
