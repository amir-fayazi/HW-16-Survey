using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.Domain.Entities;

namespace Survey.Infrastructure.Configurations
{
    public class OptionConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {


            builder.HasOne(x => x.Question)
                .WithMany(x => x.Options)
                .HasForeignKey(x => x.QuestionId);

            builder.HasMany(x => x.Votes)
                .WithOne(x => x.Option)
                .HasForeignKey(x => x.OptionId)
                .OnDelete(DeleteBehavior.Cascade);


            var date = new DateTime(2026, 10, 1);

            builder.HasData(
                // Question 1
                new { Id = 1, Text = "LINQ", QuestionId = 1, CreatedAt = date },
                new { Id = 2, Text = "EF Core", QuestionId = 1, CreatedAt = date },
                new { Id = 3, Text = "ASP.NET Core", QuestionId = 1, CreatedAt = date },
                new { Id = 4, Text = "OOP", QuestionId = 1, CreatedAt = date },

                // Question 2
                new { Id = 5, Text = "SQL Server", QuestionId = 2, CreatedAt = date },
                new { Id = 6, Text = "PostgreSQL", QuestionId = 2, CreatedAt = date },
                new { Id = 7, Text = "MySQL", QuestionId = 2, CreatedAt = date },
                new { Id = 8, Text = "SQLite", QuestionId = 2, CreatedAt = date },

                // Question 3
                new { Id = 9, Text = "Git", QuestionId = 3, CreatedAt = date },
                new { Id = 10, Text = "SVN", QuestionId = 3, CreatedAt = date },
                new { Id = 11, Text = "Mercurial", QuestionId = 3, CreatedAt = date },
                new { Id = 12, Text = "None", QuestionId = 3, CreatedAt = date },

                // Question 4
                new { Id = 13, Text = "Unit Tests", QuestionId = 4, CreatedAt = date },
                new { Id = 14, Text = "Manual Tests", QuestionId = 4, CreatedAt = date },
                new { Id = 15, Text = "Integration Tests", QuestionId = 4, CreatedAt = date },
                new { Id = 16, Text = "Rarely Test", QuestionId = 4, CreatedAt = date },

                // Question 5
                new { Id = 17, Text = "ASP.NET Core", QuestionId = 5, CreatedAt = date },
                new { Id = 18, Text = "Blazor", QuestionId = 5, CreatedAt = date },
                new { Id = 19, Text = "Angular", QuestionId = 5, CreatedAt = date },
                new { Id = 20, Text = "React", QuestionId = 5, CreatedAt = date },

                // Question 6
                new { Id = 21, Text = "Azure", QuestionId = 6, CreatedAt = date },
                new { Id = 22, Text = "AWS", QuestionId = 6, CreatedAt = date },
                new { Id = 23, Text = "Google Cloud", QuestionId = 6, CreatedAt = date },
                new { Id = 24, Text = "None", QuestionId = 6, CreatedAt = date },

                // Question 7
                new { Id = 25, Text = "Video", QuestionId = 7, CreatedAt = date },
                new { Id = 26, Text = "Documentation", QuestionId = 7, CreatedAt = date },
                new { Id = 27, Text = "Workshops", QuestionId = 7, CreatedAt = date },
                new { Id = 28, Text = "Projects", QuestionId = 7, CreatedAt = date },

                // Question 8
                new { Id = 29, Text = "Monday", QuestionId = 8, CreatedAt = date },
                new { Id = 30, Text = "Wednesday", QuestionId = 8, CreatedAt = date },
                new { Id = 31, Text = "Friday", QuestionId = 8, CreatedAt = date },
                new { Id = 32, Text = "Weekend", QuestionId = 8, CreatedAt = date }
            );
        }
    }

}
