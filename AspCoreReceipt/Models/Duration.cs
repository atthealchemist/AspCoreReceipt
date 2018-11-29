using App.Backend.Enumerable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Backend.Models
{
    public class Duration : Entity
    {
        public decimal Value { get; set; }
        public DurationUnit DurationUnit { get; set; }

        //public virtual Receipt Receipt { get; set; }
        public virtual List<Step> Steps { get; set; }
    }
}