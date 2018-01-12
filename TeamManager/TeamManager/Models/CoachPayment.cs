using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamManager.Models
{
    public class CoachPayment
    {
        [Key]
        public int coachPaymentId { get; set; }
        [Display(Name = "Amount Pro Owes")]
        public double amountProOwes { get; set; }
        [Display(Name = "Amount D2 Owes")]
        public double amountD2Owes { get; set; }
    }
}