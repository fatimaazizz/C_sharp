using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       double num1;
        double num2;
        string oprands;
        string num;
        bool points;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (points == false)
            {
                num = txt.Text;
                txt.Text = num + ".";
                points = true;
            }
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 0;
            }
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 7;
            }

        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 8;
            }

        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 9;
            }
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 4;
            }
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 5;
            }
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 6;
            }
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 2;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 2;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 1;
            }

        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                txt.Text = num + 3;
            }
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                if (!Equals(txt.Text, ""))
                {
                    oprands = "x";
                    num1 = Convert.ToDouble(txt.Text);
                    txt.Text = "";
                    points = false;
                }
            }
        }

        private void mins_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                if (!Equals(txt.Text, ""))
                {
                    oprands = "-";
                    num1 = Convert.ToDouble(txt.Text);
                    txt.Text = "";
                    points = false;
                }
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                if (!Equals(txt.Text, ""))
                {
                    oprands = "+";
                    num1 = Convert.ToDouble(txt.Text);
                    txt.Text = "";
                    points = false;
                }
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                if (!Equals(txt.Text, ""))
                {
                    oprands = "/";
                    num1 = Convert.ToDouble(txt.Text);
                    txt.Text = "";
                    points = false;
                }
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                num = txt.Text;
                if (num.Length != 0)
                {
                    if (num.Length != 1)
                    {
                        num = num.Remove(num.Length - 1);
                        txt.Text = num;
                    }
                    else if(num.Length == 1)
                    {
                        num = num.Remove(num.Length - 1);
                        txt.Text = num;
                        num1 = 0;
                    }

                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!Equals(txt.Text, " Syantax Error"))
            {
                if (Equals(oprands, "+"))
                {
                    if (!Equals(txt.Text, ""))
                    {
                        num2 = Convert.ToDouble(txt.Text);
                        double c;
                        c = num1 + num2;
                        txt.Text = c.ToString();
                        num2 = c;
                        num = txt.Text;
                        if (num.Contains("."))
                        {
                            points = true;
                        }
                        oprands = "";
                    }
                    else
                    {
                        txt.Text = num1.ToString();
                    }
                }
                else if (Equals(oprands, "x"))
                {
                    if (!Equals(txt.Text, ""))
                    {
                        num2 = Convert.ToDouble(txt.Text);
                        double c;
                        c = num1 * num2;
                        txt.Text = c.ToString();
                        num = txt.Text;
                        if(num.Contains("."))
                        {
                            points = true;
                            System.Console.WriteLine();
                        }
                        oprands = "";
                    }
                    else
                    {
                        txt.Text = num1.ToString();
                    }
                }
                else if (Equals(oprands, "-"))
                {
                    if (!Equals(txt.Text, ""))
                    {
                        num2 = Convert.ToDouble(txt.Text);
                        double c;
                        c = num1 - num2;
                        txt.Text = c.ToString();
                        num = txt.Text;
                        if (num.Contains("."))
                        {
                            points = true;
                        }
                        oprands = "";
                    }
                    else
                    {
                        txt.Text = num1.ToString();
                    }
                }
                else if (Equals(oprands, "/"))
                {
                    if (!Equals(txt.Text, ""))
                    {
                        num2 = Convert.ToDouble(txt.Text);
                        double c;
                        if (num2 != 0)
                        {
                            c = num1 / num2;
                            txt.Text = c.ToString();
                            num = txt.Text;
                            if (num.Contains("."))
                            {
                                points = true;
                            }
                            oprands = "";
                        }
                        else
                        {
                            txt.Text = " Syantax Error";
                        }

                    }
                    else
                    {
                        txt.Text = num1.ToString();
                    }
                }
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
            num1 = 0;
            num2 = 0;



            points = false;
        }

    }
}
