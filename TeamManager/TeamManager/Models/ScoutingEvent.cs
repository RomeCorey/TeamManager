using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class ScoutingEvent
    {
        [Key]
        public int scoutingEventId { get; set; }
        [Display(Name = "Team to scout")]
        public string rivalTeam { get; set; }
        [Display(Name = "Field they play on")]
        public string scoutingField { get; set; }
        [Display(Name = "Time they play")]
        public string scoutingTime { get; set; }
        //picture of the field
        [Display(Name = "Notes")]
        public string scoutingNotes { get; set; }

    }
}