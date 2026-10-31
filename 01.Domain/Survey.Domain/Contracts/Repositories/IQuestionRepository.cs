using Survey.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Domain.Contracts.Repositories
{
    public interface IQuestionRepository
    {

        void Add(Question question);

    }
}
