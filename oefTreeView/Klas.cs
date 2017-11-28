using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefTreeView
{
    class Klas: MenuItem
    {
        public string Klasnaam { get; set; }

        public void AddStudent(Student s) {
            LijstSubMenuItems.Add(s);
            NotifyPropertyChanged("LijstSubMenuItems");
        }
    }
}
