namespace HIMS_Project.PL
{
    partial class ComplaintsModule
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
            this.pnlComplaintTop = new System.Windows.Forms.Panel();
            this.btnComplaintClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlComplaintForm = new System.Windows.Forms.Panel();
            this.txtComplaintNote = new System.Windows.Forms.TextBox();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.txtComplaintId = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnComplaintSave = new System.Windows.Forms.Button();
            this.btnComplaintUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnComplaintEdit = new System.Windows.Forms.Button();
            this.btnComplaintDelete = new System.Windows.Forms.Button();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.txtComplaintSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCDescription = new System.Windows.Forms.TextBox();
            this.cmbComplaintType = new System.Windows.Forms.ComboBox();
            this.cmbComplaintBy = new System.Windows.Forms.ComboBox();
            this.ComplaintId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplaintBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlComplaintTop.SuspendLayout();
            this.pnlComplaintForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlComplaintTop
            // 
            this.pnlComplaintTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlComplaintTop.Controls.Add(this.btnComplaintClose);
            this.pnlComplaintTop.Controls.Add(this.label1);
            this.pnlComplaintTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComplaintTop.Location = new System.Drawing.Point(0, 0);
            this.pnlComplaintTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlComplaintTop.Name = "pnlComplaintTop";
            this.pnlComplaintTop.Size = new System.Drawing.Size(820, 40);
            this.pnlComplaintTop.TabIndex = 5;
            // 
            // btnComplaintClose
            // 
            this.btnComplaintClose.BackColor = System.Drawing.Color.White;
            this.btnComplaintClose.FlatAppearance.BorderSize = 0;
            this.btnComplaintClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaintClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnComplaintClose.Location = new System.Drawing.Point(12, 5);
            this.btnComplaintClose.Name = "btnComplaintClose";
            this.btnComplaintClose.Size = new System.Drawing.Size(32, 32);
            this.btnComplaintClose.TabIndex = 1;
            this.btnComplaintClose.Text = "X";
            this.btnComplaintClose.UseVisualStyleBackColor = false;
            this.btnComplaintClose.Click += new System.EventHandler(this.btnComplaintClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Module";
            // 
            // pnlComplaintForm
            // 
            this.pnlComplaintForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlComplaintForm.Controls.Add(this.cmbComplaintBy);
            this.pnlComplaintForm.Controls.Add(this.cmbComplaintType);
            this.pnlComplaintForm.Controls.Add(this.txtCDescription);
            this.pnlComplaintForm.Controls.Add(this.txtComplaintNote);
            this.pnlComplaintForm.Controls.Add(this.txtActionTaken);
            this.pnlComplaintForm.Controls.Add(this.txtComplaintId);
            this.pnlComplaintForm.Controls.Add(this.txtPhoneNo);
            this.pnlComplaintForm.Controls.Add(this.label9);
            this.pnlComplaintForm.Controls.Add(this.label7);
            this.pnlComplaintForm.Controls.Add(this.label6);
            this.pnlComplaintForm.Controls.Add(this.label8);
            this.pnlComplaintForm.Controls.Add(this.label5);
            this.pnlComplaintForm.Controls.Add(this.label4);
            this.pnlComplaintForm.Controls.Add(this.label2);
            this.pnlComplaintForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComplaintForm.Location = new System.Drawing.Point(0, 40);
            this.pnlComplaintForm.Name = "pnlComplaintForm";
            this.pnlComplaintForm.Size = new System.Drawing.Size(820, 140);
            this.pnlComplaintForm.TabIndex = 6;
            // 
            // txtComplaintNote
            // 
            this.txtComplaintNote.Location = new System.Drawing.Point(516, 86);
            this.txtComplaintNote.Multiline = true;
            this.txtComplaintNote.Name = "txtComplaintNote";
            this.txtComplaintNote.Size = new System.Drawing.Size(292, 44);
            this.txtComplaintNote.TabIndex = 4;
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Location = new System.Drawing.Point(114, 71);
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(279, 20);
            this.txtActionTaken.TabIndex = 2;
            // 
            // txtComplaintId
            // 
            this.txtComplaintId.Location = new System.Drawing.Point(431, 59);
            this.txtComplaintId.Name = "txtComplaintId";
            this.txtComplaintId.Size = new System.Drawing.Size(73, 20);
            this.txtComplaintId.TabIndex = 1;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(114, 39);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(279, 20);
            this.txtPhoneNo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Complaint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Complaint By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complaint Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Action Taken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone #";
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
            this.pnlformButtons.Controls.Add(this.btnComplaintSave);
            this.pnlformButtons.Controls.Add(this.btnComplaintUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 180);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(820, 37);
            this.pnlformButtons.TabIndex = 15;
            // 
            // btnComplaintSave
            // 
            this.btnComplaintSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintSave.Location = new System.Drawing.Point(595, 0);
            this.btnComplaintSave.Name = "btnComplaintSave";
            this.btnComplaintSave.Size = new System.Drawing.Size(75, 37);
            this.btnComplaintSave.TabIndex = 0;
            this.btnComplaintSave.Text = "Save";
            this.btnComplaintSave.UseVisualStyleBackColor = true;
            this.btnComplaintSave.Click += new System.EventHandler(this.btnComplaintSave_Click);
            // 
            // btnComplaintUpdate
            // 
            this.btnComplaintUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintUpdate.Location = new System.Drawing.Point(670, 0);
            this.btnComplaintUpdate.Name = "btnComplaintUpdate";
            this.btnComplaintUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnComplaintUpdate.TabIndex = 0;
            this.btnComplaintUpdate.Text = "Update";
            this.btnComplaintUpdate.UseVisualStyleBackColor = true;
            this.btnComplaintUpdate.Click += new System.EventHandler(this.btnComplaintUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(745, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvComplaint);
            this.panel1.Controls.Add(this.txtComplaintSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 274);
            this.panel1.TabIndex = 16;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnComplaintEdit);
            this.pnlDgvBtn.Controls.Add(this.btnComplaintDelete);
            this.pnlDgvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvBtn.Location = new System.Drawing.Point(0, 236);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(820, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnComplaintEdit
            // 
            this.btnComplaintEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintEdit.Location = new System.Drawing.Point(666, 0);
            this.btnComplaintEdit.Name = "btnComplaintEdit";
            this.btnComplaintEdit.Size = new System.Drawing.Size(77, 38);
            this.btnComplaintEdit.TabIndex = 3;
            this.btnComplaintEdit.Text = "Edit";
            this.btnComplaintEdit.UseVisualStyleBackColor = true;
            this.btnComplaintEdit.Click += new System.EventHandler(this.btnComplaintEdit_Click);
            // 
            // btnComplaintDelete
            // 
            this.btnComplaintDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintDelete.Location = new System.Drawing.Point(743, 0);
            this.btnComplaintDelete.Name = "btnComplaintDelete";
            this.btnComplaintDelete.Size = new System.Drawing.Size(77, 38);
            this.btnComplaintDelete.TabIndex = 3;
            this.btnComplaintDelete.Text = "Delete";
            this.btnComplaintDelete.UseVisualStyleBackColor = true;
            this.btnComplaintDelete.Click += new System.EventHandler(this.btnComplaintDelete_Click);
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.AllowUserToAddRows = false;
            this.dgvComplaint.AllowUserToDeleteRows = false;
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComplaintId,
            this.ComplaintBy,
            this.Contact,
            this.ComDescription,
            this.CDescription,
            this.ActionTaken,
            this.Note});
            this.dgvComplaint.Location = new System.Drawing.Point(13, 38);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.ReadOnly = true;
            this.dgvComplaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaint.Size = new System.Drawing.Size(801, 192);
            this.dgvComplaint.TabIndex = 2;
            this.dgvComplaint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaint_CellClick);
            // 
            // txtComplaintSearch
            // 
            this.txtComplaintSearch.Location = new System.Drawing.Point(294, 12);
            this.txtComplaintSearch.Name = "txtComplaintSearch";
            this.txtComplaintSearch.Size = new System.Drawing.Size(514, 20);
            this.txtComplaintSearch.TabIndex = 1;
            this.txtComplaintSearch.TextChanged += new System.EventHandler(this.txtComplaintSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By Complaint Person or Complaint content";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Note";
            // 
            // txtCDescription
            // 
            this.txtCDescription.Location = new System.Drawing.Point(516, 32);
            this.txtCDescription.Multiline = true;
            this.txtCDescription.Name = "txtCDescription";
            this.txtCDescription.Size = new System.Drawing.Size(292, 48);
            this.txtCDescription.TabIndex = 4;
            // 
            // cmbComplaintType
            // 
            this.cmbComplaintType.FormattingEnabled = true;
            this.cmbComplaintType.Location = new System.Drawing.Point(114, 12);
            this.cmbComplaintType.Name = "cmbComplaintType";
            this.cmbComplaintType.Size = new System.Drawing.Size(279, 21);
            this.cmbComplaintType.TabIndex = 5;
            // 
            // cmbComplaintBy
            // 
            this.cmbComplaintBy.FormattingEnabled = true;
            this.cmbComplaintBy.Location = new System.Drawing.Point(516, 5);
            this.cmbComplaintBy.Name = "cmbComplaintBy";
            this.cmbComplaintBy.Size = new System.Drawing.Size(292, 21);
            this.cmbComplaintBy.TabIndex = 5;
            // 
            // ComplaintId
            // 
            this.ComplaintId.DataPropertyName = "ComplaintId";
            this.ComplaintId.HeaderText = "ComplaintId";
            this.ComplaintId.Name = "ComplaintId";
            this.ComplaintId.ReadOnly = true;
            this.ComplaintId.Visible = false;
            // 
            // ComplaintBy
            // 
            this.ComplaintBy.DataPropertyName = "ComplaintBy";
            this.ComplaintBy.HeaderText = "Complaint By";
            this.ComplaintBy.Name = "ComplaintBy";
            this.ComplaintBy.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Phone #";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // ComDescription
            // 
            this.ComDescription.DataPropertyName = "ComDescription";
            this.ComDescription.HeaderText = "Complaint Type";
            this.ComDescription.Name = "ComDescription";
            this.ComDescription.ReadOnly = true;
            this.ComDescription.Width = 120;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "CDescription";
            this.CDescription.HeaderText = "Complaint";
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 200;
            // 
            // ActionTaken
            // 
            this.ActionTaken.DataPropertyName = "ActionTaken";
            this.ActionTaken.HeaderText = "Action Taken";
            this.ActionTaken.Name = "ActionTaken";
            this.ActionTaken.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // ComplaintsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlformButtons);
            this.Controls.Add(this.pnlComplaintForm);
            this.Controls.Add(this.pnlComplaintTop);
            this.Name = "ComplaintsModule";
            this.Text = "ComplaintsModule";
            this.Load += new System.EventHandler(this.ComplaintsModule_Load);
            this.pnlComplaintTop.ResumeLayout(false);
            this.pnlComplaintTop.PerformLayout();
            this.pnlComplaintForm.ResumeLayout(false);
            this.pnlComplaintForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComplaintTop;
        private System.Windows.Forms.Button btnComplaintClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlComplaintForm;
        private System.Windows.Forms.TextBox txtComplaintNote;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.TextBox txtComplaintId;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnComplaintSave;
        private System.Windows.Forms.Button btnComplaintUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnComplaintEdit;
        private System.Windows.Forms.Button btnComplaintDelete;
        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.TextBox txtComplaintSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbComplaintBy;
        private System.Windows.Forms.ComboBox cmbComplaintType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}