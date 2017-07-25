using Projekt7Edyszyn.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projekt7Edyszyn.DAL
{
    public class TraningContext : DbContext
    {
        public DbSet<Traning> Tranings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}