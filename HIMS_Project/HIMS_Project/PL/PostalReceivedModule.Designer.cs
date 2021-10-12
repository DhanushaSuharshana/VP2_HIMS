namespace HIMS_Project.PL
{
    partial class PostalReceivedModule
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
            this.pnlRePostalTop = new System.Windows.Forms.Panel();
            this.btnRePostalClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnRePostalEdit = new System.Windows.Forms.Button();
            this.btnRePostalDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvRePostal = new System.Windows.Forms.DataGridView();
            this.PostalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRePostalSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPostalForm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRePostalSave = new System.Windows.Forms.Button();
            this.btnRePostalUpdate = new System.Windows.Forms.Button();
            this.txtReNote = new System.Windows.Forms.TextBox();
            this.txtReAddress = new System.Windows.Forms.TextBox();
            this.txtReTo = new System.Windows.Forms.TextBox();
            this.txtRePostalId = new System.Windows.Forms.TextBox();
            this.txtReRefNo = new System.Windows.Forms.TextBox();
            this.txtReFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRePostalTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePostal)).BeginInit();
            this.pnlPostalForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRePostalTop
            // 
            this.pnlRePostalTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRePostalTop.Controls.Add(this.btnRePostalClose);
            this.pnlRePostalTop.Controls.Add(this.label1);
            this.pnlRePostalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRePostalTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRePostalTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRePostalTop.Name = "pnlRePostalTop";
            this.pnlRePostalTop.Size = new System.Drawing.Size(754, 42);
            this.pnlRePostalTop.TabIndex = 5;
            // 
            // btnRePostalClose
            // 
            this.btnRePostalClose.BackColor = System.Drawing.Color.White;
            this.btnRePostalClose.FlatAppearance.BorderSize = 0;
            this.btnRePostalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePostalClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePostalClose.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRePostalClose.Location = new System.Drawing.Point(12, 5);
            this.btnRePostalClose.Name = "btnRePostalClose";
            this.btnRePostalClose.Size = new System.Drawing.Size(32, 32);
            this.btnRePostalClose.TabIndex = 1;
            this.btnRePostalClose.Text = "X";
            this.btnRePostalClose.UseVisualStyleBackColor = false;
            this.btnRePostalClose.Click += new System.EventHandler(this.btnRePostalClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(296, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Received Postal";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvRePostal);
            this.panel1.Controls.Add(this.txtRePostalSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 543);
            this.panel1.TabIndex = 16;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBtn.Controls.Add(this.btnRePostalEdit);
            this.pnlDgvBtn.Controls.Add(this.btnRePostalDelete);
            this.pnlDgvBtn.Controls.Add(this.btnClear);
            this.pnlDgvBtn.Location = new System.Drawing.Point(12, 43);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(487, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnRePostalEdit
            // 
            this.btnRePostalEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRePostalEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnRePostalEdit.ForeColor = System.Drawing.Color.White;
            this.btnRePostalEdit.Location = new System.Drawing.Point(247, 0);
            this.btnRePostalEdit.Name = "btnRePostalEdit";
            this.btnRePostalEdit.Size = new System.Drawing.Size(77, 38);
            this.btnRePostalEdit.TabIndex = 3;
            this.btnRePostalEdit.Text = "E d i t";
            this.btnRePostalEdit.UseVisualStyleBackColor = false;
            this.btnRePostalEdit.Click += new System.EventHandler(this.btnRePostalEdit_Click);
            // 
            // btnRePostalDelete
            // 
            this.btnRePostalDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRePostalDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnRePostalDelete.ForeColor = System.Drawing.Color.White;
            this.btnRePostalDelete.Location = new System.Drawing.Point(324, 0);
            this.btnRePostalDelete.Name = "btnRePostalDelete";
            this.btnRePostalDelete.Size = new System.Drawing.Size(88, 38);
            this.btnRePostalDelete.TabIndex = 3;
            this.btnRePostalDelete.Text = "D e l e t e";
            this.btnRePostalDelete.UseVisualStyleBackColor = false;
            this.btnRePostalDelete.Click += new System.EventHandler(this.btnRePostalDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
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
            // dgvRePostal
            // 
            this.dgvRePostal.AllowUserToAddRows = false;
            this.dgvRePostal.AllowUserToDeleteRows = false;
            this.dgvRePostal.BackgroundColor = System.Drawing.Color.White;
            this.dgvRePostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRePostal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostalId,
            this.RefNo,
            this.MailFrom,
            this.FromAddress,
            this.ToName,
            this.Date,
            this.Note});
            this.dgvRePostal.Location = new System.Drawing.Point(11, 92);
            this.dgvRePostal.Name = "dgvRePostal";
            this.dgvRePostal.ReadOnly = true;
            this.dgvRePostal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRePostal.Size = new System.Drawing.Size(488, 427);
            this.dgvRePostal.TabIndex = 2;
            this.dgvRePostal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRePostal_CellClick);
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
            // txtRePostalSearch
            // 
            this.txtRePostalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRePostalSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.txtRePostalSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePostalSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtRePostalSearch.ForeColor = System.Drawing.Color.White;
            this.txtRePostalSearch.Location = new System.Drawing.Point(183, 8);
            this.txtRePostalSearch.Multiline = true;
            this.txtRePostalSearch.Name = "txtRePostalSearch";
            this.txtRePostalSearch.Size = new System.Drawing.Size(316, 26);
            this.txtRePostalSearch.TabIndex = 1;
            this.txtRePostalSearch.TextChanged += new System.EventHandler(this.txtRePostalSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By User Name";
            // 
            // pnlPostalForm
            // 
            this.pnlPostalForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPostalForm.Controls.Add(this.btnRePostalSave);
            this.pnlPostalForm.Controls.Add(this.label10);
            this.pnlPostalForm.Controls.Add(this.btnRePostalUpdate);
            this.pnlPostalForm.Controls.Add(this.txtReNote);
            this.pnlPostalForm.Controls.Add(this.txtReAddress);
            this.pnlPostalForm.Controls.Add(this.txtReTo);
            this.pnlPostalForm.Controls.Add(this.txtRePostalId);
            this.pnlPostalForm.Controls.Add(this.txtReRefNo);
            this.pnlPostalForm.Controls.Add(this.txtReFrom);
            this.pnlPostalForm.Controls.Add(this.label7);
            this.pnlPostalForm.Controls.Add(this.label6);
            this.pnlPostalForm.Controls.Add(this.label8);
            this.pnlPostalForm.Controls.Add(this.label5);
            this.pnlPostalForm.Controls.Add(this.label4);
            this.pnlPostalForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPostalForm.Location = new System.Drawing.Point(510, 42);
            this.pnlPostalForm.Name = "pnlPostalForm";
            this.pnlPostalForm.Size = new System.Drawing.Size(242, 543);
            this.pnlPostalForm.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(71, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Add Postal..";
            // 
            // btnRePostalSave
            // 
            this.btnRePostalSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRePostalSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRePostalSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnRePostalSave.ForeColor = System.Drawing.Color.White;
            this.btnRePostalSave.Location = new System.Drawing.Point(0, 475);
            this.btnRePostalSave.Name = "btnRePostalSave";
            this.btnRePostalSave.Size = new System.Drawing.Size(242, 34);
            this.btnRePostalSave.TabIndex = 0;
            this.btnRePostalSave.Text = "S a v e";
            this.btnRePostalSave.UseVisualStyleBackColor = false;
            this.btnRePostalSave.Click += new System.EventHandler(this.btnRePostalSave_Click);
            // 
            // btnRePostalUpdate
            // 
            this.btnRePostalUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRePostalUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRePostalUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnRePostalUpdate.ForeColor = System.Drawing.Color.White;
            this.btnRePostalUpdate.Location = new System.Drawing.Point(0, 509);
            this.btnRePostalUpdate.Name = "btnRePostalUpdate";
            this.btnRePostalUpdate.Size = new System.Drawing.Size(242, 34);
            this.btnRePostalUpdate.TabIndex = 0;
            this.btnRePostalUpdate.Text = "U p d a t e";
            this.btnRePostalUpdate.UseVisualStyleBackColor = false;
            this.btnRePostalUpdate.Click += new System.EventHandler(this.btnRePostalUpdate_Click);
            // 
            // txtReNote
            // 
            this.txtReNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReNote.BackColor = System.Drawing.Color.SteelBlue;
            this.txtReNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReNote.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtReNote.ForeColor = System.Drawing.Color.White;
            this.txtReNote.Location = new System.Drawing.Point(17, 356);
            this.txtReNote.Multiline = true;
            this.txtReNote.Name = "txtReNote";
            this.txtReNote.Size = new System.Drawing.Size(208, 78);
            this.txtReNote.TabIndex = 4;
            // 
            // txtReAddress
            // 
            this.txtReAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.txtReAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtReAddress.ForeColor = System.Drawing.Color.White;
            this.txtReAddress.Location = new System.Drawing.Point(17, 271);
            this.txtReAddress.Multiline = true;
            this.txtReAddress.Name = "txtReAddress";
            this.txtReAddress.Size = new System.Drawing.Size(208, 52);
            this.txtReAddress.TabIndex = 3;
            // 
            // txtReTo
            // 
            this.txtReTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReTo.BackColor = System.Drawing.Color.SteelBlue;
            this.txtReTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReTo.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtReTo.ForeColor = System.Drawing.Color.White;
            this.txtReTo.Location = new System.Drawing.Point(17, 209);
            this.txtReTo.Multiline = true;
            this.txtReTo.Name = "txtReTo";
            this.txtReTo.Size = new System.Drawing.Size(208, 25);
            this.txtReTo.TabIndex = 2;
            // 
            // txtRePostalId
            // 
            this.txtRePostalId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRePostalId.BackColor = System.Drawing.Color.SteelBlue;
            this.txtRePostalId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRePostalId.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtRePostalId.ForeColor = System.Drawing.Color.White;
            this.txtRePostalId.Location = new System.Drawing.Point(90, 67);
            this.txtRePostalId.Multiline = true;
            this.txtRePostalId.Name = "txtRePostalId";
            this.txtRePostalId.Size = new System.Drawing.Size(73, 20);
            this.txtRePostalId.TabIndex = 1;
            // 
            // txtReRefNo
            // 
            this.txtReRefNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReRefNo.BackColor = System.Drawing.Color.SteelBlue;
            this.txtReRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReRefNo.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtReRefNo.ForeColor = System.Drawing.Color.White;
            this.txtReRefNo.Location = new System.Drawing.Point(17, 92);
            this.txtReRefNo.Multiline = true;
            this.txtReRefNo.Name = "txtReRefNo";
            this.txtReRefNo.Size = new System.Drawing.Size(208, 25);
            this.txtReRefNo.TabIndex = 1;
            // 
            // txtReFrom
            // 
            this.txtReFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReFrom.BackColor = System.Drawing.Color.SteelBlue;
            this.txtReFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReFrom.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            this.txtReFrom.ForeColor = System.Drawing.Color.White;
            this.txtReFrom.Location = new System.Drawing.Point(17, 147);
            this.txtReFrom.Multiline = true;
            this.txtReFrom.Name = "txtReFrom";
            this.txtReFrom.Size = new System.Drawing.Size(208, 25);
            this.txtReFrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(18, 337);
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
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(18, 252);
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
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(18, 70);
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
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(18, 189);
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
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // PostalReceivedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 585);
            this.Controls.Add(this.pnlPostalForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRePostalTop);
            this.Name = "PostalReceivedModule";
            this.Text = "PostalReceivedModule";
            this.Load += new System.EventHandler(this.PostalReceivedModule_Load);
            this.pnlRePostalTop.ResumeLayout(false);
            this.pnlRePostalTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePostal)).EndInit();
            this.pnlPostalForm.ResumeLayout(false);
            this.pnlPostalForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRePostalTop;
        private System.Windows.Forms.Button btnRePostalClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnRePostalEdit;
        private System.Windows.Forms.Button btnRePostalDelete;
        private System.Windows.Forms.DataGridView dgvRePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox txtRePostalSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPostalForm;
        private System.Windows.Forms.TextBox txtReNote;
        private System.Windows.Forms.TextBox txtReAddress;
        private System.Windows.Forms.TextBox txtReTo;
        private System.Windows.Forms.TextBox txtRePostalId;
        private System.Windows.Forms.TextBox txtReRefNo;
        private System.Windows.Forms.TextBox txtReFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRePostalSave;
        private System.Windows.Forms.Button btnRePostalUpdate;
        private System.Windows.Forms.Label label10;
    }
}