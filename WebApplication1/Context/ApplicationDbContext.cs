using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace company.context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions) { }
    public DbSet<Employee> Emplyees { get; set; }
}