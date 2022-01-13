using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "39717e88-b638-4eea-8d03-66ae082576d4",
                    UserId = "26a33fbd-cd1b-4b69-a1c9-e0e49369614d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5ac2ee9b-a1e1-4c88-89f9-3a0e84277858",
                    UserId = "344c7353-8798-4d33-93d4-55ca31fac122"
                }
                );
        }
    }
}
