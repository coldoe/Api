using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class DataContext : DbContext
    {
        //it take from startup class
        //configuration of services
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        //Dbsety
        public DbSet<TodoTask> todoTasks { get; set; }
    }
}
