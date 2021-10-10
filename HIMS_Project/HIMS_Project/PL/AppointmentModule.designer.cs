namespace HIMS_Project.PL
{
    partial class AppointmentModule
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
            this.btnAppointmentClose = new System.Windows.Forms.Button();
            this.pnlFormAppointment = new System.Windows.Forms.Panel();
            this.txtAppointmentNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.btnAppointmentUpdate = new System.Windows.Forms.Button();
            this.btnAppointmentSave = new System.Windows.Forms.Button();
            this.cmbAppSpArea = new System.Windows.Forms.ComboBox();
            this.cmbAppMO = new System.Windows.Forms.ComboBox();
            this.txtAppSymptom = new System.Windows.Forms.TextBox();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAppPatient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppointmentClear = new System.Windows.Forms.Button();
            this.pnlAppointmentView = new System.Windows.Forms.Panel();
            this.btnAppointmentSearch = new System.Windows.Forms.Button();
            this.lblShowAppointmentMsg = new System.Windows.Forms.Label();
            this.pnlViewButtons = new System.Windows.Forms.Panel();
            this.btnAppointmentDelete = new System.Windows.Forms.Button();
            this.btnAppointmentEdit = new System.Windows.Forms.Button();
            this.btnAppointmentApprove = new System.Windows.Forms.Button();
            this.btnAppointmentComplete = new System.Windows.Forms.Button();
            this.btnAppointmentPrint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterAppointment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.AppointmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalOfficer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFormAppointment.SuspendLayout();
            this.pnlAppointmentView.SuspendLayout();
            this.pnlViewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppointmentClose
            // 
            this.btnAppointmentClose.BackColor = System.Drawing.Color.White;
            this.btnAppointmentClose.FlatAppearance.BorderSize = 0;
            this.btnAppointmentClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentClose.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentClose.Location = new System.Drawing.Point(9, 2);
            this.btnAppointmentClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppointmentClose.Name = "btnAppointmentClose";
            this.btnAppointmentClose.Size = new System.Drawing.Size(28, 34);
            this.btnAppointmentClose.TabIndex = 0;
            this.btnAppointmentClose.Text = "X";
            this.btnAppointmentClose.UseVisualStyleBackColor = false;
            this.btnAppointmentClose.Click += new System.EventHandler(this.btnAppointmentClose_Click);
            // 
            // pnlFormAppointment
            // 
            this.pnlFormAppointment.BackColor = System.Drawing.Color.White;
            this.pnlFormAppointment.Controls.Add(this.txtAppointmentNo);
            this.pnlFormAppointment.Controls.Add(this.label10);
            this.pnlFormAppointment.Controls.Add(this.txtAppTime);
            this.pnlFormAppointment.Controls.Add(this.btnAppointmentUpdate);
            this.pnlFormAppointment.Controls.Add(this.btnAppointmentSave);
            this.pnlFormAppointment.Controls.Add(this.cmbAppSpArea);
            this.pnlFormAppointment.Controls.Add(this.cmbAppMO);
            this.pnlFormAppointment.Controls.Add(this.txtAppSymptom);
            this.pnlFormAppointment.Controls.Add(this.dtpAppDate);
            this.pnlFormAppointment.Controls.Add(this.cmbAppPatient);
            this.pnlFormAppointment.Controls.Add(this.label6);
            this.pnlFormAppointment.Controls.Add(this.label5);
            this.pnlFormAppointment.Controls.Add(this.label4);
            this.pnlFormAppointment.Controls.Add(this.label3);
            this.pnlFormAppointment.Controls.Add(this.label2);
            this.pnlFormAppointment.Controls.Add(this.label1);
            this.pnlFormAppointment.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormAppointment.Location = new System.Drawing.Point(737, 0);
            this.pnlFormAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFormAppointment.Name = "pnlFormAppointment";
            this.pnlFormAppointment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFormAppointment.Size = new System.Drawing.Size(366, 585);
            this.pnlFormAppointment.TabIndex = 1;
            // 
            // txtAppointmentNo
            // 
            this.txtAppointmentNo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtAppointmentNo.ForeColor = System.Drawing.Color.White;
            this.txtAppointmentNo.Location = new System.Drawing.Point(105, 66);
            this.txtAppointmentNo.Name = "txtAppointmentNo";
            this.txtAppointmentNo.Size = new System.Drawing.Size(50, 29);
            this.txtAppointmentNo.TabIndex = 11;
            this.txtAppointmentNo.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Location = new System.Drawing.Point(13, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fill Appointmnet Form In Here..";
            // 
            // txtAppTime
            // 
            this.txtAppTime.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtAppTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppTime.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppTime.ForeColor = System.Drawing.Color.White;
            this.txtAppTime.Location = new System.Drawing.Point(25, 231);
            this.txtAppTime.Multiline = true;
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(263, 30);
            this.txtAppTime.TabIndex = 10;
            // 
            // btnAppointmentUpdate
            // 
            this.btnAppointmentUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAppointmentUpdate.Font = new System.Drawing.Font("Lucida Fax", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentUpdate.Location = new System.Drawing.Point(10, 515);
            this.btnAppointmentUpdate.Name = "btnAppointmentUpdate";
            this.btnAppointmentUpdate.Size = new System.Drawing.Size(346, 30);
            this.btnAppointmentUpdate.TabIndex = 9;
            this.btnAppointmentUpdate.Text = "U P D A T E";
            this.btnAppointmentUpdate.UseVisualStyleBackColor = false;
            this.btnAppointmentUpdate.Click += new System.EventHandler(this.btnAppointmentUpdate_Click);
            // 
            // btnAppointmentSave
            // 
            this.btnAppointmentSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAppointmentSave.Font = new System.Drawing.Font("Lucida Fax", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentSave.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentSave.Location = new System.Drawing.Point(10, 545);
            this.btnAppointmentSave.Name = "btnAppointmentSave";
            this.btnAppointmentSave.Size = new System.Drawing.Size(346, 30);
            this.btnAppointmentSave.TabIndex = 9;
            this.btnAppointmentSave.Text = "S A V E";
            this.btnAppointmentSave.UseVisualStyleBackColor = false;
            this.btnAppointmentSave.Click += new System.EventHandler(this.btnAppointmentSave_Click);
            // 
            // cmbAppSpArea
            // 
            this.cmbAppSpArea.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbAppSpArea.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppSpArea.ForeColor = System.Drawing.Color.White;
            this.cmbAppSpArea.FormattingEnabled = true;
            this.cmbAppSpArea.Location = new System.Drawing.Point(25, 297);
            this.cmbAppSpArea.Name = "cmbAppSpArea";
            this.cmbAppSpArea.Size = new System.Drawing.Size(263, 33);
            this.cmbAppSpArea.TabIndex = 8;
            this.cmbAppSpArea.SelectedIndexChanged += new System.EventHandler(this.cmbAppSpArea_SelectedIndexChanged);
            // 
            // cmbAppMO
            // 
            this.cmbAppMO.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbAppMO.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppMO.ForeColor = System.Drawing.Color.White;
            this.cmbAppMO.FormattingEnabled = true;
            this.cmbAppMO.Location = new System.Drawing.Point(25, 363);
            this.cmbAppMO.Name = "cmbAppMO";
            this.cmbAppMO.Size = new System.Drawing.Size(263, 33);
            this.cmbAppMO.TabIndex = 7;
            // 
            // txtAppSymptom
            // 
            this.txtAppSymptom.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtAppSymptom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppSymptom.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppSymptom.ForeColor = System.Drawing.Color.White;
            this.txtAppSymptom.Location = new System.Drawing.Point(25, 427);
            this.txtAppSymptom.Multiline = true;
            this.txtAppSymptom.Name = "txtAppSymptom";
            this.txtAppSymptom.Size = new System.Drawing.Size(263, 66);
            this.txtAppSymptom.TabIndex = 6;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpAppDate.CalendarMonthBackground = System.Drawing.Color.MediumSeaGreen;
            this.dtpAppDate.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtpAppDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpAppDate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpAppDate.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppDate.Location = new System.Drawing.Point(22, 164);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(266, 32);
            this.dtpAppDate.TabIndex = 4;
            this.dtpAppDate.Value = new System.DateTime(2021, 9, 12, 0, 0, 0, 0);
            // 
            // cmbAppPatient
            // 
            this.cmbAppPatient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbAppPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppPatient.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppPatient.ForeColor = System.Drawing.Color.White;
            this.cmbAppPatient.FormattingEnabled = true;
            this.cmbAppPatient.Location = new System.Drawing.Point(22, 95);
            this.cmbAppPatient.Name = "cmbAppPatient";
            this.cmbAppPatient.Size = new System.Drawing.Size(266, 33);
            this.cmbAppPatient.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(21, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Medical Officer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(21, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Specialty Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(21, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(21, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Appointment Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // btnAppointmentClear
            // 
            this.btnAppointmentClear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAppointmentClear.FlatAppearance.BorderSize = 0;
            this.btnAppointmentClear.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentClear.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentClear.Location = new System.Drawing.Point(561, 0);
            this.btnAppointmentClear.Name = "btnAppointmentClear";
            this.btnAppointmentClear.Size = new System.Drawing.Size(91, 45);
            this.btnAppointmentClear.TabIndex = 9;
            this.btnAppointmentClear.Text = "Clear All";
            this.btnAppointmentClear.UseVisualStyleBackColor = false;
            this.btnAppointmentClear.Click += new System.EventHandler(this.btnAppointmentClear_Click);
            // 
            // pnlAppointmentView
            // 
            this.pnlAppointmentView.AutoScroll = true;
            this.pnlAppointmentView.BackColor = System.Drawing.Color.White;
            this.pnlAppointmentView.Controls.Add(this.btnAppointmentSearch);
            this.pnlAppointmentView.Controls.Add(this.lblShowAppointmentMsg);
            this.pnlAppointmentView.Controls.Add(this.pnlViewButtons);
            this.pnlAppointmentView.Controls.Add(this.label9);
            this.pnlAppointmentView.Controls.Add(this.label8);
            this.pnlAppointmentView.Controls.Add(this.txtAppointmentSearch);
            this.pnlAppointmentView.Controls.Add(this.btnAppointmentClose);
            this.pnlAppointmentView.Controls.Add(this.cmbFilterAppointment);
            this.pnlAppointmentView.Controls.Add(this.label7);
            this.pnlAppointmentView.Controls.Add(this.dgvAppointment);
            this.pnlAppointmentView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAppointmentView.Location = new System.Drawing.Point(0, 0);
            this.pnlAppointmentView.Name = "pnlAppointmentView";
            this.pnlAppointmentView.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlAppointmentView.Size = new System.Drawing.Size(677, 585);
            this.pnlAppointmentView.TabIndex = 3;
            // 
            // btnAppointmentSearch
            // 
            this.btnAppointmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentSearch.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentSearch.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentSearch.Location = new System.Drawing.Point(601, 72);
            this.btnAppointmentSearch.Name = "btnAppointmentSearch";
            this.btnAppointmentSearch.Size = new System.Drawing.Size(65, 31);
            this.btnAppointmentSearch.TabIndex = 12;
            this.btnAppointmentSearch.Text = "Search";
            this.btnAppointmentSearch.UseVisualStyleBackColor = false;
            this.btnAppointmentSearch.Click += new System.EventHandler(this.btnAppointmentSearch_Click);
            // 
            // lblShowAppointmentMsg
            // 
            this.lblShowAppointmentMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowAppointmentMsg.AutoSize = true;
            this.lblShowAppointmentMsg.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAppointmentMsg.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblShowAppointmentMsg.Location = new System.Drawing.Point(59, 112);
            this.lblShowAppointmentMsg.Name = "lblShowAppointmentMsg";
            this.lblShowAppointmentMsg.Size = new System.Drawing.Size(634, 20);
            this.lblShowAppointmentMsg.TabIndex = 11;
            this.lblShowAppointmentMsg.Text = "Appointment Numbers are available only for approved appointment.";
            this.lblShowAppointmentMsg.Visible = false;
            // 
            // pnlViewButtons
            // 
            this.pnlViewButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewButtons.Controls.Add(this.btnAppointmentDelete);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentEdit);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentApprove);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentComplete);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentClear);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentPrint);
            this.pnlViewButtons.Location = new System.Drawing.Point(12, 535);
            this.pnlViewButtons.Name = "pnlViewButtons";
            this.pnlViewButtons.Size = new System.Drawing.Size(652, 45);
            this.pnlViewButtons.TabIndex = 10;
            // 
            // btnAppointmentDelete
            // 
            this.btnAppointmentDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentDelete.FlatAppearance.BorderSize = 0;
            this.btnAppointmentDelete.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentDelete.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentDelete.Location = new System.Drawing.Point(353, 0);
            this.btnAppointmentDelete.Name = "btnAppointmentDelete";
            this.btnAppointmentDelete.Size = new System.Drawing.Size(75, 45);
            this.btnAppointmentDelete.TabIndex = 6;
            this.btnAppointmentDelete.Text = "Delete";
            this.btnAppointmentDelete.UseVisualStyleBackColor = false;
            this.btnAppointmentDelete.Click += new System.EventHandler(this.btnAppointmentDelete_Click);
            // 
            // btnAppointmentEdit
            // 
            this.btnAppointmentEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentEdit.FlatAppearance.BorderSize = 0;
            this.btnAppointmentEdit.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentEdit.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentEdit.Location = new System.Drawing.Point(278, 0);
            this.btnAppointmentEdit.Name = "btnAppointmentEdit";
            this.btnAppointmentEdit.Size = new System.Drawing.Size(75, 45);
            this.btnAppointmentEdit.TabIndex = 6;
            this.btnAppointmentEdit.Text = "Edit";
            this.btnAppointmentEdit.UseVisualStyleBackColor = false;
            this.btnAppointmentEdit.Click += new System.EventHandler(this.btnAppointmentEdit_Click);
            // 
            // btnAppointmentApprove
            // 
            this.btnAppointmentApprove.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentApprove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentApprove.FlatAppearance.BorderSize = 0;
            this.btnAppointmentApprove.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentApprove.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentApprove.Location = new System.Drawing.Point(185, 0);
            this.btnAppointmentApprove.Name = "btnAppointmentApprove";
            this.btnAppointmentApprove.Size = new System.Drawing.Size(93, 45);
            this.btnAppointmentApprove.TabIndex = 6;
            this.btnAppointmentApprove.Text = "Approve";
            this.btnAppointmentApprove.UseVisualStyleBackColor = false;
            this.btnAppointmentApprove.Click += new System.EventHandler(this.btnAppointmentApprove_Click);
            // 
            // btnAppointmentComplete
            // 
            this.btnAppointmentComplete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentComplete.FlatAppearance.BorderSize = 0;
            this.btnAppointmentComplete.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentComplete.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentComplete.Location = new System.Drawing.Point(83, 0);
            this.btnAppointmentComplete.Name = "btnAppointmentComplete";
            this.btnAppointmentComplete.Size = new System.Drawing.Size(102, 45);
            this.btnAppointmentComplete.TabIndex = 6;
            this.btnAppointmentComplete.Text = "Complete";
            this.btnAppointmentComplete.UseVisualStyleBackColor = false;
            this.btnAppointmentComplete.Click += new System.EventHandler(this.btnAppointmentComplete_Click);
            // 
            // btnAppointmentPrint
            // 
            this.btnAppointmentPrint.BackColor = System.Drawing.SystemColors.Info;
            this.btnAppointmentPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentPrint.FlatAppearance.BorderSize = 0;
            this.btnAppointmentPrint.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointmentPrint.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAppointmentPrint.Location = new System.Drawing.Point(0, 0);
            this.btnAppointmentPrint.Name = "btnAppointmentPrint";
            this.btnAppointmentPrint.Size = new System.Drawing.Size(83, 45);
            this.btnAppointmentPrint.TabIndex = 6;
            this.btnAppointmentPrint.Text = "PRINT PDF";
            this.btnAppointmentPrint.UseVisualStyleBackColor = false;
            this.btnAppointmentPrint.Click += new System.EventHandler(this.btnAppointmentPrint_click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Location = new System.Drawing.Point(201, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 40);
            this.label9.TabIndex = 8;
            this.label9.Text = "Appointment Module";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Location = new System.Drawing.Point(315, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search By Patient Name";
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppointmentSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtAppointmentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppointmentSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentSearch.ForeColor = System.Drawing.Color.White;
            this.txtAppointmentSearch.Location = new System.Drawing.Point(319, 73);
            this.txtAppointmentSearch.Multiline = true;
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(283, 29);
            this.txtAppointmentSearch.TabIndex = 7;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // cmbFilterAppointment
            // 
            this.cmbFilterAppointment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmbFilterAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterAppointment.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterAppointment.ForeColor = System.Drawing.Color.White;
            this.cmbFilterAppointment.FormattingEnabled = true;
            this.cmbFilterAppointment.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed"});
            this.cmbFilterAppointment.Location = new System.Drawing.Point(14, 73);
            this.cmbFilterAppointment.Name = "cmbFilterAppointment";
            this.cmbFilterAppointment.Size = new System.Drawing.Size(177, 33);
            this.cmbFilterAppointment.TabIndex = 5;
            this.cmbFilterAppointment.SelectedIndexChanged += new System.EventHandler(this.cmbFilterAppointment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(13, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Filter By ";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentNo,
            this.AppointmentNumber,
            this.Patient,
            this.AppointmentDate,
            this.AppointmentTime,
            this.SpecialtyArea,
            this.MedicalOfficer,
            this.Symptom,
            this.AppointmentStatus});
            this.dgvAppointment.Location = new System.Drawing.Point(9, 135);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(658, 397);
            this.dgvAppointment.TabIndex = 3;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointment_CellClick);
            // 
            // AppointmentNo
            // 
            this.AppointmentNo.DataPropertyName = "AppointmentNo";
            this.AppointmentNo.HeaderText = "Appointment #";
            this.AppointmentNo.MinimumWidth = 6;
            this.AppointmentNo.Name = "AppointmentNo";
            this.AppointmentNo.ReadOnly = true;
            this.AppointmentNo.Visible = false;
            this.AppointmentNo.Width = 125;
            // 
            // AppointmentNumber
            // 
            this.AppointmentNumber.DataPropertyName = "AppointmentNumber";
            this.AppointmentNumber.HeaderText = "Appointment Number";
            this.AppointmentNumber.MinimumWidth = 6;
            this.AppointmentNumber.Name = "AppointmentNumber";
            this.AppointmentNumber.ReadOnly = true;
            this.AppointmentNumber.Width = 125;
            // 
            // Patient
            // 
            this.Patient.DataPropertyName = "Patient";
            this.Patient.HeaderText = "Patient";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.Width = 125;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppDate";
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.MinimumWidth = 6;
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Width = 125;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.DataPropertyName = "AppTime";
            this.AppointmentTime.HeaderText = "Appointment Time";
            this.AppointmentTime.MinimumWidth = 6;
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.ReadOnly = true;
            this.AppointmentTime.Width = 125;
            // 
            // SpecialtyArea
            // 
            this.SpecialtyArea.DataPropertyName = "SpecialityArea";
            this.SpecialtyArea.HeaderText = "MO Specialty  Area";
            this.SpecialtyArea.MinimumWidth = 6;
            this.SpecialtyArea.Name = "SpecialtyArea";
            this.SpecialtyArea.ReadOnly = true;
            this.SpecialtyArea.Width = 125;
            // 
            // MedicalOfficer
            // 
            this.MedicalOfficer.DataPropertyName = "MedicalOfficer";
            this.MedicalOfficer.HeaderText = "Medical Officer";
            this.MedicalOfficer.MinimumWidth = 6;
            this.MedicalOfficer.Name = "MedicalOfficer";
            this.MedicalOfficer.ReadOnly = true;
            this.MedicalOfficer.Width = 120;
            // 
            // Symptom
            // 
            this.Symptom.DataPropertyName = "Symptom";
            this.Symptom.HeaderText = "Symptoms";
            this.Symptom.MinimumWidth = 6;
            this.Symptom.Name = "Symptom";
            this.Symptom.ReadOnly = true;
            this.Symptom.Width = 125;
            // 
            // AppointmentStatus
            // 
            this.AppointmentStatus.DataPropertyName = "AppointmentStatus";
            this.AppointmentStatus.HeaderText = "Appointment Status";
            this.AppointmentStatus.MinimumWidth = 6;
            this.AppointmentStatus.Name = "AppointmentStatus";
            this.AppointmentStatus.ReadOnly = true;
            this.AppointmentStatus.Width = 125;
            // 
            // AppointmentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 585);
            this.Controls.Add(this.pnlAppointmentView);
            this.Controls.Add(this.pnlFormAppointment);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(729, 456);
            this.Name = "AppointmentModule";
            this.Text = "AppointmentModule";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AppointmentModule_Load);
            this.pnlFormAppointment.ResumeLayout(false);
            this.pnlFormAppointment.PerformLayout();
            this.pnlAppointmentView.ResumeLayout(false);
            this.pnlAppointmentView.PerformLayout();
            this.pnlViewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppointmentClose;
        private System.Windows.Forms.Panel pnlFormAppointment;
        private System.Windows.Forms.Button btnAppointmentSave;
        private System.Windows.Forms.ComboBox cmbAppSpArea;
        private System.Windows.Forms.ComboBox cmbAppMO;
        private System.Windows.Forms.TextBox txtAppSymptom;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.ComboBox cmbAppPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.Button btnAppointmentClear;
        private System.Windows.Forms.Button btnAppointmentUpdate;
        private System.Windows.Forms.Panel pnlAppointmentView;
        private System.Windows.Forms.Button btnAppointmentComplete;
        private System.Windows.Forms.Button btnAppointmentApprove;
        private System.Windows.Forms.Button btnAppointmentEdit;
        private System.Windows.Forms.Button btnAppointmentDelete;
        private System.Windows.Forms.ComboBox cmbFilterAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnAppointmentPrint;
        private System.Windows.Forms.TextBox txtAppointmentNo;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlViewButtons;
        private System.Windows.Forms.Label lblShowAppointmentMsg;
        private System.Windows.Forms.Button btnAppointmentSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}