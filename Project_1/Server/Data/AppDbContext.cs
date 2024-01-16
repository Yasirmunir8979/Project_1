using Microsoft.EntityFrameworkCore;
using Project_1.Shared;
using System.Collections.Generic;

namespace Project_1.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<AppointmentModel> AppointmentModels { get; set; }
        public DbSet<DiagnosticModel> DiagnosticModelS { get; set; }
        
        
    }
}
