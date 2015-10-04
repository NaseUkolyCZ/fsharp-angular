using Microsoft.Data.Entity;

namespace TodoService.Model
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> Items => Set<TodoItem>();
    }
}
