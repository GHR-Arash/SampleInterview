using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Infrastructure.EntityConfiguration
{
    class TagMapEntityTypeConfiguration : IEntityTypeConfiguration<TagMap>
    {
        public void Configure(EntityTypeBuilder<TagMap> tagMapConfiguration)
        {
            tagMapConfiguration.ToTable("TagMaps");
            tagMapConfiguration.HasKey(t => t.Id);

            tagMapConfiguration.HasOne(t => t.Tag)
               .WithMany()
               .HasForeignKey("_tagId");

            tagMapConfiguration
                .Property<int>("_tagId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("TagId")
                .IsRequired();

            tagMapConfiguration.HasOne(t => t.Category)
            .WithMany()
            .HasForeignKey("_categoryId");

            tagMapConfiguration
                .Property<int>("_categoryId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CategoryId")
                .IsRequired();


            tagMapConfiguration.HasOne(t => t.SubCategory)
            .WithMany()
            .HasForeignKey("_subcategoryId");

            tagMapConfiguration
                .Property<int>("_subcategoryId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("SubcategoryId")
                .IsRequired();


            tagMapConfiguration.Ignore(t => t.DomainEvents);
        }
    }
}
