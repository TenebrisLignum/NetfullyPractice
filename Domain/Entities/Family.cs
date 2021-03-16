using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Finances.Domain.Entities
{
    public class Family
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Назва")]
        public virtual string Name { get; set; }

        [Display(Name = "Учасники")]
        public List<FamilyUser> FamilyUser { get; set; }
        public Family()
        {
            FamilyUser = new List<FamilyUser>();
        }
    }
}
