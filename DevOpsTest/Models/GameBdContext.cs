using Microsoft.EntityFrameworkCore;

namespace DevOpsTest.Models
{
    public class GameBdContext : DbContext
    {

        public GameBdContext(DbContextOptions<GameBdContext> options) : base(options)
        {

        }

        public DbSet<UserData> Users { get; set; }

    }
}
