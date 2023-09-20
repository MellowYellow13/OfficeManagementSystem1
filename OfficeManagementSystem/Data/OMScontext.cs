using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OfficeManagementSystem.Models;



namespace OfficeManagementSystem.Data
{
    public class OMScontext : DbContext
    {

        public DbSet<Attendees> Attendees { get; set; }
        public DbSet<BudgetItems> BudgetItems { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<EventCategories> EventCategories { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Venues> Venues { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost; Database=OfficeManagmentSystemDB; Trusted_Connection=true;"
                );

            /*optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb; Database=OfficeManagmentSystemDB; Trusted_Connection=true;"
                );
            /*optionsBuilder.UseSqlite(
                "Data Source=mydb.db; Version=3;"
                );*/

            //base.OnConfiguring(optionsBuilder);
        }
    }
}
