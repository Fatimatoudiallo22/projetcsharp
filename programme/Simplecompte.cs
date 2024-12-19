using System;

namespace tp2.Entites
{
    internal class CompteSimple : Compte
    {
        // Attribut
        private int tauxCouvert;

        // Getter et Setter
        public int TauxCouvert
        {
            get { return tauxCouvert; }
            set { tauxCouvert = value; }
        }

        public int Tauxcouvert { get; internal set; }

        // Constructeur avec paramètres
        public CompteSimple(int solde, int numCompte, int tauxCouvert) : base(solde, numCompte)
        {
            TauxCouvert = tauxCouvert;
        }

        // Constructeur par défaut
        public CompteSimple()
        {
            nbCompte++;  // Incrémenter le compteur global
            Id = nbCompte;  // Assigner un nouvel ID
        }

        // Méthode d'affichage
        public override string ToString()
        {
            return $"{base.ToString()}, Taux couvert : {tauxCouvert}%";
        }
    }
}
