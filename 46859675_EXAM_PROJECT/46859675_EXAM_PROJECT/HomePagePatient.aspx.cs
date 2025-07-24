//Reese van der Linde
//446859675

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _46859675_EXAM_PROJECT
{
    public partial class HomePagePatient : System.Web.UI.Page
    {
        //creating public varables to connect to db
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            //requesting cookie
            HttpCookie theCookie = Request.Cookies["UserDetails"];
            if (theCookie != null)
            {
                lblWelcomHPP.Text = "Hello " + theCookie["name"] + " " + theCookie["surname"];
                tbServiceOneHPP.Text = "Surgical Appoinments";
                tbServiceTwoHPP.Text = "Laboratory / Medical Result Analysis";
                tbServiceThreeHPP.Text = "Routine Check-Up";
                tbServiceFourHPP.Text = "Urgent Medical Check-Up";

                tbNewsOneHPP.Text = "Telehealth Services Now Available";
                tbNewsTwoHPP.Text = "Health Education Webinars";
                tbNewsThreeHPP.Text = "Welcome New Doctors";
                tbNewsFourHPP.Text = "Introducing Patient Portal";
            }
            //validating cookie
            else
            {
                lblErrorHPP.Text = "Error: cookies has expired";
            }
            displayDb();
        }

        //displaing data from the db
        public void displayDb()
        {
            //requesting cookie
            HttpCookie theCookie = Request.Cookies["UserDetails"];

            con = new SqlConnection(conString);
            try
            {
                //opening connection
                con.Open();

                string sqlString = @"SELECT [Patient Name], [Parient Surname], [Doctor Name], [Doctor Surname], Date, Time, Services
                             FROM AppointmentsTable 
                             WHERE [Patient Rsa ID] = @rsaId";
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@rsaId", theCookie["rsaId"].ToString());

                ds = new DataSet();
                ad = new SqlDataAdapter();
                ad.SelectCommand = cmd;
                ad.Fill(ds);
                
                //populating grid view
                dgwDisplayAppoinmentsHPP.DataSource = ds;
                dgwDisplayAppoinmentsHPP.DataBind();

                con.Close();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                lblErrorHPP.Text = "Error: " + sqle.Message;
            }
        }

        //redirecting to appointment page
        protected void btnAppointmentsHPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppointmentsPatients.aspx");
        }

        //redirecting to account page
        protected void btnAccountHPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountPagePatient.aspx");
        }

        //redirecting to service page
        protected void btnServicesHPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServicesPagePatient.aspx");
        }
    }
}