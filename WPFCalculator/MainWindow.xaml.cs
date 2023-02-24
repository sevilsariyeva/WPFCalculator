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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clickCounter = 0;
        int operatorCounter = 0;
        double myanswer = 0;
        char myoperator = ' ';
        double first = 0;
        double second = 0;
        int addCounter = 0;
        int subCounter = 0;
        int multCounter = 0;
        int divCounter = 0;
        int zeroCounter = 0;
        char before = ' ';
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            if (before == '+')
            {
                myanswer = first + second;
            }
            else if (before == '-')
            {
                myanswer = first - second;
            }
            else if (before == 'x')
            {
                if (second == 0)
                {
                    second++;
                }
                myanswer = first * second;
            }
            else if (before == '/')
            {
                if (second == 0)
                {
                    second++;
                }
                myanswer = first / second;
            }
        }

        private void plusminusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainLbl.Content != null)
                {
                    if (!infoLbl.Content.Equals("0"))
                    {
                        if (mainLbl.Content.ToString().StartsWith("-"))
                        {
                            mainLbl.Content = mainLbl.Content.ToString().Trim('-');
                            infoLbl.Content = infoLbl.Content.ToString().Trim('-');
                        }
                        else
                        {
                            mainLbl.Content = "-" + mainLbl.Content;
                            if (addCounter>0 || subCounter>0 || multCounter>0 || divCounter>0)
                            {
                                infoLbl.Content = infoLbl.Content + "-";
                            }
                            else
                            {
                                infoLbl.Content = "-" + infoLbl.Content;
                            }
                        }
                    }
                    else
                    {
                        mainLbl.Content = "0";
                        infoLbl.Content = "0";
                    }
                }
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void pointBtn_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                if (mainLbl.Content == null || mainLbl.Content=="")
                {
                    mainLbl.Content += "0.";
                    infoLbl.Content += "0.";
                }
                else
                {
                    mainLbl.Content += ".";
                    infoLbl.Content += ".";
                }
            }

        }
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            if (!infoLbl.Content.Equals(string.Empty))
            {
                clickCounter = 0;
                double myvalue = double.Parse(mainLbl.Content.ToString());
                var myanswer = Math.Sqrt(myvalue);
                mainLbl.Content = myanswer.ToString();
                infoLbl.Content = myanswer.ToString();
            }
            else
            {
                clickCounter = 0;
                mainLbl.Content = "0";
                double myvalue = double.Parse(mainLbl.Content.ToString());
                var myanswer = Math.Sqrt(myvalue);
                mainLbl.Content = myanswer.ToString();
                infoLbl.Content = myanswer.ToString();
            }
        }
        private void equalityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!infoLbl.Content.Equals(string.Empty))
                {
                    before = myoperator;
                    myoperator = '=';
                    clickCounter = 0;
                    if (operatorCounter == 1)
                    {
                        second = double.Parse(mainLbl.Content.ToString());
                        Calculate();
                    }
                    else
                    {
                        first = myanswer;
                        second = double.Parse(mainLbl.Content.ToString());
                        Calculate();

                    }
                    operatorCounter = 0;
                    mainLbl.Content = myanswer.ToString();
                    infoLbl.Content = myanswer.ToString();
                    second = 0;
                }
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Content = null;
            infoLbl.Content = null;
        }
        private void squareBtn_Click(object sender, EventArgs e)
        {
            if (!infoLbl.Content.Equals(string.Empty))
            {
                infoLbl.Content = $"sqr({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) * double.Parse(mainLbl.Content.ToString())).ToString();
            }
            else
            {
                mainLbl.Content = "0";
                infoLbl.Content = $"sqr({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) * double.Parse(mainLbl.Content.ToString())).ToString();
            }
        }
        private void dividebyxBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!infoLbl.Content.Equals(string.Empty))
                {
                    infoLbl.Content = $"1/{mainLbl.Content}";
                    mainLbl.Content = (1 / double.Parse(mainLbl.Content.ToString())).ToString();
                }
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void cubeBtn_Click(object sender, EventArgs e)
        {
            if (!infoLbl.Content.Equals(string.Empty))
            {
                infoLbl.Content = $"cube({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) * double.Parse(mainLbl.Content.ToString()) * double.Parse(mainLbl.Content.ToString())).ToString();
            }
            else
            {
                mainLbl.Content = "0";
                infoLbl.Content = $"cube({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) * double.Parse(mainLbl.Content.ToString())).ToString();
            }
        }
        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (!infoLbl.Content.Equals(string.Empty))
            {
                infoLbl.Content = $"percent({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) / 100).ToString();
            }
            else
            {
                mainLbl.Content = "0";
                infoLbl.Content = $"percent({mainLbl.Content})";
                mainLbl.Content = (double.Parse(mainLbl.Content.ToString()) / 100).ToString();
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!mainLbl.Content.Equals(string.Empty))
            {
                mainLbl.Content = mainLbl.Content.ToString().Remove(mainLbl.Content.ToString().Length - 1, 1);
                infoLbl.Content = mainLbl.Content;
            }
            else
            {
                mainLbl.Content = "";
                infoLbl.Content = "";
            }
        }

    }
}
