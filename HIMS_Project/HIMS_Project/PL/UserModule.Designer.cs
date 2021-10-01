namespace HIMS_Project.PL
{
    partial class UserModule
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
            this.btnUsersClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUsersTop = new System.Windows.Forms.Panel();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUserPersonalinfo = new System.Windows.Forms.Panel();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlStaffDetail = new System.Windows.Forms.Panel();
            this.txtStaffJoinDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStaffSpArea = new System.Windows.Forms.ComboBox();
            this.pctStaffProfile = new System.Windows.Forms.PictureBox();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBrowseProfile = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlPatientUser = new System.Windows.Forms.Panel();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.pnlCommonDetail = new System.Windows.Forms.Panel();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUsersTop.SuspendLayout();
            this.pnlUserPersonalinfo.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.pnlStaffDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStaffProfile)).BeginInit();
            this.pnlPatientUser.SuspendLayout();
            this.pnlCommonDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsersClose
            // 
            this.btnUsersClose.BackColor = System.Drawing.Color.White;
            this.btnUsersClose.FlatAppearance.BorderSize = 0;
            this.btnUsersClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnUsersClose.Location = new System.Drawing.Point(12, 5);
            this.btnUsersClose.Name = "btnUsersClose";
            this.btnUsersClose.Size = new System.Drawing.Size(32, 32);
            this.btnUsersClose.TabIndex = 1;
            this.btnUsersClose.Text = "X";
            this.btnUsersClose.UseVisualStyleBackColor = false;
            this.btnUsersClose.Click += new System.EventHandler(this.btnUsersClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users Module";
            // 
            // pnlUsersTop
            // 
            this.pnlUsersTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUsersTop.Controls.Add(this.cmbUserRole);
            this.pnlUsersTop.Controls.Add(this.label2);
            this.pnlUsersTop.Controls.Add(this.btnUsersClose);
            this.pnlUsersTop.Controls.Add(this.label1);
            this.pnlUsersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsersTop.Location = new System.Drawing.Point(0, 0);
            this.pnlUsersTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUsersTop.Name = "pnlUsersTop";
            this.pnlUsersTop.Size = new System.Drawing.Size(800, 42);
            this.pnlUsersTop.TabIndex = 2;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Receptionist",
            "Medical Officer",
            "Patient"});
            this.cmbUserRole.Location = new System.Drawing.Point(567, 12);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(194, 21);
            this.cmbUserRole.TabIndex = 3;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Role";
            // 
            // pnlUserPersonalinfo
            // 
            this.pnlUserPersonalinfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUserPersonalinfo.Controls.Add(this.pnlformButtons);
            this.pnlUserPersonalinfo.Controls.Add(this.pnlStaffDetail);
            this.pnlUserPersonalinfo.Controls.Add(this.pnlPatientUser);
            this.pnlUserPersonalinfo.Controls.Add(this.pnlCommonDetail);
            this.pnlUserPersonalinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserPersonalinfo.Location = new System.Drawing.Point(0, 42);
            this.pnlUserPersonalinfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUserPersonalinfo.Name = "pnlUserPersonalinfo";
            this.pnlUserPersonalinfo.Size = new System.Drawing.Size(800, 221);
            this.pnlUserPersonalinfo.TabIndex = 3;
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.Controls.Add(this.btnUserSave);
            this.pnlformButtons.Controls.Add(this.btnUserUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 179);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(800, 34);
            this.pnlformButtons.TabIndex = 12;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserSave.Location = new System.Drawing.Point(575, 0);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 34);
            this.btnUserSave.TabIndex = 0;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserUpdate.Location = new System.Drawing.Point(650, 0);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUserUpdate.TabIndex = 0;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(725, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pnlStaffDetail
            // 
            this.pnlStaffDetail.Controls.Add(this.txtStaffJoinDate);
            this.pnlStaffDetail.Controls.Add(this.cmbStaffSpArea);
            this.pnlStaffDetail.Controls.Add(this.pctStaffProfile);
            this.pnlStaffDetail.Controls.Add(this.txtStaffEmail);
            this.pnlStaffDetail.Controls.Add(this.label15);
            this.pnlStaffDetail.Controls.Add(this.label14);
            this.pnlStaffDetail.Controls.Add(this.btnBrowseProfile);
            this.pnlStaffDetail.Controls.Add(this.label16);
            this.pnlStaffDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStaffDetail.Location = new System.Drawing.Point(0, 112);
            this.pnlStaffDetail.Name = "pnlStaffDetail";
            this.pnlStaffDetail.Size = new System.Drawing.Size(800, 67);
            this.pnlStaffDetail.TabIndex = 5;
            // 
            // txtStaffJoinDate
            // 
            this.txtStaffJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStaffJoinDate.Location = new System.Drawing.Point(80, 30);
            this.txtStaffJoinDate.Name = "txtStaffJoinDate";
            this.txtStaffJoinDate.Size = new System.Drawing.Size(149, 20);
            this.txtStaffJoinDate.TabIndex = 20;
            // 
            // cmbStaffSpArea
            // 
            this.cmbStaffSpArea.FormattingEnabled = true;
            this.cmbStaffSpArea.Location = new System.Drawing.Point(585, 28);
            this.cmbStaffSpArea.Name = "cmbStaffSpArea";
            this.cmbStaffSpArea.Size = new System.Drawing.Size(168, 21);
            this.cmbStaffSpArea.TabIndex = 19;
            // 
            // pctStaffProfile
            // 
            this.pctStaffProfile.Location = new System.Drawing.Point(12, 6);
            this.pctStaffProfile.Name = "pctStaffProfile";
            this.pctStaffProfile.Size = new System.Drawing.Size(32, 31);
            this.pctStaffProfile.TabIndex = 13;
            this.pctStaffProfile.TabStop = false;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Enabled = false;
            this.txtStaffEmail.Location = new System.Drawing.Point(276, 29);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(263, 20);
            this.txtStaffEmail.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Join Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Email";
            // 
            // btnBrowseProfile
            // 
            this.btnBrowseProfile.Enabled = false;
            this.btnBrowseProfile.Location = new System.Drawing.Point(9, 39);
            this.btnBrowseProfile.Name = "btnBrowseProfile";
            this.btnBrowseProfile.Size = new System.Drawing.Size(37, 21);
            this.btnBrowseProfile.TabIndex = 18;
            this.btnBrowseProfile.Text = "Profile";
            this.btnBrowseProfile.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(582, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Specialty Area";
            // 
            // pnlPatientUser
            // 
            this.pnlPatientUser.Controls.Add(this.cmbBloodGroup);
            this.pnlPatientUser.Controls.Add(this.txtAllergies);
            this.pnlPatientUser.Controls.Add(this.lblAllergies);
            this.pnlPatientUser.Controls.Add(this.lblBloodGroup);
            this.pnlPatientUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatientUser.Location = new System.Drawing.Point(0, 79);
            this.pnlPatientUser.Name = "pnlPatientUser";
            this.pnlPatientUser.Size = new System.Drawing.Size(800, 33);
            this.pnlPatientUser.TabIndex = 4;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.Enabled = false;
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB",
            "O"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(80, 5);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(149, 21);
            this.cmbBloodGroup.TabIndex = 6;
            this.cmbBloodGroup.Visible = false;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Enabled = false;
            this.txtAllergies.Location = new System.Drawing.Point(328, 7);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(457, 20);
            this.txtAllergies.TabIndex = 7;
            this.txtAllergies.Visible = false;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(273, 7);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(46, 13);
            this.lblAllergies.TabIndex = 2;
            this.lblAllergies.Text = "Allergies";
            this.lblAllergies.Visible = false;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(8, 8);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblBloodGroup.TabIndex = 2;
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.Visible = false;
            // 
            // pnlCommonDetail
            // 
            this.pnlCommonDetail.Controls.Add(this.cmbMaritalStatus);
            this.pnlCommonDetail.Controls.Add(this.txtName);
            this.pnlCommonDetail.Controls.Add(this.cmbGender);
            this.pnlCommonDetail.Controls.Add(this.txtNIC);
            this.pnlCommonDetail.Controls.Add(this.txtAddress);
            this.pnlCommonDetail.Controls.Add(this.txtContact);
            this.pnlCommonDetail.Controls.Add(this.label5);
            this.pnlCommonDetail.Controls.Add(this.dtpDOB);
            this.pnlCommonDetail.Controls.Add(this.label6);
            this.pnlCommonDetail.Controls.Add(this.label11);
            this.pnlCommonDetail.Controls.Add(this.label7);
            this.pnlCommonDetail.Controls.Add(this.label10);
            this.pnlCommonDetail.Controls.Add(this.label8);
            this.pnlCommonDetail.Controls.Add(this.label9);
            this.pnlCommonDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommonDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlCommonDetail.Name = "pnlCommonDetail";
            this.pnlCommonDetail.Size = new System.Drawing.Size(800, 79);
            this.pnlCommonDetail.TabIndex = 11;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.Enabled = false;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Married",
            "Single"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(658, 44);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(127, 21);
            this.cmbMaritalStatus.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(55, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(450, 44);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(155, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // txtNIC
            // 
            this.txtNIC.Enabled = false;
            this.txtNIC.Location = new System.Drawing.Point(630, 11);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(155, 20);
            this.txtNIC.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(325, 9);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(55, 41);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(144, 20);
            this.txtContact.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(261, 44);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(132, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "NIC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Marital \r\nStatus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DOB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Controls.Add(this.txtUserSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 222);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUserEdit);
            this.panel2.Controls.Add(this.btnUserDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 4;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserEdit.Location = new System.Drawing.Point(646, 0);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(77, 38);
            this.btnUserEdit.TabIndex = 3;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserDelete.Location = new System.Drawing.Point(723, 0);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(77, 38);
            this.btnUserDelete.TabIndex = 3;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(7, 38);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(788, 140);
            this.dgvUsers.TabIndex = 2;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(143, 11);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(250, 20);
            this.txtUserSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By User Name";
            // 
            // UserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUserPersonalinfo);
            this.Controls.Add(this.pnlUsersTop);
            this.Name = "UserModule";
            this.Text = "UserModule";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.pnlUsersTop.ResumeLayout(false);
            this.pnlUsersTop.PerformLayout();
            this.pnlUserPersonalinfo.ResumeLayout(false);
            this.pnlformButtons.ResumeLayout(false);
            this.pnlStaffDetail.ResumeLayout(false);
            this.pnlStaffDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStaffProfile)).EndInit();
            this.pnlPatientUser.ResumeLayout(false);
            this.pnlPatientUser.PerformLayout();
            this.pnlCommonDetail.ResumeLayout(false);
            this.pnlCommonDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUsersTop;
        private System.Windows.Forms.Panel pnlUserPersonalinfo;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlStaffDetail;
        private System.Windows.Forms.Panel pnlPatientUser;
        private System.Windows.Forms.Panel pnlCommonDetail;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker txtStaffJoinDate;
        private System.Windows.Forms.ComboBox cmbStaffSpArea;
        private System.Windows.Forms.PictureBox pctStaffProfile;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBrowseProfile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}