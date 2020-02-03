using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MVCMySQLIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace MVCMySQLIdentity.DAL
{
    public class MysqlContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public MysqlContext(DbContextOptions<MysqlContext> options):base(options) {
            //this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
