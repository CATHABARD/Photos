using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Photos.Modeles
{
    public class Evenement
    {
        [MaxLength(50)]
        public string Id { get; set; } = String.Empty;
        [MaxLength(50)]
        public string Titre { get; set; } = String.Empty;
        public DateTime Date { get; set; }
        public int Duree { get; set; }
        [MaxLength(250)]
        public string Commentaire { get; set; } = String.Empty;

        public ArrayList Jours { get; set; } = new ArrayList();
    }
}
