using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class Coach
    {
        [Key]
        public int coachId { get; set; }
    }
}