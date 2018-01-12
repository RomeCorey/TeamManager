using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class TeamMeeting
    {
        [Key]
        public int teamMeetingId { get; set; }
        [Display(Name = "Team Meeting Location")]
        public string teamMeetingLocation { get; set; }
        [Display(Name = "Team Meeting Time")]
        public string teamMeetingTime { get; set; }
        [Display(Name = "Team Meeting Date")]
        public string teamMeetingDate { get; set; }

    }
}