using FiouseAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiouseAPI.Data
{
    public class FiouseContext : DbContext
    {
        public FiouseContext(DbContextOptions<FiouseContext> options)
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Budget>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Expense>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<LengthType>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<LengthType> LengthTypes { get; set; }
    }
}
