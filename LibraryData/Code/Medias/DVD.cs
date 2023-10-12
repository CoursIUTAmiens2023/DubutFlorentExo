namespace LibraryData.Code.Medias
{
    public class DVD : Media
    {
        private int Duree { get; set; }

        public DVD(string p_Titre, int p_Reference, int p_Nombre_Exemplaire, int p_Duree) : base(p_Titre, p_Reference, p_Nombre_Exemplaire)
        {
            Duree = p_Duree;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.Out.WriteLine($"Durée : {Duree}");
        }
    }
}