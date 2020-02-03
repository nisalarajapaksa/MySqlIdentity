using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMySQLIdentity.Models
{
    public class ApplicationRole: IdentityRole<int>
    {
        [MaxLength(36)]
        public override int Id { get; set; }
    }
}
