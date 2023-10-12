namespace LibraryData.Code.Medias
{
    public class CD : Media
    {
        private string m_Artiste { get; set; }
        public CD(string p_Titre, int p_Reference, int p_Nombre_Exemplaire, string p_Artiste) : base(p_Titre, p_Reference, p_Nombre_Exemplaire)
        {
            m_Artiste = p_Artiste;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.Out.WriteLine($"Artiste : {m_Artiste}");
        }
    }
}
