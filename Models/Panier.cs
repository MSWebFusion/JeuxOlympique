using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JeuxOlympique.Models
{
    public class panier
    {
        [Key]
        public int PanierID { get; set; }

        public string UserId { get; set; } // Navigation property

        public virtual Offre Offre { get; set; }

        public int Quantite { get; set;}

        public bool paye {  get; set; }
    }
}