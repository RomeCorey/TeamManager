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
        public string tournamentLocation { get; set; }
        public string tournamentTime { get; set; }
        public double tournamentPrice { get; set; }
        public string tournamentHotel { get; set; }
        //weather API
        //google maps API
    }
}