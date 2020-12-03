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

namespace Lesson5
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeeForm.xaml
    /// </summary>
    public partial class AddEmployeeForm : Window
    {   
        
        public AddEmployeeForm()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
            List<Department> newdep = new List<Department>();
            newdep.AddRange(mainWindow.departmentsList);
            addDepartmentComboBox.ItemsSource = newdep;
        }
        
        private void yesButtonForm_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void noButtonForm_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
