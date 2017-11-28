using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace oefTreeView
{
    class MenuItem: INotifyPropertyChanged
    {
        private ImageSource _afbeelding;
        private bool _isExpanded;
        private ObservableCollection<object> _lijstSubMenuItems;
        private string _tag;

        public event PropertyChangedEventHandler PropertyChanged;

        internal void NotifyPropertyChanged(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        public ImageSource Afbeelding { get => _afbeelding; set => _afbeelding = value; }
        public string Tag { get => _tag; set => _tag = value; }
        public bool IsExpanded { get => _isExpanded; set => _isExpanded = value; }
        public ObservableCollection<object> LijstSubMenuItems { get => _lijstSubMenuItems; set => _lijstSubMenuItems = value; }


        public void WisSubItems() => LijstSubMenuItems.Clear();

        public MenuItem()
        {
            LijstSubMenuItems = new ObservableCollection<object>();
        }
    }
}
