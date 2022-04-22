using _22042022Praktika.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _22042022Praktika.Data.DAL
{
    class StadionDbContext: DbContext
    {
        public DbSet<Stadion> Stadions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q08R4SV;Database=BP202StadionPraktika;Trusted_Connection=true");
        }
    }
}
