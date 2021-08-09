using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class GameCategoriesConfiguration:IEntityTypeConfiguration<GameCategories>
    {
        public void Configure(EntityTypeBuilder<GameCategories> builder)
        {
            builder.HasKey(gameCategories=> new {gameCategories.IdCategories, gameCategories.IdGame});
            builder.HasOne(c => c.Category).WithMany(gc => gc.IdCategoriesList);
            builder.HasOne(g => g.Game).WithMany(gc => gc.IdGameCategoriesList);
        }
        
    }
}