using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Domain.Entities
{
    [NotMapped]
    public class User : IdentityUser
    {
    }
}
