
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace JeuxOlympique.Models
{
    public class Offre
    {
        [Key]
        public int OffreID { get; set; }
        public string Photo { get; set; }
        [Display(Name = "Type offre")]
        public string TypeOffre { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Nb personne")]
        public int NBPersonnes { get; set; }
        [Display(Name = "Prix")]
        public decimal Prix { get; set; }

    }
}