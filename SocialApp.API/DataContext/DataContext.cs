using Microsoft.EntityFrameworkCore;
using SocialApp.API.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    public DbSet<Value> Values { get; set; }
}