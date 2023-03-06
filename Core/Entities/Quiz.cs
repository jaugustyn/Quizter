using Quizter.Core.Services.Interfaces;

namespace Quizter.Core.Entities;

public class Quiz : IEntityBase
{
    public string Slug { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int Score { get; set; }

    public bool Published { get; set; }

    public int TimeLimit { get; set; }

    public int Attempts { get; set; }
    public string Password { get; set; }

    public int CategoryId { get; set; }
    public string UserId { get; set; }

    public virtual Category Category { get; set; }
    public virtual QuizterUser User { get; set; }
    public int Id { get; set; }
}