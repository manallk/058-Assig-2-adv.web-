using Microsoft.EntityFrameworkCore;
using assignment_WEB_API.models;

namespace assignment_WEB_API.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base (options)
        {

        }
        public DbSet <login> login { get; set; }
    }
}
