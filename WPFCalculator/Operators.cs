using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCalculator
{
    public partial class MainWindow
    {
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Content.ToString()!=string.Empty)
                {
                    addCounter++;
                    if (addCounter == 1)
                    {
                        infoLbl.Content += "+";
                        if (myoperator != ' ')
                        {
                            before = myoperator;
                            myoperator = '+';
                        }
                        else
                        {
                            before = '+';
                            myoperator = '+';
                        }
                        clickCounter = 0;
                        zeroCounter = 0;

                        if (operatorCounter == 0)
                        {
                            first = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        else
                        {
                            first = myanswer;
                            second = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        operatorCounter++;
                    }
                    mainLbl.Content = "";
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

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Content.ToString() != string.Empty)
                {
                    subCounter++;
                    if (subCounter == 1)
                    {
                        infoLbl.Content += "-";
                        if (myoperator != ' ')
                        {
                            before = myoperator;
                            myoperator = '-';
                        }
                        else
                        {
                            before = '-';
                            myoperator = '-';
                        }
                        clickCounter = 0;
                        zeroCounter = 0;

                        if (operatorCounter == 0)
                        {
                            first = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        else
                        {
                            first = myanswer;
                            second = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        operatorCounter++;
                    }
                    mainLbl.Content = "";
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

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Content.ToString() != string.Empty)
                {
                    multCounter++;
                    if (multCounter == 1)
                    {
                        infoLbl.Content += "x";
                        if (myoperator != ' ')
                        {
                            before = myoperator;
                            myoperator = 'x';
                        }
                        else
                        {
                            before = 'x';
                            myoperator = 'x';
                        }
                        clickCounter = 0;
                        zeroCounter = 0;
                        if (operatorCounter == 0)
                        {
                            first = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        else
                        {
                            first = myanswer;
                            second = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        operatorCounter++;
                    }
                    mainLbl.Content = "";
                }
                else
                {
                    throw new Exception("You have to write number before operator");
                }
            }
            catch
            {

            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (infoLbl.Content.ToString() != string.Empty)
                {
                    divCounter++;
                    if (divCounter == 1)
                    {
                        infoLbl.Content += "/";
                        if (myoperator != ' ')
                        {
                            before = myoperator;
                            myoperator = '/';
                        }
                        else
                        {
                            before = '/';
                            myoperator = '/';
                        }

                        clickCounter = 0;
                        zeroCounter = 0;

                        if (operatorCounter == 0)
                        {
                            first = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        else
                        {
                            first = myanswer;
                            second = double.Parse(mainLbl.Content.ToString());
                            Calculate();
                        }
                        operatorCounter++;
                    }
                    mainLbl.Content = "";
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
    }
}
