﻿
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace JeuxOlympique.Models
{
    public class Offre
    {
        [Key]
        public int OffreID { get; set; }
        public HttpPostedFileBase Photo { get; set; }
        public string TypeOffre { get; set; }
        public int NombrePersonnes { get; set; }
        public decimal Prix { get; set; }

    }
}