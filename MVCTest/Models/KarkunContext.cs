using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class KarkunContext : DbContext
    {
        public DbSet<Karkun> karkuns { get; set; }

    }
}