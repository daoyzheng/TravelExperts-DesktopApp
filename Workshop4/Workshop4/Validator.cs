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

        // validation if the textboxes are filled and are not empty
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


        //validation if price & commission are decimal(not letters)

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

        //validation if price & commission are positive decimal
        public static bool IsPositiveDecimal(TextBox textBox)
        {
            if (Convert.ToDecimal(textBox.Text) > 0)
            {
               
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a positive number.");
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
                    MessageBox.Show(textBox.Tag + " must be like yyyy-mm-dd .", Title);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        //validation for agency commission can not be grater than base price
        public static bool IsNotGreater(TextBox commission, TextBox price)
        {
            if (Convert.ToDecimal(commission.Text) < Convert.ToDecimal(price.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Agency commission must be less than the base price!");
                return false;
            }

        }

        // validation for Package End Date must be later than Package Start Date 
        public static bool IsLatter(TextBox EndDate, TextBox StartDate)
        {
            if (Convert.ToDateTime(EndDate.Text) > Convert.ToDateTime(StartDate.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Package End Date must be later than Package Start Date !");
                return false;
            }

        }



    }// end of Validator class
}// end of namespace
