using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using r00ch.LotteryTicketRegistrator.Models.Entities;

namespace r00ch.LotteryTicketRegistrator.Repositories.Architecture
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Customer>()
        //        .HasIndex(u => u.PhoneNumber)
        //        .IsUnique();
        //}
    }
}
