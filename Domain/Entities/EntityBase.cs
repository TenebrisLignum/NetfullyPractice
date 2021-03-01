using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Finances.Domain.Entities
{
    public class EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Користувач")]
        public virtual string TheUser { get; set; }

        [Display(Name = "Сума")]
        public virtual float Amount { get; set; }

        [Display(Name = "Дохід/Витрати")]
        public virtual bool Direction { get; set; }

        [Display(Name = "Категорія")]
        public virtual string Category { get; set; }

        [Display(Name = "Деталі")]
        public virtual string About { get; set; }

        [Display(Name = "Група")]
        public virtual string Family { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
        public EntityBase()
        {
            DateAdded = DateTime.Now;
        }
    }
}
