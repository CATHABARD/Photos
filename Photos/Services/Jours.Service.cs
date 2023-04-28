using Microsoft.EntityFrameworkCore;
using Photos.Modeles;

namespace Photos.Services
{
    class JoursService
    {
        readonly PhotosDbContext _context;
        private List<Photo> jours;
        private List<Photo> tousLesJours;

        public JoursService(PhotosDbContext context) 
        {
            jours = new ();
            tousLesJours = new ();
            _context = context;
        }

        public void GetJoursEvenement(Evenement e)
        {
            e.Jours = _context.Jours
                .Where(j => j.EvenementId == e.Id)
                .OrderBy(j => j.Date)
                .ToList();
        }

        public List<Jour> GetJoursEvenement(string idEvenement)
        {
            return _context.Jours
                .Where(j => j.EvenementId == idEvenement)
                .ToList();
        }

        public Jour? GetJour(string id)
        {
            return _context.Jours
                .Find(id);
        }

        public string AddJour(Jour jour)
        {
            jour.Id = Guid.NewGuid().ToString();
            _context.Jours.Add(jour);
            return jour.Id;
        }

        public void UpdateJour(Jour jour)
        {
            _context.Jours.Update(jour);
        }
    }
}
