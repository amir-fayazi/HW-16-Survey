using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;
using Survey.Domain.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace Survey.Infrastructure.Configurations
{
    public class SurveyAggConfiguration : IEntityTypeConfiguration<SurveyAgg>
    {
        public void Configure(EntityTypeBuilder<SurveyAgg> builder)
        {
            var createdAt = new DateTime(2026, 10, 1);
            var deletedAt = DateTime.MinValue;

            builder.HasData(
                new
                {
                    Id = 1,
                    Title = "Backend Learning Preferences",
                    SurveyStatus = SurveyStatus.Active,
                    CreatedAt = createdAt,
                    DeletedAt = deletedAt
                },
                new
                {
                    Id = 2,
                    Title = "Developer Workflow",
                    SurveyStatus = SurveyStatus.Closed,
                    CreatedAt = createdAt,
                    DeletedAt = deletedAt
                },
                new
                {
                    Id = 3,
                    Title = "New Tech Survey",
                    SurveyStatus = SurveyStatus.Active,
                    CreatedAt = createdAt,
                    DeletedAt = deletedAt
                },
                new
                {
                    Id = 4,
                    Title = "Upcoming Community Poll",
                    SurveyStatus = SurveyStatus.Draft,
                    CreatedAt = createdAt,
                    DeletedAt = deletedAt
                }
            );
        }
    }

}
