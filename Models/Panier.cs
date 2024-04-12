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

    [ForeignKey("IdentityUser")] // Spécifie la relation avec la table Utilisateur
    public IdentityUser User { get; set; } // Navigation property

        [NotMapped]
    public string TypeOffre { get; set; }
    public int NombrePersonnes { get; set; }
    public decimal Prix { get; set; }

    public virtual Offre Offre { get; set; }
    }
}