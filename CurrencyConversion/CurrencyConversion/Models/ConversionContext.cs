using CurrencyConverter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CurrencyConversion.Models
{
    public class ConversionContext : DbContext
    {
        public DbSet<ConversionRate> ConversionRates { get; set; }
    }
}