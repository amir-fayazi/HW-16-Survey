using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Dtos.Vote
{
    public class AnswerDto
    {
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
    }
}
