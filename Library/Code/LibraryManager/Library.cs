using LibraryData.Code;
using LibraryData.Code.Medias;

namespace Library.Code.LibraryManager
{
    public class Library
    {
        private List<Media> m_Bibliotheque;

        private List<Emprunt> m_Emprunts;

        public Library(List<Media> p_Bibliotheque, List<Emprunt> p_Emprunts)
        {
            m_Bibliotheque = p_Bibliotheque;
            m_Emprunts = p_Emprunts;
        }

        public Library()
        {
            m_Bibliotheque = new List<Media>();
            m_Emprunts = new List<Emprunt>();
        }

        public void AjouterMedia(Media p_NewItem)
        {
            m_Bibliotheque.Add(p_NewItem);
        }

        public void RetirerMedia(Media p_NewItem)
        {
            m_Bibliotheque.Remove(p_NewItem);
        }

        public void EmprunterMedia(Media p_Media, string p_Utilisateur)
        {
            //Est-ce que le média existe dans la bibliothèque
            Media v_Media = m_Bibliotheque.Find(p_Trg => p_Trg.Reference == p_Media.Reference);
            
            if (m_Bibliotheque.Contains(p_Media) && v_Media.Nombre_Exemplaire > 0)
            {
                m_Emprunts.Add(new(){m_Utilisateur = p_Utilisateur, m_DateTime = DateTime.Now, m_Media = p_Media});

                v_Media.Nombre_Exemplaire -= 1;
            }
        }

        public void RetournerMedia(Media p_Media, string p_Utilisateur)
        {
            Emprunt v_Emprunt = m_Emprunts.FindAll(p_Trg => p_Trg.m_Media == p_Media).Find(p_Trg => p_Trg.m_Utilisateur == p_Utilisateur);

            if (v_Emprunt != null)
            {
                p_Media += 1;

                m_Emprunts.Remove(v_Emprunt);
            }
            else
            {
                Console.WriteLine("Cet emprunt n'existe pas");
            }
        }
        public IEnumerable<Media> RechercherMedia(string p_Recherche)
        {
            return this.m_Bibliotheque.FindAll(p_Trg => p_Trg.Titre == p_Recherche).AsEnumerable();
        }
        public void ListerMediasEmpruntesParUtilisateur(string p_Utilisateur)
        {
            IEnumerable<Emprunt> v_EmpruntsList = m_Emprunts.FindAll(p_P => p_P.m_Utilisateur == p_Utilisateur).AsEnumerable();
            if (v_EmpruntsList.Any())
            {
                Console.WriteLine($"Utilisateur : {p_Utilisateur}");
                foreach(Emprunt p_Emprunt in v_EmpruntsList)
                {
                    Console.WriteLine($"Media : {p_Emprunt.m_Media.Reference}, Emprunté le : {p_Emprunt.m_DateTime}");
                }
            }
            else
            {
                Console.WriteLine($"Aucun emprunt n'as été trouvé pour l'utilisateur : {p_Utilisateur}");
            }
            
        }
        public void AfficherStatistique()
        {
            Console.WriteLine($"Nombre total de médias : {m_Bibliotheque.Count}\n");
            Console.WriteLine("Nombre de médias disponible : ");
            foreach(Media p_Media in m_Bibliotheque)
            {
                Console.WriteLine($"Référence : {p_Media.Reference}, Titre : {p_Media.Titre}, Disponible : {p_Media.Nombre_Exemplaire}");
            }
            Console.WriteLine("\nListe des médias empruntés : ");
            foreach (Emprunt p_Emprunt in m_Emprunts)
            {
                Console.WriteLine($"Media : {p_Emprunt.m_Media.Reference}, Utilisateur : {p_Emprunt.m_Utilisateur}, Emprunté le : {p_Emprunt.m_DateTime}");
            }

        }
    }
}
