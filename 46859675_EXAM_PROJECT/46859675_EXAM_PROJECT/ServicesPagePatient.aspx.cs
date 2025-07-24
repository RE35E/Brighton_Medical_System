//Reese van der Linde
//44685967

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _46859675_EXAM_PROJECT
{
    public partial class ServicesPagePatient : System.Web.UI.Page
    {
        //initialising constants
        public const decimal SURGICAL_APPOINTMENT_PRICE = 1500.00m;
        public const decimal LABORTORY_PRICE = 360.00m;
        public const decimal ROUTINE_CHECKUP_PRICE = 500.00m;
        public const decimal URGENT_MEDICAL_CHECKUP_PRICE = 2000.00m;

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnGetQuotation_Click(object sender, EventArgs e)
        {
            //intilazing variables
            int numPeople = 0;
            decimal fee = 0.0m;
            Random random = new Random();
            int randNum = random.Next(1000,10000);

            lbDisplayQuotationSPP.Items.Clear();

            //valdiating input from checkboxes and radio buttons
            if (this.rbOneSPP.Checked != true && this.rbTwoSPP.Checked != true && rbThreeSSP.Checked != true && this.rbFourSPP.Checked != true)
            {
                lblErrorSPP.Text = "Please select number of patients for the quotation.";
                return;
            }

            if(cbLabSPP.Checked != true && cbRoutineCheckUpSSP.Checked != true && cbSugicalAppointmentSPP.Checked != true && cbUrgentSSP.Checked != true)
            {
                lblErrorSPP.Text = "Please select service to add to the quotation.";
                return;
            }


            if (this.rbOneSPP.Checked == true)
            {
                numPeople = 1;
            }
            else if (this.rbTwoSPP.Checked == true)
            {
                numPeople = 2;
            }
            else if (this.rbThreeSSP.Checked == true)
            {
                numPeople = 4;
            }
            else if (this.rbFourSPP.Checked == true)
            {
                numPeople = 4;
            }


            lbDisplayQuotationSPP.Items.Add("------------------------------------------------------------");
            lbDisplayQuotationSPP.Items.Add("INVOICE TICKET NUMBER: T" + randNum.ToString());
            lbDisplayQuotationSPP.Items.Add("------------------------------------------------------------");

            if (cbLabSPP.Checked == true)
            {
                fee += LABORTORY_PRICE;
                lbDisplayQuotationSPP.Items.Add("Laboratory / Medical Result Analysis   --> " + LABORTORY_PRICE.ToString("c") + " per person.");
            }
            if (cbRoutineCheckUpSSP.Checked == true)
            {
                fee += ROUTINE_CHECKUP_PRICE;
                lbDisplayQuotationSPP.Items.Add("Routine Check-Up   --> " + ROUTINE_CHECKUP_PRICE.ToString("c") + " per person.");
            }
            if (cbSugicalAppointmentSPP.Checked == true)
            {
                fee += SURGICAL_APPOINTMENT_PRICE;
                lbDisplayQuotationSPP.Items.Add("Surgical Appointment   --> " + SURGICAL_APPOINTMENT_PRICE.ToString("c") + " per person.");
            }
            if (cbUrgentSSP.Checked == true)
            {
                lbDisplayQuotationSPP.Items.Add("Urgent Medical Check-Up   --> " + URGENT_MEDICAL_CHECKUP_PRICE.ToString("c") + " per person.");
                fee += URGENT_MEDICAL_CHECKUP_PRICE;
            }

            fee *= numPeople;
            Session["fee"] = fee;
            lbDisplayQuotationSPP.Items.Add("");
            lbDisplayQuotationSPP.Items.Add("Your fee for the above specified services for a total of " +  numPeople.ToString() + " people amounts to " + fee.ToString("C")  + ".");


            //clearing all fields
            rbOneSPP.Checked = false;
            rbTwoSPP.Checked = false;
            rbThreeSSP.Checked = false;
            rbFourSPP.Checked = false;
            cbSugicalAppointmentSPP.Checked = false;
            cbLabSPP.Checked = false;
            cbRoutineCheckUpSSP.Checked = false;
            cbUrgentSSP.Checked = false;
            lblErrorSPP.Text = "";
        }

        //redirecting to home page
        protected void btnHomeSPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePagePatient.aspx");
        }

        //redirecting to appointment page
        protected void btnAppointmentSPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppointmentsPatients.aspx");
        }

        //redirecting to account page
        protected void btnAccountSPP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountPagePatient.aspx");
        }
    }
}