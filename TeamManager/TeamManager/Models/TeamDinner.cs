using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class TeamDinner
    {
        [Key]
        public int teamDinnerId { get; set; }
        [Display(Name = "Team Dinner Time")]
        public string teamDinnerTime { get; set; }
        [Display(Name = "Team Dinner Location")]
        public string teamDinnerLocation { get; set; }
        //YELP API
        //google API

    }
}