//Reese van der Linde
//446859675

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace _46859675_EXAM_PROJECT
{
    public partial class signIn : System.Web.UI.Page
    {
        //creating public varables to connect to db
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //clearing fields
                tbEmailSI.Text = string.Empty;
                tbPasswordSI.Text = string.Empty;
                lblErrorInvalidSIP.Text = string.Empty;
            }
        }
        
        protected void btnSiginIn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conString);

                //opening db
                con.Open();

                string sqlString = "SELECT Name, Surname, [Patient RSA ID], [Contact Number], [E-mail], Password, Allergies, [Emergency Contact] " +
                                   "FROM ClientTable WHERE [E-mail] = @email AND Password = @password";
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@email", tbEmailSI.Text);
                cmd.Parameters.AddWithValue("@password", tbPasswordSI.Text);

                ad = new SqlDataAdapter();
                ds = new DataSet();

                ad.SelectCommand = cmd; 
                ad.Fill(ds);
                   
                //saveing data form db into cookie
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    HttpCookie theCookie = new HttpCookie("UserDetails");
                    theCookie["name"] = row["Name"].ToString();
                    theCookie["surname"] = row["Surname"].ToString();
                    theCookie["rsaId"] = row["Patient RSA ID"].ToString();
                    theCookie["contactNumber"] = row["Contact Number"].ToString();
                    theCookie["email"] = row["E-mail"].ToString();
                    theCookie["password"] = row["Password"].ToString();
                    theCookie["allergies"] = row["Allergies"].ToString();
                    theCookie["emergencyContact"] = row["Emergency Contact"].ToString();

                    theCookie.Expires = DateTime.Now.AddMinutes(10);
                    Response.Cookies.Add(theCookie);
                    Response.Redirect("HomePagePatient.aspx");
                }
                //validating input
                else
                {
                    lblErrorInvalidSIP.Text = "Error: invalid email or pasword entered.";
                }
                //closing db
                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                lblNoAccSi.Text = "Error: " + sqle.Message;
            }
        }

        //redirecting to sign up page
        protected void btnSignUpP_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        //redirecting to landing page
        protected void btnHomeSIP_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        //rerdirecting to sign up page
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
} 