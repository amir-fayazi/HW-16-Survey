using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;
using Survey.Domain.Enums;

namespace Survey.Infrastructure.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {

            builder.HasIndex(x => x.Username).IsUnique();

            var createdAt = new DateTime(2026, 10, 1);
           

            builder.HasData(
                new { Id = 1, Username = "admin", Password = "Test@1234", Role = Role.Admin, CreatedAt = createdAt  },
                new { Id = 2, Username = "amir", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt },
                new { Id = 3, Username = "sara", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt },
                new { Id = 4, Username = "ali", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt},
                new { Id = 5, Username = "nina", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt},
                new { Id = 6, Username = "reza", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt },
                new { Id = 7, Username = "mina", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt },
                new { Id = 8, Username = "parsa", Password = "Test@1234", Role = Role.User, CreatedAt = createdAt}
            );
        }
    }

}
