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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oefTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string showWindowWith(string question)
        {
            frmInput frmInput = new frmInput();
            frmInput.lblVraag.Content = question + "?";
            frmInput.Title = question;
            
            string answer = null;

            if (frmInput.ShowDialog() == true) {
                answer = frmInput.TextBoxText;
            }

            return answer;           
        }

        private void treeView_item_changed(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)trvJaar.SelectedItem;
            lblInfo.Text = item.Tag;
            switch (item.Tag)
            {
                case "J":
                    mniKlas.IsEnabled = true;
                    mniStudent.IsEnabled = false;
                    break;
                case "K":
                    mniStudent.IsEnabled = true;
                    mniKlas.IsEnabled = true;
                    break;
                case "S":
                    break;
                default:
                    mniStudent.IsEnabled = false;
                    mniKlas.IsEnabled = false;
                    break;
            }
        }

        private void mniJaar_Click(object sender, RoutedEventArgs e)
        {
            string answer = showWindowWith("Jaar");

            bool answerIsOk = !string.IsNullOrEmpty(answer);

            if (answerIsOk)
            {
                Jaar jaar = new Jaar() { Schooljaar = answer, Tag = "J" };
                trvJaar.Items.Add(jaar);
            }
        }


        private void mniKlas_Click(object sender, RoutedEventArgs e)
        {
            string answer = showWindowWith("Klas");

            bool isJaar = trvJaar.SelectedItem is Jaar;
            bool answerIsOk = !string.IsNullOrEmpty(answer);

            if (isJaar && answerIsOk)
            {
                Klas klas = new Klas() { Klasnaam = answer, Tag = "K" };
                ((Jaar)trvJaar.SelectedItem).AddKlas(klas);
            } else
            {
                MessageBox.Show("Je kan enkel klassen aan jaren toevoegen");
            }
        }


        private void mniStudent_Click(object sender, RoutedEventArgs e)
        {
            string answer = showWindowWith("Student");

            bool isKlas = trvJaar.SelectedItem is Klas;
            bool answerIsOk = !string.IsNullOrEmpty(answer);

            if (isKlas && answerIsOk)
            {
                Student student = new Student() { Naam = answer, Tag = "S" };
                ((Klas)trvJaar.SelectedItem).AddStudent(student);
            }else
            {
                MessageBox.Show("Je kan enkel studenten aan klassen toevoegen!");
            }
        }
    }
}
