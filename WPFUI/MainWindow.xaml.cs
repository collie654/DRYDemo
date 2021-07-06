using System.Windows;
using DRYDemoLibrary;

namespace WPFUI
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

        private void createEmployeeIdButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeProcessor proccessor = new EmployeeProcessor();
            employeeId.Text = proccessor.GenerateEmployeeID(firstName.Text, lastName.Text);
        }
    }
}
