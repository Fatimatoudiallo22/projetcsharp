using tp2.programme;

namespace tp2.many
{
    internal interface IAgence
    {
        void AjouterAgence(Agence agence);
        void AfficherAgences();
        void SupprimerAgence(int delid);
        void ModifierAgence(int numAg);
    }
}
