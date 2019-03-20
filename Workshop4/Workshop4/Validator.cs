using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4
{

    /*
    * Term 2 Threaded Project 
    * Author : Mahda Kazemian
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :Validator class to validate the package information.
    */

    public static class Validator
    {


        // validation for title that appears in dialogbox
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        // validation if the textbox is filled and is not empty
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is required to be field.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        // validation if packageid is an integer
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }


        //validation if price is decimal

        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }
        // validation if package start and end Date have specific format for date
        public static bool IsDateTime(TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    Convert.ToDateTime(textBox.Text);
                    return true;

                }
                catch (FormatException)
                {
                    MessageBox.Show(textBox.Tag + "Must be like yyyy-mm-dd", Title);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        
    }// end of Validator class
}// end of namespace
