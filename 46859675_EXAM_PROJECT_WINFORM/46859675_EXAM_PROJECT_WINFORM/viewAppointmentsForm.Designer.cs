namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class viewAppointmentsForm
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
            this.dgwDislpayAppointments = new System.Windows.Forms.DataGridView();
            this.lblSearchPatiientNameVAF = new System.Windows.Forms.Label();
            this.tbPnameVAF = new System.Windows.Forms.TextBox();
            this.lblFilterVAP = new System.Windows.Forms.Label();
            this.cbTimeVAP = new System.Windows.Forms.ComboBox();
            this.lblTimeVAP = new System.Windows.Forms.Label();
            this.lblRemoveFilterVAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDislpayAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDislpayAppointments
            // 
            this.dgwDislpayAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDislpayAppointments.Location = new System.Drawing.Point(8, 8);
            this.dgwDislpayAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDislpayAppointments.Name = "dgwDislpayAppointments";
            this.dgwDislpayAppointments.RowHeadersWidth = 51;
            this.dgwDislpayAppointments.Size = new System.Drawing.Size(1440, 303);
            this.dgwDislpayAppointments.TabIndex = 0;
            // 
            // lblSearchPatiientNameVAF
            // 
            this.lblSearchPatiientNameVAF.AutoSize = true;
            this.lblSearchPatiientNameVAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblSearchPatiientNameVAF.Location = new System.Drawing.Point(5, 382);
            this.lblSearchPatiientNameVAF.Name = "lblSearchPatiientNameVAF";
            this.lblSearchPatiientNameVAF.Size = new System.Drawing.Size(91, 16);
            this.lblSearchPatiientNameVAF.TabIndex = 1;
            this.lblSearchPatiientNameVAF.Text = "Patient Name:";
            // 
            // tbPnameVAF
            // 
            this.tbPnameVAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbPnameVAF.Location = new System.Drawing.Point(101, 382);
            this.tbPnameVAF.Name = "tbPnameVAF";
            this.tbPnameVAF.Size = new System.Drawing.Size(276, 22);
            this.tbPnameVAF.TabIndex = 2;
            this.tbPnameVAF.TextChanged += new System.EventHandler(this.tbPnameVAF_TextChanged);
            // 
            // lblFilterVAP
            // 
            this.lblFilterVAP.AutoSize = true;
            this.lblFilterVAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblFilterVAP.Location = new System.Drawing.Point(5, 339);
            this.lblFilterVAP.Name = "lblFilterVAP";
            this.lblFilterVAP.Size = new System.Drawing.Size(128, 16);
            this.lblFilterVAP.TabIndex = 4;
            this.lblFilterVAP.Text = "Filter Appointmnents";
            // 
            // cbTimeVAP
            // 
            this.cbTimeVAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbTimeVAP.FormattingEnabled = true;
            this.cbTimeVAP.Location = new System.Drawing.Point(101, 429);
            this.cbTimeVAP.Name = "cbTimeVAP";
            this.cbTimeVAP.Size = new System.Drawing.Size(276, 24);
            this.cbTimeVAP.TabIndex = 5;
            this.cbTimeVAP.SelectedIndexChanged += new System.EventHandler(this.cbTimeVAP_SelectedIndexChanged);
            // 
            // lblTimeVAP
            // 
            this.lblTimeVAP.AutoSize = true;
            this.lblTimeVAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblTimeVAP.Location = new System.Drawing.Point(5, 429);
            this.lblTimeVAP.Name = "lblTimeVAP";
            this.lblTimeVAP.Size = new System.Drawing.Size(41, 16);
            this.lblTimeVAP.TabIndex = 6;
            this.lblTimeVAP.Text = "Time:";
            // 
            // lblRemoveFilterVAP
            // 
            this.lblRemoveFilterVAP.AutoSize = true;
            this.lblRemoveFilterVAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblRemoveFilterVAP.Location = new System.Drawing.Point(652, 339);
            this.lblRemoveFilterVAP.Name = "lblRemoveFilterVAP";
            this.lblRemoveFilterVAP.Size = new System.Drawing.Size(91, 16);
            this.lblRemoveFilterVAP.TabIndex = 8;
            this.lblRemoveFilterVAP.Text = "Remove Filter";
            this.lblRemoveFilterVAP.Click += new System.EventHandler(this.lblRemoveFilterVAP_Click);
            // 
            // viewAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 492);
            this.Controls.Add(this.lblRemoveFilterVAP);
            this.Controls.Add(this.lblTimeVAP);
            this.Controls.Add(this.cbTimeVAP);
            this.Controls.Add(this.lblFilterVAP);
            this.Controls.Add(this.tbPnameVAF);
            this.Controls.Add(this.lblSearchPatiientNameVAF);
            this.Controls.Add(this.dgwDislpayAppointments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewAppointmentsForm";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.viewAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDislpayAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDislpayAppointments;
        private System.Windows.Forms.Label lblSearchPatiientNameVAF;
        private System.Windows.Forms.TextBox tbPnameVAF;
        private System.Windows.Forms.Label lblFilterVAP;
        private System.Windows.Forms.ComboBox cbTimeVAP;
        private System.Windows.Forms.Label lblTimeVAP;
        private System.Windows.Forms.Label lblRemoveFilterVAP;
    }
}