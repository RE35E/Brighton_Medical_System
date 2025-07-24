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
    public partial class invoiceForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public invoiceForm()
        {
            InitializeComponent();
        }

        //displaying db in data grid view
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
            //Exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        private void invoiceForm_Load(object sender, EventArgs e)
        {
            loadDb(dgwDisplayAppointmentsIP);
        }

        private void btnGenerateQuoteIP_Click(object sender, EventArgs e)
        {
            //declaring variables
            String pName, pSurname, pRsaId, dName, dSurname, date, time, service;
            decimal fee;

            //generating random variable
            Random random = new Random();
            int randNum = random.Next(1000, 10000);

            //validating input
            if (tbAppointmentIdIP.Text == string.Empty)
            {
                MessageBox.Show("Please enter the appointment id you want to create an invoice for");
                return;
            }

            try
            {
                con.Open();

                string sqlString = @"SELECT * FROM AppointmentsTable WHERE AppointmentID = @appId";

                new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("appId", int.Parse(tbAppointmentIdIP.Text));

                ds = new DataSet();
                ad = new SqlDataAdapter();

                ad.SelectCommand = cmd;
                ad.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    pName = row["Patient Name"].ToString();
                    pSurname = row["Patient Surname"].ToString();
                    pRsaId = row["Patient Rsa ID"].ToString();
                    dName = row["Doctor Name"].ToString();
                    dSurname = row["Doctor Surname"].ToString();
                    date = row["Date"].ToString();
                    time = row["Time"].ToString();
                    service = row["Services"].ToString();
                    fee = decimal.Parse(row["Fee"].ToString());

                    //displaying output to listbox
                    lbDisplayQuoteIP.Items.Add("-------------------------------------");
                    lbDisplayQuoteIP.Items.Add("Invoice Number: #" + randNum.ToString());
                    lbDisplayQuoteIP.Items.Add("-------------------------------------");

                    lbDisplayQuoteIP.Items.Add("");
                    lbDisplayQuoteIP.Items.Add("Hello " + pName.ToString());
                    lbDisplayQuoteIP.Items.Add("");
                    lbDisplayQuoteIP.Items.Add("Here is your invoice: ");
                    lbDisplayQuoteIP.Items.Add("Date: " + date);
                    lbDisplayQuoteIP.Items.Add("Time: " + time);
                    lbDisplayQuoteIP.Items.Add("Doctor: " + dSurname);
                    lbDisplayQuoteIP.Items.Add("Service: " + service);
                    lbDisplayQuoteIP.Items.Add("Fee: " + fee.ToString("c"));
                }
                //validating input
                else
                {
                    MessageBox.Show("Error: Invalid appointment ID entered.");
                }
                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
    }
}
