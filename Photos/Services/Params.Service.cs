using Photos.Modeles;
using Photos.PhotosDBDataSetTableAdapters;
using System.Collections.Generic;

namespace Photos.Services
{
    class ParamsService
    {
		private readonly ParamsTableAdapter ParamsTableAdapter;
		private readonly PhotosDBDataSet PhotosDBDataSet;

		public ParamsService()
        {
			PhotosDBDataSet = new PhotosDBDataSet();
            ParamsTableAdapter = new ParamsTableAdapter();
        }

		public List<Param> GetParams()
        {
            List<Param> parametres = new List<Param>();
            ParamsTableAdapter.Fill(PhotosDBDataSet.Params);
            foreach (PhotosDBDataSet.ParamsRow row in PhotosDBDataSet.Params.Rows)
            {
                Param p = new Param();
                p.Id = row.Id;
                p.Nom = row.Nom;
                p.Valeur = row.Valeur;
                parametres.Add(p);
            }

			return parametres;
        }

        public Param GetParam(string paramName)
        {
            ParamsTableAdapter.FillByNom(PhotosDBDataSet.Params, paramName);

            foreach (PhotosDBDataSet.ParamsRow row in PhotosDBDataSet.Params.Rows)
            {
                if (row.Nom == paramName)
                {
                    Param p = new Param();
                    p.Id = row.Id;
                    p.Nom = row.Nom;
                    p.Valeur = row.Valeur;
                    return p;
                }
            }
            return null; // rien trouvé
        }

        public Param GetParam(int Id)
        {
            ParamsTableAdapter.Fill(PhotosDBDataSet.Params);
            foreach (PhotosDBDataSet.ParamsRow row in PhotosDBDataSet.Params.Rows)
            {
                if (row.Id == Id)
                {
                    Param p = new Param();
                    p.Id = row.Id;
                    p.Nom = row.Nom;
                    p.Valeur = row.Valeur;
                    return p;
                }
            }
            return null; // rien trouvé
        }

        public void AddParam(Param param)
        {
            PhotosDBDataSet.ParamsRow row= PhotosDBDataSet.Params.NewParamsRow();
            row.Nom = param.Nom;
            row.Valeur = param.Valeur;
            PhotosDBDataSet.Params.AddParamsRow(row);
            ParamsTableAdapter.Update(PhotosDBDataSet.Params);
        }

        /// <summary>
        /// Permet de changer la valeur d'un paramêtre
        /// </summary>
        /// <param name="param"></param>
        public void UpdateParam(Param param)
        {
            PhotosDBDataSet.ParamsRow row = PhotosDBDataSet.Params.FindById(param.Id);
            row.Valeur = param.Valeur;
            ParamsTableAdapter.Update(PhotosDBDataSet.Params);
        }
    }
}
