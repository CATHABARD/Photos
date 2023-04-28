using Photos.Modeles;

namespace Photos.Services
{
    class PhotosService
    {
        readonly PhotosDbContext _context;
        private readonly Jour? jourCourant;

        public PhotosService(PhotosDbContext context, Jour j)
        {
            jourCourant = j;
            _context = context;
        }

        public PhotosService(PhotosDbContext context)
        {
            jourCourant = null;
            _context = context;
        }

        /// <summary>
        /// Add des photos au jour courant
        /// </summary>
        /// <param name="photos">Liste des photos à ajouter</param>
        public void AddPhotos(List<Photo> photos)
        {
            _context.Photos.AddRange(photos);
        }

        /// <summary>
        /// Add une photo au jour courant
        /// </summary>(
        /// <param name="p">Photo à ajouter</param>
        public void AddPhoto(Photo p)
        {
            _context.Photos.Add(p);
        }

        /// <summary>
        /// Retourne la liste des photos du jour
        /// </summary>
        /// <param name="j">Jour</param>
        /// <returns>La liste des photos dans une Liste</returns>
        public List<Photo> GetPhotosJour(Jour j)
        {
            return _context.Photos
                .Where(p => p.IdJour == j.Id)
                .ToList();
        }

        public void UpdatePhoto(Photo p)
        {
            _context.Update(p);
        }

        public void DeteletePhoto(Photo p)
        {
            _context.Photos.Remove(p);
        }
    }
}
