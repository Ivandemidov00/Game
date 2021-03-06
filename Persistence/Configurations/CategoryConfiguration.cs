using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
         public void Configure(EntityTypeBuilder<Category> builder)
                {
                    builder.HasKey(category => category.Id);
                    builder.HasMany(gc => gc.IdCategoriesList).WithOne();
                }

        
    }
}