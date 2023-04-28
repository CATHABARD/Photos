using Photos.Modeles;

namespace Photos.Services
{
    class ParamsService
    {
        readonly PhotosDbContext _context;

        public ParamsService(PhotosDbContext context)
        {
            _context = context;
        }

		public List<Param> GetParams()
        {
            return _context.Params
                .ToList();
        }

        public Param? GetParam(string paramName)
        {
            Param? Param = _context.Params
                .FirstOrDefault(p => p.Nom == paramName);
            
            return Param;
        }

        public Param? GetParam(int Id)
        {
            return _context.Params
                .Find(Id);
        }

        public void AddParam(Param param)
        {
            _context.Add(param);
        }

        /// <summary>
        /// Permet de changer la valeur d'un paramêtre
        /// </summary>
        /// <param name="param">Objet Param</param>
        public void UpdateParam(Param param)
        {
            _context.Update(param);
        }
    }
}
