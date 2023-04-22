using System;
using System.ComponentModel.DataAnnotations;

namespace Photos.Modeles
{
    public class Jour
    {
        [MaxLength(50)]
        public string Id { get; set; } = String.Empty;
        [MaxLength(50)]
        public string IdEvenement { get; set; } = String.Empty;
        [MaxLength(250)]
        public string Commentaire { get; set; } = String.Empty;
        public DateTime Date { get; set; }
    }
}
