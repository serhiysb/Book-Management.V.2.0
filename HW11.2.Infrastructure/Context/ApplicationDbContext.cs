using HW11._2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11._2.Infrastructure.Context
{
    public class ApplicationDbContext:DbContext
    {
        DbSet<Book> Books => Set<Book>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
