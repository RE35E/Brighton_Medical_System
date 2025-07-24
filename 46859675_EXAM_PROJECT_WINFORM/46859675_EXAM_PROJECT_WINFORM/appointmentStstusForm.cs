//Reese van der Linde
//46859675

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _46859675_EXAM_PROJECT_WINFORM
{
    public partial class appointmentStstusForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;

        public appointmentStstusForm()
        {
            InitializeComponent();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            string status;

            //validation input
            if (rbCompletedCAS.Checked == true)
            {
                status = "Completed";
            }
            else if (rbCanceled.Checked == true)
            {
                status = "Canceled";
            }
            else if (rbScheduledCAS.Checked == true)
            {
                status = "Schedueled";
            }
            else
            {
                MessageBox.Show("Please select a status option");
                return;
            }

            if (tbAppointmentIDCAS.Text == string.Empty)
            {
                MessageBox.Show("Please enter an appointment ID");
                return;
            }

            try
            {
                con.Open();

                string sqlString = @"UPDATE AppointmentsTable SET Status = @status WHERE AppointmentID = @id";

                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", int.Parse(tbAppointmentIDCAS.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                loadDb(dgwAppointmentCAS);
                MessageBox.Show("Appointment successfully updated");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        //displaying db to data grid view
        public void loadDb(DataGridView name)
        {
            try
            {
                con.Open();

                string sqlString = @"SELECT * FROM AppointmentsTable";


                cmd = new SqlCommand(sqlString, con);
                ad = new SqlDataAdapter();
                ds = new DataSet();

                ad.SelectCommand = cmd;
                ad.Fill(ds, "AppointmentsTable");

                name.DataMember = "AppointmentsTable";
                name.DataSource = ds;

                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        private void appointmentStstusForm_Load(object sender, EventArgs e)
        {
            loadDb(dgwAppointmentCAS);
        }
    }
}
