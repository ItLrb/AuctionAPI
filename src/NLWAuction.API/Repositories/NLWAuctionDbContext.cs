﻿using Microsoft.EntityFrameworkCore;
using NLWAuction.API.Entities;

namespace NLWAuction.API.Repositories;

public class NLWAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\italo\Downloads\leilaoDbNLW.db");
    }
}
