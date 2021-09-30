using contractor_app_DP.Classes;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contractor_app_DP
{
    public class ContractortDbContext : DbContext
    {
        //private readonly ContrahentDbContext GetContext;
        public DbSet<RegisterModel> Contractors { get; set; }
        //public ContractortDbContext(DbContextOptions<ContractortDbContext> options) :base(options)
        //{
          
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<RegisterModel>().ToTable("Contractors");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ContrahentDB;Integrated Security=True");


        }


    }
}
