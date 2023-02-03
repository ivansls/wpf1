using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace проект1
{
    class Class1
    {
        
        Random rnd = new Random();
        public void random(Dictionary<int, Button> but, Dictionary<int, RadioButton> R_but, TextBlock textBlock)
        {
            bool flag = true;
            while (flag)
            {
                int value = rnd.Next(1, 9);
                switch (value)
                {
                    case 1:
                        if (but[1].Content.ToString() == "")
                        {
                            but[1].Content = "0";
                            but[1].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 2:
                        if (but[2].Content.ToString() == "")
                        {
                            but[2].Content = "0";
                            but[2].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 3:
                        if (but[3].Content.ToString() == "")
                        {
                            but[3].Content = "0";
                            but[3].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 4:
                        if (but[4].Content.ToString() == "")
                        {
                            but[4].Content = "0";
                            but[4].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 5:
                        if (but[5].Content.ToString() == "")
                        {
                            but[5].Content = "0";
                            but[5].IsEnabled = false;
                            flag = false;
                        }
                        break;

                    case 6:
                        if (but[6].Content.ToString() == "")
                        {
                            but[6].Content = "0";
                            but[6].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 7:
                        if (but[7].Content.ToString() == "")
                        {
                            but[7].Content = "0";
                            but[7].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 8:
                        if (but[8].Content.ToString() == "")
                        {
                            but[8].Content = "0";
                            but[8].IsEnabled = false;
                            flag = false;
                        }
                        break;
                    case 9:
                        if (but[9].Content.ToString() == "")
                        {
                            but[9].Content = "0";
                            but[9].IsEnabled = false;
                            flag = false;
                        }
                        break;
                }
            }
           
        }
    }
}
