using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Web.model;
using Microsoft.EntityFrameworkCore;

namespace Example.Web.db
{
    #pragma warning disable CS1591
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    }

    #pragma warning restore CS1591
}