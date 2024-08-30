using Microsoft.EntityFrameworkCore;
using ToDosAspNet.Models;

namespace ToDosAspNet.Contexts;

public class TodosContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
    }
}