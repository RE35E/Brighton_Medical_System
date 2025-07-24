namespace _46859675_EXAM_PROJECT_WINFORM
{
    partial class Form1
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
            this.lblEmailSIP = new System.Windows.Forms.Label();
            this.lblPasswordSIP = new System.Windows.Forms.Label();
            this.tbEmailSIP = new System.Windows.Forms.TextBox();
            this.tbPasswordSIP = new System.Windows.Forms.TextBox();
            this.btnSignInSIP = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmailSIP
            // 
            this.lblEmailSIP.AutoSize = true;
            this.lblEmailSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblEmailSIP.Location = new System.Drawing.Point(324, 257);
            this.lblEmailSIP.Name = "lblEmailSIP";
            this.lblEmailSIP.Size = new System.Drawing.Size(44, 16);
            this.lblEmailSIP.TabIndex = 0;
            this.lblEmailSIP.Text = "Email:";
            // 
            // lblPasswordSIP
            // 
            this.lblPasswordSIP.AutoSize = true;
            this.lblPasswordSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblPasswordSIP.Location = new System.Drawing.Point(324, 402);
            this.lblPasswordSIP.Name = "lblPasswordSIP";
            this.lblPasswordSIP.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordSIP.TabIndex = 1;
            this.lblPasswordSIP.Text = "Password:";
            // 
            // tbEmailSIP
            // 
            this.tbEmailSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbEmailSIP.Location = new System.Drawing.Point(481, 257);
            this.tbEmailSIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmailSIP.Name = "tbEmailSIP";
            this.tbEmailSIP.Size = new System.Drawing.Size(747, 22);
            this.tbEmailSIP.TabIndex = 1;
            // 
            // tbPasswordSIP
            // 
            this.tbPasswordSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbPasswordSIP.Location = new System.Drawing.Point(481, 399);
            this.tbPasswordSIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPasswordSIP.Name = "tbPasswordSIP";
            this.tbPasswordSIP.Size = new System.Drawing.Size(747, 22);
            this.tbPasswordSIP.TabIndex = 2;
            // 
            // btnSignInSIP
            // 
            this.btnSignInSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnSignInSIP.Location = new System.Drawing.Point(324, 495);
            this.btnSignInSIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignInSIP.Name = "btnSignInSIP";
            this.btnSignInSIP.Size = new System.Drawing.Size(904, 96);
            this.btnSignInSIP.TabIndex = 3;
            this.btnSignInSIP.Text = "&Sign In";
            this.btnSignInSIP.UseVisualStyleBackColor = true;
            this.btnSignInSIP.Click += new System.EventHandler(this.btnSignInSIP_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::_46859675_EXAM_PROJECT_WINFORM.Properties.Resources.logoBrightonMedical;
            this.pbLogo.Location = new System.Drawing.Point(567, 69);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(418, 94);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 633);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnSignInSIP);
            this.Controls.Add(this.tbPasswordSIP);
            this.Controls.Add(this.tbEmailSIP);
            this.Controls.Add(this.lblPasswordSIP);
            this.Controls.Add(this.lblEmailSIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sign In Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailSIP;
        private System.Windows.Forms.Label lblPasswordSIP;
        private System.Windows.Forms.TextBox tbEmailSIP;
        private System.Windows.Forms.TextBox tbPasswordSIP;
        private System.Windows.Forms.Button btnSignInSIP;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

