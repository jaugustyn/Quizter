using Quizter.Core.Services.Interfaces;

namespace Quizter.Core.Entities;

public class Category : IEntityBase
{
    public string Name { get; set; }

    public int ParentId { get; set; }
    public Category Parent { get; set; }

    public ICollection<Category> SubCategories { get; } = new List<Category>();
    public int Id { get; set; }
}