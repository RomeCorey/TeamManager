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
        public string rivalTeam { get; set; }
        public string scoutingField { get; set; }
        public string scoutingTime { get; set; }
        //picture of the field
        public string scoutingNotes { get; set; }

    }
}