using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Prius",
                    UpdatedBy = "SystemAdmin"
                },
                new Model
                {
                    Id = 2,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Supra",
                    UpdatedBy = "SystemAdmin"
                },
                new Model
                {
                    Id = 3,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "3 Series",
                    UpdatedBy = "SystemAdmin"
                },
                new Model
                {
                    Id = 4,
                    CreatedBy = "SystemAdmin",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "X5",
                    UpdatedBy = "SystemAdmin"
                }
                );
        }
    }
}
