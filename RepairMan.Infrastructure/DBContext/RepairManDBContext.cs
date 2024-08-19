using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepairMan.Domain.Models;

namespace RepairMan.Infrastructure.DBContext
{
    public class RepairManDBContext : IdentityDbContext<ApplicationUser>
    {
        public RepairManDBContext(DbContextOptions<RepairManDBContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
