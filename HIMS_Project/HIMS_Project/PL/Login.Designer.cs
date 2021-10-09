namespace HIMS_Project.PL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.btnRecoverPW = new System.Windows.Forms.Button();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.btnPasswordEye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtUsername.Location = new System.Drawing.Point(83, 312);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 24);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Purple;
            this.txtPassword.Location = new System.Drawing.Point(84, 379);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(199, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(118, 467);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 43);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoginError.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoginError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginError.Location = new System.Drawing.Point(62, 526);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(0, 16);
            this.lblLoginError.TabIndex = 6;
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecoverPW
            // 
            this.btnRecoverPW.BackColor = System.Drawing.Color.Transparent;
            this.btnRecoverPW.FlatAppearance.BorderSize = 0;
            this.btnRecoverPW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecoverPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecoverPW.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverPW.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecoverPW.Image = ((System.Drawing.Image)(resources.GetObject("btnRecoverPW.Image")));
            this.btnRecoverPW.Location = new System.Drawing.Point(54, 428);
            this.btnRecoverPW.Name = "btnRecoverPW";
            this.btnRecoverPW.Size = new System.Drawing.Size(252, 31);
            this.btnRecoverPW.TabIndex = 7;
            this.btnRecoverPW.UseVisualStyleBackColor = false;
            this.btnRecoverPW.Click += new System.EventHandler(this.btnRecoverPW_Click);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginExit.FlatAppearance.BorderSize = 0;
            this.btnLoginExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginExit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginExit.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginExit.Image")));
            this.btnLoginExit.Location = new System.Drawing.Point(357, 91);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(28, 29);
            this.btnLoginExit.TabIndex = 5;
            this.btnLoginExit.UseVisualStyleBackColor = false;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // btnPasswordEye
            // 
            this.btnPasswordEye.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordEye.ForeColor = System.Drawing.Color.Transparent;
            this.btnPasswordEye.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordEye.Image")));
            this.btnPasswordEye.Location = new System.Drawing.Point(250, 374);
            this.btnPasswordEye.Name = "btnPasswordEye";
            this.btnPasswordEye.Size = new System.Drawing.Size(44, 33);
            this.btnPasswordEye.TabIndex = 9;
            this.btnPasswordEye.UseVisualStyleBackColor = false;
            this.btnPasswordEye.Click += new System.EventHandler(this.btnPasswordEye_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 609);
            this.Controls.Add(this.btnPasswordEye);
            this.Controls.Add(this.btnRecoverPW);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Button btnRecoverPW;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.Button btnPasswordEye;
    }
}