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

        static int function = 0;

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

            if (x == "" || m == "" || function == 0)
            {
                Answer.Text = "Ошибка";
                return;
            }

            double xD = Convert.ToDouble(x);
            double mD = Convert.ToDouble(m);

            Console.WriteLine(xD);
            Console.WriteLine(mD);

            switch (function)
            {
                case 1:
                    if (xD - mD == 0) {
                        Answer.Text = (Math.Pow(Math.Sinh(xD), 2) + Math.Pow(mD, 2) + Math.Sin(mD)).ToString();
                    } else if (xD - mD > 0)
                    {
                        Answer.Text = (Math.Pow(Math.Sinh(xD) - mD, 2) + Math.Cos(mD)).ToString();
                    } else
                    {
                        Answer.Text = (Math.Pow(mD - Math.Sinh(xD), 2) + Math.Tan(mD)).ToString();
                    }
                    break;
                case 2:
                    if (xD - mD == 0)
                    {
                        Answer.Text = (Math.Pow(Math.Pow(xD, 2), 2) + Math.Pow(mD, 2) + Math.Sin(mD)).ToString();
                    }
                    else if (xD - mD > 0)
                    {
                        Answer.Text = (Math.Pow(Math.Pow(xD, 2) - mD, 2) + Math.Cos(mD)).ToString();
                    }
                    else
                    {
                        Answer.Text = (Math.Pow(mD - Math.Pow(xD, 2), 2) + Math.Tan(mD)).ToString();
                    }
                    break;
                case 3:
                    if (xD - mD == 0)
                    {
                        Answer.Text = (Math.Pow(Math.Exp(xD), 2) + Math.Pow(mD, 2) + Math.Sin(mD)).ToString();
                    }
                    else if (xD - mD > 0)
                    {
                        Answer.Text = (Math.Pow(Math.Exp(xD) - mD, 2) + Math.Cos(mD)).ToString();
                    }
                    else
                    {
                        Answer.Text = (Math.Pow(mD - Math.Exp(xD), 2) + Math.Tan(mD)).ToString();
                    }
                    break;
            }

        }

        public void ClickButtonClear(object sender, RoutedEventArgs e)
        {
            xInput.Text = "";
            mInput.Text = "";
            Answer.Text = "";
            r1.IsChecked = false;
            r2.IsChecked = false;
            r3.IsChecked = false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
