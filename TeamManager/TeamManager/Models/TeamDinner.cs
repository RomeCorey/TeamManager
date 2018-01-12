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
        public string teamDinnerTime { get; set; }
        public string teamDinnerLocation { get; set; }
        //YELP API
        //google API

    }
}