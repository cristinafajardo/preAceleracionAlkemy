using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Posts
    { 
        public char Title {get; set;}
        public string Content {get; set;}
        //reference navigtion property
        public Usuarios User {get; set;}
    }
}
