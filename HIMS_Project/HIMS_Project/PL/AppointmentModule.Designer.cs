﻿namespace HIMS_Project.PL
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
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.btnAppointmentUpdate = new System.Windows.Forms.Button();
            this.btnAppointmentClear = new System.Windows.Forms.Button();
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
            this.pnlAppointmentView = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
            this.btnAppointmentPrint = new System.Windows.Forms.Button();
            this.btnAppointmentComplete = new System.Windows.Forms.Button();
            this.btnAppointmentApprove = new System.Windows.Forms.Button();
            this.btnAppointmentEdit = new System.Windows.Forms.Button();
            this.btnAppointmentDelete = new System.Windows.Forms.Button();
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
            this.pnlViewButtons = new System.Windows.Forms.Panel();
            this.lblShowAppointmentMsg = new System.Windows.Forms.Label();
            this.pnlFormAppointment.SuspendLayout();
            this.pnlAppointmentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.pnlViewButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAppointmentClose
            // 
            this.btnAppointmentClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAppointmentClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentClose.Location = new System.Drawing.Point(9, 8);
            this.btnAppointmentClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppointmentClose.Name = "btnAppointmentClose";
            this.btnAppointmentClose.Size = new System.Drawing.Size(28, 34);
            this.btnAppointmentClose.TabIndex = 0;
            this.btnAppointmentClose.Text = "X";
            this.btnAppointmentClose.UseVisualStyleBackColor = true;
            this.btnAppointmentClose.Click += new System.EventHandler(this.btnAppointmentClose_Click);
            // 
            // pnlFormAppointment
            // 
            this.pnlFormAppointment.Controls.Add(this.txtAppointmentNo);
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
            this.pnlFormAppointment.Location = new System.Drawing.Point(562, 0);
            this.pnlFormAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFormAppointment.Name = "pnlFormAppointment";
            this.pnlFormAppointment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFormAppointment.Size = new System.Drawing.Size(309, 585);
            this.pnlFormAppointment.TabIndex = 1;
            // 
            // txtAppointmentNo
            // 
            this.txtAppointmentNo.Location = new System.Drawing.Point(79, 64);
            this.txtAppointmentNo.Name = "txtAppointmentNo";
            this.txtAppointmentNo.Size = new System.Drawing.Size(50, 25);
            this.txtAppointmentNo.TabIndex = 11;
            this.txtAppointmentNo.Visible = false;
            // 
            // txtAppTime
            // 
            this.txtAppTime.Location = new System.Drawing.Point(25, 231);
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(263, 25);
            this.txtAppTime.TabIndex = 10;
            // 
            // btnAppointmentUpdate
            // 
            this.btnAppointmentUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAppointmentUpdate.Location = new System.Drawing.Point(10, 515);
            this.btnAppointmentUpdate.Name = "btnAppointmentUpdate";
            this.btnAppointmentUpdate.Size = new System.Drawing.Size(289, 30);
            this.btnAppointmentUpdate.TabIndex = 9;
            this.btnAppointmentUpdate.Text = "UPDATE";
            this.btnAppointmentUpdate.UseVisualStyleBackColor = true;
            this.btnAppointmentUpdate.Click += new System.EventHandler(this.btnAppointmentUpdate_Click);
            // 
            // btnAppointmentClear
            // 
            this.btnAppointmentClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAppointmentClear.Location = new System.Drawing.Point(456, 0);
            this.btnAppointmentClear.Name = "btnAppointmentClear";
            this.btnAppointmentClear.Size = new System.Drawing.Size(82, 60);
            this.btnAppointmentClear.TabIndex = 9;
            this.btnAppointmentClear.Text = "CLEAR ALL";
            this.btnAppointmentClear.UseVisualStyleBackColor = true;
            this.btnAppointmentClear.Click += new System.EventHandler(this.btnAppointmentClear_Click);
            // 
            // btnAppointmentSave
            // 
            this.btnAppointmentSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAppointmentSave.Location = new System.Drawing.Point(10, 545);
            this.btnAppointmentSave.Name = "btnAppointmentSave";
            this.btnAppointmentSave.Size = new System.Drawing.Size(289, 30);
            this.btnAppointmentSave.TabIndex = 9;
            this.btnAppointmentSave.Text = "SAVE";
            this.btnAppointmentSave.UseVisualStyleBackColor = true;
            this.btnAppointmentSave.Click += new System.EventHandler(this.btnAppointmentSave_Click);
            // 
            // cmbAppSpArea
            // 
            this.cmbAppSpArea.FormattingEnabled = true;
            this.cmbAppSpArea.Location = new System.Drawing.Point(25, 297);
            this.cmbAppSpArea.Name = "cmbAppSpArea";
            this.cmbAppSpArea.Size = new System.Drawing.Size(263, 25);
            this.cmbAppSpArea.TabIndex = 8;
            this.cmbAppSpArea.SelectedIndexChanged += new System.EventHandler(this.cmbAppSpArea_SelectedIndexChanged);
            // 
            // cmbAppMO
            // 
            this.cmbAppMO.FormattingEnabled = true;
            this.cmbAppMO.Location = new System.Drawing.Point(25, 363);
            this.cmbAppMO.Name = "cmbAppMO";
            this.cmbAppMO.Size = new System.Drawing.Size(263, 25);
            this.cmbAppMO.TabIndex = 7;
            // 
            // txtAppSymptom
            // 
            this.txtAppSymptom.Location = new System.Drawing.Point(25, 427);
            this.txtAppSymptom.Multiline = true;
            this.txtAppSymptom.Name = "txtAppSymptom";
            this.txtAppSymptom.Size = new System.Drawing.Size(263, 49);
            this.txtAppSymptom.TabIndex = 6;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppDate.Location = new System.Drawing.Point(22, 164);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(266, 25);
            this.dtpAppDate.TabIndex = 4;
            this.dtpAppDate.Value = new System.DateTime(2021, 9, 12, 0, 0, 0, 0);
            // 
            // cmbAppPatient
            // 
            this.cmbAppPatient.FormattingEnabled = true;
            this.cmbAppPatient.Location = new System.Drawing.Point(22, 95);
            this.cmbAppPatient.Name = "cmbAppPatient";
            this.cmbAppPatient.Size = new System.Drawing.Size(266, 25);
            this.cmbAppPatient.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Medical Officer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Specialty Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Appointment Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // pnlAppointmentView
            // 
            this.pnlAppointmentView.AutoScroll = true;
            this.pnlAppointmentView.Controls.Add(this.lblShowAppointmentMsg);
            this.pnlAppointmentView.Controls.Add(this.pnlViewButtons);
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
            this.pnlAppointmentView.Size = new System.Drawing.Size(558, 585);
            this.pnlAppointmentView.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search By Patient Name";
            // 
            // txtAppointmentSearch
            // 
            this.txtAppointmentSearch.Location = new System.Drawing.Point(238, 84);
            this.txtAppointmentSearch.Name = "txtAppointmentSearch";
            this.txtAppointmentSearch.Size = new System.Drawing.Size(307, 25);
            this.txtAppointmentSearch.TabIndex = 7;
            this.txtAppointmentSearch.TextChanged += new System.EventHandler(this.txtAppointmentSearch_TextChanged);
            // 
            // btnAppointmentPrint
            // 
            this.btnAppointmentPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentPrint.Location = new System.Drawing.Point(0, 0);
            this.btnAppointmentPrint.Name = "btnAppointmentPrint";
            this.btnAppointmentPrint.Size = new System.Drawing.Size(83, 60);
            this.btnAppointmentPrint.TabIndex = 6;
            this.btnAppointmentPrint.Text = "PRINT PDF";
            this.btnAppointmentPrint.UseVisualStyleBackColor = true;
            this.btnAppointmentPrint.Click += new System.EventHandler(this.btnAppointmentPrint_click);
            // 
            // btnAppointmentComplete
            // 
            this.btnAppointmentComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentComplete.Location = new System.Drawing.Point(83, 0);
            this.btnAppointmentComplete.Name = "btnAppointmentComplete";
            this.btnAppointmentComplete.Size = new System.Drawing.Size(83, 60);
            this.btnAppointmentComplete.TabIndex = 6;
            this.btnAppointmentComplete.Text = "COMPLETE";
            this.btnAppointmentComplete.UseVisualStyleBackColor = true;
            this.btnAppointmentComplete.Click += new System.EventHandler(this.btnAppointmentComplete_Click);
            // 
            // btnAppointmentApprove
            // 
            this.btnAppointmentApprove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentApprove.Location = new System.Drawing.Point(166, 0);
            this.btnAppointmentApprove.Name = "btnAppointmentApprove";
            this.btnAppointmentApprove.Size = new System.Drawing.Size(75, 60);
            this.btnAppointmentApprove.TabIndex = 6;
            this.btnAppointmentApprove.Text = "APPROVE";
            this.btnAppointmentApprove.UseVisualStyleBackColor = true;
            this.btnAppointmentApprove.Click += new System.EventHandler(this.btnAppointmentApprove_Click);
            // 
            // btnAppointmentEdit
            // 
            this.btnAppointmentEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentEdit.Location = new System.Drawing.Point(241, 0);
            this.btnAppointmentEdit.Name = "btnAppointmentEdit";
            this.btnAppointmentEdit.Size = new System.Drawing.Size(75, 60);
            this.btnAppointmentEdit.TabIndex = 6;
            this.btnAppointmentEdit.Text = "EDIT";
            this.btnAppointmentEdit.UseVisualStyleBackColor = true;
            this.btnAppointmentEdit.Click += new System.EventHandler(this.btnAppointmentEdit_Click);
            // 
            // btnAppointmentDelete
            // 
            this.btnAppointmentDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAppointmentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentDelete.Location = new System.Drawing.Point(316, 0);
            this.btnAppointmentDelete.Name = "btnAppointmentDelete";
            this.btnAppointmentDelete.Size = new System.Drawing.Size(75, 60);
            this.btnAppointmentDelete.TabIndex = 6;
            this.btnAppointmentDelete.Text = "DELETE";
            this.btnAppointmentDelete.UseVisualStyleBackColor = true;
            this.btnAppointmentDelete.Click += new System.EventHandler(this.btnAppointmentDelete_Click);
            // 
            // cmbFilterAppointment
            // 
            this.cmbFilterAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterAppointment.FormattingEnabled = true;
            this.cmbFilterAppointment.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed"});
            this.cmbFilterAppointment.Location = new System.Drawing.Point(13, 84);
            this.cmbFilterAppointment.Name = "cmbFilterAppointment";
            this.cmbFilterAppointment.Size = new System.Drawing.Size(163, 25);
            this.cmbFilterAppointment.TabIndex = 5;
            this.cmbFilterAppointment.SelectedIndexChanged += new System.EventHandler(this.cmbFilterAppointment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Filter By ";
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(539, 374);
            this.dgvAppointment.TabIndex = 3;
            // 
            // AppointmentNo
            // 
            this.AppointmentNo.DataPropertyName = "AppointmentNo";
            this.AppointmentNo.HeaderText = "Appointment #";
            this.AppointmentNo.Name = "AppointmentNo";
            this.AppointmentNo.Visible = false;
            // 
            // AppointmentNumber
            // 
            this.AppointmentNumber.HeaderText = "Appointment Number";
            this.AppointmentNumber.Name = "AppointmentNumber";
            // 
            // Patient
            // 
            this.Patient.DataPropertyName = "Patient";
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.DataPropertyName = "AppDate";
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.Name = "AppointmentDate";
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.DataPropertyName = "AppTime";
            this.AppointmentTime.HeaderText = "Appointment Time";
            this.AppointmentTime.Name = "AppointmentTime";
            // 
            // SpecialtyArea
            // 
            this.SpecialtyArea.DataPropertyName = "SpecialityArea";
            this.SpecialtyArea.HeaderText = "MO Specialty  Area";
            this.SpecialtyArea.Name = "SpecialtyArea";
            // 
            // MedicalOfficer
            // 
            this.MedicalOfficer.DataPropertyName = "MO_Id";
            this.MedicalOfficer.HeaderText = "Medical Officer";
            this.MedicalOfficer.Name = "MedicalOfficer";
            // 
            // Symptom
            // 
            this.Symptom.DataPropertyName = "Symptom";
            this.Symptom.HeaderText = "Symptoms";
            this.Symptom.Name = "Symptom";
            // 
            // AppointmentStatus
            // 
            this.AppointmentStatus.DataPropertyName = "AppoinmentStatus";
            this.AppointmentStatus.HeaderText = "Appointment Status";
            this.AppointmentStatus.Name = "AppointmentStatus";
            // 
            // pnlViewButtons
            // 
            this.pnlViewButtons.Controls.Add(this.btnAppointmentDelete);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentEdit);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentApprove);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentComplete);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentClear);
            this.pnlViewButtons.Controls.Add(this.btnAppointmentPrint);
            this.pnlViewButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewButtons.Location = new System.Drawing.Point(10, 515);
            this.pnlViewButtons.Name = "pnlViewButtons";
            this.pnlViewButtons.Size = new System.Drawing.Size(538, 60);
            this.pnlViewButtons.TabIndex = 10;
            // 
            // lblShowAppointmentMsg
            // 
            this.lblShowAppointmentMsg.AutoSize = true;
            this.lblShowAppointmentMsg.Location = new System.Drawing.Point(90, 112);
            this.lblShowAppointmentMsg.Name = "lblShowAppointmentMsg";
            this.lblShowAppointmentMsg.Size = new System.Drawing.Size(410, 17);
            this.lblShowAppointmentMsg.TabIndex = 11;
            this.lblShowAppointmentMsg.Text = "Appointment Numbers are available only for approved appointment.";
            this.lblShowAppointmentMsg.Visible = false;
            // 
            // AppointmentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 585);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.pnlViewButtons.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentStatus;
        private System.Windows.Forms.TextBox txtAppointmentNo;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlViewButtons;
        private System.Windows.Forms.Label lblShowAppointmentMsg;
    }
}