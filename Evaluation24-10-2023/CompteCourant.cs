using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation24_10_2023
{
    public class CompteCourant : Compte
    {
        internal int montantDecouvert { get; set; }
        /// <summary>
        /// creation d'un compte courant
        /// </summary>
        /// <param name="titulaire"></param>
        /// <param name="signataire"></param>
        /// <param name="soldeInitial"></param>
        /// <param name="montantDecouvert"></param>
        public CompteCourant(Client titulaire, Client signataire,int soldeInitial, int montantDecouvert)
        {
            this.titulaire = titulaire;
            this.soldeinitial = soldeInitial;
            this.signataires.Add(signataire);
            this.montantDecouvert = montantDecouvert;
        }
        /// <summary>
        /// Debiter le compte
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public override double debiter(double montant)
        {
            this.solde -= montant;
            if (this.solde <= this.montantDecouvert)
            {
                Console.WriteLine("Vous avez retirez " + montant);
                return this.solde;
            }
            Console.WriteLine("Vous ne pouvez retirez " + montant);
            return this.solde;
        }
        /// <summary>
        /// Ajouter un signataire
        /// </summary>
        /// <param name="signataire"></param>
        /// <returns></returns>
        public override List<Client> addSignataire(Client signataire)
        {
            this.signataires.Add(signataire);
            return signataires;
        }
        /// <summary>
        /// Retirer un signataire
        /// </summary>
        /// <param name="signataire"></param>
        /// <returns></returns>
        public override List<Client> removeSignataire(Client signataire)
        {
            this.signataires.Remove(signataire);
            return signataires;

        }
    }
}
