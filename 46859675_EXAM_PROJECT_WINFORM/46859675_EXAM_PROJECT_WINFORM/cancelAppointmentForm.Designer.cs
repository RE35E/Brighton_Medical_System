namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class cancelAppointmentForm
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
            this.dgwDisplayAppointmentsCAF = new System.Windows.Forms.DataGridView();
            this.lblIdCAF = new System.Windows.Forms.Label();
            this.buttCancelAppointmentCAF = new System.Windows.Forms.Button();
            this.tbAppointmentIDCAF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayAppointmentsCAF)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDisplayAppointmentsCAF
            // 
            this.dgwDisplayAppointmentsCAF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplayAppointmentsCAF.Location = new System.Drawing.Point(8, 8);
            this.dgwDisplayAppointmentsCAF.Name = "dgwDisplayAppointmentsCAF";
            this.dgwDisplayAppointmentsCAF.RowHeadersWidth = 51;
            this.dgwDisplayAppointmentsCAF.RowTemplate.Height = 24;
            this.dgwDisplayAppointmentsCAF.Size = new System.Drawing.Size(1289, 410);
            this.dgwDisplayAppointmentsCAF.TabIndex = 0;
            // 
            // lblIdCAF
            // 
            this.lblIdCAF.AutoSize = true;
            this.lblIdCAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdCAF.Location = new System.Drawing.Point(24, 451);
            this.lblIdCAF.Name = "lblIdCAF";
            this.lblIdCAF.Size = new System.Drawing.Size(101, 16);
            this.lblIdCAF.TabIndex = 1;
            this.lblIdCAF.Text = "Appointment ID:";
            // 
            // buttCancelAppointmentCAF
            // 
            this.buttCancelAppointmentCAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttCancelAppointmentCAF.Location = new System.Drawing.Point(25, 496);
            this.buttCancelAppointmentCAF.Name = "buttCancelAppointmentCAF";
            this.buttCancelAppointmentCAF.Size = new System.Drawing.Size(410, 82);
            this.buttCancelAppointmentCAF.TabIndex = 2;
            this.buttCancelAppointmentCAF.Text = "&Remove Appointment";
            this.buttCancelAppointmentCAF.UseVisualStyleBackColor = true;
            this.buttCancelAppointmentCAF.Click += new System.EventHandler(this.buttCancelAppointmentCAF_Click);
            // 
            // tbAppointmentIDCAF
            // 
            this.tbAppointmentIDCAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbAppointmentIDCAF.Location = new System.Drawing.Point(131, 448);
            this.tbAppointmentIDCAF.Name = "tbAppointmentIDCAF";
            this.tbAppointmentIDCAF.Size = new System.Drawing.Size(304, 22);
            this.tbAppointmentIDCAF.TabIndex = 3;
            this.tbAppointmentIDCAF.TextChanged += new System.EventHandler(this.tbAppointmentIDCAF_TextChanged);
            // 
            // cancelAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 590);
            this.Controls.Add(this.tbAppointmentIDCAF);
            this.Controls.Add(this.buttCancelAppointmentCAF);
            this.Controls.Add(this.lblIdCAF);
            this.Controls.Add(this.dgwDisplayAppointmentsCAF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "cancelAppointmentForm";
            this.Text = "Cancel Appointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cancelAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayAppointmentsCAF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDisplayAppointmentsCAF;
        private System.Windows.Forms.Label lblIdCAF;
        private System.Windows.Forms.Button buttCancelAppointmentCAF;
        private System.Windows.Forms.TextBox tbAppointmentIDCAF;
    }
}