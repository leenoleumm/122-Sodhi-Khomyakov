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

namespace _122_Соди_Хомяков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static int function;

        public void f1(object sender, RoutedEventArgs e)
        {
            function = 1;
        }

        public void f2(object sender, RoutedEventArgs e)
        {
            function = 2;
        }

        public void f3(object sender, RoutedEventArgs e)
        {
            function = 3;
        }

        public void ClickButton(object sender, RoutedEventArgs e)
        {
            string x = xInput.Text.ToString();
            string m = mInput.Text.ToString();

            if (x == "" || m == "")
            {
                Answer.Text = "Ошибка";
                return;
            }

            double xD = Convert.ToDouble(x);
            double mD = Convert.ToDouble(m);

            switch (function)
            {
                case 1:
                    Answer.Text = (xD + mD).ToString();
                    break;
                case 2:
                    Answer.Text = (xD * mD).ToString();
                    break;
                case 3:
                    Answer.Text = (xD - mD).ToString();
                    break;
            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
