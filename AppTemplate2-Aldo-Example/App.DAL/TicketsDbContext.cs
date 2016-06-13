using App.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{
   public class TicketsDbContext:DbContext
    {

       //Reglas en las bases de datos. 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tblUsers");

            base.OnModelCreating(modelBuilder); 
        }

        public TicketsDbContext():base("TicketsDbConnName")
        {

        }

       //Crea la tabla users
        public DbSet<User> Users { get; set; }
       //crea la tabla Addresses
        public DbSet<Address> Addresses { get; set; }
    }
}
