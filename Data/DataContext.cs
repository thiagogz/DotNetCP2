using DotNetCP2.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCP2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> t_Users { get; set; }
    }
}
