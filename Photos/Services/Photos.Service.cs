using Photos.Modeles;
using Photos.PhotosDBDataSetTableAdapters;
using System.Collections;

namespace Photos.Services
{
    class PhotosService
    {
        private readonly PhotosTableAdapter photosTableAdapter1;
        private readonly PhotosDBDataSet photosDBDataSet1;
        private readonly Jour jourCourant;

        public PhotosService(Jour j)
        {
            jourCourant = j;
            photosTableAdapter1 = new PhotosTableAdapter();
            photosDBDataSet1 = new PhotosDBDataSet();
        }

        public PhotosService()
        {
            jourCourant = null;
            photosTableAdapter1 = new PhotosTableAdapter();
            photosDBDataSet1 = new PhotosDBDataSet();
        }

        /// <summary>
        /// Add des photos au jour courant
        /// </summary>
        /// <param name="photos">Liste des photos à ajouter</param>
        public void AddPhotos(ArrayList photos)
        {
            foreach(Photo p in photos)
            {
                PhotosDBDataSet.PhotosRow row = this.photosDBDataSet1.Photos.NewPhotosRow();
                row.IdJour = p.IdJour;
                row.Commentaire = p.Commentaire;
                row.Adresse = p.Adresse;
                row.Heure = p.Heure;
                row.Id = Guid.NewGuid().ToString();
                photosDBDataSet1.Photos.AddPhotosRow(row);
            }
            this.photosTableAdapter1.Update(photosDBDataSet1.Photos);
        }

        /// <summary>
        /// Add une photo au jour courant
        /// </summary>(
        /// <param name="p">Photo à ajouter</param>
        public void AddPhoto(Photo p)
        {
            PhotosDBDataSet.PhotosRow row = this.photosDBDataSet1.Photos.NewPhotosRow();
            row.IdJour = jourCourant.Id;
            row.Commentaire = jourCourant.Commentaire;
            row.Adresse = p.Adresse;
            row.Heure = p.Heure;
            this.photosDBDataSet1.Photos.AddPhotosRow(row);
            this.photosTableAdapter1.Update(photosDBDataSet1.Photos);
        }

        /// <summary>
        /// Retourne la liste des photos du jour
        /// </summary>
        /// <param name="j">Jour</param>
        /// <returns>La liste des photos dans un ArrayList</returns>
        public ArrayList GetPhotosJour(Jour j)
        {
            ArrayList liste = new ArrayList();
            photosTableAdapter1.FillByJour(photosDBDataSet1.Photos, j.Id);
            foreach(PhotosDBDataSet.PhotosRow row in photosDBDataSet1.Photos.Rows)
            {
                Photo p = new Photo
                {
                    Id = row.Id,
                    Commentaire = row.Commentaire.Trim(),
                    Adresse = row.Adresse.Trim(),
                    IdJour = row.IdJour,
                    Heure = row.Heure
                };
                liste.Add(p);
            }
            return liste;
        }

        public void UpdatePhoto(Photo p)
        {
            try
            {
                photosTableAdapter1.FillById(photosDBDataSet1.Photos, p.Id);
                PhotosDBDataSet.PhotosRow row = photosDBDataSet1.Photos.FindById(p.Id);
                row.Adresse = p.Adresse;
                row.Heure = p.Heure;
                row.IdJour = p.IdJour;
                row.Commentaire = p.Commentaire.Trim();
                photosTableAdapter1.Update(row);
           } catch { }
        }

        public void DeteletePhoto(Photo p)
        {
            PhotosDBDataSet.PhotosDataTable table = new PhotosDBDataSet.PhotosDataTable();
            try
            {
                photosTableAdapter1.FillById(table, p.Id);
                PhotosDBDataSet.PhotosRow row = (PhotosDBDataSet.PhotosRow)table.Rows[0];
                row.Delete();
                photosTableAdapter1.Update(row);
            } catch { MessageBox.Show("Erreur lors de la suppression de la photo."); }
        }
    }
}
