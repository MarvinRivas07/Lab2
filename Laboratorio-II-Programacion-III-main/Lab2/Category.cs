using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Category
    {
        public string Name { get; set; }
        public Area Area { get; set; }

        public Category(string name, Area area)
        {
            Name = name;
            Area = area;
        }
    }
}
