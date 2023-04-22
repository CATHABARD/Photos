using System;
using System.ComponentModel.DataAnnotations;

namespace Photos.Modeles
{
    internal class Param
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Nom { get; set; } = String.Empty;
        [MaxLength(300)]
        public string Valeur { get; set; } = String.Empty;
    }
}
