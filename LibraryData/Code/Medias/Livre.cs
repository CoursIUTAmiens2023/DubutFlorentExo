
namespace LibraryData.Code.Medias
{
    public class Livre : Media
    {
        private string Auteur { get; set; }
        public Livre(string p_Titre, int p_Reference, int p_Nombre_Exemplaire, string p_Auteur) : base(p_Titre, p_Reference, p_Nombre_Exemplaire)
        {
            Auteur = p_Auteur;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.Out.WriteLine($"Auteur : {Auteur}");
        }
    }
}
