
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
            this.lblEveSta = new System.Windows.Forms.Label();
            this.btnEveSave = new System.Windows.Forms.Button();
            this.lblEveTitle = new System.Windows.Forms.Label();
            this.lblEveEnd = new System.Windows.Forms.Label();
            this.lblEveStaDate = new System.Windows.Forms.Label();
            this.lblEveStaTime = new System.Windows.Forms.Label();
            this.lblEventAttendents = new System.Windows.Forms.Label();
            this.chklstAttendants = new System.Windows.Forms.CheckedListBox();
            this.radButEveStaAM = new System.Windows.Forms.RadioButton();
            this.cBoxEveStaYear = new System.Windows.Forms.ComboBox();
            this.cBoxEveStaHour = new System.Windows.Forms.ComboBox();
            this.radButEveStaPM = new System.Windows.Forms.RadioButton();
            this.lblEveStaColon = new System.Windows.Forms.Label();
            this.cBoxEveStaMon = new System.Windows.Forms.ComboBox();
            this.cBoxEveStaDay = new System.Windows.Forms.ComboBox();
            this.cBoxEveStaMin = new System.Windows.Forms.ComboBox();
            this.lblEveStaSlashTwo = new System.Windows.Forms.Label();
            this.lblEveStaSlashOne = new System.Windows.Forms.Label();
            this.lblEveEndDate = new System.Windows.Forms.Label();
            this.lblEveEndTime = new System.Windows.Forms.Label();
            this.cBoxEveEndYear = new System.Windows.Forms.ComboBox();
            this.cBoxEveEndHour = new System.Windows.Forms.ComboBox();
            this.lblEveEndColon = new System.Windows.Forms.Label();
            this.lblEveEndSlashTwo = new System.Windows.Forms.Label();
            this.lblEveEndSlashOne = new System.Windows.Forms.Label();
            this.cBoxEveEndMon = new System.Windows.Forms.ComboBox();
            this.cBoxEveEndDay = new System.Windows.Forms.ComboBox();
            this.cBoxEveEndMin = new System.Windows.Forms.ComboBox();
            this.panelEveStaRad = new System.Windows.Forms.Panel();
            this.panelEveEndRad = new System.Windows.Forms.Panel();
            this.radButEveEndPM = new System.Windows.Forms.RadioButton();
            this.radButEveEndAM = new System.Windows.Forms.RadioButton();
            this.panelEveAdd = new System.Windows.Forms.Panel();
            this.btnEveBack = new System.Windows.Forms.Button();
            this.btnEveCoord = new System.Windows.Forms.Button();
            this.panelEveView = new System.Windows.Forms.Panel();
            this.BtnEveViewCancel = new System.Windows.Forms.Button();
            this.btnEveViewDelete = new System.Windows.Forms.Button();
            this.btnEveViewEdit = new System.Windows.Forms.Button();
            this.lblEveView = new System.Windows.Forms.Label();
            this.btnEveViewCreate = new System.Windows.Forms.Button();
            this.lblEveViewDate = new System.Windows.Forms.Label();
            this.lViewEveView = new System.Windows.Forms.ListView();
            this.panelEveStaRad.SuspendLayout();
            this.panelEveEndRad.SuspendLayout();
            this.panelEveAdd.SuspendLayout();
            this.panelEveView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxEveName
            // 
            this.tBoxEveName.Location = new System.Drawing.Point(137, 56);
            this.tBoxEveName.MaxLength = 50;
            this.tBoxEveName.Name = "tBoxEveName";
            this.tBoxEveName.Size = new System.Drawing.Size(365, 20);
            this.tBoxEveName.TabIndex = 0;
            // 
            // lblEveName
            // 
            this.lblEveName.AutoSize = true;
            this.lblEveName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveName.Location = new System.Drawing.Point(3, 56);
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
            this.lblEveDesc.Location = new System.Drawing.Point(4, 99);
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
            this.lblEveLoc.Location = new System.Drawing.Point(4, 270);
            this.lblEveLoc.Name = "lblEveLoc";
            this.lblEveLoc.Size = new System.Drawing.Size(109, 17);
            this.lblEveLoc.TabIndex = 1;
            this.lblEveLoc.Text = "Event Location:";
            // 
            // tBoxEveDesc
            // 
            this.tBoxEveDesc.Location = new System.Drawing.Point(137, 99);
            this.tBoxEveDesc.MaxLength = 500;
            this.tBoxEveDesc.Multiline = true;
            this.tBoxEveDesc.Name = "tBoxEveDesc";
            this.tBoxEveDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxEveDesc.Size = new System.Drawing.Size(365, 154);
            this.tBoxEveDesc.TabIndex = 0;
            // 
            // tBoxEveLoc
            // 
            this.tBoxEveLoc.Location = new System.Drawing.Point(137, 270);
            this.tBoxEveLoc.MaxLength = 50;
            this.tBoxEveLoc.Name = "tBoxEveLoc";
            this.tBoxEveLoc.Size = new System.Drawing.Size(365, 20);
            this.tBoxEveLoc.TabIndex = 0;
            // 
            // lblEveSta
            // 
            this.lblEveSta.AutoSize = true;
            this.lblEveSta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveSta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveSta.Location = new System.Drawing.Point(22, 325);
            this.lblEveSta.Name = "lblEveSta";
            this.lblEveSta.Size = new System.Drawing.Size(79, 17);
            this.lblEveSta.TabIndex = 1;
            this.lblEveSta.Text = "Event Start:";
            // 
            // btnEveSave
            // 
            this.btnEveSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveSave.FlatAppearance.BorderSize = 0;
            this.btnEveSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveSave.Location = new System.Drawing.Point(701, 401);
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
            this.lblEveTitle.Location = new System.Drawing.Point(3, 5);
            this.lblEveTitle.Name = "lblEveTitle";
            this.lblEveTitle.Size = new System.Drawing.Size(235, 47);
            this.lblEveTitle.TabIndex = 1;
            this.lblEveTitle.Text = "NEW EVENT";
            // 
            // lblEveEnd
            // 
            this.lblEveEnd.AutoSize = true;
            this.lblEveEnd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEnd.Location = new System.Drawing.Point(416, 326);
            this.lblEveEnd.Name = "lblEveEnd";
            this.lblEveEnd.Size = new System.Drawing.Size(75, 17);
            this.lblEveEnd.TabIndex = 1;
            this.lblEveEnd.Text = "Event End:";
            // 
            // lblEveStaDate
            // 
            this.lblEveStaDate.AutoSize = true;
            this.lblEveStaDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStaDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStaDate.Location = new System.Drawing.Point(160, 305);
            this.lblEveStaDate.Name = "lblEveStaDate";
            this.lblEveStaDate.Size = new System.Drawing.Size(44, 17);
            this.lblEveStaDate.TabIndex = 1;
            this.lblEveStaDate.Text = "Date:";
            // 
            // lblEveStaTime
            // 
            this.lblEveStaTime.AutoSize = true;
            this.lblEveStaTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStaTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStaTime.Location = new System.Drawing.Point(317, 305);
            this.lblEveStaTime.Name = "lblEveStaTime";
            this.lblEveStaTime.Size = new System.Drawing.Size(45, 17);
            this.lblEveStaTime.TabIndex = 1;
            this.lblEveStaTime.Text = "Time:";
            // 
            // lblEventAttendents
            // 
            this.lblEventAttendents.AutoSize = true;
            this.lblEventAttendents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEventAttendents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEventAttendents.Location = new System.Drawing.Point(606, 79);
            this.lblEventAttendents.Name = "lblEventAttendents";
            this.lblEventAttendents.Size = new System.Drawing.Size(83, 17);
            this.lblEventAttendents.TabIndex = 4;
            this.lblEventAttendents.Text = "Attendants:";
            // 
            // chklstAttendants
            // 
            this.chklstAttendants.FormattingEnabled = true;
            this.chklstAttendants.Location = new System.Drawing.Point(512, 99);
            this.chklstAttendants.Name = "chklstAttendants";
            this.chklstAttendants.Size = new System.Drawing.Size(264, 154);
            this.chklstAttendants.TabIndex = 5;
            // 
            // radButEveStaAM
            // 
            this.radButEveStaAM.AutoSize = true;
            this.radButEveStaAM.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.radButEveStaAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.radButEveStaAM.Location = new System.Drawing.Point(3, 3);
            this.radButEveStaAM.Name = "radButEveStaAM";
            this.radButEveStaAM.Size = new System.Drawing.Size(49, 21);
            this.radButEveStaAM.TabIndex = 6;
            this.radButEveStaAM.TabStop = true;
            this.radButEveStaAM.Text = "AM";
            this.radButEveStaAM.UseVisualStyleBackColor = true;
            // 
            // cBoxEveStaYear
            // 
            this.cBoxEveStaYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveStaYear.Enabled = false;
            this.cBoxEveStaYear.FormattingEnabled = true;
            this.cBoxEveStaYear.Location = new System.Drawing.Point(215, 324);
            this.cBoxEveStaYear.Name = "cBoxEveStaYear";
            this.cBoxEveStaYear.Size = new System.Drawing.Size(54, 21);
            this.cBoxEveStaYear.TabIndex = 7;
            // 
            // cBoxEveStaHour
            // 
            this.cBoxEveStaHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveStaHour.FormattingEnabled = true;
            this.cBoxEveStaHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxEveStaHour.Location = new System.Drawing.Point(284, 324);
            this.cBoxEveStaHour.Name = "cBoxEveStaHour";
            this.cBoxEveStaHour.Size = new System.Drawing.Size(39, 21);
            this.cBoxEveStaHour.TabIndex = 8;
            // 
            // radButEveStaPM
            // 
            this.radButEveStaPM.AutoSize = true;
            this.radButEveStaPM.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.radButEveStaPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.radButEveStaPM.Location = new System.Drawing.Point(66, 3);
            this.radButEveStaPM.Name = "radButEveStaPM";
            this.radButEveStaPM.Size = new System.Drawing.Size(47, 21);
            this.radButEveStaPM.TabIndex = 6;
            this.radButEveStaPM.TabStop = true;
            this.radButEveStaPM.Text = "PM";
            this.radButEveStaPM.UseVisualStyleBackColor = true;
            // 
            // lblEveStaColon
            // 
            this.lblEveStaColon.AutoSize = true;
            this.lblEveStaColon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStaColon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStaColon.Location = new System.Drawing.Point(330, 326);
            this.lblEveStaColon.Name = "lblEveStaColon";
            this.lblEveStaColon.Size = new System.Drawing.Size(12, 17);
            this.lblEveStaColon.TabIndex = 9;
            this.lblEveStaColon.Text = ":";
            // 
            // cBoxEveStaMon
            // 
            this.cBoxEveStaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveStaMon.Enabled = false;
            this.cBoxEveStaMon.FormattingEnabled = true;
            this.cBoxEveStaMon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxEveStaMon.Location = new System.Drawing.Point(107, 324);
            this.cBoxEveStaMon.Name = "cBoxEveStaMon";
            this.cBoxEveStaMon.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveStaMon.TabIndex = 10;
            // 
            // cBoxEveStaDay
            // 
            this.cBoxEveStaDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveStaDay.Enabled = false;
            this.cBoxEveStaDay.FormattingEnabled = true;
            this.cBoxEveStaDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cBoxEveStaDay.Location = new System.Drawing.Point(161, 324);
            this.cBoxEveStaDay.Name = "cBoxEveStaDay";
            this.cBoxEveStaDay.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveStaDay.TabIndex = 10;
            // 
            // cBoxEveStaMin
            // 
            this.cBoxEveStaMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveStaMin.FormattingEnabled = true;
            this.cBoxEveStaMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBoxEveStaMin.Location = new System.Drawing.Point(347, 324);
            this.cBoxEveStaMin.Name = "cBoxEveStaMin";
            this.cBoxEveStaMin.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveStaMin.TabIndex = 10;
            // 
            // lblEveStaSlashTwo
            // 
            this.lblEveStaSlashTwo.AutoSize = true;
            this.lblEveStaSlashTwo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStaSlashTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStaSlashTwo.Location = new System.Drawing.Point(201, 325);
            this.lblEveStaSlashTwo.Name = "lblEveStaSlashTwo";
            this.lblEveStaSlashTwo.Size = new System.Drawing.Size(14, 17);
            this.lblEveStaSlashTwo.TabIndex = 9;
            this.lblEveStaSlashTwo.Text = "/";
            // 
            // lblEveStaSlashOne
            // 
            this.lblEveStaSlashOne.AutoSize = true;
            this.lblEveStaSlashOne.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveStaSlashOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveStaSlashOne.Location = new System.Drawing.Point(148, 325);
            this.lblEveStaSlashOne.Name = "lblEveStaSlashOne";
            this.lblEveStaSlashOne.Size = new System.Drawing.Size(14, 17);
            this.lblEveStaSlashOne.TabIndex = 9;
            this.lblEveStaSlashOne.Text = "/";
            // 
            // lblEveEndDate
            // 
            this.lblEveEndDate.AutoSize = true;
            this.lblEveEndDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndDate.Location = new System.Drawing.Point(550, 305);
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
            this.lblEveEndTime.Location = new System.Drawing.Point(709, 305);
            this.lblEveEndTime.Name = "lblEveEndTime";
            this.lblEveEndTime.Size = new System.Drawing.Size(45, 17);
            this.lblEveEndTime.TabIndex = 1;
            this.lblEveEndTime.Text = "Time:";
            // 
            // cBoxEveEndYear
            // 
            this.cBoxEveEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveEndYear.Enabled = false;
            this.cBoxEveEndYear.FormattingEnabled = true;
            this.cBoxEveEndYear.Location = new System.Drawing.Point(605, 324);
            this.cBoxEveEndYear.Name = "cBoxEveEndYear";
            this.cBoxEveEndYear.Size = new System.Drawing.Size(54, 21);
            this.cBoxEveEndYear.TabIndex = 7;
            // 
            // cBoxEveEndHour
            // 
            this.cBoxEveEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveEndHour.FormattingEnabled = true;
            this.cBoxEveEndHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxEveEndHour.Location = new System.Drawing.Point(676, 324);
            this.cBoxEveEndHour.Name = "cBoxEveEndHour";
            this.cBoxEveEndHour.Size = new System.Drawing.Size(39, 21);
            this.cBoxEveEndHour.TabIndex = 8;
            // 
            // lblEveEndColon
            // 
            this.lblEveEndColon.AutoSize = true;
            this.lblEveEndColon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndColon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndColon.Location = new System.Drawing.Point(722, 326);
            this.lblEveEndColon.Name = "lblEveEndColon";
            this.lblEveEndColon.Size = new System.Drawing.Size(12, 17);
            this.lblEveEndColon.TabIndex = 9;
            this.lblEveEndColon.Text = ":";
            // 
            // lblEveEndSlashTwo
            // 
            this.lblEveEndSlashTwo.AutoSize = true;
            this.lblEveEndSlashTwo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndSlashTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndSlashTwo.Location = new System.Drawing.Point(591, 325);
            this.lblEveEndSlashTwo.Name = "lblEveEndSlashTwo";
            this.lblEveEndSlashTwo.Size = new System.Drawing.Size(14, 17);
            this.lblEveEndSlashTwo.TabIndex = 9;
            this.lblEveEndSlashTwo.Text = "/";
            // 
            // lblEveEndSlashOne
            // 
            this.lblEveEndSlashOne.AutoSize = true;
            this.lblEveEndSlashOne.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveEndSlashOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveEndSlashOne.Location = new System.Drawing.Point(538, 325);
            this.lblEveEndSlashOne.Name = "lblEveEndSlashOne";
            this.lblEveEndSlashOne.Size = new System.Drawing.Size(14, 17);
            this.lblEveEndSlashOne.TabIndex = 9;
            this.lblEveEndSlashOne.Text = "/";
            // 
            // cBoxEveEndMon
            // 
            this.cBoxEveEndMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveEndMon.Enabled = false;
            this.cBoxEveEndMon.FormattingEnabled = true;
            this.cBoxEveEndMon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBoxEveEndMon.Location = new System.Drawing.Point(497, 324);
            this.cBoxEveEndMon.Name = "cBoxEveEndMon";
            this.cBoxEveEndMon.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveEndMon.TabIndex = 10;
            // 
            // cBoxEveEndDay
            // 
            this.cBoxEveEndDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveEndDay.Enabled = false;
            this.cBoxEveEndDay.FormattingEnabled = true;
            this.cBoxEveEndDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cBoxEveEndDay.Location = new System.Drawing.Point(551, 324);
            this.cBoxEveEndDay.Name = "cBoxEveEndDay";
            this.cBoxEveEndDay.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveEndDay.TabIndex = 10;
            // 
            // cBoxEveEndMin
            // 
            this.cBoxEveEndMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEveEndMin.FormattingEnabled = true;
            this.cBoxEveEndMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBoxEveEndMin.Location = new System.Drawing.Point(739, 324);
            this.cBoxEveEndMin.Name = "cBoxEveEndMin";
            this.cBoxEveEndMin.Size = new System.Drawing.Size(40, 21);
            this.cBoxEveEndMin.TabIndex = 10;
            // 
            // panelEveStaRad
            // 
            this.panelEveStaRad.Controls.Add(this.radButEveStaPM);
            this.panelEveStaRad.Controls.Add(this.radButEveStaAM);
            this.panelEveStaRad.Location = new System.Drawing.Point(284, 351);
            this.panelEveStaRad.Name = "panelEveStaRad";
            this.panelEveStaRad.Size = new System.Drawing.Size(115, 29);
            this.panelEveStaRad.TabIndex = 11;
            // 
            // panelEveEndRad
            // 
            this.panelEveEndRad.Controls.Add(this.radButEveEndPM);
            this.panelEveEndRad.Controls.Add(this.radButEveEndAM);
            this.panelEveEndRad.Location = new System.Drawing.Point(676, 351);
            this.panelEveEndRad.Name = "panelEveEndRad";
            this.panelEveEndRad.Size = new System.Drawing.Size(111, 29);
            this.panelEveEndRad.TabIndex = 11;
            // 
            // radButEveEndPM
            // 
            this.radButEveEndPM.AutoSize = true;
            this.radButEveEndPM.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.radButEveEndPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.radButEveEndPM.Location = new System.Drawing.Point(66, 3);
            this.radButEveEndPM.Name = "radButEveEndPM";
            this.radButEveEndPM.Size = new System.Drawing.Size(47, 21);
            this.radButEveEndPM.TabIndex = 6;
            this.radButEveEndPM.TabStop = true;
            this.radButEveEndPM.Text = "PM";
            this.radButEveEndPM.UseVisualStyleBackColor = true;
            // 
            // radButEveEndAM
            // 
            this.radButEveEndAM.AutoSize = true;
            this.radButEveEndAM.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.radButEveEndAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.radButEveEndAM.Location = new System.Drawing.Point(3, 3);
            this.radButEveEndAM.Name = "radButEveEndAM";
            this.radButEveEndAM.Size = new System.Drawing.Size(49, 21);
            this.radButEveEndAM.TabIndex = 6;
            this.radButEveEndAM.TabStop = true;
            this.radButEveEndAM.Text = "AM";
            this.radButEveEndAM.UseVisualStyleBackColor = true;
            // 
            // panelEveAdd
            // 
            this.panelEveAdd.Controls.Add(this.btnEveBack);
            this.panelEveAdd.Controls.Add(this.btnEveCoord);
            this.panelEveAdd.Controls.Add(this.panelEveEndRad);
            this.panelEveAdd.Controls.Add(this.lblEveTitle);
            this.panelEveAdd.Controls.Add(this.panelEveStaRad);
            this.panelEveAdd.Controls.Add(this.lblEveName);
            this.panelEveAdd.Controls.Add(this.cBoxEveEndMin);
            this.panelEveAdd.Controls.Add(this.lblEveDesc);
            this.panelEveAdd.Controls.Add(this.cBoxEveStaMin);
            this.panelEveAdd.Controls.Add(this.lblEveLoc);
            this.panelEveAdd.Controls.Add(this.cBoxEveEndDay);
            this.panelEveAdd.Controls.Add(this.lblEveSta);
            this.panelEveAdd.Controls.Add(this.cBoxEveStaDay);
            this.panelEveAdd.Controls.Add(this.tBoxEveDesc);
            this.panelEveAdd.Controls.Add(this.cBoxEveEndMon);
            this.panelEveAdd.Controls.Add(this.tBoxEveName);
            this.panelEveAdd.Controls.Add(this.lblEveEndSlashOne);
            this.panelEveAdd.Controls.Add(this.tBoxEveLoc);
            this.panelEveAdd.Controls.Add(this.cBoxEveStaMon);
            this.panelEveAdd.Controls.Add(this.lblEveStaDate);
            this.panelEveAdd.Controls.Add(this.lblEveEndSlashTwo);
            this.panelEveAdd.Controls.Add(this.lblEveStaTime);
            this.panelEveAdd.Controls.Add(this.lblEveStaSlashOne);
            this.panelEveAdd.Controls.Add(this.lblEveEndDate);
            this.panelEveAdd.Controls.Add(this.lblEveEndColon);
            this.panelEveAdd.Controls.Add(this.lblEveEnd);
            this.panelEveAdd.Controls.Add(this.lblEveStaSlashTwo);
            this.panelEveAdd.Controls.Add(this.lblEveEndTime);
            this.panelEveAdd.Controls.Add(this.cBoxEveEndHour);
            this.panelEveAdd.Controls.Add(this.btnEveSave);
            this.panelEveAdd.Controls.Add(this.lblEveStaColon);
            this.panelEveAdd.Controls.Add(this.lblEventAttendents);
            this.panelEveAdd.Controls.Add(this.cBoxEveEndYear);
            this.panelEveAdd.Controls.Add(this.chklstAttendants);
            this.panelEveAdd.Controls.Add(this.cBoxEveStaHour);
            this.panelEveAdd.Controls.Add(this.cBoxEveStaYear);
            this.panelEveAdd.Location = new System.Drawing.Point(3, 4);
            this.panelEveAdd.Name = "panelEveAdd";
            this.panelEveAdd.Size = new System.Drawing.Size(796, 443);
            this.panelEveAdd.TabIndex = 12;
            // 
            // btnEveBack
            // 
            this.btnEveBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveBack.FlatAppearance.BorderSize = 0;
            this.btnEveBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveBack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveBack.Location = new System.Drawing.Point(14, 401);
            this.btnEveBack.Name = "btnEveBack";
            this.btnEveBack.Size = new System.Drawing.Size(75, 29);
            this.btnEveBack.TabIndex = 13;
            this.btnEveBack.Text = "Back";
            this.btnEveBack.UseVisualStyleBackColor = false;
            this.btnEveBack.Click += new System.EventHandler(this.btnEveBack_Click);
            // 
            // btnEveCoord
            // 
            this.btnEveCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveCoord.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveCoord.FlatAppearance.BorderSize = 0;
            this.btnEveCoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveCoord.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveCoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveCoord.Location = new System.Drawing.Point(265, 401);
            this.btnEveCoord.Name = "btnEveCoord";
            this.btnEveCoord.Size = new System.Drawing.Size(326, 29);
            this.btnEveCoord.TabIndex = 12;
            this.btnEveCoord.Text = "Coordinate Event with Selected Attendants";
            this.btnEveCoord.UseVisualStyleBackColor = false;
            this.btnEveCoord.Click += new System.EventHandler(this.btnEveCoord_Click);
            // 
            // panelEveView
            // 
            this.panelEveView.Controls.Add(this.lViewEveView);
            this.panelEveView.Controls.Add(this.BtnEveViewCancel);
            this.panelEveView.Controls.Add(this.btnEveViewDelete);
            this.panelEveView.Controls.Add(this.btnEveViewEdit);
            this.panelEveView.Controls.Add(this.lblEveView);
            this.panelEveView.Controls.Add(this.btnEveViewCreate);
            this.panelEveView.Controls.Add(this.lblEveViewDate);
            this.panelEveView.Location = new System.Drawing.Point(3, 4);
            this.panelEveView.Name = "panelEveView";
            this.panelEveView.Size = new System.Drawing.Size(796, 443);
            this.panelEveView.TabIndex = 12;
            // 
            // BtnEveViewCancel
            // 
            this.BtnEveViewCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.BtnEveViewCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEveViewCancel.FlatAppearance.BorderSize = 0;
            this.BtnEveViewCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEveViewCancel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEveViewCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.BtnEveViewCancel.Location = new System.Drawing.Point(14, 401);
            this.BtnEveViewCancel.Name = "BtnEveViewCancel";
            this.BtnEveViewCancel.Size = new System.Drawing.Size(75, 29);
            this.BtnEveViewCancel.TabIndex = 15;
            this.BtnEveViewCancel.Text = "Cancel";
            this.BtnEveViewCancel.UseVisualStyleBackColor = false;
            this.BtnEveViewCancel.Click += new System.EventHandler(this.BtnEveViewCancel_Click);
            // 
            // btnEveViewDelete
            // 
            this.btnEveViewDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveViewDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveViewDelete.FlatAppearance.BorderSize = 0;
            this.btnEveViewDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveViewDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveViewDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveViewDelete.Location = new System.Drawing.Point(512, 401);
            this.btnEveViewDelete.Name = "btnEveViewDelete";
            this.btnEveViewDelete.Size = new System.Drawing.Size(75, 29);
            this.btnEveViewDelete.TabIndex = 14;
            this.btnEveViewDelete.Text = "Delete";
            this.btnEveViewDelete.UseVisualStyleBackColor = false;
            this.btnEveViewDelete.Click += new System.EventHandler(this.btnEveViewDelete_Click);
            // 
            // btnEveViewEdit
            // 
            this.btnEveViewEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveViewEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveViewEdit.FlatAppearance.BorderSize = 0;
            this.btnEveViewEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveViewEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveViewEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveViewEdit.Location = new System.Drawing.Point(597, 401);
            this.btnEveViewEdit.Name = "btnEveViewEdit";
            this.btnEveViewEdit.Size = new System.Drawing.Size(96, 29);
            this.btnEveViewEdit.TabIndex = 13;
            this.btnEveViewEdit.Text = "Edit/View";
            this.btnEveViewEdit.UseVisualStyleBackColor = false;
            this.btnEveViewEdit.Click += new System.EventHandler(this.btnEveViewEdit_Click);
            // 
            // lblEveView
            // 
            this.lblEveView.AutoSize = true;
            this.lblEveView.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEveView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveView.Location = new System.Drawing.Point(21, 57);
            this.lblEveView.Name = "lblEveView";
            this.lblEveView.Size = new System.Drawing.Size(53, 17);
            this.lblEveView.TabIndex = 12;
            this.lblEveView.Text = "Events:";
            // 
            // btnEveViewCreate
            // 
            this.btnEveViewCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnEveViewCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEveViewCreate.FlatAppearance.BorderSize = 0;
            this.btnEveViewCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEveViewCreate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnEveViewCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.btnEveViewCreate.Location = new System.Drawing.Point(701, 401);
            this.btnEveViewCreate.Name = "btnEveViewCreate";
            this.btnEveViewCreate.Size = new System.Drawing.Size(75, 29);
            this.btnEveViewCreate.TabIndex = 12;
            this.btnEveViewCreate.Text = "Create";
            this.btnEveViewCreate.UseVisualStyleBackColor = false;
            this.btnEveViewCreate.Click += new System.EventHandler(this.btnEveViewCreate_Click);
            // 
            // lblEveViewDate
            // 
            this.lblEveViewDate.AutoSize = true;
            this.lblEveViewDate.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblEveViewDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.lblEveViewDate.Location = new System.Drawing.Point(3, 5);
            this.lblEveViewDate.Name = "lblEveViewDate";
            this.lblEveViewDate.Size = new System.Drawing.Size(116, 47);
            this.lblEveViewDate.TabIndex = 12;
            this.lblEveViewDate.Text = "DATE";
            // 
            // lViewEveView
            // 
            this.lViewEveView.FullRowSelect = true;
            this.lViewEveView.HideSelection = false;
            this.lViewEveView.Location = new System.Drawing.Point(26, 79);
            this.lViewEveView.Name = "lViewEveView";
            this.lViewEveView.Size = new System.Drawing.Size(750, 316);
            this.lViewEveView.TabIndex = 17;
            this.lViewEveView.UseCompatibleStateImageBehavior = false;
            this.lViewEveView.View = System.Windows.Forms.View.Details;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEveView);
            this.Controls.Add(this.panelEveAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panelEveStaRad.ResumeLayout(false);
            this.panelEveStaRad.PerformLayout();
            this.panelEveEndRad.ResumeLayout(false);
            this.panelEveEndRad.PerformLayout();
            this.panelEveAdd.ResumeLayout(false);
            this.panelEveAdd.PerformLayout();
            this.panelEveView.ResumeLayout(false);
            this.panelEveView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxEveName;
        private System.Windows.Forms.Label lblEveName;
        private System.Windows.Forms.Label lblEveDesc;
        private System.Windows.Forms.Label lblEveLoc;
        private System.Windows.Forms.TextBox tBoxEveDesc;
        private System.Windows.Forms.TextBox tBoxEveLoc;
        private System.Windows.Forms.Label lblEveSta;
        private System.Windows.Forms.Button btnEveSave;
        private System.Windows.Forms.Label lblEveTitle;
        private System.Windows.Forms.Label lblEveEnd;
        private System.Windows.Forms.Label lblEveStaDate;
        private System.Windows.Forms.Label lblEveStaTime;
        private System.Windows.Forms.Label lblEventAttendents;
        private System.Windows.Forms.CheckedListBox chklstAttendants;
        private System.Windows.Forms.RadioButton radButEveStaAM;
        private System.Windows.Forms.ComboBox cBoxEveStaYear;
        private System.Windows.Forms.ComboBox cBoxEveStaHour;
        private System.Windows.Forms.RadioButton radButEveStaPM;
        private System.Windows.Forms.Label lblEveStaColon;
        private System.Windows.Forms.ComboBox cBoxEveStaMon;
        private System.Windows.Forms.ComboBox cBoxEveStaDay;
        private System.Windows.Forms.ComboBox cBoxEveStaMin;
        private System.Windows.Forms.Label lblEveStaSlashTwo;
        private System.Windows.Forms.Label lblEveStaSlashOne;
        private System.Windows.Forms.Label lblEveEndDate;
        private System.Windows.Forms.Label lblEveEndTime;
        private System.Windows.Forms.ComboBox cBoxEveEndYear;
        private System.Windows.Forms.ComboBox cBoxEveEndHour;
        private System.Windows.Forms.Label lblEveEndColon;
        private System.Windows.Forms.Label lblEveEndSlashTwo;
        private System.Windows.Forms.Label lblEveEndSlashOne;
        private System.Windows.Forms.ComboBox cBoxEveEndMon;
        private System.Windows.Forms.ComboBox cBoxEveEndDay;
        private System.Windows.Forms.ComboBox cBoxEveEndMin;
        private System.Windows.Forms.Panel panelEveStaRad;
        private System.Windows.Forms.Panel panelEveEndRad;
        private System.Windows.Forms.RadioButton radButEveEndPM;
        private System.Windows.Forms.RadioButton radButEveEndAM;
        private System.Windows.Forms.Panel panelEveAdd;
        private System.Windows.Forms.Panel panelEveView;
        private System.Windows.Forms.Label lblEveViewDate;
        private System.Windows.Forms.Label lblEveView;
        private System.Windows.Forms.Button btnEveViewCreate;
        private System.Windows.Forms.Button BtnEveViewCancel;
        private System.Windows.Forms.Button btnEveViewDelete;
        private System.Windows.Forms.Button btnEveViewEdit;
        private System.Windows.Forms.Button btnEveCoord;
        private System.Windows.Forms.Button btnEveBack;
        private System.Windows.Forms.ListView lViewEveView;
    }
}