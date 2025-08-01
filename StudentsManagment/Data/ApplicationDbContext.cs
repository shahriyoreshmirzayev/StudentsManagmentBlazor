using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentsManagment.Shared.Models;

namespace StudentsManagment.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
           : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<SystemCode> SystemCodes { get; set; }
    public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
}
