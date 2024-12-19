using System;
using System.Collections.Generic;
using System.Linq;
using tp2.programme;

namespace tp2.many
{
    internal class IAgenceImpl
    {
        private static List<Agence> agences = new List<Agence>();
        public void AjouterAgence()
        {
            Agence ag = new Agence();
            Console.WriteLine("ajouter un code");
            ag.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("ajouter  libelle");
            ag.Libelle = Console.ReadLine();
            agences.Add(ag);
            Console.WriteLine($"Agence ajoutée: {ag}");
        }
        public void AfficherAgences()
        {
            foreach (var agence in agences)
            {
                Console.WriteLine(agence.ToString());
            }
        }
        public void ModifierAgence(int numAg)
        {
            // Find the agency by its Id
            Agence new_ag = agences.FirstOrDefault(a => a.Id == numAg);

            if (new_ag != null)
            {
                Console.WriteLine("le nouveau code");
                new_ag.Code = int.Parse(Console.ReadLine());
                Console.WriteLine("le nouveau libelle");
                new_ag.Libelle = Console.ReadLine();
                Console.WriteLine($"Agence modifiée: {new_ag}");
            }
            else
            {
                Console.WriteLine($"Aucune agence trouvée avec l'ID {numAg}. La modification a échoué.");
            }
        }
        public void SupprimerAgence(int delid)
        {

            Agence del_agence = agences.FirstOrDefault(a => a.Id == delid);

            if (del_agence != null)
            {

                agences.Remove(del_agence);
                Console.WriteLine($"Agence supprimée: {del_agence}");
            }
            else
            {
                Console.WriteLine($"Aucune agence trouvée avec l'ID {delid}. La suppression a échoué.");
            }
        }

    }
}
