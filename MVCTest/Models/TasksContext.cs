using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
    }
}