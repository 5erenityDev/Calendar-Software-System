
namespace CalendarSoftwareSystem
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.Lavender;
            this.lbDays.Location = new System.Drawing.Point(-1, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(32, 23);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.lbDays);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(145, 90);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
    }
}
