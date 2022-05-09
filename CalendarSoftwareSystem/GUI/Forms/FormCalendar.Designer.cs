
namespace CalendarSoftwareSystem
{
    partial class FormCalendar
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.lblLogUser = new System.Windows.Forms.Label();
            this.btnLogLogin = new System.Windows.Forms.Button();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.tBoxLogPass = new System.Windows.Forms.TextBox();
            this.tBoxLogUser = new System.Windows.Forms.TextBox();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCalLogOut = new System.Windows.Forms.Button();
            this.btnCalPrevious = new System.Windows.Forms.Button();
            this.btnCalNext = new System.Windows.Forms.Button();
            this.flPanelMonth = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCalendarSaturday = new System.Windows.Forms.Label();
            this.labelCalendarFriday = new System.Windows.Forms.Label();
            this.labelCalendarThursday = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.labelCalendarWednesday = new System.Windows.Forms.Label();
            this.labelCalendarTuesday = new System.Windows.Forms.Label();
            this.labelCalendarMonday = new System.Windows.Forms.Label();
            this.labelCalendarSunday = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panelLogin.Controls.Add(this.lblLogPass);
            this.panelLogin.Controls.Add(this.lblLogUser);
            this.panelLogin.Controls.Add(this.btnLogLogin);
            this.panelLogin.Controls.Add(this.lblLogTitle);
            this.panelLogin.Controls.Add(this.tBoxLogPass);
            this.panelLogin.Controls.Add(this.tBoxLogUser);
            this.panelLogin.Location = new System.Drawing.Point(-1, -1);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1267, 681);
            this.panelLogin.TabIndex = 0;
            // 
            // lblLogPass
            // 
            this.lblLogPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogPass.AutoSize = true;
            this.lblLogPass.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.lblLogPass.Location = new System.Drawing.Point(364, 323);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new System.Drawing.Size(146, 32);
            this.lblLogPass.TabIndex = 8;
            this.lblLogPass.Text = "Password:";
            // 
            // lblLogUser
            // 
            this.lblLogUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogUser.AutoSize = true;
            this.lblLogUser.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.lblLogUser.Location = new System.Drawing.Point(355, 253);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(155, 32);
            this.lblLogUser.TabIndex = 8;
            this.lblLogUser.Text = "Username:";
            // 
            // btnLogLogin
            // 
            this.btnLogLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btnLogLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogLogin.FlatAppearance.BorderSize = 0;
            this.btnLogLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogLogin.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.btnLogLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnLogLogin.Location = new System.Drawing.Point(562, 407);
            this.btnLogLogin.Name = "btnLogLogin";
            this.btnLogLogin.Size = new System.Drawing.Size(142, 53);
            this.btnLogLogin.TabIndex = 7;
            this.btnLogLogin.Text = "Log in";
            this.btnLogLogin.UseVisualStyleBackColor = false;
            this.btnLogLogin.Click += new System.EventHandler(this.btnLogLogin_Click);
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold);
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.lblLogTitle.Location = new System.Drawing.Point(464, 52);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(338, 160);
            this.lblLogTitle.TabIndex = 6;
            this.lblLogTitle.Text = "Business\r\nCalendar";
            this.lblLogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxLogPass
            // 
            this.tBoxLogPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.tBoxLogPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLogPass.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.tBoxLogPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.tBoxLogPass.Location = new System.Drawing.Point(516, 323);
            this.tBoxLogPass.MaxLength = 50;
            this.tBoxLogPass.Name = "tBoxLogPass";
            this.tBoxLogPass.Size = new System.Drawing.Size(329, 40);
            this.tBoxLogPass.TabIndex = 1;
            // 
            // tBoxLogUser
            // 
            this.tBoxLogUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.tBoxLogUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLogUser.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.tBoxLogUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.tBoxLogUser.Location = new System.Drawing.Point(516, 253);
            this.tBoxLogUser.MaxLength = 50;
            this.tBoxLogUser.Name = "tBoxLogUser";
            this.tBoxLogUser.Size = new System.Drawing.Size(329, 40);
            this.tBoxLogUser.TabIndex = 0;
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panelCalendar.Controls.Add(this.lblYear);
            this.panelCalendar.Controls.Add(this.btnCalLogOut);
            this.panelCalendar.Controls.Add(this.btnCalPrevious);
            this.panelCalendar.Controls.Add(this.btnCalNext);
            this.panelCalendar.Controls.Add(this.flPanelMonth);
            this.panelCalendar.Controls.Add(this.labelCalendarSaturday);
            this.panelCalendar.Controls.Add(this.labelCalendarFriday);
            this.panelCalendar.Controls.Add(this.labelCalendarThursday);
            this.panelCalendar.Controls.Add(this.lblMonth);
            this.panelCalendar.Controls.Add(this.labelCalendarWednesday);
            this.panelCalendar.Controls.Add(this.labelCalendarTuesday);
            this.panelCalendar.Controls.Add(this.labelCalendarMonday);
            this.panelCalendar.Controls.Add(this.labelCalendarSunday);
            this.panelCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelCalendar.Location = new System.Drawing.Point(-1, -1);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(1267, 681);
            this.panelCalendar.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.lblYear.Location = new System.Drawing.Point(1050, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(119, 47);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "YEAR";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalLogOut
            // 
            this.btnCalLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btnCalLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalLogOut.FlatAppearance.BorderSize = 0;
            this.btnCalLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalLogOut.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnCalLogOut.Location = new System.Drawing.Point(13, 598);
            this.btnCalLogOut.Name = "btnCalLogOut";
            this.btnCalLogOut.Size = new System.Drawing.Size(75, 64);
            this.btnCalLogOut.TabIndex = 4;
            this.btnCalLogOut.Text = "Log Out";
            this.btnCalLogOut.UseVisualStyleBackColor = false;
            this.btnCalLogOut.Click += new System.EventHandler(this.btnCalLogOut_Click);
            // 
            // btnCalPrevious
            // 
            this.btnCalPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btnCalPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalPrevious.FlatAppearance.BorderSize = 0;
            this.btnCalPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalPrevious.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnCalPrevious.Location = new System.Drawing.Point(1178, 598);
            this.btnCalPrevious.Name = "btnCalPrevious";
            this.btnCalPrevious.Size = new System.Drawing.Size(75, 29);
            this.btnCalPrevious.TabIndex = 3;
            this.btnCalPrevious.Text = "Previous";
            this.btnCalPrevious.UseVisualStyleBackColor = false;
            this.btnCalPrevious.Click += new System.EventHandler(this.btnCalPrevious_Click);
            // 
            // btnCalNext
            // 
            this.btnCalNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btnCalNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalNext.FlatAppearance.BorderSize = 0;
            this.btnCalNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalNext.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnCalNext.Location = new System.Drawing.Point(1178, 633);
            this.btnCalNext.Name = "btnCalNext";
            this.btnCalNext.Size = new System.Drawing.Size(75, 29);
            this.btnCalNext.TabIndex = 2;
            this.btnCalNext.Text = "Next";
            this.btnCalNext.UseVisualStyleBackColor = false;
            this.btnCalNext.Click += new System.EventHandler(this.btnCalNext_Click);
            // 
            // flPanelMonth
            // 
            this.flPanelMonth.Location = new System.Drawing.Point(106, 86);
            this.flPanelMonth.Name = "flPanelMonth";
            this.flPanelMonth.Size = new System.Drawing.Size(1063, 576);
            this.flPanelMonth.TabIndex = 1;
            // 
            // labelCalendarSaturday
            // 
            this.labelCalendarSaturday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarSaturday.AutoSize = true;
            this.labelCalendarSaturday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarSaturday.Location = new System.Drawing.Point(1029, 52);
            this.labelCalendarSaturday.Name = "labelCalendarSaturday";
            this.labelCalendarSaturday.Size = new System.Drawing.Size(115, 28);
            this.labelCalendarSaturday.TabIndex = 0;
            this.labelCalendarSaturday.Text = "Saturday";
            // 
            // labelCalendarFriday
            // 
            this.labelCalendarFriday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarFriday.AutoSize = true;
            this.labelCalendarFriday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarFriday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarFriday.Location = new System.Drawing.Point(894, 52);
            this.labelCalendarFriday.Name = "labelCalendarFriday";
            this.labelCalendarFriday.Size = new System.Drawing.Size(84, 28);
            this.labelCalendarFriday.TabIndex = 0;
            this.labelCalendarFriday.Text = "Friday";
            // 
            // labelCalendarThursday
            // 
            this.labelCalendarThursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarThursday.AutoSize = true;
            this.labelCalendarThursday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarThursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarThursday.Location = new System.Drawing.Point(730, 52);
            this.labelCalendarThursday.Name = "labelCalendarThursday";
            this.labelCalendarThursday.Size = new System.Drawing.Size(115, 28);
            this.labelCalendarThursday.TabIndex = 0;
            this.labelCalendarThursday.Text = "Thursday";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.lblMonth.Location = new System.Drawing.Point(98, 5);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(164, 47);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "MONTH";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCalendarWednesday
            // 
            this.labelCalendarWednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarWednesday.AutoSize = true;
            this.labelCalendarWednesday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarWednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarWednesday.Location = new System.Drawing.Point(557, 52);
            this.labelCalendarWednesday.Name = "labelCalendarWednesday";
            this.labelCalendarWednesday.Size = new System.Drawing.Size(151, 28);
            this.labelCalendarWednesday.TabIndex = 0;
            this.labelCalendarWednesday.Text = "Wednesday";
            // 
            // labelCalendarTuesday
            // 
            this.labelCalendarTuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarTuesday.AutoSize = true;
            this.labelCalendarTuesday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarTuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarTuesday.Location = new System.Drawing.Point(429, 52);
            this.labelCalendarTuesday.Name = "labelCalendarTuesday";
            this.labelCalendarTuesday.Size = new System.Drawing.Size(108, 28);
            this.labelCalendarTuesday.TabIndex = 0;
            this.labelCalendarTuesday.Text = "Tuesday";
            // 
            // labelCalendarMonday
            // 
            this.labelCalendarMonday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarMonday.AutoSize = true;
            this.labelCalendarMonday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarMonday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarMonday.Location = new System.Drawing.Point(282, 52);
            this.labelCalendarMonday.Name = "labelCalendarMonday";
            this.labelCalendarMonday.Size = new System.Drawing.Size(109, 28);
            this.labelCalendarMonday.TabIndex = 0;
            this.labelCalendarMonday.Text = "Monday";
            // 
            // labelCalendarSunday
            // 
            this.labelCalendarSunday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalendarSunday.AutoSize = true;
            this.labelCalendarSunday.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelCalendarSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(142)))), ((int)(((byte)(204)))));
            this.labelCalendarSunday.Location = new System.Drawing.Point(136, 52);
            this.labelCalendarSunday.Name = "labelCalendarSunday";
            this.labelCalendarSunday.Size = new System.Drawing.Size(98, 28);
            this.labelCalendarSunday.TabIndex = 0;
            this.labelCalendarSunday.Text = "Sunday";
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCalendar.ResumeLayout(false);
            this.panelCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox tBoxLogPass;
        private System.Windows.Forms.TextBox tBoxLogUser;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.FlowLayoutPanel flPanelMonth;
        private System.Windows.Forms.Label labelCalendarSunday;
        private System.Windows.Forms.Label labelCalendarSaturday;
        private System.Windows.Forms.Label labelCalendarFriday;
        private System.Windows.Forms.Label labelCalendarThursday;
        private System.Windows.Forms.Label labelCalendarWednesday;
        private System.Windows.Forms.Label labelCalendarTuesday;
        private System.Windows.Forms.Label labelCalendarMonday;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnCalPrevious;
        private System.Windows.Forms.Button btnCalNext;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.Button btnLogLogin;
        private System.Windows.Forms.Label lblLogPass;
        private System.Windows.Forms.Label lblLogUser;
        private System.Windows.Forms.Button btnCalLogOut;
        private System.Windows.Forms.Label lblYear;
    }
}

