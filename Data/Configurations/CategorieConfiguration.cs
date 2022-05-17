using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;
namespace Data.Configurations
{
    public class CategorieConfiguration : IEntityTypeConfiguration<Livre>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Livre> builder)
        {

            builder.HasOne(livre => livre.Categorie)
                .WithMany(c => c.Livres)
                .HasForeignKey(livre => livre.CategorieFK);

        }
    }
}
