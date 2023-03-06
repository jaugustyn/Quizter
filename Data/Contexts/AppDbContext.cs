using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quizter.Core.Entities;

namespace Quizter.Data.Contexts;

public class AppDbContext : IdentityDbContext<QuizterUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Shadow properties
        var allEntities = modelBuilder.Model.GetEntityTypes();

        foreach (var entity in allEntities)
        {
            entity.AddProperty("CreatedDate", typeof(DateTime));
            entity.AddProperty("UpdatedDate", typeof(DateTime));
        }


        // FluentAPI
        // Quiz 
        modelBuilder.Entity<Quiz>(b => { b.HasKey(c => c.Id); });
    }
}