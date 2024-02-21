using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAZALDBFramework.Windows
{
    public class FAZALMessageBox
    {
        // yeh message box for error hai jo jaha par b istamal ho sakhta hia 
        public static void ShowErrorMessage(string message)
        {

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
        }


        // yeh message box for Error loading parameter hai jo jaha par b istamal ho sakhta hia 
        public static void ShowErrorMessage(string message,string title)
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        // yeh message box for Success hai jo jaha par b istamal ho sakhta hia 
        public static void ShowSuccessMessage(string message)
        {

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }// yeh message box for Success loading parameter hai jo jaha par b istamal ho sakhta hia 
        public static void ShowSuccessMessage(string message, string title)
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}
