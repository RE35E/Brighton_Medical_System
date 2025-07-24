//Reese van der Linde
//46859675

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _46859675_EXAM_PROJECT_WINFORM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignInSIP_Click(object sender, EventArgs e)
        {
            //declaring variables
            string email = tbEmailSIP.Text; 
            string password = tbPasswordSIP.Text;

            //validating input
            if (email.ToLower() == "admin" &&  password.ToLower() == "admin")
            {
                mdiForm newMdiForm = new mdiForm();
                newMdiForm.Show();
            }
            else
            {
                tbEmailSIP.Text = string.Empty;
                tbPasswordSIP.Text = string.Empty;
                MessageBox.Show(" Invalid log in details please try again");
            }

        }
    }
}
