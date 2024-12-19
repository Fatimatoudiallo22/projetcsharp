using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.entites
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private int tel;
        private int idagence;
        public static int nbcli;

        public int Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public int Tel { get { return tel; } set { tel = value; } }
        public int Idagence { get { return idagence; } set { idagence = value; } }

        public Client(string nom, string prenom, int tel, int idagence)
        {
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Idagence = idagence;
        }

        public Client()
        {
            nbcli++;
            Id = nbcli;
        }

        public override string ToString()
        {
            return "id : " + id + " nom : " + nom + " prenom : " + prenom + " tel : " + tel + " id agence : " + idagence;
        }

        // Nouvelle méthode pour afficher une représentation personnalisée
        public string GetFullDescription()
        {
            string description = ToString();  // Utilise la méthode ToString() pour obtenir la description de base
            if (Idagence > 100) // Exemple de condition
            {
                description += " (Client d'une grande agence)";
            }
            else
            {
                description += " (Client d'une petite agence)";
            }
            return description;
        }
    }
}
