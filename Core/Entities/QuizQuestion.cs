using Quizter.Core.Services.Interfaces;
using QuizterAPI.Models.Enums;

namespace Quizter.Core.Entities;

public class QuizQuestion : IEntityBase
{
    public string Content { get; set; }

    public string ImagePath { get; set; }

    public string VideoPath { get; set; }

    public QuestionType Type { get; set; }

    public Difficulty Level { get; set; }

    public int Points { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public int QuizId { get; set; }

    public virtual Quiz Quiz { get; set; }
    public int Id { get; set; }
}