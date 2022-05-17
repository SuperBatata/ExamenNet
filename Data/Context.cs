using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Configurations;
using Domain;


namespace Data
{
    public class Context: DbContext
    {

        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<PretLivre> PretLivres { get; set; }

        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source= (localdb)\MSSQLLOCALDB; INITIAL CATALOG= Bibliothequekhaledbattiche; INTEGRATED SECURITY= TRUE").UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PretLivreConfiguration());
            modelBuilder.ApplyConfiguration(new CategorieConfiguration());

        }
    }
}
