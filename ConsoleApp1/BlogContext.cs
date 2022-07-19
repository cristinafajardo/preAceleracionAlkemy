using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        { 

        }
        //entities
        public DbSet<Usuarios>Usuarios {get; set;}
        public DbSet<Posts>Posts {get; set;}
        public DbSet<Comments>Comments {get; set;}
    }
}

    