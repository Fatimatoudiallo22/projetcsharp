using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.many
{
    internal interface IClient
    {
        void AjouterClient(int Idtest);
        void AfficherClients();
        void ModifierClient(int cliid);
        void SupprimerClient(int delcli);
    }
}
