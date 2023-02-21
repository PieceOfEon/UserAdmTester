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

namespace UserAdmTester
{
    /// <summary>
    /// Interaction logic for TeamLWindow.xaml
    /// </summary>
    public partial class TeamLWindow : Window
    {
        public TeamLWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewProjectWindow newProjectWindow = new NewProjectWindow();
            newProjectWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SetTaskWindow setTaskWindow = new SetTaskWindow();
            setTaskWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DeveloperTaskWindow developerTaskWindow = new DeveloperTaskWindow();
            developerTaskWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TesterTaskWindow testerTaskWindow = new TesterTaskWindow();
            testerTaskWindow.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CompletedTaskWindow completedTaskWindow = new CompletedTaskWindow();
            completedTaskWindow.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
