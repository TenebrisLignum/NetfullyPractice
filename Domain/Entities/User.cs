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
        [Display(Name = "Група")]
        public List<FamilyUser> FamilyUser { get; set; }
        public User()
        {
            FamilyUser = new List<FamilyUser>();
        }
    }
}
