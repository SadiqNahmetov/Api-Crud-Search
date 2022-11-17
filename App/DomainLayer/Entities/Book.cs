using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
