using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefTreeView
{
    class Student: MenuItem
    {
        public string Naam { get; set; }

        public override string ToString() => Naam;
        
    }
}
