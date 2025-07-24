namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class invoiceForm
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
            this.dgwDisplayAppointmentsIP = new System.Windows.Forms.DataGridView();
            this.lblAppointmentIdIP = new System.Windows.Forms.Label();
            this.tbAppointmentIdIP = new System.Windows.Forms.TextBox();
            this.btnGenerateQuoteIP = new System.Windows.Forms.Button();
            this.lbDisplayQuoteIP = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayAppointmentsIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDisplayAppointmentsIP
            // 
            this.dgwDisplayAppointmentsIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDisplayAppointmentsIP.Location = new System.Drawing.Point(8, 8);
            this.dgwDisplayAppointmentsIP.Name = "dgwDisplayAppointmentsIP";
            this.dgwDisplayAppointmentsIP.RowHeadersWidth = 51;
            this.dgwDisplayAppointmentsIP.RowTemplate.Height = 24;
            this.dgwDisplayAppointmentsIP.Size = new System.Drawing.Size(1380, 192);
            this.dgwDisplayAppointmentsIP.TabIndex = 0;
            // 
            // lblAppointmentIdIP
            // 
            this.lblAppointmentIdIP.AutoSize = true;
            this.lblAppointmentIdIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblAppointmentIdIP.Location = new System.Drawing.Point(8, 225);
            this.lblAppointmentIdIP.Name = "lblAppointmentIdIP";
            this.lblAppointmentIdIP.Size = new System.Drawing.Size(101, 16);
            this.lblAppointmentIdIP.TabIndex = 1;
            this.lblAppointmentIdIP.Text = "Appointment ID:";
            // 
            // tbAppointmentIdIP
            // 
            this.tbAppointmentIdIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbAppointmentIdIP.Location = new System.Drawing.Point(138, 225);
            this.tbAppointmentIdIP.Name = "tbAppointmentIdIP";
            this.tbAppointmentIdIP.Size = new System.Drawing.Size(218, 22);
            this.tbAppointmentIdIP.TabIndex = 2;
            // 
            // btnGenerateQuoteIP
            // 
            this.btnGenerateQuoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnGenerateQuoteIP.Location = new System.Drawing.Point(8, 264);
            this.btnGenerateQuoteIP.Name = "btnGenerateQuoteIP";
            this.btnGenerateQuoteIP.Size = new System.Drawing.Size(392, 62);
            this.btnGenerateQuoteIP.TabIndex = 3;
            this.btnGenerateQuoteIP.Text = "&Generate Invoice";
            this.btnGenerateQuoteIP.UseVisualStyleBackColor = true;
            this.btnGenerateQuoteIP.Click += new System.EventHandler(this.btnGenerateQuoteIP_Click);
            // 
            // lbDisplayQuoteIP
            // 
            this.lbDisplayQuoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbDisplayQuoteIP.FormattingEnabled = true;
            this.lbDisplayQuoteIP.ItemHeight = 16;
            this.lbDisplayQuoteIP.Location = new System.Drawing.Point(8, 371);
            this.lbDisplayQuoteIP.Name = "lbDisplayQuoteIP";
            this.lbDisplayQuoteIP.Size = new System.Drawing.Size(1382, 180);
            this.lbDisplayQuoteIP.TabIndex = 4;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 556);
            this.Controls.Add(this.lbDisplayQuoteIP);
            this.Controls.Add(this.btnGenerateQuoteIP);
            this.Controls.Add(this.tbAppointmentIdIP);
            this.Controls.Add(this.lblAppointmentIdIP);
            this.Controls.Add(this.dgwDisplayAppointmentsIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "invoiceForm";
            this.Text = "Generate Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.invoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDisplayAppointmentsIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDisplayAppointmentsIP;
        private System.Windows.Forms.Label lblAppointmentIdIP;
        private System.Windows.Forms.TextBox tbAppointmentIdIP;
        private System.Windows.Forms.Button btnGenerateQuoteIP;
        private System.Windows.Forms.ListBox lbDisplayQuoteIP;
    }
}