using Microsoft.EntityFrameworkCore;
using MiniProyecto.API.Models;

namespace MiniProyecto.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values { get; set; }
    }
}