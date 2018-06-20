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

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<LengthType> LengthTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Budget>()
                .HasOne(b => b.LengthType)
                .WithMany()
                .HasForeignKey(b => b.LengthTypeId)
                .HasConstraintName("FK_LengthType_Budget");

            modelBuilder.Entity<Budget>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Expense>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<LengthType>()
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
