using tp2.entites;
using tp2.Entites;

namespace tp2.many
{
    internal interface ICompte
    {
        void AjouterCompte(Compte compte);
        void AfficherCompte();
        void AfficherCompteSimple();
        void AfficherEpargne();

        void AjouterClient(Client client);
        void AfficherClient();
        void ModifierCompte(int numCompte);
        void SupprimerCompte(int numCompte);

    }
}
