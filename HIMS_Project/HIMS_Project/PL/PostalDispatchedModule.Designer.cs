namespace HIMS_Project.PL
{
    partial class PostalDispatchedModule
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
            this.pnlDiPostalTop = new System.Windows.Forms.Panel();
            this.btnDiPostalClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPostalForm = new System.Windows.Forms.Panel();
            this.txtDiNote = new System.Windows.Forms.TextBox();
            this.txtDiAddress = new System.Windows.Forms.TextBox();
            this.txtDiTo = new System.Windows.Forms.TextBox();
            this.txtDiPostalId = new System.Windows.Forms.TextBox();
            this.txtDiRefNo = new System.Windows.Forms.TextBox();
            this.txtDiFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnDiPostalSave = new System.Windows.Forms.Button();
            this.btnDiPostalUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnDiPostalEdit = new System.Windows.Forms.Button();
            this.btnDiPostalDelete = new System.Windows.Forms.Button();
            this.dgvDiPostal = new System.Windows.Forms.DataGridView();
            this.PostalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiPostalSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDiPostalTop.SuspendLayout();
            this.pnlPostalForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDiPostalTop
            // 
            this.pnlDiPostalTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDiPostalTop.Controls.Add(this.btnDiPostalClose);
            this.pnlDiPostalTop.Controls.Add(this.label1);
            this.pnlDiPostalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiPostalTop.Location = new System.Drawing.Point(0, 0);
            this.pnlDiPostalTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDiPostalTop.Name = "pnlDiPostalTop";
            this.pnlDiPostalTop.Size = new System.Drawing.Size(800, 42);
            this.pnlDiPostalTop.TabIndex = 5;
            // 
            // btnDiPostalClose
            // 
            this.btnDiPostalClose.BackColor = System.Drawing.Color.White;
            this.btnDiPostalClose.FlatAppearance.BorderSize = 0;
            this.btnDiPostalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiPostalClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnDiPostalClose.Location = new System.Drawing.Point(12, 5);
            this.btnDiPostalClose.Name = "btnDiPostalClose";
            this.btnDiPostalClose.Size = new System.Drawing.Size(32, 32);
            this.btnDiPostalClose.TabIndex = 1;
            this.btnDiPostalClose.Text = "X";
            this.btnDiPostalClose.UseVisualStyleBackColor = false;
            this.btnDiPostalClose.Click += new System.EventHandler(this.btnDiPostalClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispatched Postal";
            // 
            // pnlPostalForm
            // 
            this.pnlPostalForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPostalForm.Controls.Add(this.txtDiNote);
            this.pnlPostalForm.Controls.Add(this.txtDiAddress);
            this.pnlPostalForm.Controls.Add(this.txtDiTo);
            this.pnlPostalForm.Controls.Add(this.txtDiPostalId);
            this.pnlPostalForm.Controls.Add(this.txtDiRefNo);
            this.pnlPostalForm.Controls.Add(this.txtDiFrom);
            this.pnlPostalForm.Controls.Add(this.label7);
            this.pnlPostalForm.Controls.Add(this.label6);
            this.pnlPostalForm.Controls.Add(this.label8);
            this.pnlPostalForm.Controls.Add(this.label5);
            this.pnlPostalForm.Controls.Add(this.label4);
            this.pnlPostalForm.Controls.Add(this.label2);
            this.pnlPostalForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPostalForm.Location = new System.Drawing.Point(0, 42);
            this.pnlPostalForm.Name = "pnlPostalForm";
            this.pnlPostalForm.Size = new System.Drawing.Size(800, 132);
            this.pnlPostalForm.TabIndex = 6;
            // 
            // txtDiNote
            // 
            this.txtDiNote.Location = new System.Drawing.Point(512, 40);
            this.txtDiNote.Multiline = true;
            this.txtDiNote.Name = "txtDiNote";
            this.txtDiNote.Size = new System.Drawing.Size(264, 81);
            this.txtDiNote.TabIndex = 4;
            // 
            // txtDiAddress
            // 
            this.txtDiAddress.Location = new System.Drawing.Point(512, 10);
            this.txtDiAddress.Name = "txtDiAddress";
            this.txtDiAddress.Size = new System.Drawing.Size(264, 20);
            this.txtDiAddress.TabIndex = 3;
            // 
            // txtDiTo
            // 
            this.txtDiTo.Location = new System.Drawing.Point(89, 71);
            this.txtDiTo.Name = "txtDiTo";
            this.txtDiTo.Size = new System.Drawing.Size(304, 20);
            this.txtDiTo.TabIndex = 2;
            // 
            // txtDiPostalId
            // 
            this.txtDiPostalId.Location = new System.Drawing.Point(433, 56);
            this.txtDiPostalId.Name = "txtDiPostalId";
            this.txtDiPostalId.Size = new System.Drawing.Size(73, 20);
            this.txtDiPostalId.TabIndex = 1;
            // 
            // txtDiRefNo
            // 
            this.txtDiRefNo.Location = new System.Drawing.Point(89, 13);
            this.txtDiRefNo.Name = "txtDiRefNo";
            this.txtDiRefNo.Size = new System.Drawing.Size(304, 20);
            this.txtDiRefNo.TabIndex = 1;
            // 
            // txtDiFrom
            // 
            this.txtDiFrom.Location = new System.Drawing.Point(89, 39);
            this.txtDiFrom.Name = "txtDiFrom";
            this.txtDiFrom.Size = new System.Drawing.Size(304, 20);
            this.txtDiFrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ref No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "To name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attach Document";
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.btnDiPostalSave);
            this.pnlformButtons.Controls.Add(this.btnDiPostalUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 174);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(800, 34);
            this.pnlformButtons.TabIndex = 15;
            // 
            // btnDiPostalSave
            // 
            this.btnDiPostalSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalSave.Location = new System.Drawing.Point(575, 0);
            this.btnDiPostalSave.Name = "btnDiPostalSave";
            this.btnDiPostalSave.Size = new System.Drawing.Size(75, 34);
            this.btnDiPostalSave.TabIndex = 0;
            this.btnDiPostalSave.Text = "Save";
            this.btnDiPostalSave.UseVisualStyleBackColor = true;
            this.btnDiPostalSave.Click += new System.EventHandler(this.btnDiPostalSave_Click);
            // 
            // btnDiPostalUpdate
            // 
            this.btnDiPostalUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalUpdate.Location = new System.Drawing.Point(650, 0);
            this.btnDiPostalUpdate.Name = "btnDiPostalUpdate";
            this.btnDiPostalUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnDiPostalUpdate.TabIndex = 0;
            this.btnDiPostalUpdate.Text = "Update";
            this.btnDiPostalUpdate.UseVisualStyleBackColor = true;
            this.btnDiPostalUpdate.Click += new System.EventHandler(this.btnDiPostalUpdate_Click);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvDiPostal);
            this.panel1.Controls.Add(this.txtDiPostalSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 251);
            this.panel1.TabIndex = 16;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalEdit);
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalDelete);
            this.pnlDgvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvBtn.Location = new System.Drawing.Point(0, 213);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(800, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnDiPostalEdit
            // 
            this.btnDiPostalEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalEdit.Location = new System.Drawing.Point(646, 0);
            this.btnDiPostalEdit.Name = "btnDiPostalEdit";
            this.btnDiPostalEdit.Size = new System.Drawing.Size(77, 38);
            this.btnDiPostalEdit.TabIndex = 3;
            this.btnDiPostalEdit.Text = "Edit";
            this.btnDiPostalEdit.UseVisualStyleBackColor = true;
            this.btnDiPostalEdit.Click += new System.EventHandler(this.btnDiPostalEdit_Click);
            // 
            // btnDiPostalDelete
            // 
            this.btnDiPostalDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalDelete.Location = new System.Drawing.Point(723, 0);
            this.btnDiPostalDelete.Name = "btnDiPostalDelete";
            this.btnDiPostalDelete.Size = new System.Drawing.Size(77, 38);
            this.btnDiPostalDelete.TabIndex = 3;
            this.btnDiPostalDelete.Text = "Delete";
            this.btnDiPostalDelete.UseVisualStyleBackColor = true;
            this.btnDiPostalDelete.Click += new System.EventHandler(this.btnDiPostalDelete_Click);
            // 
            // dgvDiPostal
            // 
            this.dgvDiPostal.AllowUserToAddRows = false;
            this.dgvDiPostal.AllowUserToDeleteRows = false;
            this.dgvDiPostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiPostal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostalId,
            this.RefNo,
            this.MailFrom,
            this.FromAddress,
            this.ToName,
            this.Date,
            this.Note});
            this.dgvDiPostal.Location = new System.Drawing.Point(7, 38);
            this.dgvDiPostal.Name = "dgvDiPostal";
            this.dgvDiPostal.ReadOnly = true;
            this.dgvDiPostal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiPostal.Size = new System.Drawing.Size(788, 169);
            this.dgvDiPostal.TabIndex = 2;
            this.dgvDiPostal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiPostal_CellClick);
            // 
            // PostalId
            // 
            this.PostalId.DataPropertyName = "PostalId";
            this.PostalId.HeaderText = "PostalId";
            this.PostalId.Name = "PostalId";
            this.PostalId.ReadOnly = true;
            this.PostalId.Visible = false;
            // 
            // RefNo
            // 
            this.RefNo.DataPropertyName = "RefNo";
            this.RefNo.HeaderText = "Reference No";
            this.RefNo.Name = "RefNo";
            this.RefNo.ReadOnly = true;
            // 
            // MailFrom
            // 
            this.MailFrom.DataPropertyName = "MailFrom";
            this.MailFrom.HeaderText = "Mail From";
            this.MailFrom.Name = "MailFrom";
            this.MailFrom.ReadOnly = true;
            // 
            // FromAddress
            // 
            this.FromAddress.DataPropertyName = "FromAddress";
            this.FromAddress.HeaderText = "From Address";
            this.FromAddress.Name = "FromAddress";
            this.FromAddress.ReadOnly = true;
            // 
            // ToName
            // 
            this.ToName.DataPropertyName = "MailTo";
            this.ToName.HeaderText = "To Name";
            this.ToName.Name = "ToName";
            this.ToName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "MDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // txtDiPostalSearch
            // 
            this.txtDiPostalSearch.Location = new System.Drawing.Point(143, 11);
            this.txtDiPostalSearch.Name = "txtDiPostalSearch";
            this.txtDiPostalSearch.Size = new System.Drawing.Size(250, 20);
            this.txtDiPostalSearch.TabIndex = 1;
            this.txtDiPostalSearch.TextChanged += new System.EventHandler(this.txtDiPostalSearch_TextChanged);
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
            // PostalDispatchedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlformButtons);
            this.Controls.Add(this.pnlPostalForm);
            this.Controls.Add(this.pnlDiPostalTop);
            this.Name = "PostalDispatchedModule";
            this.Text = "PostalDispatchedModule";
            this.Load += new System.EventHandler(this.PostalDispatchedModule_Load);
            this.pnlDiPostalTop.ResumeLayout(false);
            this.pnlDiPostalTop.PerformLayout();
            this.pnlPostalForm.ResumeLayout(false);
            this.pnlPostalForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiPostalTop;
        private System.Windows.Forms.Button btnDiPostalClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPostalForm;
        private System.Windows.Forms.TextBox txtDiNote;
        private System.Windows.Forms.TextBox txtDiAddress;
        private System.Windows.Forms.TextBox txtDiTo;
        private System.Windows.Forms.TextBox txtDiPostalId;
        private System.Windows.Forms.TextBox txtDiRefNo;
        private System.Windows.Forms.TextBox txtDiFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnDiPostalSave;
        private System.Windows.Forms.Button btnDiPostalUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnDiPostalEdit;
        private System.Windows.Forms.Button btnDiPostalDelete;
        private System.Windows.Forms.DataGridView dgvDiPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox txtDiPostalSearch;
        private System.Windows.Forms.Label label3;
    }
}