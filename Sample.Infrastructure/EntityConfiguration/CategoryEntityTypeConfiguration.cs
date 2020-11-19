using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain;

namespace Sample.Infrastructure.EntityConfiguration
{
    class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> categoryConfiguration)
        {
            categoryConfiguration.ToTable("Category");
            categoryConfiguration.HasKey(c => c.Id);
                       
            categoryConfiguration.HasData(
                new Category() { Id = 1, Name = "A" },
                new Category() { Id = 2, Name = "B" },
                new Category() { Id = 3, Name = "C" });

            categoryConfiguration.Ignore(c => c.DomainEvents);

        }
    }
}
