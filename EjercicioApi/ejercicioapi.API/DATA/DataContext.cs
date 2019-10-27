using ejercicioapi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ejercicioapi.API.DATA
{
    public class DataContext : DbContext    
    {
        public DbSet<Category> Categories {get; set;}

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}