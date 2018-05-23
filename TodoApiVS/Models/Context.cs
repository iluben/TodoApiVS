using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApiVS.Models
{
    //Context class
    public class Context : DbContext
    {
        //Constructor
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        //DbSets
        public DbSet<Films> Films { get; set; }
    }
}
