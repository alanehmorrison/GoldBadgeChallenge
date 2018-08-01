using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class Badge
    {
        public Badge() { }
        public Badge(int id, bool v, List<string> doors)
        {
            Id = id;
            Doors = doors;
        }
        public int Id { get; set; }
        public List<string> Doors { get; set; }
    }
}
