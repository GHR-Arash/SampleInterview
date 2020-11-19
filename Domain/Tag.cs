using Sample.Domain.Core;
using Sample.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain
{
    public class Tag : Entity, IAggregateRoot
    {
        public string Keyword { get;  set; }
       
    }
}
