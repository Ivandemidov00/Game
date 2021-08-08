using System.Threading;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IGameDbContext
    {
        DbSet<Game> games { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<GameCategories> GameCategoriesEnumerable { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}