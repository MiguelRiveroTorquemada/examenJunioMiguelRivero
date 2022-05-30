using Microsoft.EntityFrameworkCore;
using LibroItem;
namespace Libros.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<LibroItems>? LibroItem { get; set; }
    }
}
