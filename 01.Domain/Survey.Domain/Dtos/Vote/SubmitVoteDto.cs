using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Dtos.Vote
{
    public class SubmitVoteDto
    {
        public int SurveyId { get; set; }
        public List<AnswerDto> Answers { get; set; } = [];
    }
}
