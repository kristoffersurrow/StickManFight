using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickManFight
{
    static class InputValidation
    {
        public static void InputVal(string inputText, System.Windows.Controls.Label errlabel, ref bool inputok)
        {

            if (string.IsNullOrWhiteSpace(inputText))
            {
                errlabel.Content = "Skal være udfyldt";
                inputok = false;
            }

            else if (!inputText.All(char.IsDigit))
            {
                errlabel.Content = "Må kun indeholde tal";
                inputok = false;
            }

            else if ((Convert.ToInt32(inputText) < 0) || (Convert.ToInt32(inputText) > 250))
            {
                errlabel.Content = "Skal være mellem 0 & 250";
                inputok = false;
            }

            else
            {
                errlabel.Content = "";
            }

        }

        //Overloaded Method
        public static void InputVal(string inputText, System.Windows.Controls.Label errlabel)
        {

            if (string.IsNullOrWhiteSpace(inputText))
            {
                errlabel.Content = "Skal være udfyldt";
            }

            else if (!inputText.All(char.IsDigit))
            {
                errlabel.Content = "Må kun indeholde tal";
            }

            else if ((Convert.ToInt32(inputText) < 0) || (Convert.ToInt32(inputText) > 250))
            {
                errlabel.Content = "Skal være mellem 0 & 250";
            }

            else
            {
                errlabel.Content = "";
            }

        }
    }
}
