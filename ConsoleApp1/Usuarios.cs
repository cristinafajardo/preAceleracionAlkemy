using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Usuarios
    {
        public int Id {get;set;}
        public string Name {get;set;}  
        public char Password { get; set; }
        public string Email { get; set; }
        //reference navigtion property
        public Posts Posts { get; set; }
        public Comments Comments { get; set; }
    }

}
