using Microsoft.Data.Entity;

namespace fsharp_angular_web.Model
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> Items => Set<TodoItem>();
    }
}
