namespace Persistence
{
    public class DbInitialize
    {
        public static void Initialize(GameDbContext gameDbContext)
        {
            gameDbContext.Database.EnsureCreated();
        }
    }
}