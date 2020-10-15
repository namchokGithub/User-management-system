using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using User_Management_System.Models;

/*
 * Namespace: ~/Models/ManagementContext.cs
 * Author: Namchok Singhchai
 * Description: The context for management model.
 */

namespace User_Management_System.Data
{
    public class ManagementContext : DbContext
    {
        private readonly ILogger<ManagementContext> _logger;

        public ManagementContext(DbContextOptions<ManagementContext> options, ILogger<ManagementContext> logger)
            : base(options)
        {
            _logger = logger;
            _logger.LogTrace("Start management context.");
        } // End Constructor

        public DbSet<Management> Management { get; set; }
    } // End ManagementContext
}
