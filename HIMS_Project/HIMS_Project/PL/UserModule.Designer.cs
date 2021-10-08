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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            this.btnUsersClose = new System.Windows.Forms.Button();
            this.pnlUsersTop = new System.Windows.Forms.Panel();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCommonDetail = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.pnlPatientUser = new System.Windows.Forms.Panel();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBrowseProfile = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.pctStaffProfile = new System.Windows.Forms.PictureBox();
            this.cmbStaffSpArea = new System.Windows.Forms.ComboBox();
            this.txtStaffJoinDate = new System.Windows.Forms.DateTimePicker();
            this.pnlStaffDetail = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.pnlUsersTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlCommonDetail.SuspendLayout();
            this.pnlPatientUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStaffProfile)).BeginInit();
            this.pnlStaffDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsersClose
            // 
            this.btnUsersClose.BackColor = System.Drawing.Color.White;
            this.btnUsersClose.FlatAppearance.BorderSize = 0;
            this.btnUsersClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnUsersClose.Location = new System.Drawing.Point(8, 32);
            this.btnUsersClose.Name = "btnUsersClose";
            this.btnUsersClose.Size = new System.Drawing.Size(32, 32);
            this.btnUsersClose.TabIndex = 1;
            this.btnUsersClose.Text = "X";
            this.btnUsersClose.UseVisualStyleBackColor = false;
            this.btnUsersClose.Click += new System.EventHandler(this.btnUsersClose_Click);
            // 
            // pnlUsersTop
            // 
            this.pnlUsersTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsersTop.Controls.Add(this.cmbUserRole);
            this.pnlUsersTop.Controls.Add(this.label2);
            this.pnlUsersTop.Controls.Add(this.btnUsersClose);
            this.pnlUsersTop.Location = new System.Drawing.Point(3, 20);
            this.pnlUsersTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUsersTop.Name = "pnlUsersTop";
            this.pnlUsersTop.Size = new System.Drawing.Size(404, 77);
            this.pnlUsersTop.TabIndex = 2;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Receptionist",
            "Medical Officer",
            "Patient"});
            this.cmbUserRole.Location = new System.Drawing.Point(171, 45);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(194, 21);
            this.cmbUserRole.TabIndex = 3;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Varela Round", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Role";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(98, 0);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 42);
            this.btnUserSave.TabIndex = 0;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(13, 0);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUserUpdate.TabIndex = 0;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlCommonDetail);
            this.panel1.Controls.Add(this.pnlPatientUser);
            this.panel1.Controls.Add(this.pnlUsersTop);
            this.panel1.Controls.Add(this.pnlStaffDetail);
            this.panel1.Controls.Add(this.pnlformButtons);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Controls.Add(this.txtUserSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 902);
            this.panel1.TabIndex = 4;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserEdit.Location = new System.Drawing.Point(62, 0);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(77, 38);
            this.btnUserEdit.TabIndex = 3;
            this.btnUserEdit.Text = "Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUserDelete.Location = new System.Drawing.Point(139, 0);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(77, 38);
            this.btnUserDelete.TabIndex = 3;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(109, 557);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(1172, 279);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(157, 100);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(250, 20);
            this.txtUserSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By User Name";
            // 
            // pnlCommonDetail
            // 
            this.pnlCommonDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCommonDetail.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlCommonDetail.Location = new System.Drawing.Point(62, 173);
            this.pnlCommonDetail.Name = "pnlCommonDetail";
            this.pnlCommonDetail.Size = new System.Drawing.Size(1258, 174);
            this.pnlCommonDetail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(715, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(382, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1051, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 42);
            this.label10.TabIndex = 2;
            this.label10.Text = "Marital \r\nStatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(468, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(941, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "NIC";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(443, 120);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(223, 20);
            this.dtpDOB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(20, 129);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(306, 20);
            this.txtContact.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(494, 28);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtNIC
            // 
            this.txtNIC.Enabled = false;
            this.txtNIC.Location = new System.Drawing.Point(976, 28);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(155, 20);
            this.txtNIC.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(731, 123);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(291, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(25, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.Enabled = false;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Married",
            "Single"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(1094, 119);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(127, 21);
            this.cmbMaritalStatus.TabIndex = 5;
            // 
            // pnlPatientUser
            // 
            this.pnlPatientUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPatientUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlPatientUser.Controls.Add(this.cmbBloodGroup);
            this.pnlPatientUser.Controls.Add(this.txtAllergies);
            this.pnlPatientUser.Controls.Add(this.lblAllergies);
            this.pnlPatientUser.Controls.Add(this.lblBloodGroup);
            this.pnlPatientUser.Location = new System.Drawing.Point(62, 353);
            this.pnlPatientUser.Name = "pnlPatientUser";
            this.pnlPatientUser.Size = new System.Drawing.Size(1258, 86);
            this.pnlPatientUser.TabIndex = 4;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.White;
            this.lblBloodGroup.Location = new System.Drawing.Point(21, 4);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(118, 21);
            this.lblBloodGroup.TabIndex = 2;
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.Visible = false;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.ForeColor = System.Drawing.Color.White;
            this.lblAllergies.Location = new System.Drawing.Point(1148, 4);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(85, 21);
            this.lblAllergies.TabIndex = 2;
            this.lblAllergies.Text = "Allergies";
            this.lblAllergies.Visible = false;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Enabled = false;
            this.txtAllergies.Location = new System.Drawing.Point(398, 36);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(835, 20);
            this.txtAllergies.TabIndex = 7;
            this.txtAllergies.Visible = false;
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
            this.cmbBloodGroup.Location = new System.Drawing.Point(20, 32);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(306, 21);
            this.cmbBloodGroup.TabIndex = 6;
            this.cmbBloodGroup.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(963, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 21);
            this.label16.TabIndex = 14;
            this.label16.Text = "Specialty Area";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(484, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(43, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 21);
            this.label15.TabIndex = 15;
            this.label15.Text = "Join Date";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Enabled = false;
            this.txtStaffEmail.Location = new System.Drawing.Point(500, 29);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(263, 20);
            this.txtStaffEmail.TabIndex = 17;
            // 
            // pctStaffProfile
            // 
            this.pctStaffProfile.Location = new System.Drawing.Point(12, 6);
            this.pctStaffProfile.Name = "pctStaffProfile";
            this.pctStaffProfile.Size = new System.Drawing.Size(32, 31);
            this.pctStaffProfile.TabIndex = 13;
            this.pctStaffProfile.TabStop = false;
            // 
            // cmbStaffSpArea
            // 
            this.cmbStaffSpArea.FormattingEnabled = true;
            this.cmbStaffSpArea.Location = new System.Drawing.Point(966, 29);
            this.cmbStaffSpArea.Name = "cmbStaffSpArea";
            this.cmbStaffSpArea.Size = new System.Drawing.Size(168, 21);
            this.cmbStaffSpArea.TabIndex = 19;
            // 
            // txtStaffJoinDate
            // 
            this.txtStaffJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStaffJoinDate.Location = new System.Drawing.Point(71, 26);
            this.txtStaffJoinDate.Name = "txtStaffJoinDate";
            this.txtStaffJoinDate.Size = new System.Drawing.Size(149, 20);
            this.txtStaffJoinDate.TabIndex = 20;
            // 
            // pnlStaffDetail
            // 
            this.pnlStaffDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlStaffDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnlStaffDetail.Controls.Add(this.txtStaffJoinDate);
            this.pnlStaffDetail.Controls.Add(this.cmbStaffSpArea);
            this.pnlStaffDetail.Controls.Add(this.pctStaffProfile);
            this.pnlStaffDetail.Controls.Add(this.txtStaffEmail);
            this.pnlStaffDetail.Controls.Add(this.label15);
            this.pnlStaffDetail.Controls.Add(this.label14);
            this.pnlStaffDetail.Controls.Add(this.btnBrowseProfile);
            this.pnlStaffDetail.Controls.Add(this.label16);
            this.pnlStaffDetail.Location = new System.Drawing.Point(40, 444);
            this.pnlStaffDetail.Name = "pnlStaffDetail";
            this.pnlStaffDetail.Size = new System.Drawing.Size(1288, 87);
            this.pnlStaffDetail.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnUserEdit);
            this.panel2.Controls.Add(this.btnUserDelete);
            this.panel2.Location = new System.Drawing.Point(1075, 814);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 38);
            this.panel2.TabIndex = 4;
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlformButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlformButtons.Controls.Add(this.btnUserSave);
            this.pnlformButtons.Controls.Add(this.btnUserUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Location = new System.Drawing.Point(1064, 65);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(262, 42);
            this.pnlformButtons.TabIndex = 12;
            // 
            // UserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 861);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserModule";
            this.Text = "UserModule";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.pnlUsersTop.ResumeLayout(false);
            this.pnlUsersTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlCommonDetail.ResumeLayout(false);
            this.pnlCommonDetail.PerformLayout();
            this.pnlPatientUser.ResumeLayout(false);
            this.pnlPatientUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStaffProfile)).EndInit();
            this.pnlStaffDetail.ResumeLayout(false);
            this.pnlStaffDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlformButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsersClose;
        private System.Windows.Forms.Panel pnlUsersTop;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlCommonDetail;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPatientUser;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBrowseProfile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.PictureBox pctStaffProfile;
        private System.Windows.Forms.ComboBox cmbStaffSpArea;
        private System.Windows.Forms.DateTimePicker txtStaffJoinDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlStaffDetail;
        private System.Windows.Forms.Panel pnlformButtons;
    }
}