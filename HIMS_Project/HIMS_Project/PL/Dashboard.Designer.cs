namespace HIMS_Project.PL
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMDIUserRole = new System.Windows.Forms.Label();
            this.lblMDIUsername = new System.Windows.Forms.Label();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlSubReference = new System.Windows.Forms.Panel();
            this.btnReferenceSpArea = new System.Windows.Forms.Button();
            this.btnReferenceCType = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.pnlSubPostal = new System.Windows.Forms.Panel();
            this.btnPostalDispatched = new System.Windows.Forms.Button();
            this.btnPostalReceived = new System.Windows.Forms.Button();
            this.btnPostal = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.pnlTopSpace = new System.Windows.Forms.Panel();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboardClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenuBar.SuspendLayout();
            this.pnlSubReference.SuspendLayout();
            this.pnlSubPostal.SuspendLayout();
            this.pnlTopSpace.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1217, 39);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMDIUserRole
            // 
            this.lblMDIUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMDIUserRole.AutoSize = true;
            this.lblMDIUserRole.BackColor = System.Drawing.Color.Transparent;
            this.lblMDIUserRole.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold);
            this.lblMDIUserRole.ForeColor = System.Drawing.Color.White;
            this.lblMDIUserRole.Location = new System.Drawing.Point(40, 132);
            this.lblMDIUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDIUserRole.Name = "lblMDIUserRole";
            this.lblMDIUserRole.Size = new System.Drawing.Size(76, 19);
            this.lblMDIUserRole.TabIndex = 3;
            this.lblMDIUserRole.Text = "User Role";
            this.lblMDIUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMDIUsername
            // 
            this.lblMDIUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMDIUsername.AutoSize = true;
            this.lblMDIUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblMDIUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDIUsername.ForeColor = System.Drawing.Color.White;
            this.lblMDIUsername.Location = new System.Drawing.Point(40, 90);
            this.lblMDIUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDIUsername.Name = "lblMDIUsername";
            this.lblMDIUsername.Size = new System.Drawing.Size(79, 19);
            this.lblMDIUsername.TabIndex = 4;
            this.lblMDIUsername.Text = "Username";
            this.lblMDIUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.AutoScroll = true;
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.pnlMenuBar.Controls.Add(this.label2);
            this.pnlMenuBar.Controls.Add(this.btnUser);
            this.pnlMenuBar.Controls.Add(this.pnlSubReference);
            this.pnlMenuBar.Controls.Add(this.btnReference);
            this.pnlMenuBar.Controls.Add(this.btnAppointment);
            this.pnlMenuBar.Controls.Add(this.btnComplaint);
            this.pnlMenuBar.Controls.Add(this.pnlSubPostal);
            this.pnlMenuBar.Controls.Add(this.btnPostal);
            this.pnlMenuBar.Controls.Add(this.btnVisitor);
            this.pnlMenuBar.Controls.Add(this.pnlTopSpace);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuBar.ForeColor = System.Drawing.Color.White;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(242, 894);
            this.pnlMenuBar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 831);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "   HospitalInformation\r\n   Management System\r\n  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 740);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(242, 80);
            this.btnUser.TabIndex = 10;
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlSubReference
            // 
            this.pnlSubReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.pnlSubReference.Controls.Add(this.btnReferenceSpArea);
            this.pnlSubReference.Controls.Add(this.btnReferenceCType);
            this.pnlSubReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubReference.Location = new System.Drawing.Point(0, 660);
            this.pnlSubReference.Name = "pnlSubReference";
            this.pnlSubReference.Size = new System.Drawing.Size(242, 80);
            this.pnlSubReference.TabIndex = 9;
            // 
            // btnReferenceSpArea
            // 
            this.btnReferenceSpArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferenceSpArea.FlatAppearance.BorderSize = 0;
            this.btnReferenceSpArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferenceSpArea.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferenceSpArea.ForeColor = System.Drawing.Color.White;
            this.btnReferenceSpArea.Location = new System.Drawing.Point(0, 40);
            this.btnReferenceSpArea.Name = "btnReferenceSpArea";
            this.btnReferenceSpArea.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReferenceSpArea.Size = new System.Drawing.Size(242, 40);
            this.btnReferenceSpArea.TabIndex = 1;
            this.btnReferenceSpArea.Text = "MO Speciality Area";
            this.btnReferenceSpArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferenceSpArea.UseVisualStyleBackColor = true;
            this.btnReferenceSpArea.Click += new System.EventHandler(this.btnReferenceSpArea_Click);
            // 
            // btnReferenceCType
            // 
            this.btnReferenceCType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferenceCType.FlatAppearance.BorderSize = 0;
            this.btnReferenceCType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferenceCType.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferenceCType.ForeColor = System.Drawing.Color.White;
            this.btnReferenceCType.Location = new System.Drawing.Point(0, 0);
            this.btnReferenceCType.Name = "btnReferenceCType";
            this.btnReferenceCType.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReferenceCType.Size = new System.Drawing.Size(242, 40);
            this.btnReferenceCType.TabIndex = 0;
            this.btnReferenceCType.Text = "Complaint Types";
            this.btnReferenceCType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferenceCType.UseVisualStyleBackColor = true;
            this.btnReferenceCType.Click += new System.EventHandler(this.btnReferenceCType_Click);
            // 
            // btnReference
            // 
            this.btnReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReference.FlatAppearance.BorderSize = 0;
            this.btnReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReference.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReference.ForeColor = System.Drawing.Color.White;
            this.btnReference.Image = ((System.Drawing.Image)(resources.GetObject("btnReference.Image")));
            this.btnReference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReference.Location = new System.Drawing.Point(0, 580);
            this.btnReference.Name = "btnReference";
            this.btnReference.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReference.Size = new System.Drawing.Size(242, 80);
            this.btnReference.TabIndex = 8;
            this.btnReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(0, 500);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAppointment.Size = new System.Drawing.Size(242, 80);
            this.btnAppointment.TabIndex = 7;
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnComplaint
            // 
            this.btnComplaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComplaint.FlatAppearance.BorderSize = 0;
            this.btnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaint.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaint.ForeColor = System.Drawing.Color.White;
            this.btnComplaint.Image = ((System.Drawing.Image)(resources.GetObject("btnComplaint.Image")));
            this.btnComplaint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaint.Location = new System.Drawing.Point(0, 420);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnComplaint.Size = new System.Drawing.Size(242, 80);
            this.btnComplaint.TabIndex = 6;
            this.btnComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // pnlSubPostal
            // 
            this.pnlSubPostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.pnlSubPostal.Controls.Add(this.btnPostalDispatched);
            this.pnlSubPostal.Controls.Add(this.btnPostalReceived);
            this.pnlSubPostal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubPostal.ForeColor = System.Drawing.Color.White;
            this.pnlSubPostal.Location = new System.Drawing.Point(0, 340);
            this.pnlSubPostal.Name = "pnlSubPostal";
            this.pnlSubPostal.Size = new System.Drawing.Size(242, 80);
            this.pnlSubPostal.TabIndex = 5;
            // 
            // btnPostalDispatched
            // 
            this.btnPostalDispatched.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostalDispatched.FlatAppearance.BorderSize = 0;
            this.btnPostalDispatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostalDispatched.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostalDispatched.ForeColor = System.Drawing.Color.White;
            this.btnPostalDispatched.Location = new System.Drawing.Point(0, 40);
            this.btnPostalDispatched.Name = "btnPostalDispatched";
            this.btnPostalDispatched.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPostalDispatched.Size = new System.Drawing.Size(242, 40);
            this.btnPostalDispatched.TabIndex = 1;
            this.btnPostalDispatched.Text = "Dispatched Postal";
            this.btnPostalDispatched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostalDispatched.UseVisualStyleBackColor = true;
            this.btnPostalDispatched.Click += new System.EventHandler(this.btnPostalDispatched_Click);
            // 
            // btnPostalReceived
            // 
            this.btnPostalReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostalReceived.FlatAppearance.BorderSize = 0;
            this.btnPostalReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostalReceived.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostalReceived.ForeColor = System.Drawing.Color.White;
            this.btnPostalReceived.Location = new System.Drawing.Point(0, 0);
            this.btnPostalReceived.Name = "btnPostalReceived";
            this.btnPostalReceived.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPostalReceived.Size = new System.Drawing.Size(242, 40);
            this.btnPostalReceived.TabIndex = 0;
            this.btnPostalReceived.Text = "Received Postal";
            this.btnPostalReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostalReceived.UseVisualStyleBackColor = true;
            this.btnPostalReceived.Click += new System.EventHandler(this.btnPostalReceived_Click);
            // 
            // btnPostal
            // 
            this.btnPostal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostal.FlatAppearance.BorderSize = 0;
            this.btnPostal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostal.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostal.ForeColor = System.Drawing.Color.White;
            this.btnPostal.Image = ((System.Drawing.Image)(resources.GetObject("btnPostal.Image")));
            this.btnPostal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostal.Location = new System.Drawing.Point(0, 260);
            this.btnPostal.Name = "btnPostal";
            this.btnPostal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPostal.Size = new System.Drawing.Size(242, 80);
            this.btnPostal.TabIndex = 4;
            this.btnPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostal.UseVisualStyleBackColor = true;
            this.btnPostal.Click += new System.EventHandler(this.btnPostal_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Varela Round", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.White;
            this.btnVisitor.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitor.Image")));
            this.btnVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.Location = new System.Drawing.Point(0, 180);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(242, 80);
            this.btnVisitor.TabIndex = 3;
            this.btnVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // pnlTopSpace
            // 
            this.pnlTopSpace.Controls.Add(this.btnUserProfile);
            this.pnlTopSpace.Controls.Add(this.btnLogOut);
            this.pnlTopSpace.Controls.Add(this.lblMDIUsername);
            this.pnlTopSpace.Controls.Add(this.lblMDIUserRole);
            this.pnlTopSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSpace.Name = "pnlTopSpace";
            this.pnlTopSpace.Size = new System.Drawing.Size(242, 180);
            this.pnlTopSpace.TabIndex = 2;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserProfile.Location = new System.Drawing.Point(39, 12);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(56, 51);
            this.btnUserProfile.TabIndex = 5;
            this.btnUserProfile.Text = "Pro";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Lucida Fax", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Wheat;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(170, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(53, 51);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashboardClose
            // 
            this.btnDashboardClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboardClose.BackColor = System.Drawing.Color.White;
            this.btnDashboardClose.FlatAppearance.BorderSize = 0;
            this.btnDashboardClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnDashboardClose.Location = new System.Drawing.Point(27, 3);
            this.btnDashboardClose.Name = "btnDashboardClose";
            this.btnDashboardClose.Size = new System.Drawing.Size(32, 32);
            this.btnDashboardClose.TabIndex = 0;
            this.btnDashboardClose.Text = "X";
            this.btnDashboardClose.UseVisualStyleBackColor = false;
            this.btnDashboardClose.Click += new System.EventHandler(this.btnDashboardClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlContent.Controls.Add(this.btnDashboardClose);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(242, 0);
            this.pnlContent.MinimumSize = new System.Drawing.Size(729, 456);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1028, 894);
            this.pnlContent.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1270, 894);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "Dashboard";
            this.Text = "MDI Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlSubReference.ResumeLayout(false);
            this.pnlSubPostal.ResumeLayout(false);
            this.pnlTopSpace.ResumeLayout(false);
            this.pnlTopSpace.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMDIUserRole;
        private System.Windows.Forms.Label lblMDIUsername;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlSubReference;
        private System.Windows.Forms.Button btnReferenceSpArea;
        private System.Windows.Forms.Button btnReferenceCType;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.Panel pnlSubPostal;
        private System.Windows.Forms.Button btnPostalDispatched;
        private System.Windows.Forms.Button btnPostalReceived;
        private System.Windows.Forms.Button btnPostal;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDashboardClose;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Panel pnlTopSpace;
    }
}