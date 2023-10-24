using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation24_10_2023
{
    public class CompteEpargne : Compte
    {
        internal int soldeMin { get; set; }
        internal double tauxInteret { get; set; }
        /// <summary>
        /// Création d'un compte epargne
        /// </summary>
        /// <param name="soldeMin"></param>
        /// <param name="titulaire"></param>
        /// <param name="solde"></param>
        /// <param name="tauxInteret"></param>
        public CompteEpargne(int soldeMin, Client titulaire,double solde, double tauxInteret)
        {
            if (solde < soldeMin)
            {
                Console.WriteLine("Le solde minimal n'est pas atteint le compte ne peut être créé.");
            }
            else
            {
                this.solde = solde;
                this.soldeMin = soldeMin;
                this.titulaire = titulaire;
                this.tauxInteret = tauxInteret;
            }
        }
        /// <summary>
        /// Debiter le compte
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public override double debiter(double montant)
        {
            if (montant > this.solde)
            {
                Console.WriteLine("Vous ne pouvez retirez plus que le solde du compte");
                return this.solde;
            }
            this.solde -= montant;
            Console.WriteLine("Vous avez retiré " + montant + "euros");
            Console.WriteLine("Le solde est maintenant de " + this.solde + "euros");
            return this.solde;
        }
        /// <summary>
        /// ajouter un signataire au compte
        /// </summary>
        /// <param name="signataire"></param>
        /// <returns></returns>
        public override List<Client> addSignataire(Client signataire)
        {
            this.signataires.Add(signataire);
            return signataires;
        }
        /// <summary>
        /// retirer un signataire au compte
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
