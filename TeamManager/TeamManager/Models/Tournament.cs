using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class Tournament
    {
        [Key]
        public int tournamentId { get; set; }
        [Display(Name = "Tournament Dates")]
        public string tournamentDates { get; set; }
        [Display(Name = "Tournament Location")]
        public string tournamentLocation { get; set; }
        [Display(Name = "Tournament Time")]
        public string tournamentTime { get; set; }
        [Display(Name = "Tournament Price")]
        public double tournamentPrice { get; set; }
        [Display(Name = "Hotel Info")]
        public string tournamentHotel { get; set; }
        //weather API
        //google maps API
    }
}