using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetProject.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext (DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetProject.Models.Account> Movie { get; set; }
    }
}