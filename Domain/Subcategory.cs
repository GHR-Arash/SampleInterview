using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain
{
    public class Subcategory : Entity, IAggregateRoot
    {
        public string Name { get;  set; }
    }
}
