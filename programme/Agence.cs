using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.programme
{
    internal class Agence
    {
        private int id;
        private int code;
        private string libelle;
        public static int nbagence;

        // Propriétés
        public int Id { get { return id; } private set { id = value; } }
        public int Code
        {
            get { return code; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le code de l'agence doit être un nombre positif.");
                }
                code = value;
            }
        }

        public string Libelle
        {
            get { return libelle; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le libellé de l'agence ne peut pas être vide.");
                }
                libelle = value;
            }
        }

        // Constructeur par défaut
        public Agence()
        {
            nbagence++;
            Id = nbagence;
        }

        // Constructeur avec paramètres
        public Agence(int code, string libelle)
        {
            Code = code;
            Libelle = libelle;
            nbagence++;
            Id = nbagence; // Assigner un ID unique
        }

        // Méthode ToString() modifiée pour un affichage plus lisible
        public override string ToString()
        {
            return $"ID : {id}, Code : {code}, Libellé : {libelle}";
        }

        // Méthode pour afficher un rapport de toutes les agences
        public static void AfficherRapport(List<Agence> agences)
        {
            Console.WriteLine("Rapport des agences :");
            foreach (var agence in agences)
            {
                Console.WriteLine(agence.ToString());
            }
        }

        // Méthode pour rechercher une agence par son code
        public static Agence RechercherParCode(List<Agence> agences, int codeRecherche)
        {
            return agences.FirstOrDefault(agence => agence.Code == codeRecherche);
        }
    }
}
