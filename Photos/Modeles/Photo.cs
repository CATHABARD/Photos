using System.ComponentModel.DataAnnotations;

namespace Photos.Modeles
{
    public class Photo
    {
        [MaxLength(50)]
        public string Id { get; set; } = String.Empty;
        [MaxLength(500)]
        public string Commentaire { get; set; } = String.Empty;
        public string IdJour { get; set; } = String.Empty;
        [MaxLength(250)]
        public string Adresse { get; set; } = String.Empty;
        public DateTime Heure { get; set; }
    }
}
