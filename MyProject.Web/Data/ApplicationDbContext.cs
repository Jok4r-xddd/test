using LeaveManagementSystem.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
