﻿using System;
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
        [Display(Name = "Date")]
        public string practiceDate { get; set; }
        [Display(Name = "Practice Time")]
        public string practiceTime { get; set; }
        [Display(Name = "Practice Location")]
        public string practiceLocation { get; set; }
        [Display(Name = "Practice Price")]
        public double practicePrice { get; set; }
        [Display(Name = "Indoor")]
        public string practiceIndoor { get; set; }
        [Display(Name = "Outdoor")]
        public string practiceOutdoor { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }


        // weather API
        // google maps API
    }
}