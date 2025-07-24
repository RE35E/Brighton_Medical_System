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
    public partial class addPaatientForm : Form
    {
        //declaring variables to access db
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;

        public addPaatientForm()
        {
            InitializeComponent();
        }

        private void addPaatientForm_Load(object sender, EventArgs e)
        {
            loadDb(dgwDisplayPatients);
        }
        //displaing db to data grid view
        public void loadDb(DataGridView name)
        {
            try
            {
                con.Open();

                string sqlString = @"SELECT * FROM ClientTable";

                cmd = new SqlCommand(sqlString, con);
                ad = new SqlDataAdapter();
                ds = new DataSet();

                ad.SelectCommand = cmd;
                ad.Fill(ds, "ClientTable");

                  name.DataSource = ds; 
                name.DataMember = "ClientTable";
               
                con.Close();
            }
            //exception handeling
            catch (SqlException sqle) 
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
        private void btnAppPatientAPP_Click(object sender, EventArgs e)
        {
            //validating input
            if (tbNameAPP.Text == string.Empty || tbSurnameAPP.Text == string.Empty || tbRsaIdAPP.Text == string.Empty || tbEmailAPP.Text == string.Empty || tbPasswordAPP.Text == string.Empty || tbEmergencyContactAPP.Text == string.Empty || tbContactNumAPP.Text == string.Empty || tbAllergiesAPP.Text == string.Empty )
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }


            try
            {
                con.Open();

                string sqlString = @"INSERT INTO ClientTable(Name, Surname, [Patient RSA ID ], [Contact Number], [E-mail], [Password], [Allergies], [Emergency Contact]) 
                                    VALUES (@name, @surname, @rsaId, @num, @email, @password, @allergies, @emergencyContact)";

                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@name", tbNameAPP.Text);
                cmd.Parameters.AddWithValue("@surname", tbSurnameAPP.Text);
                cmd.Parameters.AddWithValue("@rsaId", tbRsaIdAPP.Text);
                cmd.Parameters.AddWithValue("@num", tbContactNumAPP.Text);
                cmd.Parameters.AddWithValue("@email", tbEmailAPP.Text);
                cmd.Parameters.AddWithValue("@password", tbPasswordAPP.Text);
                cmd.Parameters.AddWithValue("@allergies", tbAllergiesAPP.Text);
                cmd.Parameters.AddWithValue("@emergencyContact", tbEmergencyContactAPP.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                loadDb(dgwDisplayPatients);

                MessageBox.Show("Patient successfully added to the system.");
            }
            //exception handeling
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
    }
}
