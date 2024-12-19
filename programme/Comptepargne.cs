using System;

namespace tp2.Entites
{
    internal class CompteEpargne : Compte
    {
        // Attribut
        private int duree;

        // Getter et Setter
        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        // Constructeur par défaut
        public CompteEpargne()
        {
            nbCompte++;  // Incrémenter le compteur global
            Id = nbCompte;  // Assigner un nouvel ID
        }

        // Constructeur avec paramètres
        public CompteEpargne(int solde, int numCompte, int duree) : base(solde, numCompte)
        {
            Duree = duree;
        }

        // Méthode d'affichage
        public override string ToString()
        {
            return $"{base.ToString()}, Durée : {duree} mois";
        }
    }
}
