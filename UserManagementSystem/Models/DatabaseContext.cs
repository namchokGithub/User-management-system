using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

/*
 * Name: DatabaseContext.cs
 * Namespace: Models
 * Author: Namchok
 */

namespace UserManagementSystem.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<Account> Account { get; set; }
        public DbSet<Log> Log{ get; set; }
        public DbSet<LogAccount> Log_account{ get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TypeAccount> Type_account { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Course>().ToTable("Course");
        //}
    }
}
