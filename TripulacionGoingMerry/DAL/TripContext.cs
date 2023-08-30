using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TripulacionGoingMerry.Models;
using System.Linq;
using System.Web;

namespace TripulacionGoingMerry.DAL
{
    public class TripContext: DbContext
    {

        public TripContext() : base("TripContext")
        {
        }
        public DbSet<Tripulants> Tripulants { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        }
}