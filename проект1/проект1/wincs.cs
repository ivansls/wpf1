using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace проект1
{
    class wincs
    {
        int wincount = 0;
        public void all_true(Dictionary<int, Button> but, Dictionary<int, RadioButton> R_bu, TextBlock textblock, int count)
        {
            if (but[1].Content == "X" && but[2].Content == "X" && but[3].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[4].Content == "X" && but[5].Content == "X" && but[6].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[7].Content == "X" && but[8].Content == "X" && but[9].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[1].Content == "X" && but[4].Content == "X" && but[7].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[2].Content == "X" && but[5].Content == "X" && but[8].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[3].Content == "X" && but[6].Content == "X" && but[9].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[1].Content == "X" && but[5].Content == "X" && but[9].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }
            else if (but[3].Content == "X" && but[5].Content == "X" && but[7].Content == "X")
            {
                textblock.Text = "win - you";
                off_button();
            }

            else if (but[1].Content == "0" && but[2].Content == "0" && but[3].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[4].Content == "0" && but[5].Content == "0" && but[6].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[7].Content == "0" && but[8].Content == "0" && but[9].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[1].Content == "0" && but[4].Content == "0" && but[7].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[2].Content == "0" && but[5].Content == "0" && but[8].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[3].Content == "0" && but[6].Content == "0" && but[9].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[1].Content == "0" && but[5].Content == "0" && but[9].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else if (but[3].Content == "0" && but[5].Content == "0" && but[7].Content == "0")
            {
                textblock.Text = "win - robot";
                off_button();
            }
            else
            {
                if (count == 9)
                {
                    textblock.Text = "win - ничья";
                    off_button();
                }
                
            }

            void off_button()
            {
                R_bu[1].IsEnabled = true;
                R_bu[2].IsEnabled = true;
                R_bu[1].IsEnabled = true;
                R_bu[2].IsEnabled = true;
                but[1].IsEnabled = false;
                but[2].IsEnabled = false;
                but[3].IsEnabled = false;
                but[4].IsEnabled = false;
                but[5].IsEnabled = false;
                but[6].IsEnabled = false;
                but[7].IsEnabled = false;
                but[8].IsEnabled = false;
                but[9].IsEnabled = false;
            }
        } 
    }
}
