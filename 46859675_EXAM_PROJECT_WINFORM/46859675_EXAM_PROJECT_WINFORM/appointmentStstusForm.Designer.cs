namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class appointmentStstusForm
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
            this.dgwAppointmentCAS = new System.Windows.Forms.DataGridView();
            this.lblidCAS = new System.Windows.Forms.Label();
            this.tbAppointmentIDCAS = new System.Windows.Forms.TextBox();
            this.rbScheduledCAS = new System.Windows.Forms.RadioButton();
            this.rbCompletedCAS = new System.Windows.Forms.RadioButton();
            this.rbCanceled = new System.Windows.Forms.RadioButton();
            this.gbStatusAppCAS = new System.Windows.Forms.GroupBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppointmentCAS)).BeginInit();
            this.gbStatusAppCAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAppointmentCAS
            // 
            this.dgwAppointmentCAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAppointmentCAS.Location = new System.Drawing.Point(12, 12);
            this.dgwAppointmentCAS.Name = "dgwAppointmentCAS";
            this.dgwAppointmentCAS.RowHeadersWidth = 51;
            this.dgwAppointmentCAS.RowTemplate.Height = 24;
            this.dgwAppointmentCAS.Size = new System.Drawing.Size(1390, 343);
            this.dgwAppointmentCAS.TabIndex = 0;
            // 
            // lblidCAS
            // 
            this.lblidCAS.AutoSize = true;
            this.lblidCAS.Location = new System.Drawing.Point(12, 383);
            this.lblidCAS.Name = "lblidCAS";
            this.lblidCAS.Size = new System.Drawing.Size(101, 16);
            this.lblidCAS.TabIndex = 1;
            this.lblidCAS.Text = "Appointment ID:";
            // 
            // tbAppointmentIDCAS
            // 
            this.tbAppointmentIDCAS.Location = new System.Drawing.Point(138, 383);
            this.tbAppointmentIDCAS.Name = "tbAppointmentIDCAS";
            this.tbAppointmentIDCAS.Size = new System.Drawing.Size(191, 22);
            this.tbAppointmentIDCAS.TabIndex = 2;
            // 
            // rbScheduledCAS
            // 
            this.rbScheduledCAS.AutoSize = true;
            this.rbScheduledCAS.Location = new System.Drawing.Point(0, 41);
            this.rbScheduledCAS.Name = "rbScheduledCAS";
            this.rbScheduledCAS.Size = new System.Drawing.Size(101, 20);
            this.rbScheduledCAS.TabIndex = 3;
            this.rbScheduledCAS.TabStop = true;
            this.rbScheduledCAS.Text = "Schedueled";
            this.rbScheduledCAS.UseVisualStyleBackColor = true;
            // 
            // rbCompletedCAS
            // 
            this.rbCompletedCAS.AutoSize = true;
            this.rbCompletedCAS.Location = new System.Drawing.Point(152, 41);
            this.rbCompletedCAS.Name = "rbCompletedCAS";
            this.rbCompletedCAS.Size = new System.Drawing.Size(94, 20);
            this.rbCompletedCAS.TabIndex = 4;
            this.rbCompletedCAS.TabStop = true;
            this.rbCompletedCAS.Text = "Completed";
            this.rbCompletedCAS.UseVisualStyleBackColor = true;
            // 
            // rbCanceled
            // 
            this.rbCanceled.AutoSize = true;
            this.rbCanceled.Location = new System.Drawing.Point(297, 41);
            this.rbCanceled.Name = "rbCanceled";
            this.rbCanceled.Size = new System.Drawing.Size(86, 20);
            this.rbCanceled.TabIndex = 5;
            this.rbCanceled.TabStop = true;
            this.rbCanceled.Text = "Canceled";
            this.rbCanceled.UseVisualStyleBackColor = true;
            // 
            // gbStatusAppCAS
            // 
            this.gbStatusAppCAS.Controls.Add(this.rbCanceled);
            this.gbStatusAppCAS.Controls.Add(this.rbCompletedCAS);
            this.gbStatusAppCAS.Controls.Add(this.rbScheduledCAS);
            this.gbStatusAppCAS.Location = new System.Drawing.Point(12, 438);
            this.gbStatusAppCAS.Name = "gbStatusAppCAS";
            this.gbStatusAppCAS.Size = new System.Drawing.Size(417, 100);
            this.gbStatusAppCAS.TabIndex = 6;
            this.gbStatusAppCAS.TabStop = false;
            this.gbStatusAppCAS.Text = "Select status of appointment";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(12, 557);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(414, 57);
            this.btnChangeStatus.TabIndex = 7;
            this.btnChangeStatus.Text = "&Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // appointmentStstusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 626);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.tbAppointmentIDCAS);
            this.Controls.Add(this.lblidCAS);
            this.Controls.Add(this.dgwAppointmentCAS);
            this.Controls.Add(this.gbStatusAppCAS);
            this.Name = "appointmentStstusForm";
            this.Text = "appointmentStstusForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.appointmentStstusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppointmentCAS)).EndInit();
            this.gbStatusAppCAS.ResumeLayout(false);
            this.gbStatusAppCAS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAppointmentCAS;
        private System.Windows.Forms.Label lblidCAS;
        private System.Windows.Forms.TextBox tbAppointmentIDCAS;
        private System.Windows.Forms.RadioButton rbScheduledCAS;
        private System.Windows.Forms.RadioButton rbCompletedCAS;
        private System.Windows.Forms.RadioButton rbCanceled;
        private System.Windows.Forms.GroupBox gbStatusAppCAS;
        private System.Windows.Forms.Button btnChangeStatus;
    }
}