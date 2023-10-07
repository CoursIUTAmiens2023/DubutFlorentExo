
namespace LibraryData.Code.Medias
{
    public class Media
    {
        public string Titre { get; set; }
        public int Reference { get; set; }
        public int Nombre_Exemplaire { get; set; }

        public Media(string p_Titre, int p_Reference, int p_Nombre_Exemplaire)
        {
            Titre = p_Titre;
            Reference = p_Reference;
            Nombre_Exemplaire = p_Nombre_Exemplaire;
        }

        public virtual void AfficherInfos()
        {
            Console.Write($"Media : Titre : {Titre}, Référence : {Reference}, Nombre d'exemplaires : {Nombre_Exemplaire} ");
        }

        public static Media operator + (Media p_Media, int p_Number)
        {
            p_Media.Nombre_Exemplaire += p_Number;
            return p_Media;
        }

        public static Media operator - (Media p_Media, int p_Number)
        {
            if (p_Media.Nombre_Exemplaire <= 0)
                throw new Exception($"Class Media : Le nombre de médias est déjà égale à 0");
            p_Media.Nombre_Exemplaire += p_Number;
            return p_Media;
        }

    }
}
