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
        public string teamMeetingLocation { get; set; }
        public string teamMeetingTime { get; set; }
        public string teamMeetingDate { get; set; }

    }
}