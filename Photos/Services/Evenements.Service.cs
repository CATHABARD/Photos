using Microsoft.EntityFrameworkCore;
using Photos.Modeles;

namespace Photos.Services
{
    public class EvenementsService
    {
        private List<Evenement> liste;
        public List<Evenement> Liste { get => liste; set => liste = value; }
        readonly PhotosDbContext _context;

        private readonly JoursService joursService;

        public EvenementsService(PhotosDbContext context)
        {
            _context = context;
            joursService = new (_context);
            liste = new ();
        }

        /// <summary>
        /// Retourne la liste de tous les évènements
        /// </summary>
        /// <returns></returns>
        public List<Evenement> GetEvenements()
        {
            liste = _context.Evenements
                .OrderBy(e => e.Date)
                .ToList ();

            return liste;
        }

        /// <summary>
        /// Retourne la liste des évènements avec les jours et les photos.
        /// </summary>
        /// <returns>liste des évènements détaillée</returns>
        public List<Evenement> GetEvenementsDetailles()
        {
            liste = _context.Evenements
                .OrderBy(e => e.Date)
                .ToList();

            if(liste.Count > 0)
            {
                foreach(Evenement e in liste)
                {
                    e.Jours = _context.Jours
                        .Where(j => j.EvenementId == e.Id)
                        .OrderBy(j => j.Date)
                        .ToList();
                }
            }
            return this.liste;
        }

        /// <summary>
        /// Retourne l'évènement ayant pour Id <id> ou null
        /// </summary>
        /// <param name="id">Id de l'évènement à trouver</param>
        /// <returns>L'évènement trouvé ou null s'il n'existe pas dans la collection</returns>
        public Evenement? GetEvenement(string id)
        {
            return _context.Evenements
                .Find(id);
        }

        /// <summary>
        /// Ajoute une ligne à la base avec les données de e
        /// </summary>
        /// <param name="e">Evènement à ajouter à la base</param>
        public void AddEvenement(Evenement e)
        {
            _context.Evenements.Add(e);
        }

        /// <summary>
        /// Met à jour la ligne row dans la base de données avec les infos de e
        /// </summary>
        /// <param name="e">Evènement mis à jour</param>
        /// <param name="row">Ligne à mettre à jour.</param>
        public void UpdateEvenement(Evenement e)
        {
            _context.Evenements.Update(e);
        }

        /// <summary>
        /// Retourne la date de fin de l'évèenemnt
        /// </summary>
        /// <param name="e">Evènement</param>
        /// <returns>Date de fin</returns>
        public DateTime GetDateFinEvenement(Evenement e)
        {
            return e.Date.Date.AddDays(e.Duree);
        }

    }

}
