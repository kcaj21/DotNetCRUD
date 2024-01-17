using DotNetCRUD.Models;
using Microsoft.EntityFrameworkCore;
namespace DotNetCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
