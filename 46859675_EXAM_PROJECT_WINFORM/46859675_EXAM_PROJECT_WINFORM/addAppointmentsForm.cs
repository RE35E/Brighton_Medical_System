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

namespace _46859675_EXAM_PROJECT_WINFORM
{
    public partial class addAppointmentsForm : Form
    {

        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;

        public addAppointmentsForm()
        {
            InitializeComponent();
        }

        //populating combo boxes in windows form
        private void addAppointmentsForm_Load(object sender, EventArgs e)
        {     
            populateCbTime(tbTimeAAF);
            populateCbServices(cbServiceAAF);
            popualteCbDoctors(cbDoctorAAP);
        }

        //populating combo box
        public void popualteCbDoctors(ComboBox name)
        {
            name.Items.Add("Piere Marais");
            name.Items.Add("Emily Johnson");
            name.Items.Add("Michael Smith");
            name.Items.Add("Olivia Martinez");
            name.Items.Add("William Brown");
        }

        //populating combo box
        public void populateCbTime(ComboBox name)
        {
            name.Items.Add("08:00");
            name.Items.Add("08:30");
            name.Items.Add("09:00");
            name.Items.Add("09:30");
            name.Items.Add("10:00");
            name.Items.Add("10:30");
            name.Items.Add("11:00");
            name.Items.Add("11:30");
            name.Items.Add("12:00");
            name.Items.Add("13:30");
            name.Items.Add("14:00");
            name.Items.Add("14:30");
            name.Items.Add("15:00");
            name.Items.Add("15:30");
            name.Items.Add("16:00");
        }

        //populating combo box
        public void populateCbServices(ComboBox name)
        {
            name.Items.Add("Surgical Appointment");
            name.Items.Add("Labratory / Medical Result Analysis");
            name.Items.Add("Routine Check-Up");
            name.Items.Add("Urgent Medical Check-Up");
        }

        private void btnMakeAppointmentAAF_Click(object sender, EventArgs e)
        {
            //declaring variable
            decimal fee = 0.0m;

            //validating input
            if (tbPnameAAF.Text == string.Empty || tbPsnameAAF.Text == string.Empty || tbPIDAAF.Text == string.Empty || tbDateAAP.Text == string.Empty || tbTimeAAF.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (cbDoctorAAP.SelectedIndex == -1 || cbServiceAAF.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                con.Open();
                string sqlString = @"INSERT INTO AppointmentsTable([Patient Name], [Patient Surname], [Patient Rsa ID], [Doctor Name], [Doctor Surname], Date, Time, Services, Fee, Status) 
                                    VALUES (@pname, @psname, @prsaid, @dname, @dsurname, @date, @time, @service, @fee, @status)";

                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@pname", tbPnameAAF.Text);
                cmd.Parameters.AddWithValue("@psname", tbPsnameAAF.Text);
                cmd.Parameters.AddWithValue("@prsaid", tbPIDAAF.Text);

                string[] doctorNamePart = cbDoctorAAP.SelectedItem.ToString().Split(' ');

                cmd.Parameters.AddWithValue("@dname", doctorNamePart[0]);
                cmd.Parameters.AddWithValue("@dsurname", doctorNamePart[1]);
                cmd.Parameters.AddWithValue("@date", tbDateAAP.Text);
                cmd.Parameters.AddWithValue("@time", tbTimeAAF.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@service", cbServiceAAF.SelectedItem.ToString());

                fee = getFee(cbServiceAAF.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@status", "Scheduled");

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Appointment sucessfully added");

            }
            //exception handeling
            catch (SqlException sqle) 
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        //caclulaitng fee of service
        public decimal getFee(string service)
        {
            decimal fee = 0;

            if (service == "Surgical Appointment")
            {
                fee = 1500.00m;
            }
            else if (service == "Labratory / Medical Result Analysis")
            {
                fee = 360.00m;
            }
            else if (service == "Routine Check-Up")
            {
                fee = 500.00m;
            }
            else if (service == "Urgent Medical Check-Up")
            {
                fee = 2000.00m;
            }
            return fee;
        }
    }
}
