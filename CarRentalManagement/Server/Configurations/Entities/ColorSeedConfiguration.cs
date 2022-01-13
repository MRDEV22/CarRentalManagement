using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color
                {
                    Id = 1,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Red",
                    UpdatedBy = "SystemAdmin"
                },
                new Color
                {
                    Id = 2,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "SystemAdmin"
                }
                );
        }
    }
}
