namespace HIMS_Project.PL
{
    partial class PasswordRecover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecover));
            this.txtReqNIC = new System.Windows.Forms.TextBox();
            this.btnLoginReq = new System.Windows.Forms.Button();
            this.lblErrorRequest = new System.Windows.Forms.Label();
            this.pnlRecoverData = new System.Windows.Forms.Panel();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblReUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpReqDOB = new System.Windows.Forms.DateTimePicker();
            this.pnlRecoverData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReqNIC
            // 
            this.txtReqNIC.BackColor = System.Drawing.Color.White;
            this.txtReqNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReqNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtReqNIC.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtReqNIC.Location = new System.Drawing.Point(562, 281);
            this.txtReqNIC.Name = "txtReqNIC";
            this.txtReqNIC.Size = new System.Drawing.Size(197, 24);
            this.txtReqNIC.TabIndex = 5;
            // 
            // btnLoginReq
            // 
            this.btnLoginReq.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginReq.FlatAppearance.BorderSize = 0;
            this.btnLoginReq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoginReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginReq.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginReq.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginReq.Image")));
            this.btnLoginReq.Location = new System.Drawing.Point(468, 380);
            this.btnLoginReq.Name = "btnLoginReq";
            this.btnLoginReq.Size = new System.Drawing.Size(259, 42);
            this.btnLoginReq.TabIndex = 6;
            this.btnLoginReq.UseVisualStyleBackColor = false;
            this.btnLoginReq.Click += new System.EventHandler(this.btnLoginReq_Click);
            // 
            // lblErrorRequest
            // 
            this.lblErrorRequest.AutoSize = true;
            this.lblErrorRequest.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorRequest.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.lblErrorRequest.ForeColor = System.Drawing.Color.Black;
            this.lblErrorRequest.Location = new System.Drawing.Point(531, 425);
            this.lblErrorRequest.Name = "lblErrorRequest";
            this.lblErrorRequest.Size = new System.Drawing.Size(109, 16);
            this.lblErrorRequest.TabIndex = 2;
            this.lblErrorRequest.Text = "No User Found.";
            this.lblErrorRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorRequest.Visible = false;
            // 
            // pnlRecoverData
            // 
            this.pnlRecoverData.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecoverData.Controls.Add(this.btnLoginBack);
            this.pnlRecoverData.Controls.Add(this.lblRePassword);
            this.pnlRecoverData.Controls.Add(this.lblReUsername);
            this.pnlRecoverData.Controls.Add(this.label7);
            this.pnlRecoverData.Controls.Add(this.label6);
            this.pnlRecoverData.Controls.Add(this.label5);
            this.pnlRecoverData.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRecoverData.Location = new System.Drawing.Point(436, 454);
            this.pnlRecoverData.Name = "pnlRecoverData";
            this.pnlRecoverData.Size = new System.Drawing.Size(316, 146);
            this.pnlRecoverData.TabIndex = 7;
            this.pnlRecoverData.Visible = false;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.FlatAppearance.BorderSize = 0;
            this.btnLoginBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBack.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBack.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginBack.Image")));
            this.btnLoginBack.Location = new System.Drawing.Point(26, 99);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(265, 42);
            this.btnLoginBack.TabIndex = 5;
            this.btnLoginBack.UseVisualStyleBackColor = true;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(125, 75);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(0, 16);
            this.lblRePassword.TabIndex = 4;
            // 
            // lblReUsername
            // 
            this.lblReUsername.AutoSize = true;
            this.lblReUsername.Location = new System.Drawing.Point(125, 44);
            this.lblReUsername.Name = "lblReUsername";
            this.lblReUsername.Size = new System.Drawing.Size(0, 16);
            this.lblReUsername.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Successfully recovered.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(762, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpReqDOB
            // 
            this.dtpReqDOB.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpReqDOB.CalendarTitleForeColor = System.Drawing.Color.LightSeaGreen;
            this.dtpReqDOB.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReqDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqDOB.Location = new System.Drawing.Point(561, 329);
            this.dtpReqDOB.Name = "dtpReqDOB";
            this.dtpReqDOB.Size = new System.Drawing.Size(198, 25);
            this.dtpReqDOB.TabIndex = 9;
            this.dtpReqDOB.Value = new System.DateTime(2021, 9, 8, 0, 0, 0, 0);
            // 
            // PasswordRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 609);
            this.Controls.Add(this.dtpReqDOB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRecoverData);
            this.Controls.Add(this.btnLoginReq);
            this.Controls.Add(this.txtReqNIC);
            this.Controls.Add(this.lblErrorRequest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecover";
            this.Load += new System.EventHandler(this.PasswordRecover_Load);
            this.pnlRecoverData.ResumeLayout(false);
            this.pnlRecoverData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReqNIC;
        private System.Windows.Forms.Button btnLoginReq;
        private System.Windows.Forms.Label lblErrorRequest;
        private System.Windows.Forms.Panel pnlRecoverData;
        private System.Windows.Forms.Button btnLoginBack;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblReUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpReqDOB;
    }
}