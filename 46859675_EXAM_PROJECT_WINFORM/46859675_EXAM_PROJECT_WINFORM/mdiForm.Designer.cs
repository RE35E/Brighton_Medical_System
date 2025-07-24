namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class mdiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAppointmentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAppointmentsToolStripMenuItem,
            this.addAppointmentsToolStripMenuItem,
            this.moveAppointmentsToolStripMenuItem,
            this.cancelAppointmentsToolStripMenuItem,
            this.changeAppointmentStatusToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.viewAppointmentsToolStripMenuItem.Text = "View Appointments";
            this.viewAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.viewAppointmentsToolStripMenuItem_Click);
            // 
            // addAppointmentsToolStripMenuItem
            // 
            this.addAppointmentsToolStripMenuItem.Name = "addAppointmentsToolStripMenuItem";
            this.addAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.addAppointmentsToolStripMenuItem.Text = "Add Appointments";
            this.addAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentsToolStripMenuItem_Click);
            // 
            // moveAppointmentsToolStripMenuItem
            // 
            this.moveAppointmentsToolStripMenuItem.Name = "moveAppointmentsToolStripMenuItem";
            this.moveAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.moveAppointmentsToolStripMenuItem.Text = "Move Appointments";
            this.moveAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.moveAppointmentsToolStripMenuItem_Click);
            // 
            // cancelAppointmentsToolStripMenuItem
            // 
            this.cancelAppointmentsToolStripMenuItem.Name = "cancelAppointmentsToolStripMenuItem";
            this.cancelAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.cancelAppointmentsToolStripMenuItem.Text = "Remove Appointments";
            this.cancelAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentsToolStripMenuItem_Click);
            // 
            // changeAppointmentStatusToolStripMenuItem
            // 
            this.changeAppointmentStatusToolStripMenuItem.Name = "changeAppointmentStatusToolStripMenuItem";
            this.changeAppointmentStatusToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.changeAppointmentStatusToolStripMenuItem.Text = "Change Appointment Status";
            this.changeAppointmentStatusToolStripMenuItem.Click += new System.EventHandler(this.changeAppointmentStatusToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateInvoiceToolStripMenuItem,
            this.addPatientToSystemToolStripMenuItem});
            this.invoicesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.invoicesToolStripMenuItem.Text = "Patients";
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Quotation";
            this.generateInvoiceToolStripMenuItem.Click += new System.EventHandler(this.generateInvoiceToolStripMenuItem_Click);
            // 
            // addPatientToSystemToolStripMenuItem
            // 
            this.addPatientToSystemToolStripMenuItem.Name = "addPatientToSystemToolStripMenuItem";
            this.addPatientToSystemToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addPatientToSystemToolStripMenuItem.Text = "Add Patient To System";
            this.addPatientToSystemToolStripMenuItem.Click += new System.EventHandler(this.addPatientToSystemToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdiForm";
            this.Text = "Brighton Medical Windows Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAppointmentStatusToolStripMenuItem;
    }
}