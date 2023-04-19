using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationFCCCrashCourseJokeApp.Models;

namespace WebApplicationFCCCrashCourseJokeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplicationFCCCrashCourseJokeApp.Models.Joke>? Joke { get; set; }
    }
}