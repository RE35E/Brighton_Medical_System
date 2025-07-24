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
    public partial class moveAppointmentForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;

        public moveAppointmentForm()
        {
            InitializeComponent();
        }

        //pupulating combox with time
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
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
        private void moveAppointmentForm_Load(object sender, EventArgs e)
        {
            populateCbTime(cbNewTiimrMAP);
            loadDb(dgwDsiplayAppointmentsMAP);
        }

        private void btnmoveAppointmentMAP_Click(object sender, EventArgs e)
        {
            //valadating input
            if (tbIDmoveMAP.Text == string.Empty || tbneDateMAP.Text == string.Empty || cbNewTiimrMAP.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                con.Open();

                string sqlString = @"UPDATE AppointmentsTable SET Date = @date, Time = @time WHERE AppointmentID = @id";

                cmd = new SqlCommand (sqlString, con);
                cmd.Parameters.AddWithValue("@date", tbneDateMAP.Text);
                cmd.Parameters.AddWithValue("@time", cbNewTiimrMAP.SelectedItem);
                cmd.Parameters.AddWithValue("@id", int.Parse(tbIDmoveMAP.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                loadDb(dgwDsiplayAppointmentsMAP);
                MessageBox.Show("Appointment successfully updated");

            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
    }
}
