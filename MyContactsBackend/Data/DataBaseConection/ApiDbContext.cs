﻿using Data.DataBaseConection.ModelMapping;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DataBaseConection
{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new ContactMapping());
        }
    }
}
