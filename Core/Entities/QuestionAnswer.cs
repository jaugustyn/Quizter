using Quizter.Core.Services.Interfaces;

namespace Quizter.Core.Entities;

public class QuestionAnswer : IEntityBase
{
    public string Content { get; set; }

    public bool IsCorrect { get; set; }

    public int QuestionId { get; set; }

    public virtual QuizQuestion Question { get; set; }
    public int Id { get; set; }
}