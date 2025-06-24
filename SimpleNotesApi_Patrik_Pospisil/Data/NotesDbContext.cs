using Microsoft.EntityFrameworkCore;
using SimpleNotesApi.Models;
using System.Collections.Generic;

namespace SimpleNotesApi.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes => Set<Note>();
    }
}
