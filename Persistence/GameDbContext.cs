using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence
{
    public class GameDbContext:DbContext,IGameDbContext
    {
        public DbSet<Game> games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameCategories> GameCategoriesEnumerable { get; set; }

        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new GameCategoriesConfiguration());
            base.OnModelCreating(builder);

        }
    }
}