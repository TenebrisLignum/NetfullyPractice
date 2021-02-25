using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Finances.Domain.Entities
{
    public class Categories
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Назва категорії")]
        public virtual string Name { get; set; }
    }
}
