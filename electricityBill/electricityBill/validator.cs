using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electricityBill
{
    /*Create class that will validate user input in the form
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */
    public static class validator
    {
        // tests if a text box is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; //innocent until proven guilty
            if(tb.Text == "") //empty textbox
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }

        //tests if a text box is a string
        public static bool IsString(TextBox tb, string name)
        {
            bool result = true;
            if(!Regex.IsMatch(tb.Text,"^[a-zA-Z -'.]+$"))
            {
                result = false;
                MessageBox.Show(name + " has to be a name with no numbers", "Data entry error");
                tb.Focus();
            }
            return result;
        }

        //test if input is a non-negative integer
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int num; // parsed number
            if(!Int32.TryParse(tb.Text, out num)) // if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be non-negative integer", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if(num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }
            return result;
        }

        //test if input is a positive integer & not equal to 0
        public static bool IsNonZeroPositiveInt(TextBox tb, string name)
        {
            bool result = true;
            int num; // parsed number
            if (!Int32.TryParse(tb.Text, out num)) // if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be non-negative integer", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative or equal to 0
            {
                if (num <= 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }
            return result;
        }

        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num; // parsed number
            if (!Double.TryParse(tb.Text, out num)) // if not double
            {
                result = false;
                MessageBox.Show(name + " has to be a floating point number", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }
            return result;
        }

        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;
            decimal num; // parsed number
            if (!Decimal.TryParse(tb.Text, out num)) // if not decimal
            {
                result = false;
                MessageBox.Show(name + " has to be a decimal number", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }
            return result;
        }
    }
}
