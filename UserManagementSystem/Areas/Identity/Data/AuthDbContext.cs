using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Areas.Identity.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Account");
                entity.Property(e => e.Id).HasColumnName("acc_Id");
                entity.Property(e => e.UserName).HasColumnName("acc_user");
                entity.Property(e => e.PasswordHash).HasColumnName("acc_password");
                entity.Property(e => e.acc_mem_Id).HasColumnName("acc_mem_Id");
            });
        }
    }
}
