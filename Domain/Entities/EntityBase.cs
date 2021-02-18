using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Finances.Domain.Entities
{
    public class EntityBase
    {
        // Описуємо клас (сутність) для роботи з бд
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Сума")]
        public virtual float Amount { get; set; }

        [Display(Name = "Дохід/Витрати")]
        public virtual bool Direction { get; set; }

        [Display(Name = "Категорія")]
        public virtual string Category { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
        public EntityBase()
        {
            DateAdded = DateTime.Now;
        }
    }
}
