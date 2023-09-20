using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagementSystem.Essential
{
    public static class Validator
    {
        public static string Title { get; set; } = "Entry Error";

        public static Boolean IsPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag + " is a required field.", Title);
                textbox.Focus();
                return false;
            }
            return true;
        }
        public static Boolean IsDecimal(TextBox textbox)
        {
            // Testing to see if the text in TextBox will convert. If it won't it's true and throws false.
            if (!decimal.TryParse(textbox.Text, out _))
            {
                MessageBox.Show(textbox.Tag + " requires a numerical value.", Title);
                return false;
            }
            return true;
        }

        public static Boolean IsInteger(TextBox textbox)
        {
            // Testing to see if the text in TextBox will convert. If it won't it's true and throws false.
            if (!int.TryParse(textbox.Text, out _))
            {
                MessageBox.Show(textbox.Tag + " requires a whole number.", Title);
                return false;
            }
            return true;
        }

        public static Boolean IsKey(TextBox textbox, int numOfDigits)
        {
            if (textbox.Text.Length != numOfDigits)
            {
                MessageBox.Show(textbox.Tag + " is required to be " + numOfDigits + " long.", Title);
                return false;
            }
            return true;
        }

        public static Boolean IsWithinRange(TextBox textbox, int min, int max)
        {
            // Initiallizing a placeholder value
            decimal testVal;

            // Attempting to convert the text in parameter TextBox to see if it's a decimal and store it in placeholder
            if (Validator.IsDecimal(textbox))
            {
                testVal = decimal.Parse(textbox.Text);
                // Is Decimal, text to see if it is within range, or rather, if it is outside the range.
                if (testVal < min || testVal > max)
                {
                    MessageBox.Show(textbox.Tag + $" not within range of {min} to {max} .", Title);
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        public static Boolean IsWithinRange(TextBox textbox, DateTime early, DateTime late)
        {
            DateTime testDate = DateTime.Parse(textbox.Text);

            // Attempting to convert the text in parameter TextBox to see if it's a decimal and store it in placeholder
            if (Validator.IsDate(textbox))
            {
                // Is Decimal, text to see if it is within range, or rather, if it is outside the range.
                if (testDate < early || testDate > late)
                {
                    MessageBox.Show(textbox.Tag + " not within range of " + early.ToShortDateString() + " to " + late.ToShortDateString() + " .", Title);
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        // OVERLOADED Function IsWithinRange, using DateTimePicker
        public static Boolean IsWithinRange(DateTimePicker dateTimePicker, DateTime early, DateTime late)
        {
            DateTime testDate = DateTime.Parse(dateTimePicker.Text);

            // Is Decimal, text to see if it is within range, or rather, if it is outside the range.
            if (testDate < early || testDate > late)
            {
                MessageBox.Show(dateTimePicker.Tag + " not within range of " + early.ToShortDateString() + " to " + late.ToShortDateString() + " .", Title);
                return false;
            }
            else
                return true;
        }

        public static bool IsDate(TextBox textbox)
        {
            DateTime testDate;

            if (DateTime.TryParse(textbox.Text, out testDate))
            {
                return true;
            }

            MessageBox.Show(textbox.Tag + $" not a valid date.", Title);
            return false;

        }

        public static bool IsLength(TextBox textbox, int length)
        {
            if (textbox.Text.Length > length)
            {
                MessageBox.Show(textbox.Tag + $" is too long.", Title);
                return false;
            }
            else
                return true;

        }
    }
}
