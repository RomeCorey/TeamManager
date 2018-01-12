using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class TeamPractice
    {
        [Key]
        public int teamPracticeId { get; set; }
        public string practiceLocation { get; set; }
        public double practicePrice { get; set; }
        public bool indoor { get; set; }
        public bool outdoor { get; set; }
        public string practiceTime { get; set; }
        // weather API
        // google maps API
    }
}