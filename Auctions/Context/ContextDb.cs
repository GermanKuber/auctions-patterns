﻿using Auctions.Domain;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Context
{
    public class ContextDb : DbContext
    {

        public DbSet<Auction> Auctions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=TestDb;User Id=sa;Password=Password01!;");
        }
    }
}