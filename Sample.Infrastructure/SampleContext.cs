using MediatR;
using Microsoft.EntityFrameworkCore;
using Sample.Domain;
using Sample.Domain.Core;
using Sample.Infrastructure.EntityConfiguration;
using Sample.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Infrastructure
{
    public class SampleContext:DbContext,IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "";
        private readonly IMediator _mediator;

        public DbSet<TagMap> TagMaps { get; set; }
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(this);
            var result = await base.SaveChangesAsync(cancellationToken);
            return true;
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SubcategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TagEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TagMapEntityTypeConfiguration());
        }

        public SampleContext(DbContextOptions<SampleContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
    }
}
