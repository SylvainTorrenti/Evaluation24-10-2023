using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation24_10_2023
{
    public abstract class Compte
    {
        internal int numero{ get; set; }
        internal Client titulaire { get; set; }
        internal List<Client> signataires { get; set; } = new List<Client>();
        internal double soldeinitial { get; set; }
        internal double solde { get; set; }

        public abstract double debiter(double montant);
        public abstract List<Client> addSignataire(Client signataire);
        public abstract List<Client> removeSignataire(Client signataire);
        /// <summary>
        /// Crediter le compte
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public double crediter(double montant)
        {
            return solde += montant;
        }

    }
}
