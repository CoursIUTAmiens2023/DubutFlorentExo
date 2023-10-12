
namespace LibraryData.Code.Medias
{
    public class Media
    {
        public string m_Titre { get; set; }
        public int m_Reference { get; set; }
        public int m_Nombre_Exemplaire { get; set; }

        public Media(string p_Titre, int p_Reference, int p_Nombre_Exemplaire)
        {
            m_Titre = p_Titre;
            m_Reference = p_Reference;
            m_Nombre_Exemplaire = p_Nombre_Exemplaire;
        }

        public virtual void AfficherInfos()
        {
            Console.Write($"Media : Titre : {m_Titre}, Référence : {m_Reference}, Nombre d'exemplaires : {m_Nombre_Exemplaire} ");
        }

        public static Media operator + (Media p_Media, int p_Number)
        {
            p_Media.m_Nombre_Exemplaire += p_Number;
            return p_Media;
        }

        public static Media operator - (Media p_Media, int p_Number)
        {
            if (p_Media.m_Nombre_Exemplaire <= 0)
                throw new Exception($"Class Media : Le nombre de médias est déjà égale à 0");
            p_Media.m_Nombre_Exemplaire += p_Number;
            return p_Media;
        }

    }
}
