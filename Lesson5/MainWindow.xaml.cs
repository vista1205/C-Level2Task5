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

namespace Lesson5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> employees = new List<Employee>();
        public List<Department> departmentsList = new List<Department>();
        public MainWindow()
        {
            InitializeComponent();
            departmentsList.AddRange(new[]
            {
               new Department("Первый"),
               new Department("Второй"),
               new Department("Третий"),
               new Department("Четвёртый")
            });
            employees.AddRange(new[]
            {
                new Employee("Иванов Иван Иванович", "ivanonv@ivan.ru", new DateTime(1998,12,9), departmentsList[0], Lesson5_Wpf001.Control.Gender.Male),
                new Employee("Иванова Ирина Ивановна", "ivanonva@irina.ru", new DateTime(2001,11,8), departmentsList[1], Lesson5_Wpf001.Control.Gender.Female),
                new Employee("Лыскова Роза Викторовна", "liskova@roza.ru", new DateTime(2005,7,20), departmentsList[2], Lesson5_Wpf001.Control.Gender.Female),
                new Employee("Чеченев Александр Иванович", "chechnev@alex.ru", new DateTime(1988,2,12), departmentsList[3], Lesson5_Wpf001.Control.Gender.Male)
            });
            personlistView.ItemsSource = employees;
        }

        private void personlistView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                fioTextBox.Text = (e.AddedItems[0] as Employee).FIO;
                mailTextBox.Text = (e.AddedItems[0] as Employee).Mail;
                dateBirthday.SelectedDate = (e.AddedItems[0] as Employee).Birthday;
                userGenderControl.Gender = (e.AddedItems[0] as Employee).Gender;
            }
        }
    }
}
