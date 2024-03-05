
using System.ComponentModel.DataAnnotations;

namespace JeuxOlympique.Models
{
    public class Offre
    {
        [Key]
        public int OffreID { get; set; }
        public string Photo { get; set; }
        public string TypeOffre { get; set; }
        public int NombrePersonnes { get; set; }
        public decimal Prix { get; set; }

    }
}