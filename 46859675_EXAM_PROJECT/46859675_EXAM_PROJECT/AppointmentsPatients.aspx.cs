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
using System.Diagnostics;
using System.Web.Services.Description;
using System.Web.WebSockets;

namespace _46859675_EXAM_PROJECT
{
    public partial class AppointmentsPatients : System.Web.UI.Page
    {
        //creating variables to access db
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter ad;
        public DataSet ds;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BrightonMedical.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            //populating requierd fields
            if (!IsPostBack)
            {
                populateDdlServices(ddlServicesAPP);
                populateDdlTime(ddlTimeAPP);
                populateDdlTime(ddlMoveTimeAPP);
                populateDdlDoctor(ddlDoctorApp);
                myCalMakeAppointmentsAPP.SelectedDate = DateTime.Today.Date;
                myCalMakeMoveAppointmentsAPP.SelectedDate = DateTime.Today.Date;
            }



            //displaying db in grid view
            displayAppointments();

            //requesting cookie
            HttpCookie theCookie = Request.Cookies["UserDetails"];
            if (theCookie != null)
            {
                lblHeadingAPP.Text = "Hello " + theCookie["name"] + " " + theCookie["surname"];
            }
            //validating cookie
            else
            {
                lblErrorAPP.Text = "Error: cookies expire";
            }
            

        }

        //populating drop down list
        public void populateDdlServices(DropDownList name)
        {
            name.Items.Add("Surgical Appointment");
            name.Items.Add("Labratory / Medical Result Analysis");
            name.Items.Add("Routine Check-Up");
            name.Items.Add("Urgent Medical Check-Up");
        }

        //populating drop down list
        public void populateDdlDoctor(DropDownList name)
        {
            name.Items.Add("Piere Marais");
            name.Items.Add("Emily Johnson");
            name.Items.Add("Michael Smith");
            name.Items.Add("Olivia Martinez");
            name.Items.Add("William Brown");
        }

        //populating drop down list
        public void populateDdlTime(DropDownList name)
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

        //setting calander selected date
        protected void myCalMakeAppointmentsAPP_SelectionChanged(object sender, EventArgs e)
        {
            DateTime theDate = myCalMakeAppointmentsAPP.SelectedDate;
            lblDateSelectedAPP.Text = theDate.ToString("dd-MMM-yyyy");
        }

        protected void btnMakeAppointmentAPP_Click(object sender, EventArgs e)
        {
            //initilsing variable
            decimal fee = 0.0m;
            con = new SqlConnection(conString);
            HttpCookie theCookie = Request.Cookies["UserDetails"];
            DateTime theDate = myCalMakeAppointmentsAPP.SelectedDate;
            try
            {
                con.Open();
                string sqlString = @"INSERT INTO AppointmentsTable([Patient Name], [Parient Surname], [Patient Rsa ID], [Doctor Name], [Doctor Surname], 
                Date, Time, Services,Fee, Status) VALUES (@pname, @psurname, @rsaId, @dname, @dsurname, @date, @time, @service, @fee, @status)";
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@pname", theCookie["name"].ToString());
                cmd.Parameters.AddWithValue("@psurname", theCookie["surname"].ToString());
                cmd.Parameters.AddWithValue("@rsaId", theCookie["rsaId"].ToString());

                string[] doctorNamePart = ddlDoctorApp.SelectedItem.ToString().Split(' ');
                
                cmd.Parameters.AddWithValue("@dname", doctorNamePart[0]);
                cmd.Parameters.AddWithValue("@dsurname", doctorNamePart[1]);
                cmd.Parameters.AddWithValue("@date", theDate.ToString("dd-MMM-yyyy"));
                cmd.Parameters.AddWithValue("@time", ddlTimeAPP.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@service", ddlServicesAPP.SelectedItem.ToString());

                fee = calcFee(ddlServicesAPP.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@status", "Scheduled");
                
                cmd.ExecuteNonQuery();
                con.Close();
                displayAppointments();
            }
            //exception handeling
            catch (SqlException sqle)
            {
                lblErrorAPP.Text = ("Error: " + sqle.Message);
            }
        }

        //calculaiting fee based on service
        public decimal calcFee(String service)
        {
            decimal fee = 0.0m;
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


        //displaying all patient appointments
        public void displayAppointments()
        {
            HttpCookie theCookie = Request.Cookies["UserDetails"];
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                string sqlString = @"SELECT * FROM AppointmentsTable WHERE [Patient Rsa ID] = @rsaId";
                cmd = new SqlCommand(sqlString, con);
                cmd.Parameters.AddWithValue("@rsaId", theCookie["rsaId"]);


                ds = new DataSet();
                ad = new SqlDataAdapter();

                ad.SelectCommand = cmd;
                ad.Fill(ds);

                dgwDisplayAppoinmentsAPP.DataSource = ds;
                dgwDisplayAppoinmentsAPP.DataBind();

                con.Close();

            }
            //exception handeling
            catch (SqlException sqle)
            {
                lblErrorAPP.Text = ("Error: " + sqle.Message);
            }

        }

        protected void btnCancelAPP_Click(object sender, EventArgs e)
        {
            //validating input
            if (tbCancelIdAPP.Text != " ")
            {
                con = new SqlConnection(conString);
                try
                {
                    con.Open();
                    string sqlString = @"DELETE FROM AppointmentsTable WHERE AppointmentID = @id";
                    cmd = new SqlCommand(sqlString, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(tbCancelIdAPP.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    tbCancelIdAPP.Text = "";

                    displayAppointments();
                }
                //exception handeling
                catch (SqlException sqle)
                {
                    lblErrorAPP.Text = ("Error: " + sqle.Message);
                }
            }
            else
            {
                lblErrorAPP.Text = "Please enter an appointmet ID to remove";
                return;
            }
        }

        protected void btnMoveAPP_Click(object sender, EventArgs e)
        {
            if (tbAppointmentIDAPP.Text != " " && ddlMoveTimeAPP.SelectedIndex != -1)
            {
                con = new SqlConnection(conString);
                DateTime theDate = myCalMakeMoveAppointmentsAPP.SelectedDate;

                try
                {
                    con.Open();
                    string sqlString = @"UPDATE AppointmentsTable SET Date = @date, Time = @time WHERE AppointmentID = @id";
                    cmd = new SqlCommand(sqlString, con);
                    cmd.Parameters.AddWithValue("@date", theDate.ToString("dd MMMM yyyy"));
                    cmd.Parameters.AddWithValue("@time", ddlMoveTimeAPP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", int.Parse(tbAppointmentIDAPP.Text));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    displayAppointments();
                }
                catch ( SqlException sqle)
                {
                    lblErrorAPP.Text = ("Error: " + sqle.Message);
                }
            }
            else
            {
                lblErrorAPP.Text = "Please fill in all fields to move an appointment";
            }
        }
        
        //setting calander selecred date
        protected void myCalMakeMoveAppointmentsAPP_SelectionChanged(object sender, EventArgs e)
        {
            DateTime theDate = myCalMakeMoveAppointmentsAPP.SelectedDate;
            lblNewMoveDateAPP.Text = theDate.ToString("dd MMMM yyyy");
        }

        //redirecting to home page
        protected void btnHomeAPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePagePatient.aspx");
        }

        //redirecting to service page
        protected void btnServicesAPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServicesPagePatient.aspx");
        }

        //redirecting to account page
        protected void btnAccountAPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountPagePatient.aspx");
        }
    }
}