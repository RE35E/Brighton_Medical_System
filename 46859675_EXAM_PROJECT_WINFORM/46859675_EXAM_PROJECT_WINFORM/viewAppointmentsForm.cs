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
    public partial class viewAppointmentsForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;

        public viewAppointmentsForm()
        {
            InitializeComponent();
        }

        private void viewAppointmentsForm_Load(object sender, EventArgs e)
        {
            loadDb(dgwDislpayAppointments);
            populateCbTime(cbTimeVAP);
        }

        //populating combox with times
        public void populateCbTime(ComboBox name)
        {
            name.Items.Add("");
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

        public void loadDb(DataGridView name) {
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

        private void tbPnameVAF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sqlString = $"SELECT * FROM AppointmentsTable WHERE [Patient Name] LIKE '%{tbPnameVAF.Text}%'";

                cmd = new SqlCommand(sqlString, con);
                ad = new SqlDataAdapter();
                ds = new DataSet();

                ad.SelectCommand = cmd;
                ad.Fill(ds, "AppointmentsTable");

                dgwDislpayAppointments.DataMember = "AppointmentsTable";
                dgwDislpayAppointments.DataSource = ds;

                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        private void cbTimeVAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sqlString = @"SELECT * FROM AppointmentsTable WHERE Time = @time";

                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@time", cbTimeVAP.SelectedItem.ToString());

                ad = new SqlDataAdapter();
                ds = new DataSet();

                ad.SelectCommand = cmd;
                ad.Fill(ds, "AppointmentsTable");

                dgwDislpayAppointments.DataMember = "AppointmentsTable";
                dgwDislpayAppointments.DataSource = ds;

                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        //clearing fields
        private void lblRemoveFilterVAP_Click(object sender, EventArgs e)
        {
            cbTimeVAP.SelectedIndex = 0;
            tbPnameVAF.Text = string.Empty;
            loadDb(dgwDislpayAppointments);
        }
    }
}
