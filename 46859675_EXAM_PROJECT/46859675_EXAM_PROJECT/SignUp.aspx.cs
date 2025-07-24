//Reese van der Linde
//446859675

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace _46859675_EXAM_PROJECT
{
    public partial class SignUp : System.Web.UI.Page
    {
        //creating public varables to connect to db
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUpSU_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                //adding patient to the db
                con.Open();

                string sqlString = @"INSERT INTO ClientTable(Name, Surname, [Patient RSA ID ],[Contact Number], [E-mail], Password, Allergies, [Emergency Contact]) VALUES (@name, @surname, @patientIDnum, @contectNum, @email, @password, @allergies, @Emergency)";

                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@name", tbNameSU.Text);
                cmd.Parameters.AddWithValue("@surname", tbSurnameSU.Text);
                cmd.Parameters.AddWithValue("@contectNum", tbContactSU.Text);
                cmd.Parameters.AddWithValue("@email", tbEmailSU.Text);
                cmd.Parameters.AddWithValue("@password", tbPasswordSU.Text);
                cmd.Parameters.AddWithValue("@allergies", tbAllergiesSU.Text);
                cmd.Parameters.AddWithValue("@Emergency", tbEmergencyContactSU.Text);
                cmd.Parameters.AddWithValue("@patientIDnum", tbIDNumSUP.Text);


                cmd.ExecuteNonQuery();

                con.Close();

                //clearing all fields
                tbNameSU.Text = "";
                tbSurnameSU.Text = "";
                tbContactSU.Text = "";
                tbEmailSU.Text = "";
                tbPasswordSU.Text = "";
                tbAllergiesSU.Text = "";
                tbEmergencyContactSU.Text = "";
                tbIDNumSUP.Text = "";

                //redirecting to sign up page
                Response.Redirect("signIn.aspx");
            }
            //exception handeling
            catch(SqlException sqle)
            {
                lblErrorSUP.Text = "Error: " + sqle.Message;
            }
        }

        //redirecting to sign in page
        protected void btnSignInSUP_Click(object sender, EventArgs e)
        {
            Response.Redirect("signIn.aspx");
        }

        //redirecting to landing page
        protected void btnHomeSUP_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}