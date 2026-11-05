using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class SurveyParticipationConfiguration : IEntityTypeConfiguration<SurveyParticipation>
    {
        public void Configure(EntityTypeBuilder<SurveyParticipation> builder)
        {
            builder.HasIndex(x => new
            {
                x.PersonId,
                x.SurveyId
            }).IsUnique();

            var date = new DateTime(2026, 10, 20);

            builder.HasData(
                // Survey 1 - 4 Participants
                new { Id = 1, PersonId = 2, SurveyId = 1, CreatedAt = date },
                new { Id = 2, PersonId = 3, SurveyId = 1, CreatedAt = date },
                new { Id = 3, PersonId = 4, SurveyId = 1, CreatedAt = date },
                new { Id = 4, PersonId = 5, SurveyId = 1, CreatedAt = date },

                // Survey 2 - 2 Participants
                new { Id = 5, PersonId = 2, SurveyId = 2, CreatedAt = date },
                new { Id = 6, PersonId = 3, SurveyId = 2, CreatedAt = date }
            );
        }
    }

}
