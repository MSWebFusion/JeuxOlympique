using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeuxOlympique.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public Offre Offre { get; set; }
        public DateTime DateReservation { get; set; }
        public string StatutReservation { get; set; }



    }
}