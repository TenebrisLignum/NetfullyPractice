using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Domain.Entities
{
    public class IndexViewModel
    {
        public EntityBase EntityBase { get; set; }
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<User> User { get; set; }
        public Family Family { get; set; }
    }
}
