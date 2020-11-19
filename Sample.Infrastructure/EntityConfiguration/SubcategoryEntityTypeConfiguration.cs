using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Infrastructure.EntityConfiguration
{
    class SubcategoryEntityTypeConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> subcategoryConfiguration)
        {
            subcategoryConfiguration.ToTable("Subcategory");
            subcategoryConfiguration.HasKey(s => s.Id);

            subcategoryConfiguration.HasData(
                new Subcategory() {Id  = 1, Name = "A1" },
                new Subcategory() { Id = 2, Name = "A2" },
                new Subcategory() { Id = 3, Name = "B1" },
                new Subcategory() { Id = 4, Name = "C1" }, 
                new Subcategory() { Id = 5, Name = "C2" }, 
                new Subcategory() { Id = 6, Name = "c3" });

            subcategoryConfiguration.Ignore(s => s.DomainEvents);
        }
    }
}
