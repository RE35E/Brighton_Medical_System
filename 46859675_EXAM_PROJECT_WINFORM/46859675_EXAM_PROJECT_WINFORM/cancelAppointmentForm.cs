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
    public partial class cancelAppointmentForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public cancelAppointmentForm()
        {
            InitializeComponent();
        }

        //displaing db to data grid view
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

        private void buttCancelAppointmentCAF_Click(object sender, EventArgs e)
        {
            //valildating input
            if( tbAppointmentIDCAF.Text == string.Empty)
            {
                MessageBox.Show("Please enter the appointment id of the appointment you want to cancel");
                return;
            }

            try
            {
                con.Open();

                string sqlString = @"DELETE FROM AppointmentsTable WHERE AppointmentID = @id";
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@id", int.Parse(tbAppointmentIDCAF.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                tbAppointmentIDCAF.Text =string.Empty;
                loadDb(dgwDisplayAppointmentsCAF);
                MessageBox.Show( "Appointmet succesfully removed");  
            }
            //exception handeling
            catch (SqlException sqle)
            {
                 MessageBox.Show(sqle.Message, "Error Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelAppointmentForm_Load(object sender, EventArgs e)
        {
            loadDb(dgwDisplayAppointmentsCAF);
        }

        private void tbAppointmentIDCAF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
