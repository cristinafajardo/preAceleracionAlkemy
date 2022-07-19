using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Comments
    {
        public int Id { get; set; } 
        public DateTime Date {get; set;}
        public string Comment { get; set;}
        //reference navigtion property
        public Usuarios User { get; set; }

    }

}
