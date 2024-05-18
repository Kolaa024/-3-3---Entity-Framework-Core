using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linqmaster;
using Microsoft.EntityFrameworkCore;
namespace Linqmaster
{
    public class WorkLog : DbContext
    {
        public DbSet<Metro> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=university.db");
    }
}
