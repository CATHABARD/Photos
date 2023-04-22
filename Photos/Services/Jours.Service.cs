using Photos.Modeles;
using Photos.PhotosDBDataSetTableAdapters;
using System.Collections;

namespace Photos.Services
{
    class Jours
    {
        private readonly JoursTableAdapter joursTableAdapter1;
        private readonly PhotosDBDataSet photosOrganiserDBDataSet1;
        private ArrayList jours;
        private ArrayList tousLesJours;

        public Jours() 
        {
            jours = new ArrayList();
            tousLesJours = new ArrayList();
            joursTableAdapter1 = new JoursTableAdapter();
            photosOrganiserDBDataSet1 = new PhotosDBDataSet();
        }

        public void GetJoursEvenement(Evenement e)
        {
            this.jours.Clear();
            joursTableAdapter1.FillByEvenement(photosOrganiserDBDataSet1.Jours, e.Id);
            e.Jours = new ArrayList();
            foreach (PhotosDBDataSet.JoursRow row in photosOrganiserDBDataSet1.Jours.Rows)
            {
                Jour j = new Jour();
                j.Date = row.Date;
                j.Id = row.Id;
                j.IdEvenement = row.IdEvenement;
                j.Commentaire = row.Commentaire;
                e.Jours.Add(j);
            }
            return;
        }

        public ArrayList GetJoursEvenement(string idEvenement)
        {
            ArrayList jours = new ArrayList();

            joursTableAdapter1.FillByEvenement(photosOrganiserDBDataSet1.Jours, idEvenement);
            foreach (PhotosDBDataSet.JoursRow row in photosOrganiserDBDataSet1.Jours.Rows)
            {
                Jour j = new Jour();
                j.Date = row.Date;
                j.Id = row.Id;
                j.IdEvenement = row.IdEvenement;
                j.Commentaire = row.Commentaire;
                jours.Add(j);
            }
            return jours;
        }

        public Jour GetJour(string id)
        {
            Jour j = new Jour();

            joursTableAdapter1.FillById(photosOrganiserDBDataSet1.Jours, id);
            foreach (PhotosDBDataSet.JoursRow row in photosOrganiserDBDataSet1.Jours.Rows)
            {
                j.Date = row.Date;
                j.Id = row.Id;
                j.IdEvenement = row.IdEvenement;
                j.Commentaire = row.Commentaire;
            }
            return j;
        }


    }
}
