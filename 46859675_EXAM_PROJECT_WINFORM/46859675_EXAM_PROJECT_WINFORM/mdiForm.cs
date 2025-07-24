//Reese van der Linde
//46859675

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46859675_EXAM_PROJECT_WINFORM
{
    public partial class mdiForm : Form
    {
        public mdiForm()
        {
            InitializeComponent();
        }

        private void mdiForm_Load(object sender, EventArgs e)
        {

        }

        private void viewAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAppointmentsForm newViewAppointmentsForm = new viewAppointmentsForm();
            newViewAppointmentsForm.MdiParent = this;
            newViewAppointmentsForm.Show();
        }

        private void addAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAppointmentsForm newAddAppointmentsForm = new addAppointmentsForm();
            newAddAppointmentsForm.MdiParent = this;
            newAddAppointmentsForm.Show();
        }

        private void cancelAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelAppointmentForm newCancelAppointmentForm = new cancelAppointmentForm();
            newCancelAppointmentForm.MdiParent = this;
            newCancelAppointmentForm.Show();
        }

        private void moveAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveAppointmentForm newMoveAppointmentForm = new moveAppointmentForm();
            newMoveAppointmentForm.MdiParent= this;
            newMoveAppointmentForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are closng the program", "Exit Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void generateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoiceForm newInvoiceForm = new invoiceForm();
            newInvoiceForm.MdiParent = this;
            newInvoiceForm.Show();
        }

        private void addPatientToSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPaatientForm newAddPaatientForm = new addPaatientForm();
            newAddPaatientForm.MdiParent = this;
            newAddPaatientForm.Show();
        }

        private void changeAppointmentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointmentStstusForm newAppointmentStstusForm = new appointmentStstusForm();
            newAppointmentStstusForm.MdiParent = this;
            newAppointmentStstusForm.Show();
        }
    }
}
