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
        public double amountOwed { get; set; }
        public bool divisionD2 { get; set; }
        public bool pro { get; set; }

    }
}