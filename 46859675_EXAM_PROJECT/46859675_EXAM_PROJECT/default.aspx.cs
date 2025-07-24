//Reese van der Linde
//446859675

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _46859675_EXAM_PROJECT
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //populating about us field
                lblInfographicLP.Text = "Brighton Medical is a reputable medical practice dedicated to providing top-notch healthcare services to its patients." +
                                " As a trusted healthcare provider, Brighton Medical offers a wide range of medical procedures and services tailored to meet the diverse needs of its clientele." +
                                " From routine check-ups to urgent medical consultations, Brighton Medical ensures that patients receive the highest standard of care at every visit." +
                                " With a team of highly skilled doctors and medical professionals, Brighton Medical is committed to delivering innovative solutions and personalized treatment plans to improve patient outcomes." +
                                " Through their desktop and web applications, Brighton Medical aims to streamline the appointment booking process, empower patients to manage their healthcare journey effectively, and enhance overall patient satisfaction." +
                                " With a focus on excellence and innovation, Brighton Medical is dedicated to making a positive impact on the health and well-being of their community.";
                
                //populating serves offered fields
                tbServiceOneLP.Text = "Surgical Appoinments";
                tbServiceTwoLP.Text = "Laboratory / Medical Result Analysis";
                tbServiceThreeLP.Text = "Routine Check-Up";
                tbServiceFourLP.Text = "Urgent Medical Check-Up";

                //populating news fields
                tbNewsOneLp.Text = "Telehealth Services Now Available";
                tbNewsTwoLP.Text = "Health Education Webinars";
                tbNewsThreeLP.Text = "Welcome New Doctors";
                tbNewsFourLP.Text = "Introducing Patient Portal";
            }
            
        }

        //redirecting to sign up page
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        //redirecting to sign in page
        protected void btnSignInLP_Click(object sender, EventArgs e)
        {
            Response.Redirect("signIn.aspx");
        }


    }
}