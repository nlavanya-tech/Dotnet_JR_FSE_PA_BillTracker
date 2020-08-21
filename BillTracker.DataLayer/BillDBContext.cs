using BillTracker.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillTracker.DataLayer
{
   public class BillDBContext : DbContext
    {
        public BillDBContext(DbContextOptions<BillDBContext> dbContextOptions)
            : base(dbContextOptions)
        {
           
        }
        /// <summary>
        //    /// Creating DbSet for Table
        //    /// </summary>
        public DbSet<BillDetails> billDetails { get; set; }
        public DbSet<User>   users { get; set; }
        public DbSet<UserLogin>  userLogins { get; set; }

        /// <summary>
        //    /// While Model or Table creating Applaying Primary key to Table
        //    /// </summary>
        //    /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetails>()
                .HasKey(x => x.BillId);
            modelBuilder.Entity<User>()
                .HasKey(x => x.UserId);
            modelBuilder.Entity<UserLogin>()
                 .HasKey(x => x.UserName);
        }

        public Task FindByNameAsync(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }
    }
}

