using Microsoft.EntityFrameworkCore;


namespace apiQuizz.Models
{
    public class QuizzDbContext : DbContext
    {
        public QuizzDbContext(DbContextOptions<QuizzDbContext> options) : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}