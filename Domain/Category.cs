using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain
{
    public class Category : Entity, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
