using System;
using System.Collections;
using Photos.Modeles;
using Photos.PhotosDBDataSetTableAdapters;

namespace Photos.Services
{
    public class EvenementsService
    {
        private readonly EvenementsTableAdapter evenementsTableAdapter1;
        private readonly PhotosDBDataSet photosOrganiserDBDataSet1;
        private ArrayList liste;
        public ArrayList Liste { get => liste; set => liste = value; }

        private readonly Jours joursService;

        public EvenementsService()
        {
            photosOrganiserDBDataSet1 = new PhotosDBDataSet();
            evenementsTableAdapter1 = new EvenementsTableAdapter();
            joursService = new Jours();
            liste = new ArrayList();
        }

        /// <summary>
        /// Retourne la liste de tous les évènements
        /// </summary>
        /// <returns></returns>
        public ArrayList GetEvenements()
        {
            evenementsTableAdapter1.Fill(this.photosOrganiserDBDataSet1.Evenements);
            foreach(PhotosDBDataSet.EvenementsRow row in photosOrganiserDBDataSet1.Evenements.Rows)
            {
                Evenement e = new Evenement
                {
                    Date = row.Date,
                    Duree = row.Duree,
                    Commentaire = row.Commentaire,
                    Id = row.Id,
                    Titre = row.Titre
                };
                this.liste.Add(e);
            }
            return this.liste;
        }

        /// <summary>
        /// Retourne la liste des évènements avec les jours et les photos.
        /// </summary>
        /// <returns>liste des évènements détaillée</returns>
        public ArrayList GetEvenementsDetailles()
        {
            this.liste.Clear();
            evenementsTableAdapter1.Fill(this.photosOrganiserDBDataSet1.Evenements);
            foreach (PhotosDBDataSet.EvenementsRow row in photosOrganiserDBDataSet1.Evenements.Rows)
            {
                Evenement e = new Evenement
                {
                    Date = row.Date,
                    Duree = row.Duree,
                    Commentaire = row.Commentaire,
                    Id = row.Id,
                    Titre = row.Titre,
                };
                joursService.GetJoursEvenement(e);
                this.liste.Add(e);
            }
            return this.liste;
        }

        /// <summary>
        /// Retourne l'évènement ayant pour Id <id> ou null
        /// </summary>
        /// <param name="id">Id de l'évènement à trouver</param>
        /// <returns>L'évènement trouvé ou null s'il n'existe pas dans la collection</returns>
        public Evenement GetEvenement(string id)
        {
            foreach(Evenement E in liste)
            {
                if (E.Id == id)
                {
                    return E;
                }
            }
            return null;
        }

        /// <summary>
        /// Ajoute une ligne à la base avec les données de e
        /// </summary>
        /// <param name="e">Evènement à ajouter à la base</param>
        public void AddEvenement(Evenement e)
        {
            PhotosDBDataSet.EvenementsRow row = this.photosOrganiserDBDataSet1.Evenements.NewEvenementsRow();
            row.Date = e.Date;
            row.Duree = e.Duree;
            row.Commentaire = e.Commentaire;
            row.Titre = e.Titre;
            row.Id = Guid.NewGuid().ToString();
            photosOrganiserDBDataSet1.Evenements.AddEvenementsRow(row);
            evenementsTableAdapter1.Update(photosOrganiserDBDataSet1.Evenements);
        }

        /// <summary>
        /// Met à jour la ligne row dans la base de données avec les infos de e
        /// </summary>
        /// <param name="e">Evènement mis à jour</param>
        /// <param name="row">Ligne à mettre à jour.</param>
        public void UpdateEvenement(Evenement e)
        {
            evenementsTableAdapter1.FillById(photosOrganiserDBDataSet1.Evenements, e.Id);
            // Si e.Id ne retourne rien
            if (photosOrganiserDBDataSet1.Evenements.Count == 0)
                return;

            PhotosDBDataSet.EvenementsRow row = (PhotosDBDataSet.EvenementsRow)photosOrganiserDBDataSet1.Evenements.Rows[0];
            row.Date = e.Date;
            row.Duree = e.Duree;
            row.Commentaire = e.Commentaire;
            row.Titre = e.Titre;
            evenementsTableAdapter1.Update(photosOrganiserDBDataSet1.Evenements);
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
