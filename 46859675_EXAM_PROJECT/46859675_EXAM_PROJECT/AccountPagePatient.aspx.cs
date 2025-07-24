//Reese van der Linde
//4468596

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace _46859675_EXAM_PROJECT
{
    public partial class AccountPagePatient : System.Web.UI.Page

    {
        //declaring variables to access db
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
                HttpCookie theCookie = Request.Cookies["UserDetails"];
                if (theCookie != null)
                {
                    lblHeadingACPP.Text = "Hello " + theCookie["name"] + " " + theCookie["surname"] + " to the Account Page";
                }
                //validating cookie
                else
                {
                    lblErrorACP.Text = "Error: cookies has expired";
                }
                tbNameACPP.Text = theCookie["name"];
                tbSurnameACPP.Text = theCookie["surname"];
                tbIdNumACPP.Text = theCookie["rsaId"];
                tbCOntactNumACPP.Text = theCookie["contactNumber"];
                tbEmailACPP.Text = theCookie["email"];
                tbPasswordACPP.Text = theCookie["password"];
                tbAllergiesACPP.Text = theCookie["allergies"];
                tbEmergencyContactACPP.Text = theCookie["emergencyContact"];

                lblHeadingACPP.Text = "Hello " + theCookie["name"].ToString() + " " + theCookie["surname"];
            }
        }

        protected void btnUpdateACPP_Click(object sender, EventArgs e)
        {
            updateCookies();
            HttpCookie theCookie = Request.Cookies["UserDetails"];

            //updating db with new details
            con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sqlString = @"UPDATE ClientTable SET 
                                    [Name] = @name,
                                    [Surname] = @surname,
                                    [Contact Number] = @contactNumber,
                                    [E-mail] = @email,
                                    Password = @password,
                                    Allergies = @allergies,   
                                    [Emergency Contact] = @emergencyContact
                                    WHERE [Patient RSA ID] = @rsaId";
                                    
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@name", tbNameACPP.Text);
                cmd.Parameters.AddWithValue("@surname", tbSurnameACPP.Text);
                cmd.Parameters.AddWithValue("@contactNumber", tbCOntactNumACPP.Text);
                cmd.Parameters.AddWithValue("@email", tbEmailACPP.Text);
                cmd.Parameters.AddWithValue("@password", tbPasswordACPP.Text);
                cmd.Parameters.AddWithValue("@allergies", tbAllergiesACPP.Text);
                cmd.Parameters.AddWithValue("@emergencyContact", tbEmergencyContactACPP.Text);
                cmd.Parameters.AddWithValue("@rsaId", theCookie["rsaId"].ToString());

                cmd.ExecuteNonQuery();
                con.Close();

                lblHeadingACPP.Text = "Your details have been succesfully update";

            }
            //exception handeling
            catch (SqlException sqle) 
            {
                lblErrorACP.Text = "Error: " + sqle.Message;
            }
        }

        //updating cookies with the new patient information
        public void updateCookies()
        {
            HttpCookie theCookie = new HttpCookie("UserDetails");
            theCookie["name"] = tbNameACPP.Text;
            theCookie["surname"] = tbSurnameACPP.Text;
            theCookie["rsaId"] = tbIdNumACPP.Text;
            theCookie["contactNumber"] = tbCOntactNumACPP.Text;
            theCookie["email"] = tbEmailACPP.Text;
            theCookie["password"] = tbPasswordACPP.Text;
            theCookie["allergies"] = tbAllergiesACPP.Text;
            theCookie["emergencyContact"] = tbEmergencyContactACPP.Text;

            theCookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(theCookie);

        }

        //redirecting to home page
        protected void btnHomeACPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePagePatient.aspx");
        }

        //redirecting to appointments page
        protected void btnAppointments_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppointmentsPatients.aspx");
        }

        //redirecting to service page
        protected void btnServicesACPP_Click(object sender, EventArgs e)
        {  
            Response.Redirect("ServicesPagePatient.aspx");
        }

        //redirecting to landing page
        protected void btnLogoutACPP_Click(object sender, EventArgs e)
        {   
            Response.Redirect("default.aspx");
        }
    }
}