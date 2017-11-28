using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefTreeView
{
    class Jaar: MenuItem
    {
        public string Schooljaar { get; set; }

        public void AddKlas(Klas k) {
            LijstSubMenuItems.Add(k);
            NotifyPropertyChanged("LijstSubMenuItems");
        }
    }
}
