
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace MovieApp.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
    }
}
