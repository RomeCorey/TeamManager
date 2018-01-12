using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class CoachNotes
    {
        [Key]
        public string coachNotes { get; set; }
    }
}