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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReqNIC = new System.Windows.Forms.TextBox();
            this.btnLoginReq = new System.Windows.Forms.Button();
            this.lblErrorRequest = new System.Windows.Forms.Label();
            this.pnlRecoverData = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReUsername = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpReqDOB = new System.Windows.Forms.DateTimePicker();
            this.pnlRecoverData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forgotten Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "To recover your username and password, \r\nPlease submit the following information." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC Number";
            // 
            // txtReqNIC
            // 
            this.txtReqNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqNIC.Location = new System.Drawing.Point(153, 126);
            this.txtReqNIC.Name = "txtReqNIC";
            this.txtReqNIC.Size = new System.Drawing.Size(204, 23);
            this.txtReqNIC.TabIndex = 5;
            // 
            // btnLoginReq
            // 
            this.btnLoginReq.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginReq.Location = new System.Drawing.Point(32, 213);
            this.btnLoginReq.Name = "btnLoginReq";
            this.btnLoginReq.Size = new System.Drawing.Size(325, 33);
            this.btnLoginReq.TabIndex = 6;
            this.btnLoginReq.Text = "Request";
            this.btnLoginReq.UseVisualStyleBackColor = true;
            this.btnLoginReq.Click += new System.EventHandler(this.btnLoginReq_Click);
            // 
            // lblErrorRequest
            // 
            this.lblErrorRequest.AutoSize = true;
            this.lblErrorRequest.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRequest.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRequest.Location = new System.Drawing.Point(128, 256);
            this.lblErrorRequest.Name = "lblErrorRequest";
            this.lblErrorRequest.Size = new System.Drawing.Size(110, 16);
            this.lblErrorRequest.TabIndex = 2;
            this.lblErrorRequest.Text = "No User Found.";
            this.lblErrorRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorRequest.Visible = false;
            // 
            // pnlRecoverData
            // 
            this.pnlRecoverData.Controls.Add(this.btnLoginBack);
            this.pnlRecoverData.Controls.Add(this.lblRePassword);
            this.pnlRecoverData.Controls.Add(this.lblReUsername);
            this.pnlRecoverData.Controls.Add(this.label7);
            this.pnlRecoverData.Controls.Add(this.label6);
            this.pnlRecoverData.Controls.Add(this.label5);
            this.pnlRecoverData.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRecoverData.Location = new System.Drawing.Point(32, 283);
            this.pnlRecoverData.Name = "pnlRecoverData";
            this.pnlRecoverData.Size = new System.Drawing.Size(325, 155);
            this.pnlRecoverData.TabIndex = 7;
            this.pnlRecoverData.Visible = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(68, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Successfully recovered.";
            // 
            // lblReUsername
            // 
            this.lblReUsername.AutoSize = true;
            this.lblReUsername.Location = new System.Drawing.Point(125, 44);
            this.lblReUsername.Name = "lblReUsername";
            this.lblReUsername.Size = new System.Drawing.Size(0, 16);
            this.lblReUsername.TabIndex = 3;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(125, 75);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(0, 16);
            this.lblRePassword.TabIndex = 4;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBack.Location = new System.Drawing.Point(26, 108);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(265, 28);
            this.btnLoginBack.TabIndex = 5;
            this.btnLoginBack.Text = "Login Now";
            this.btnLoginBack.UseVisualStyleBackColor = true;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpReqDOB
            // 
            this.dtpReqDOB.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReqDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReqDOB.Location = new System.Drawing.Point(153, 166);
            this.dtpReqDOB.Name = "dtpReqDOB";
            this.dtpReqDOB.Size = new System.Drawing.Size(200, 25);
            this.dtpReqDOB.TabIndex = 9;
            this.dtpReqDOB.Value = new System.DateTime(2021, 9, 8, 0, 0, 0, 0);
            // 
            // PasswordRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.dtpReqDOB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlRecoverData);
            this.Controls.Add(this.btnLoginReq);
            this.Controls.Add(this.txtReqNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErrorRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecover";
            this.pnlRecoverData.ResumeLayout(false);
            this.pnlRecoverData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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