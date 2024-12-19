using System;
using tp2.Entites;
using tp2.many;

namespace tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ICompteImpl Gest_Comp = new ICompteImpl();
            IAgenceImpl Gest_Ag = new IAgenceImpl();
            IClientImpl Gest_Cli = new IClientImpl();
            // choisir un entier
            int choix;
            //verification
            do
            {
                Console.WriteLine("----------Menu---------");
                Console.WriteLine("1. Ajouter une compte");
                Console.WriteLine("2. Afficher tous les compte");
                Console.WriteLine("3. afficher tous les Comptes Simple");
                Console.WriteLine("4. afficher tous les Comptes Epargne");
                Console.WriteLine("5. modifier un compte");
                Console.WriteLine("6. supprimer un compte");
                Console.WriteLine("7. ajouter un agence");
                Console.WriteLine("8. afficher un agence");
                Console.WriteLine("9. modifier un agence");
                Console.WriteLine("10. supprimer un agence");
                Console.WriteLine("11. ajouter un client");
                Console.WriteLine("12. afficher les client");
                Console.WriteLine("13. modifier un client");
                Console.WriteLine("14. supprimer un client");
                Console.WriteLine("15.   Quitter    ");
                Console.WriteLine("---entrer votre choix---");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Ajouter une compte");
                        Console.WriteLine("1. compte simple");
                        Console.WriteLine("2. compte epargne");
                        int type = int.Parse(Console.ReadLine());
                        if (type == 1)
                        {
                            CompteSimple cs = new CompteSimple();
                            Console.WriteLine("ajouter une num compte");
                            cs.Numcompte = int.Parse(Console.ReadLine());
                            Console.WriteLine("ajouter une solde");
                            cs.Solde = int.Parse(Console.ReadLine());
                            Console.WriteLine("ajouter une taux de couvertir");
                            cs.Tauxcouvert = int.Parse(Console.ReadLine());

                            Gest_Comp.AjouterCompte(cs);
                        }
                        else if (type == 2)
                        {
                            CompteEpargne ce = new CompteEpargne();
                            Console.WriteLine("ajouter une num compte");
                            ce.Numcompte = int.Parse(Console.ReadLine());
                            Console.WriteLine("ajouter une solde");
                            ce.Solde = int.Parse(Console.ReadLine());
                            Console.WriteLine("ajouter la duree");
                            ce.Duree = int.Parse(Console.ReadLine());

                            Gest_Comp.AjouterCompte(ce);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Afficher tous les compte");
                        Gest_Comp.AfficherCompte();
                        break;
                    case 3:
                        Console.WriteLine("Afficher tous les compte simple");
                        Gest_Comp.AfficherCompteSimple();
                        break;
                    case 4:
                        Console.WriteLine("Afficher tous les compte epargne");
                        Gest_Comp.AfficherEpargne();
                        break;
                    case 5:
                        Console.WriteLine("5. modifier un compte");
                        Console.WriteLine("saisir le numero du compte a modifier");
                        int numCompte = int.Parse(Console.ReadLine());
                        Gest_Comp.ModifierCompte(numCompte);
                        break;
                    case 6:
                        Console.WriteLine("6. supprimer un compte");
                        Console.WriteLine("saisir le numero du compte a supprimer");
                        int numCompt = int.Parse(Console.ReadLine());
                        Gest_Comp.SupprimerCompte(numCompt);
                        break;
                    case 7:
                        Console.WriteLine("7. ajouter un agence");
                        Gest_Ag.AjouterAgence();
                        break;
                    case 8:
                        Console.WriteLine("les agences sont :");
                        Gest_Ag.AfficherAgences();
                        break;
                    case 9:
                        Console.WriteLine("modifier un agence");
                        Console.WriteLine("saisit le numero de l agence a modifier");
                        int numAg = int.Parse(Console.ReadLine());
                        Gest_Ag.ModifierAgence(numAg);
                        break;
                    case 10:
                        Console.WriteLine("supprimer un agence");
                        Console.WriteLine("saisit l id de l agence a supprimer");
                        int delid = int.Parse(Console.ReadLine());
                        Gest_Ag.SupprimerAgence(delid);
                        break;
                    case 11:
                        Gest_Cli.AjouterClient();
                        break;
                    case 12:
                        Console.WriteLine("les clients sont :");
                        Gest_Cli.AfficherClients();
                        break;
                    case 13:
                        Console.WriteLine(" modifier un client");
                        Console.WriteLine("l id du client a modifier");
                        int cliid = int.Parse(Console.ReadLine());
                        Gest_Cli.ModifierClient(cliid);
                        break;
                    case 14:
                        Console.WriteLine("12. supprimer un client");
                        Console.WriteLine("l id du client a supprimer");
                        int delcli = int.Parse(Console.ReadLine());
                        Gest_Cli.SupprimerClient(delcli);
                        break;
                    case 15:
                        Console.WriteLine(" Quitter ");
                        break;

                }
            } while (choix != 15);

        }
    }
}
