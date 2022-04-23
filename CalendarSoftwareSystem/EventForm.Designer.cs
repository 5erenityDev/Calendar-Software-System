
namespace CalendarSoftwareSystem
{
    partial class EventForm
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
            this.tBoxEveName = new System.Windows.Forms.TextBox();
            this.lblEveName = new System.Windows.Forms.Label();
            this.lblEveDesc = new System.Windows.Forms.Label();
            this.lblEveLoc = new System.Windows.Forms.Label();
            this.tBoxEveDesc = new System.Windows.Forms.TextBox();
            this.tBoxEveLoc = new System.Windows.Forms.TextBox();
            this.lblEveStart = new System.Windows.Forms.Label();
            this.btnEveSave = new System.Windows.Forms.Button();
            this.lblEveTitle = new System.Windows.Forms.Label();
            this.tBoxEveStartDate = new System.Windows.Forms.TextBox();
            this.tBoxEveStartTime = new System.Windows.Forms.TextBox();
            this.tBoxEveEndDate = new System.Windows.Forms.TextBox();
            this.tBoxEveEndTime = new System.Windows.Forms.TextBox();
            this.lblEveEnd = new System.Windows.Forms.Label();
            this.lblEveStartDate = new System.Windows.Forms.Label();
            this.lblEveStartTime = new System.Windows.Forms.Label();
            this.lblEveEndDate = new System.Windows.Forms.Label();
            this.lblEveEndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxEveName
            // 
            this.tBoxEveName.Location = new System.Drawing.Point(149, 64);
            this.tBoxEveName.Name = "tBoxEveName";
            this.tBoxEveName.Size = new System.Drawing.Size(639, 20);
            this.tBoxEveName.TabIndex = 0;
            // 
            // lblEveName
            // 
            this.lblEveName.AutoSize = true;
            this.lblEveName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveName.Location = new System.Drawing.Point(12, 65);
            this.lblEveName.Name = "lblEveName";
            this.lblEveName.Size = new System.Drawing.Size(93, 17);
            this.lblEveName.TabIndex = 1;
            this.lblEveName.Text = "Event Name:";
            // 
            // lblEveDesc
            // 
            this.lblEveDesc.AutoSize = true;
            this.lblEveDesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveDesc.Location = new System.Drawing.Point(12, 108);
            this.lblEveDesc.Name = "lblEveDesc";
            this.lblEveDesc.Size = new System.Drawing.Size(127, 17);
            this.lblEveDesc.TabIndex = 1;
            this.lblEveDesc.Text = "Event Description:";
            // 
            // lblEveLoc
            // 
            this.lblEveLoc.AutoSize = true;
            this.lblEveLoc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveLoc.Location = new System.Drawing.Point(12, 279);
            this.lblEveLoc.Name = "lblEveLoc";
            this.lblEveLoc.Size = new System.Drawing.Size(109, 17);
            this.lblEveLoc.TabIndex = 1;
            this.lblEveLoc.Text = "Event Location:";
            // 
            // tBoxEveDesc
            // 
            this.tBoxEveDesc.Location = new System.Drawing.Point(149, 107);
            this.tBoxEveDesc.Multiline = true;
            this.tBoxEveDesc.Name = "tBoxEveDesc";
            this.tBoxEveDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxEveDesc.Size = new System.Drawing.Size(639, 149);
            this.tBoxEveDesc.TabIndex = 0;
            // 
            // tBoxEveLoc
            // 
            this.tBoxEveLoc.Location = new System.Drawing.Point(149, 278);
            this.tBoxEveLoc.Name = "tBoxEveLoc";
            this.tBoxEveLoc.Size = new System.Drawing.Size(639, 20);
            this.tBoxEveLoc.TabIndex = 0;
            // 
            // lblEveStart
            // 
            this.lblEveStart.AutoSize = true;
            this.lblEveStart.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStart.Location = new System.Drawing.Point(64, 334);
            this.lblEveStart.Name = "lblEveStart";
            this.lblEveStart.Size = new System.Drawing.Size(79, 17);
            this.lblEveStart.TabIndex = 1;
            this.lblEveStart.Text = "Event Start:";
            // 
            // btnEveSave
            // 
            this.btnEveSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveSave.FlatAppearance.BorderSize = 0;
            this.btnEveSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveSave.Location = new System.Drawing.Point(713, 409);
            this.btnEveSave.Name = "btnEveSave";
            this.btnEveSave.Size = new System.Drawing.Size(75, 29);
            this.btnEveSave.TabIndex = 3;
            this.btnEveSave.Text = "Save";
            this.btnEveSave.UseVisualStyleBackColor = false;
            this.btnEveSave.Click += new System.EventHandler(this.btnEveSave_Click);
            // 
            // lblEveTitle
            // 
            this.lblEveTitle.AutoSize = true;
            this.lblEveTitle.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblEveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveTitle.Location = new System.Drawing.Point(12, 9);
            this.lblEveTitle.Name = "lblEveTitle";
            this.lblEveTitle.Size = new System.Drawing.Size(148, 47);
            this.lblEveTitle.TabIndex = 1;
            this.lblEveTitle.Text = "EVENT:";
            // 
            // tBoxEveStartDate
            // 
            this.tBoxEveStartDate.Location = new System.Drawing.Point(149, 333);
            this.tBoxEveStartDate.Name = "tBoxEveStartDate";
            this.tBoxEveStartDate.Size = new System.Drawing.Size(129, 20);
            this.tBoxEveStartDate.TabIndex = 0;
            // 
            // tBoxEveStartTime
            // 
            this.tBoxEveStartTime.Location = new System.Drawing.Point(284, 333);
            this.tBoxEveStartTime.Name = "tBoxEveStartTime";
            this.tBoxEveStartTime.Size = new System.Drawing.Size(129, 20);
            this.tBoxEveStartTime.TabIndex = 0;
            // 
            // tBoxEveEndDate
            // 
            this.tBoxEveEndDate.Location = new System.Drawing.Point(524, 333);
            this.tBoxEveEndDate.Name = "tBoxEveEndDate";
            this.tBoxEveEndDate.Size = new System.Drawing.Size(129, 20);
            this.tBoxEveEndDate.TabIndex = 0;
            // 
            // tBoxEveEndTime
            // 
            this.tBoxEveEndTime.Location = new System.Drawing.Point(659, 333);
            this.tBoxEveEndTime.Name = "tBoxEveEndTime";
            this.tBoxEveEndTime.Size = new System.Drawing.Size(129, 20);
            this.tBoxEveEndTime.TabIndex = 0;
            // 
            // lblEveEnd
            // 
            this.lblEveEnd.AutoSize = true;
            this.lblEveEnd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEnd.Location = new System.Drawing.Point(439, 334);
            this.lblEveEnd.Name = "lblEveEnd";
            this.lblEveEnd.Size = new System.Drawing.Size(75, 17);
            this.lblEveEnd.TabIndex = 1;
            this.lblEveEnd.Text = "Event End:";
            // 
            // lblEveStartDate
            // 
            this.lblEveStartDate.AutoSize = true;
            this.lblEveStartDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStartDate.Location = new System.Drawing.Point(192, 313);
            this.lblEveStartDate.Name = "lblEveStartDate";
            this.lblEveStartDate.Size = new System.Drawing.Size(44, 17);
            this.lblEveStartDate.TabIndex = 1;
            this.lblEveStartDate.Text = "Date:";
            // 
            // lblEveStartTime
            // 
            this.lblEveStartTime.AutoSize = true;
            this.lblEveStartTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStartTime.Location = new System.Drawing.Point(327, 313);
            this.lblEveStartTime.Name = "lblEveStartTime";
            this.lblEveStartTime.Size = new System.Drawing.Size(45, 17);
            this.lblEveStartTime.TabIndex = 1;
            this.lblEveStartTime.Text = "Time:";
            // 
            // lblEveEndDate
            // 
            this.lblEveEndDate.AutoSize = true;
            this.lblEveEndDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndDate.Location = new System.Drawing.Point(570, 313);
            this.lblEveEndDate.Name = "lblEveEndDate";
            this.lblEveEndDate.Size = new System.Drawing.Size(44, 17);
            this.lblEveEndDate.TabIndex = 1;
            this.lblEveEndDate.Text = "Date:";
            // 
            // lblEveEndTime
            // 
            this.lblEveEndTime.AutoSize = true;
            this.lblEveEndTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndTime.Location = new System.Drawing.Point(703, 313);
            this.lblEveEndTime.Name = "lblEveEndTime";
            this.lblEveEndTime.Size = new System.Drawing.Size(45, 17);
            this.lblEveEndTime.TabIndex = 1;
            this.lblEveEndTime.Text = "Time:";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEveSave);
            this.Controls.Add(this.lblEveEnd);
            this.Controls.Add(this.lblEveEndTime);
            this.Controls.Add(this.lblEveEndDate);
            this.Controls.Add(this.lblEveStartTime);
            this.Controls.Add(this.lblEveStartDate);
            this.Controls.Add(this.lblEveStart);
            this.Controls.Add(this.lblEveLoc);
            this.Controls.Add(this.lblEveDesc);
            this.Controls.Add(this.lblEveTitle);
            this.Controls.Add(this.lblEveName);
            this.Controls.Add(this.tBoxEveEndTime);
            this.Controls.Add(this.tBoxEveStartTime);
            this.Controls.Add(this.tBoxEveEndDate);
            this.Controls.Add(this.tBoxEveStartDate);
            this.Controls.Add(this.tBoxEveLoc);
            this.Controls.Add(this.tBoxEveDesc);
            this.Controls.Add(this.tBoxEveName);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxEveName;
        private System.Windows.Forms.Label lblEveName;
        private System.Windows.Forms.Label lblEveDesc;
        private System.Windows.Forms.Label lblEveLoc;
        private System.Windows.Forms.TextBox tBoxEveDesc;
        private System.Windows.Forms.TextBox tBoxEveLoc;
        private System.Windows.Forms.Label lblEveStart;
        private System.Windows.Forms.Button btnEveSave;
        private System.Windows.Forms.Label lblEveTitle;
        private System.Windows.Forms.TextBox tBoxEveStartDate;
        private System.Windows.Forms.TextBox tBoxEveStartTime;
        private System.Windows.Forms.TextBox tBoxEveEndDate;
        private System.Windows.Forms.TextBox tBoxEveEndTime;
        private System.Windows.Forms.Label lblEveEnd;
        private System.Windows.Forms.Label lblEveStartDate;
        private System.Windows.Forms.Label lblEveStartTime;
        private System.Windows.Forms.Label lblEveEndDate;
        private System.Windows.Forms.Label lblEveEndTime;
    }
}