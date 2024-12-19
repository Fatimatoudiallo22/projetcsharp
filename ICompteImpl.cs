using System;
using System.Collections.Generic;
using System.Linq;
using tp2.Entites;

namespace tp2.many
{
    internal class ICompteImpl
    {
        private List<Compte> comptes = new List<Compte>();

        //les fonctions 
        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
            Console.WriteLine("ajout valider");
        }
        public void AfficherCompte()
        {
            //parcourir la liste
            Console.WriteLine("La liste des comptes est :  ");
            foreach (var compte in comptes)
            {
                //affichage

                Console.WriteLine(compte.ToString());
            }
        }
        public void AfficherCompteSimple()
        {
            //parcourir la liste
            foreach (var compte in comptes)

            {
                if (compte is CompteSimple comptesimple)
                {
                    Console.WriteLine(comptesimple.ToString());
                }
            }
        }
        public void AfficherEpargne()
        {
            //parcourir la liste
            foreach (var compte in comptes)
            {

                if (compte is CompteEpargne compteepargne)
                {
                    Console.WriteLine(compteepargne.ToString());
                }
            }
        }
        public void ModifierCompte(int numCompte)
        {

            var compte = comptes.FirstOrDefault(c => c.Numcompte == numCompte);

            if (compte != null)
            {
                Console.WriteLine("Compte trouvé. Modifiez les informations.");


                Console.WriteLine("Entrez le nouveau solde : ");
                if (int.TryParse(Console.ReadLine(), out int newSolde) && newSolde >= 0)
                {
                    compte.Solde = newSolde;
                    Console.WriteLine("Solde modifié avec succès.");
                }


                if (compte is CompteSimple)
                {

                    Console.WriteLine("Entrez le nouveau taux de couverture : ");
                    if (int.TryParse(Console.ReadLine(), out int newTaux) && newTaux >= 0)
                    {
                        ((CompteSimple)compte).Tauxcouvert = newTaux;
                        Console.WriteLine("Taux de couverture modifié.");
                    }
                }
                else if (compte is CompteEpargne)
                {

                    Console.WriteLine("Entrez la nouvelle durée : ");
                    if (int.TryParse(Console.ReadLine(), out int newDuree) && newDuree > 0)
                    {
                        ((CompteEpargne)compte).Duree = newDuree;
                        Console.WriteLine("Durée modifiée.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Aucun compte trouvé avec ce numéro.");
            }
        }
        public void SupprimerCompte(int numCompt)
        {

            var compte = comptes.FirstOrDefault(c => c.Numcompte == numCompt);

            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine("Compte supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Aucun compte trouvé avec ce numéro.");
            }
        }



    }
}

