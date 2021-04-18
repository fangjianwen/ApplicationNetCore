using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal
{
   public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //注入Sql链接字符串
            optionsBuilder.UseSqlServer(@"Server=.;Database=ApplicationNetCore;Trusted_Connection=True;");
        }
        /// <summary>
        /// Users表
        /// </summary>
        public DbSet<Users> Users { get; set; }
    }
}
