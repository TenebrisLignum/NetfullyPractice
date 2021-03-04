using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Domain.Entities
{
    public class PictureViewModel
    {
        public User user { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
