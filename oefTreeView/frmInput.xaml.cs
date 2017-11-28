using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace oefTreeView
{
    /// <summary>
    /// Interaction logic for frmInput.xaml
    /// </summary>
    public partial class frmInput : Window
    {
        public frmInput()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtAntwoord.Text = "";

            DialogResult = false;
            Close();
        }

        public string TextBoxText { get => txtAntwoord.Text; set => txtAntwoord.Text = value; }
    }
}
