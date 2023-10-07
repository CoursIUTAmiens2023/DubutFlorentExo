using System.Runtime.CompilerServices;
using LibraryData.Code;
using LibraryData.Code.Medias;
using Library.Code.LibraryManager;

namespace MaPremiereApplication
{
    internal class Program
    {
        private static void Main(string[] p_Args)
        {
            CD v_Media = new("Vivre pour le meilleur",195,15,"Johnny");
            DVD v_Dvd = new("Le roi lion",2,1,100);

            v_Media.AfficherInfos();
            v_Dvd.AfficherInfos();

            Library.Code.LibraryManager.Library v_Library = new(new List<Media>(), new List<Emprunt>());

            v_Library.AjouterMedia(v_Media);
            v_Library.AjouterMedia(v_Dvd);

            IEnumerable<Media> v_RechercheMedia = v_Library.RechercherMedia("Vivre pour le meilleur");

            v_Library.AfficherStatistique();

            v_Library.EmprunterMedia(v_Dvd, "Florent DUBUT");
        }
    }
}
