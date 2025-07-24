namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class moveAppointmentForm
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
            this.dgwDsiplayAppointmentsMAP = new System.Windows.Forms.DataGridView();
            this.lblNewDateMAP = new System.Windows.Forms.Label();
            this.lblNeTimeMAP = new System.Windows.Forms.Label();
            this.tbneDateMAP = new System.Windows.Forms.TextBox();
            this.cbNewTiimrMAP = new System.Windows.Forms.ComboBox();
            this.btnmoveAppointmentMAP = new System.Windows.Forms.Button();
            this.lblIdMAP = new System.Windows.Forms.Label();
            this.tbIDmoveMAP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDsiplayAppointmentsMAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDsiplayAppointmentsMAP
            // 
            this.dgwDsiplayAppointmentsMAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDsiplayAppointmentsMAP.Location = new System.Drawing.Point(12, 12);
            this.dgwDsiplayAppointmentsMAP.Name = "dgwDsiplayAppointmentsMAP";
            this.dgwDsiplayAppointmentsMAP.RowHeadersWidth = 51;
            this.dgwDsiplayAppointmentsMAP.RowTemplate.Height = 24;
            this.dgwDsiplayAppointmentsMAP.Size = new System.Drawing.Size(1142, 395);
            this.dgwDsiplayAppointmentsMAP.TabIndex = 0;
            // 
            // lblNewDateMAP
            // 
            this.lblNewDateMAP.AutoSize = true;
            this.lblNewDateMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblNewDateMAP.Location = new System.Drawing.Point(5, 489);
            this.lblNewDateMAP.Name = "lblNewDateMAP";
            this.lblNewDateMAP.Size = new System.Drawing.Size(69, 16);
            this.lblNewDateMAP.TabIndex = 1;
            this.lblNewDateMAP.Text = "New Date:";
            // 
            // lblNeTimeMAP
            // 
            this.lblNeTimeMAP.AutoSize = true;
            this.lblNeTimeMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblNeTimeMAP.Location = new System.Drawing.Point(5, 538);
            this.lblNeTimeMAP.Name = "lblNeTimeMAP";
            this.lblNeTimeMAP.Size = new System.Drawing.Size(71, 16);
            this.lblNeTimeMAP.TabIndex = 2;
            this.lblNeTimeMAP.Text = "New Time:";
            // 
            // tbneDateMAP
            // 
            this.tbneDateMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbneDateMAP.Location = new System.Drawing.Point(250, 486);
            this.tbneDateMAP.Name = "tbneDateMAP";
            this.tbneDateMAP.Size = new System.Drawing.Size(350, 22);
            this.tbneDateMAP.TabIndex = 3;
            // 
            // cbNewTiimrMAP
            // 
            this.cbNewTiimrMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbNewTiimrMAP.FormattingEnabled = true;
            this.cbNewTiimrMAP.Location = new System.Drawing.Point(250, 535);
            this.cbNewTiimrMAP.Name = "cbNewTiimrMAP";
            this.cbNewTiimrMAP.Size = new System.Drawing.Size(350, 24);
            this.cbNewTiimrMAP.TabIndex = 4;
            // 
            // btnmoveAppointmentMAP
            // 
            this.btnmoveAppointmentMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnmoveAppointmentMAP.Location = new System.Drawing.Point(633, 440);
            this.btnmoveAppointmentMAP.Name = "btnmoveAppointmentMAP";
            this.btnmoveAppointmentMAP.Size = new System.Drawing.Size(521, 135);
            this.btnmoveAppointmentMAP.TabIndex = 5;
            this.btnmoveAppointmentMAP.Text = "&Move Appointment";
            this.btnmoveAppointmentMAP.UseVisualStyleBackColor = true;
            this.btnmoveAppointmentMAP.Click += new System.EventHandler(this.btnmoveAppointmentMAP_Click);
            // 
            // lblIdMAP
            // 
            this.lblIdMAP.AutoSize = true;
            this.lblIdMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdMAP.Location = new System.Drawing.Point(8, 440);
            this.lblIdMAP.Name = "lblIdMAP";
            this.lblIdMAP.Size = new System.Drawing.Size(101, 16);
            this.lblIdMAP.TabIndex = 6;
            this.lblIdMAP.Text = "Appointment ID:";
            // 
            // tbIDmoveMAP
            // 
            this.tbIDmoveMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbIDmoveMAP.Location = new System.Drawing.Point(250, 437);
            this.tbIDmoveMAP.Name = "tbIDmoveMAP";
            this.tbIDmoveMAP.Size = new System.Drawing.Size(350, 22);
            this.tbIDmoveMAP.TabIndex = 7;
            // 
            // moveAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 602);
            this.Controls.Add(this.tbIDmoveMAP);
            this.Controls.Add(this.lblIdMAP);
            this.Controls.Add(this.btnmoveAppointmentMAP);
            this.Controls.Add(this.cbNewTiimrMAP);
            this.Controls.Add(this.tbneDateMAP);
            this.Controls.Add(this.lblNeTimeMAP);
            this.Controls.Add(this.lblNewDateMAP);
            this.Controls.Add(this.dgwDsiplayAppointmentsMAP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "moveAppointmentForm";
            this.Text = "Move Appointments  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.moveAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDsiplayAppointmentsMAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDsiplayAppointmentsMAP;
        private System.Windows.Forms.Label lblNewDateMAP;
        private System.Windows.Forms.Label lblNeTimeMAP;
        private System.Windows.Forms.TextBox tbneDateMAP;
        private System.Windows.Forms.ComboBox cbNewTiimrMAP;
        private System.Windows.Forms.Button btnmoveAppointmentMAP;
        private System.Windows.Forms.Label lblIdMAP;
        private System.Windows.Forms.TextBox tbIDmoveMAP;
    }
}