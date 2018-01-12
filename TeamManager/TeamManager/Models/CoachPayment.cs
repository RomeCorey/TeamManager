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
        public double amountProOwes { get; set; }
        public double amountD2Owes { get; set; }
    }
}