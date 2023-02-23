using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    public partial class MainWindow
    {
        //var temp = double.Parse(mainLbl.Content.ToString());
        //temp += 1;
        //        mainLbl.Content = temp;
        //        var temp1 = double.Parse(infoLbl.Content.ToString());
        //temp1 += 1;
        //        infoLbl.Content = temp1;
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content == null)
            {
                zeroCounter++;
                if (zeroCounter == 1)
                {
                    mainLbl.Content += "0";
                    infoLbl.Content += "0";
                }

            }
            else
            {
                zeroCounter++;
                if (mainLbl.Content.Equals("0"))
                {
                    zeroCounter++;
                    if (zeroCounter == 1)
                    {
                        mainLbl.Content += "0";
                        infoLbl.Content += "0";
                    }

                }
                else
                {
                    mainLbl.Content += "0";
                    infoLbl.Content += "0";
                }
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content!= null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "1";
                    infoLbl.Content = "1";
                }
                else
                {
                    mainLbl.Content += "1";
                    infoLbl.Content += "1";
                }
            }
            else
            {
                mainLbl.Content += "1";               
                infoLbl.Content +="1";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "2";
                    infoLbl.Content = "2";
                }
                else
                {
                    mainLbl.Content += "2";
                    infoLbl.Content += "2";
                }
            }
            else
            {
                mainLbl.Content += "2";
                infoLbl.Content += "2";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "3";
                    infoLbl.Content = "3";
                }
                else
                {
                    mainLbl.Content += "3";
                    infoLbl.Content += "3";
                }
            }
            else
            {
                mainLbl.Content += "3";
                infoLbl.Content += "3";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "4";
                    infoLbl.Content = "4";
                }
                else
                {
                    mainLbl.Content += "4";
                    infoLbl.Content += "4";
                }
            }
            else
            {
                mainLbl.Content += "4";
                infoLbl.Content += "4";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void fiveBtn_Click(object sender, EventArgs e)
        {

            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "5";
                    infoLbl.Content = "5";
                }
                else
                {
                    mainLbl.Content += "5";
                    infoLbl.Content += "5";
                }
            }
            else
            {
                mainLbl.Content += "5";
                infoLbl.Content += "5";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "6";
                    infoLbl.Content = "6";
                }
                else
                {
                    mainLbl.Content += "6";
                    infoLbl.Content += "6";
                }
            }
            else
            {
                mainLbl.Content += "6";
                infoLbl.Content += "6";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "7";
                    infoLbl.Content = "7";
                }
                else
                {
                    mainLbl.Content += "7";
                    infoLbl.Content += "7";
                }
            }
            else
            {
                mainLbl.Content += "7";
                infoLbl.Content += "7";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "8";
                    infoLbl.Content = "8";
                }
                else
                {
                    mainLbl.Content += "8";
                    infoLbl.Content += "8";
                }
            }
            else
            {
                mainLbl.Content += "8";
                infoLbl.Content += "8";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (mainLbl.Content != null)
            {
                if (mainLbl.Content.Equals("0"))
                {
                    mainLbl.Content = "9";
                    infoLbl.Content = "9";
                }
                else
                {
                    mainLbl.Content += "9";
                    infoLbl.Content += "9";
                }
            }
            else
            {
                mainLbl.Content += "9";
                infoLbl.Content += "9";
            }
            AddClicked = false;
            MultClicked = false;
            SubClicked = false;
            DivClicked = false;
            addCounter = 0;
            subCounter = 0;
            multCounter = 0;
            divCounter = 0;
        }
    }
}
