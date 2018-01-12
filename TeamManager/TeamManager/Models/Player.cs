using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class Player
    {
        [Key]
        public int playerId { get; set; }
        [Display(Name = "Amount Owed")]
        public double amountOwed { get; set; }
        [Display(Name = "Division")]
        public bool divisionD2 { get; set; }
        [Display(Name = "Division")]
        public bool pro { get; set; }

    }
}