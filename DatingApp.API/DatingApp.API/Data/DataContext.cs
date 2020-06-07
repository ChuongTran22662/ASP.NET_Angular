using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext //đại diện cho cơ sở dữ liệu
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //contructor

        public DbSet<Value> Values { get; set; }
        
        public DbSet<User> Users { get; set; }
    }
}
