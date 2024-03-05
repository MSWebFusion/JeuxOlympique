using System.ComponentModel.DataAnnotations;

namespace JeuxOlympique.Models
{
    public class Utilisateur
    {
        [Key]
        public int UtilisateurID { get; set; }
        public int AspnetusersID { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string AdresseEmail { get; set; }
    }
}