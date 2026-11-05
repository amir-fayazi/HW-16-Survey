using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasOne(x => x.Person)
                .WithMany(x => x.Votes)
                .HasForeignKey(x => x.PersonId);

            builder.HasIndex(x => new { x.PersonId, x.QuestionId })
                .IsUnique();


            var date = new DateTime(2026, 10, 20);

            builder.HasData(
                // Question 1 - 4 Votes
                new { Id = 1, PersonId = 2, QuestionId = 1, OptionId = 1, CreatedAt = date },
                new { Id = 2, PersonId = 3, QuestionId = 1, OptionId = 2, CreatedAt = date },
                new { Id = 3, PersonId = 4, QuestionId = 1, OptionId = 1, CreatedAt = date },
                new { Id = 4, PersonId = 5, QuestionId = 1, OptionId = 3, CreatedAt = date },

                // Question 2 - 4 Votes
                new { Id = 5, PersonId = 2, QuestionId = 2, OptionId = 5, CreatedAt = date },
                new { Id = 6, PersonId = 3, QuestionId = 2, OptionId = 5, CreatedAt = date },
                new { Id = 7, PersonId = 4, QuestionId = 2, OptionId = 8, CreatedAt = date },
                new { Id = 8, PersonId = 5, QuestionId = 2, OptionId = 5, CreatedAt = date },

                // Question 3 - 2 Votes
                new { Id = 9, PersonId = 2, QuestionId = 3, OptionId = 9, CreatedAt = date },
                new { Id = 10, PersonId = 3, QuestionId = 3, OptionId = 9, CreatedAt = date },

                // Question 4 - 2 Votes
                new { Id = 11, PersonId = 2, QuestionId = 4, OptionId = 13, CreatedAt = date },
                new { Id = 12, PersonId = 3, QuestionId = 4, OptionId = 14, CreatedAt = date }
            );
        }
    }

}
