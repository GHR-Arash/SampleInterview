using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Infrastructure.EntityConfiguration
{
    class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> tagConfiguration)
        {
            tagConfiguration.ToTable("Tag");
            tagConfiguration.HasKey(t => t.Id);


            tagConfiguration.HasData(
             new Tag() { Id=1,Keyword = "x" },
             new Tag() { Id=2,Keyword = "z" },
             new Tag() { Id=3,Keyword = "Y" });

            tagConfiguration.Ignore(t => t.DomainEvents);
        }
    }
}
