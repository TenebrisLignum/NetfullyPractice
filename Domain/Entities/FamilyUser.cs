using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Domain.Entities
{
    public class FamilyUser
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
