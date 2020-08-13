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
    }
}
