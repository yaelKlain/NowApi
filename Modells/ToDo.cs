using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modells
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool completed { get; set; }
        public DateTime createDate { get; set; }
    }
}
