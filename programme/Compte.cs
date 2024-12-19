using System;

namespace tp2.Entites
{
    internal class Compte
    {
        // Attributs
        protected int id;
        protected int numCompte;
        protected int solde;
        protected static int nbCompte;

        // Getters et Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }

        public int Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public int Numcompte { get; internal set; }

        // Constructeurs
        public Compte() { }

        public Compte(int solde, int numCompte)
        {
            Solde = solde;
            NumCompte = numCompte;
        }

        // Méthode d'affichage
        public override string ToString()
        {
            return $"ID : {id}, Solde : {solde}, Numéro du Compte : {numCompte}";
        }
    }
}
