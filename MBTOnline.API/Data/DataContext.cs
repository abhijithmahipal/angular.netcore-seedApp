using MBTOnline.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MBTOnline.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){}
        public DbSet<Value> Values { get; set; }
    }
}