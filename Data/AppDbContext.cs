using Microsoft.EntityFrameworkCore;
using FootballClub.Models;
namespace FootballClub.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Player> players => Set<Player>();
}