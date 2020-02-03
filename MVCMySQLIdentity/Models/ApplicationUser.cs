using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVCMySQLIdentity.Models
{
    public class ApplicationUser: IdentityUser<int>
    {
        [MaxLength(36)]
        public override int Id { get; set; }
        public ApplicationUser() { }
    }
}
