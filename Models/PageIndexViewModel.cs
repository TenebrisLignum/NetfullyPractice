using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finances.Domain.Entities;

namespace Finances.Models
{
    public class PageIndexViewModel
    {
        public IEnumerable<EntityBase> EntityBases { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
