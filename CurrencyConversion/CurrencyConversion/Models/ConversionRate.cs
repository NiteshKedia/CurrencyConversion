using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CurrencyConverter.Models
{
    public class ConversionRate
    {
        [Key]
        public Int32 ID { get; set; }
        public String currency { get; set; }
        public DateTime date { get; set; }
        public Double value { get; set; }
    }
}