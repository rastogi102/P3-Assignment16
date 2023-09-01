using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppTaskManagement.Models;

namespace WebAppTaskManagement.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext (DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTaskManagement.Models.Task> Task { get; set; } = default!;
    }
}
