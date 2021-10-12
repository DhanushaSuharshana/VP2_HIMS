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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnDiPostalEdit = new System.Windows.Forms.Button();
            this.btnDiPostalDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.pnlPostalForm = new System.Windows.Forms.Panel();
            this.btnDiPostalSave = new System.Windows.Forms.Button();
            this.btnDiPostalUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
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
            this.pnlDiPostalTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).BeginInit();
            this.pnlPostalForm.SuspendLayout();
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
            this.pnlDiPostalTop.Size = new System.Drawing.Size(754, 42);
            this.pnlDiPostalTop.TabIndex = 6;
            // 
            // btnDiPostalClose
            // 
            this.btnDiPostalClose.BackColor = System.Drawing.Color.White;
            this.btnDiPostalClose.FlatAppearance.BorderSize = 0;
            this.btnDiPostalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiPostalClose.ForeColor = System.Drawing.Color.Teal;
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispatched Postal";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvDiPostal);
            this.panel1.Controls.Add(this.txtDiPostalSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 543);
            this.panel1.TabIndex = 17;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalEdit);
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalDelete);
            this.pnlDgvBtn.Controls.Add(this.btnClear);
            this.pnlDgvBtn.Location = new System.Drawing.Point(12, 45);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(487, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnDiPostalEdit
            // 
            this.btnDiPostalEdit.BackColor = System.Drawing.Color.Teal;
            this.btnDiPostalEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiPostalEdit.ForeColor = System.Drawing.Color.White;
            this.btnDiPostalEdit.Location = new System.Drawing.Point(247, 0);
            this.btnDiPostalEdit.Name = "btnDiPostalEdit";
            this.btnDiPostalEdit.Size = new System.Drawing.Size(77, 38);
            this.btnDiPostalEdit.TabIndex = 3;
            this.btnDiPostalEdit.Text = "E d i t";
            this.btnDiPostalEdit.UseVisualStyleBackColor = false;
            this.btnDiPostalEdit.Click += new System.EventHandler(this.btnDiPostalEdit_Click);
            // 
            // btnDiPostalDelete
            // 
            this.btnDiPostalDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDiPostalDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDiPostalDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiPostalDelete.ForeColor = System.Drawing.Color.White;
            this.btnDiPostalDelete.Location = new System.Drawing.Point(324, 0);
            this.btnDiPostalDelete.Name = "btnDiPostalDelete";
            this.btnDiPostalDelete.Size = new System.Drawing.Size(88, 38);
            this.btnDiPostalDelete.TabIndex = 3;
            this.btnDiPostalDelete.Text = "D e l e t e";
            this.btnDiPostalDelete.UseVisualStyleBackColor = false;
            this.btnDiPostalDelete.Click += new System.EventHandler(this.btnDiPostalDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(412, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C l e a r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvDiPostal
            // 
            this.dgvDiPostal.AllowUserToAddRows = false;
            this.dgvDiPostal.AllowUserToDeleteRows = false;
            this.dgvDiPostal.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiPostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiPostal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostalId,
            this.RefNo,
            this.MailFrom,
            this.FromAddress,
            this.ToName,
            this.Date,
            this.Note});
            this.dgvDiPostal.Location = new System.Drawing.Point(12, 94);
            this.dgvDiPostal.Name = "dgvDiPostal";
            this.dgvDiPostal.ReadOnly = true;
            this.dgvDiPostal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiPostal.Size = new System.Drawing.Size(487, 429);
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
            this.txtDiPostalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiPostalSearch.BackColor = System.Drawing.Color.Teal;
            this.txtDiPostalSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiPostalSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiPostalSearch.ForeColor = System.Drawing.Color.White;
            this.txtDiPostalSearch.Location = new System.Drawing.Point(180, 8);
            this.txtDiPostalSearch.Multiline = true;
            this.txtDiPostalSearch.Name = "txtDiPostalSearch";
            this.txtDiPostalSearch.Size = new System.Drawing.Size(319, 26);
            this.txtDiPostalSearch.TabIndex = 1;
            this.txtDiPostalSearch.TextChanged += new System.EventHandler(this.txtDiPostalSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By User Name";
            // 
            // pnlPostalForm
            // 
            this.pnlPostalForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPostalForm.Controls.Add(this.btnDiPostalSave);
            this.pnlPostalForm.Controls.Add(this.btnDiPostalUpdate);
            this.pnlPostalForm.Controls.Add(this.label10);
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
            this.pnlPostalForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPostalForm.Location = new System.Drawing.Point(510, 42);
            this.pnlPostalForm.Name = "pnlPostalForm";
            this.pnlPostalForm.Size = new System.Drawing.Size(242, 543);
            this.pnlPostalForm.TabIndex = 18;
            // 
            // btnDiPostalSave
            // 
            this.btnDiPostalSave.BackColor = System.Drawing.Color.Teal;
            this.btnDiPostalSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDiPostalSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiPostalSave.ForeColor = System.Drawing.Color.White;
            this.btnDiPostalSave.Location = new System.Drawing.Point(0, 475);
            this.btnDiPostalSave.Name = "btnDiPostalSave";
            this.btnDiPostalSave.Size = new System.Drawing.Size(242, 34);
            this.btnDiPostalSave.TabIndex = 0;
            this.btnDiPostalSave.Text = "S a v e";
            this.btnDiPostalSave.UseVisualStyleBackColor = false;
            this.btnDiPostalSave.Click += new System.EventHandler(this.btnDiPostalSave_Click);
            // 
            // btnDiPostalUpdate
            // 
            this.btnDiPostalUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnDiPostalUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDiPostalUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiPostalUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDiPostalUpdate.Location = new System.Drawing.Point(0, 509);
            this.btnDiPostalUpdate.Name = "btnDiPostalUpdate";
            this.btnDiPostalUpdate.Size = new System.Drawing.Size(242, 34);
            this.btnDiPostalUpdate.TabIndex = 0;
            this.btnDiPostalUpdate.Text = "U p d a t e";
            this.btnDiPostalUpdate.UseVisualStyleBackColor = false;
            this.btnDiPostalUpdate.Click += new System.EventHandler(this.btnDiPostalUpdate_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(64, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Add Postal..";
            // 
            // txtDiNote
            // 
            this.txtDiNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiNote.BackColor = System.Drawing.Color.Teal;
            this.txtDiNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiNote.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiNote.ForeColor = System.Drawing.Color.White;
            this.txtDiNote.Location = new System.Drawing.Point(16, 328);
            this.txtDiNote.Multiline = true;
            this.txtDiNote.Name = "txtDiNote";
            this.txtDiNote.Size = new System.Drawing.Size(211, 80);
            this.txtDiNote.TabIndex = 4;
            // 
            // txtDiAddress
            // 
            this.txtDiAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiAddress.BackColor = System.Drawing.Color.Teal;
            this.txtDiAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiAddress.ForeColor = System.Drawing.Color.White;
            this.txtDiAddress.Location = new System.Drawing.Point(16, 251);
            this.txtDiAddress.Multiline = true;
            this.txtDiAddress.Name = "txtDiAddress";
            this.txtDiAddress.Size = new System.Drawing.Size(211, 52);
            this.txtDiAddress.TabIndex = 3;
            // 
            // txtDiTo
            // 
            this.txtDiTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiTo.BackColor = System.Drawing.Color.Teal;
            this.txtDiTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiTo.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiTo.ForeColor = System.Drawing.Color.White;
            this.txtDiTo.Location = new System.Drawing.Point(16, 193);
            this.txtDiTo.Multiline = true;
            this.txtDiTo.Name = "txtDiTo";
            this.txtDiTo.Size = new System.Drawing.Size(211, 26);
            this.txtDiTo.TabIndex = 2;
            // 
            // txtDiPostalId
            // 
            this.txtDiPostalId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiPostalId.BackColor = System.Drawing.Color.Teal;
            this.txtDiPostalId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiPostalId.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiPostalId.ForeColor = System.Drawing.Color.White;
            this.txtDiPostalId.Location = new System.Drawing.Point(78, 47);
            this.txtDiPostalId.Multiline = true;
            this.txtDiPostalId.Name = "txtDiPostalId";
            this.txtDiPostalId.Size = new System.Drawing.Size(35, 26);
            this.txtDiPostalId.TabIndex = 1;
            // 
            // txtDiRefNo
            // 
            this.txtDiRefNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiRefNo.BackColor = System.Drawing.Color.Teal;
            this.txtDiRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiRefNo.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiRefNo.ForeColor = System.Drawing.Color.White;
            this.txtDiRefNo.Location = new System.Drawing.Point(16, 76);
            this.txtDiRefNo.Multiline = true;
            this.txtDiRefNo.Name = "txtDiRefNo";
            this.txtDiRefNo.Size = new System.Drawing.Size(211, 26);
            this.txtDiRefNo.TabIndex = 1;
            // 
            // txtDiFrom
            // 
            this.txtDiFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiFrom.BackColor = System.Drawing.Color.Teal;
            this.txtDiFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiFrom.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtDiFrom.ForeColor = System.Drawing.Color.White;
            this.txtDiFrom.Location = new System.Drawing.Point(16, 134);
            this.txtDiFrom.Multiline = true;
            this.txtDiFrom.Name = "txtDiFrom";
            this.txtDiFrom.Size = new System.Drawing.Size(211, 26);
            this.txtDiFrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(18, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Address";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ref No";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "To name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // PostalDispatchedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 585);
            this.Controls.Add(this.pnlPostalForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDiPostalTop);
            this.Name = "PostalDispatchedModule";
            this.Text = "PostalDispatchedModule";
            this.Load += new System.EventHandler(this.PostalDispatchedModule_Load);
            this.pnlDiPostalTop.ResumeLayout(false);
            this.pnlDiPostalTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).EndInit();
            this.pnlPostalForm.ResumeLayout(false);
            this.pnlPostalForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDiPostalTop;
        private System.Windows.Forms.Button btnDiPostalClose;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnDiPostalSave;
        private System.Windows.Forms.Button btnDiPostalUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
    }
}