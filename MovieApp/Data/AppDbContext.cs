
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace MovieApp.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext   //Translator Which Helps To Communicate With Class And DB
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
    }
}
