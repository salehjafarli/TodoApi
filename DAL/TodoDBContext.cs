using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> opts): base(opts)
        {
        }
        public DbSet<Event> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
