using Postman.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Domain.ValueObjects
{
    public class Address : EntityBase<Guid>
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}