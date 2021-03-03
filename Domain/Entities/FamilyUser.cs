using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Domain.Entities
{
    public class FamilyUser
    {
        [Key]
        public string UserId { get; set; }
        public User User { get; set; }
        [Key]
        public string FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
