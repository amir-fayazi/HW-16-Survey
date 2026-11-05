using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            builder.HasMany(x => x.Votes)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Survey)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.SurveyId)
                .OnDelete(DeleteBehavior.Cascade);


            var date = new DateTime(2026, 10, 1);

            builder.HasData(
                new { Id = 1, Text = "Which backend topic do you enjoy most?", SurveyId = 1, CreatedAt = date },
                new { Id = 2, Text = "Which database do you use most?", SurveyId = 1, CreatedAt = date },

                new { Id = 3, Text = "Which version control system do you use?", SurveyId = 2, CreatedAt = date },
                new { Id = 4, Text = "How do you usually test your code?", SurveyId = 2, CreatedAt = date },

                new { Id = 5, Text = "Which framework would you learn next?", SurveyId = 3, CreatedAt = date },
                new { Id = 6, Text = "Which cloud platform interests you?", SurveyId = 3, CreatedAt = date },

                new { Id = 7, Text = "What learning format do you prefer?", SurveyId = 4, CreatedAt = date },
                new { Id = 8, Text = "Which day suits a community meetup?", SurveyId = 4, CreatedAt = date }
            );

        }
    }

}
