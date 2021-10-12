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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnComplaintEdit = new System.Windows.Forms.Button();
            this.btnComplaintDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.ComplaintId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplaintBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComplaintSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlComplaintForm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnComplaintSave = new System.Windows.Forms.Button();
            this.btnComplaintUpdate = new System.Windows.Forms.Button();
            this.cmbComplaintBy = new System.Windows.Forms.ComboBox();
            this.cmbComplaintType = new System.Windows.Forms.ComboBox();
            this.txtCDescription = new System.Windows.Forms.TextBox();
            this.txtComplaintNote = new System.Windows.Forms.TextBox();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.txtComplaintId = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlComplaintTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            this.pnlComplaintForm.SuspendLayout();
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
            this.pnlComplaintTop.Size = new System.Drawing.Size(754, 40);
            this.pnlComplaintTop.TabIndex = 6;
            // 
            // btnComplaintClose
            // 
            this.btnComplaintClose.BackColor = System.Drawing.Color.White;
            this.btnComplaintClose.FlatAppearance.BorderSize = 0;
            this.btnComplaintClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaintClose.ForeColor = System.Drawing.Color.Red;
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Module";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvComplaint);
            this.panel1.Controls.Add(this.txtComplaintSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 545);
            this.panel1.TabIndex = 17;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBtn.Controls.Add(this.btnComplaintEdit);
            this.pnlDgvBtn.Controls.Add(this.btnComplaintDelete);
            this.pnlDgvBtn.Controls.Add(this.btnClear);
            this.pnlDgvBtn.Location = new System.Drawing.Point(12, 67);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(489, 45);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnComplaintEdit
            // 
            this.btnComplaintEdit.BackColor = System.Drawing.Color.Red;
            this.btnComplaintEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplaintEdit.ForeColor = System.Drawing.Color.White;
            this.btnComplaintEdit.Location = new System.Drawing.Point(246, 0);
            this.btnComplaintEdit.Name = "btnComplaintEdit";
            this.btnComplaintEdit.Size = new System.Drawing.Size(77, 45);
            this.btnComplaintEdit.TabIndex = 3;
            this.btnComplaintEdit.Text = "E d i t";
            this.btnComplaintEdit.UseVisualStyleBackColor = false;
            this.btnComplaintEdit.Click += new System.EventHandler(this.btnComplaintEdit_Click);
            // 
            // btnComplaintDelete
            // 
            this.btnComplaintDelete.BackColor = System.Drawing.Color.Red;
            this.btnComplaintDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplaintDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplaintDelete.ForeColor = System.Drawing.Color.White;
            this.btnComplaintDelete.Location = new System.Drawing.Point(323, 0);
            this.btnComplaintDelete.Name = "btnComplaintDelete";
            this.btnComplaintDelete.Size = new System.Drawing.Size(87, 45);
            this.btnComplaintDelete.TabIndex = 3;
            this.btnComplaintDelete.Text = "D e l e t e";
            this.btnComplaintDelete.UseVisualStyleBackColor = false;
            this.btnComplaintDelete.Click += new System.EventHandler(this.btnComplaintDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(410, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C l e a r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.AllowUserToAddRows = false;
            this.dgvComplaint.AllowUserToDeleteRows = false;
            this.dgvComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplaint.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComplaintId,
            this.ComplaintBy,
            this.Contact,
            this.ComDescription,
            this.CDescription,
            this.ActionTaken,
            this.Note});
            this.dgvComplaint.Location = new System.Drawing.Point(12, 118);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.ReadOnly = true;
            this.dgvComplaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaint.Size = new System.Drawing.Size(489, 391);
            this.dgvComplaint.TabIndex = 2;
            this.dgvComplaint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaint_CellClick);
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
            // txtComplaintSearch
            // 
            this.txtComplaintSearch.BackColor = System.Drawing.Color.Red;
            this.txtComplaintSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplaintSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtComplaintSearch.ForeColor = System.Drawing.Color.White;
            this.txtComplaintSearch.Location = new System.Drawing.Point(42, 32);
            this.txtComplaintSearch.Multiline = true;
            this.txtComplaintSearch.Name = "txtComplaintSearch";
            this.txtComplaintSearch.Size = new System.Drawing.Size(418, 26);
            this.txtComplaintSearch.TabIndex = 1;
            this.txtComplaintSearch.TextChanged += new System.EventHandler(this.txtComplaintSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(58, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By Complaint Person or Complaint content";
            // 
            // pnlComplaintForm
            // 
            this.pnlComplaintForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlComplaintForm.Controls.Add(this.label10);
            this.pnlComplaintForm.Controls.Add(this.btnComplaintSave);
            this.pnlComplaintForm.Controls.Add(this.btnComplaintUpdate);
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
            this.pnlComplaintForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlComplaintForm.ForeColor = System.Drawing.Color.White;
            this.pnlComplaintForm.Location = new System.Drawing.Point(510, 40);
            this.pnlComplaintForm.Name = "pnlComplaintForm";
            this.pnlComplaintForm.Size = new System.Drawing.Size(242, 545);
            this.pnlComplaintForm.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(51, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Any Complaint ?";
            // 
            // btnComplaintSave
            // 
            this.btnComplaintSave.BackColor = System.Drawing.Color.Red;
            this.btnComplaintSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComplaintSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplaintSave.ForeColor = System.Drawing.Color.White;
            this.btnComplaintSave.Location = new System.Drawing.Point(0, 481);
            this.btnComplaintSave.Name = "btnComplaintSave";
            this.btnComplaintSave.Size = new System.Drawing.Size(242, 32);
            this.btnComplaintSave.TabIndex = 6;
            this.btnComplaintSave.Text = "S a v e";
            this.btnComplaintSave.UseVisualStyleBackColor = false;
            this.btnComplaintSave.Click += new System.EventHandler(this.btnComplaintSave_Click);
            // 
            // btnComplaintUpdate
            // 
            this.btnComplaintUpdate.BackColor = System.Drawing.Color.Red;
            this.btnComplaintUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComplaintUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplaintUpdate.ForeColor = System.Drawing.Color.White;
            this.btnComplaintUpdate.Location = new System.Drawing.Point(0, 513);
            this.btnComplaintUpdate.Name = "btnComplaintUpdate";
            this.btnComplaintUpdate.Size = new System.Drawing.Size(242, 32);
            this.btnComplaintUpdate.TabIndex = 7;
            this.btnComplaintUpdate.Text = "U p d a t e";
            this.btnComplaintUpdate.UseVisualStyleBackColor = false;
            this.btnComplaintUpdate.Click += new System.EventHandler(this.btnComplaintUpdate_Click);
            // 
            // cmbComplaintBy
            // 
            this.cmbComplaintBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComplaintBy.BackColor = System.Drawing.Color.Red;
            this.cmbComplaintBy.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.cmbComplaintBy.ForeColor = System.Drawing.Color.White;
            this.cmbComplaintBy.FormattingEnabled = true;
            this.cmbComplaintBy.Location = new System.Drawing.Point(12, 115);
            this.cmbComplaintBy.Name = "cmbComplaintBy";
            this.cmbComplaintBy.Size = new System.Drawing.Size(215, 28);
            this.cmbComplaintBy.TabIndex = 2;
            // 
            // cmbComplaintType
            // 
            this.cmbComplaintType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComplaintType.BackColor = System.Drawing.Color.Red;
            this.cmbComplaintType.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.cmbComplaintType.ForeColor = System.Drawing.Color.White;
            this.cmbComplaintType.FormattingEnabled = true;
            this.cmbComplaintType.Location = new System.Drawing.Point(12, 62);
            this.cmbComplaintType.Name = "cmbComplaintType";
            this.cmbComplaintType.Size = new System.Drawing.Size(215, 28);
            this.cmbComplaintType.TabIndex = 1;
            // 
            // txtCDescription
            // 
            this.txtCDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCDescription.BackColor = System.Drawing.Color.Red;
            this.txtCDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtCDescription.ForeColor = System.Drawing.Color.White;
            this.txtCDescription.Location = new System.Drawing.Point(12, 170);
            this.txtCDescription.Multiline = true;
            this.txtCDescription.Name = "txtCDescription";
            this.txtCDescription.Size = new System.Drawing.Size(215, 78);
            this.txtCDescription.TabIndex = 3;
            // 
            // txtComplaintNote
            // 
            this.txtComplaintNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplaintNote.BackColor = System.Drawing.Color.Red;
            this.txtComplaintNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplaintNote.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtComplaintNote.ForeColor = System.Drawing.Color.White;
            this.txtComplaintNote.Location = new System.Drawing.Point(12, 380);
            this.txtComplaintNote.Multiline = true;
            this.txtComplaintNote.Name = "txtComplaintNote";
            this.txtComplaintNote.Size = new System.Drawing.Size(215, 78);
            this.txtComplaintNote.TabIndex = 6;
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActionTaken.BackColor = System.Drawing.Color.Red;
            this.txtActionTaken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActionTaken.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtActionTaken.ForeColor = System.Drawing.Color.White;
            this.txtActionTaken.Location = new System.Drawing.Point(12, 326);
            this.txtActionTaken.Multiline = true;
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(215, 26);
            this.txtActionTaken.TabIndex = 5;
            // 
            // txtComplaintId
            // 
            this.txtComplaintId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplaintId.BackColor = System.Drawing.Color.Red;
            this.txtComplaintId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplaintId.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtComplaintId.ForeColor = System.Drawing.Color.White;
            this.txtComplaintId.Location = new System.Drawing.Point(154, 38);
            this.txtComplaintId.Multiline = true;
            this.txtComplaintId.Name = "txtComplaintId";
            this.txtComplaintId.Size = new System.Drawing.Size(73, 20);
            this.txtComplaintId.TabIndex = 1;
            this.txtComplaintId.Visible = false;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo.BackColor = System.Drawing.Color.Red;
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtPhoneNo.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNo.Location = new System.Drawing.Point(12, 275);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(215, 26);
            this.txtPhoneNo.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(9, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Note";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Complaint";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Complaint By";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Complaint Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Action Taken";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // ComplaintsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 585);
            this.Controls.Add(this.pnlComplaintForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlComplaintTop);
            this.Name = "ComplaintsModule";
            this.Text = "ComplaintsModule";
            this.Load += new System.EventHandler(this.ComplaintsModule_Load);
            this.pnlComplaintTop.ResumeLayout(false);
            this.pnlComplaintTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            this.pnlComplaintForm.ResumeLayout(false);
            this.pnlComplaintForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComplaintTop;
        private System.Windows.Forms.Button btnComplaintClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnComplaintEdit;
        private System.Windows.Forms.Button btnComplaintDelete;
        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox txtComplaintSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlComplaintForm;
        private System.Windows.Forms.ComboBox cmbComplaintBy;
        private System.Windows.Forms.ComboBox cmbComplaintType;
        private System.Windows.Forms.TextBox txtCDescription;
        private System.Windows.Forms.TextBox txtComplaintNote;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.TextBox txtComplaintId;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComplaintSave;
        private System.Windows.Forms.Button btnComplaintUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
    }
}