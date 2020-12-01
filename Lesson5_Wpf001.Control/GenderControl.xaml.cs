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

namespace Lesson5_Wpf001.Control
{
    /// <summary>
    /// Логика взаимодействия для GenderControl.xaml
    /// </summary>
    public partial class GenderControl : UserControl
    {
        private Gender _gender = Gender.Male;
        public Gender Gender
        {
            get { return _gender; }
            set
            {
                switch (value)
                {
                    case Gender.Male:
                        maleRadioButton.IsChecked = true;
                        break;
                    case Gender.Female:
                        femaleRadioButton.IsChecked = true;
                        break;
                }
                _gender = value;
            }
        }
        public GenderControl()
        {
            InitializeComponent();
        }

        private void maleRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _gender = Gender.Male;
        }

        private void femaleRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _gender = Gender.Female;
        }
    }
}
