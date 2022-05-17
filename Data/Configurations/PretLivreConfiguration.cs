using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Data.Configurations
{
    public class PretLivreConfiguration : IEntityTypeConfiguration <PretLivre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PretLivre> builder)
        {
            builder.HasKey(pl => new { pl.LivreFK, pl.AbonneFK });
            builder.HasOne(pl => pl.Livre).WithMany(p => p.PretLivres).HasForeignKey(pl => pl.LivreFK);
            builder.HasOne(l => l.Abonne).WithMany(l => l.PretLivres).HasForeignKey(pl => pl.AbonneFK);
        }
    }
}
