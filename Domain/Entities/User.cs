using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Domain.Entities
{
    [NotMapped]
    public class User : IdentityUser
    {
        [Display(Name = "Аватар")]
        public byte[] Avatar { get; set; }

        [Display(Name = "Ім'я")]
        public virtual string FirstName { get; set; }

        [Display(Name = "Фамілія")]
        public virtual string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'.'MM'.'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Групи")]
        public List<FamilyUser> FamilyUser { get; set; }

        public User()
        {
            FamilyUser = new List<FamilyUser>();
        }
    }
}
