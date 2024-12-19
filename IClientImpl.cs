using System;
using System.Collections.Generic;
using System.Linq;
using tp2.entites;

namespace tp2.many
{
    internal class IClientImpl
    {
        private static List<Client> clients = new List<Client>();


        public void AjouterClient()
        {
            Client cl = new Client();
            Console.WriteLine("le nom");
            cl.Nom = Console.ReadLine();
            Console.WriteLine("le prenom");
            cl.Prenom = Console.ReadLine();
            Console.WriteLine(" le tel");
            cl.Tel = int.Parse(Console.ReadLine());
            Console.WriteLine("ID de l agence");
            cl.Idagence = int.Parse(Console.ReadLine());
            clients.Add(cl);
            Console.WriteLine($"Client ajouté: {cl}");
        }

        public void AfficherClients()
        {
            foreach (var client in clients)
            {
                Console.WriteLine(client.ToString());
            }
        }
        public void ModifierClient(int cliid)
        {
            // Find the client by its Id
            Client new_cli = clients.FirstOrDefault(c => c.Id == cliid);

            if (new_cli != null)
            {
                Console.WriteLine("le nom ");
                new_cli.Nom = Console.ReadLine();
                Console.WriteLine("le prenom");
                new_cli.Prenom = Console.ReadLine();
                Console.WriteLine("le tel");
                new_cli.Tel = int.Parse(Console.ReadLine());
                Console.WriteLine($"Client modifié: {new_cli}");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {new_cli}. La modification a échoué.");
            }
        }
        public void SupprimerClient(int delcli)
        {
            // Find the client by its Id
            Client Cli = clients.FirstOrDefault(c => c.Id == delcli);

            if (Cli != null)
            {
                // Remove the client from the list
                clients.Remove(Cli);
                Console.WriteLine($"Client supprimé: {Cli}");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {delcli}. La suppression a échoué.");
            }
        }
    }
}
