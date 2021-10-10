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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostalDispatchedModule));
            this.label9 = new System.Windows.Forms.Label();
            this.btnDiPostalClose = new System.Windows.Forms.Button();
            this.pnlPostalForm = new System.Windows.Forms.Panel();
            this.txtDiNote = new System.Windows.Forms.TextBox();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnDiPostalSave = new System.Windows.Forms.Button();
            this.btnDiPostalUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlDiPostalTop = new System.Windows.Forms.Panel();
            this.pnlPostalForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).BeginInit();
            this.pnlDiPostalTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label9.Location = new System.Drawing.Point(279, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(316, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dispatched Postal";
            // 
            // btnDiPostalClose
            // 
            this.btnDiPostalClose.BackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiPostalClose.BackgroundImage")));
            this.btnDiPostalClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiPostalClose.FlatAppearance.BorderSize = 0;
            this.btnDiPostalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiPostalClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnDiPostalClose.Location = new System.Drawing.Point(3, 9);
            this.btnDiPostalClose.Name = "btnDiPostalClose";
            this.btnDiPostalClose.Size = new System.Drawing.Size(32, 32);
            this.btnDiPostalClose.TabIndex = 1;
            this.btnDiPostalClose.UseVisualStyleBackColor = false;
            this.btnDiPostalClose.Click += new System.EventHandler(this.btnDiPostalClose_Click);
            // 
            // pnlPostalForm
            // 
            this.pnlPostalForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPostalForm.Controls.Add(this.txtDiNote);
            this.pnlPostalForm.Controls.Add(this.pnlformButtons);
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
            this.pnlPostalForm.Location = new System.Drawing.Point(0, 71);
            this.pnlPostalForm.Name = "pnlPostalForm";
            this.pnlPostalForm.Size = new System.Drawing.Size(923, 181);
            this.pnlPostalForm.TabIndex = 6;
            // 
            // txtDiNote
            // 
            this.txtDiNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiNote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiNote.Location = new System.Drawing.Point(482, 67);
            this.txtDiNote.Multiline = true;
            this.txtDiNote.Name = "txtDiNote";
            this.txtDiNote.Size = new System.Drawing.Size(264, 81);
            this.txtDiNote.TabIndex = 4;
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.btnDiPostalSave);
            this.pnlformButtons.Controls.Add(this.btnDiPostalUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Location = new System.Drawing.Point(762, 28);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(150, 120);
            this.pnlformButtons.TabIndex = 15;
            // 
            // btnDiPostalSave
            // 
            this.btnDiPostalSave.BackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiPostalSave.BackgroundImage")));
            this.btnDiPostalSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiPostalSave.FlatAppearance.BorderSize = 0;
            this.btnDiPostalSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalSave.Location = new System.Drawing.Point(0, 6);
            this.btnDiPostalSave.Name = "btnDiPostalSave";
            this.btnDiPostalSave.Size = new System.Drawing.Size(164, 35);
            this.btnDiPostalSave.TabIndex = 0;
            this.btnDiPostalSave.UseVisualStyleBackColor = false;
            this.btnDiPostalSave.Click += new System.EventHandler(this.btnDiPostalSave_Click);
            // 
            // btnDiPostalUpdate
            // 
            this.btnDiPostalUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiPostalUpdate.BackgroundImage")));
            this.btnDiPostalUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiPostalUpdate.FlatAppearance.BorderSize = 0;
            this.btnDiPostalUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalUpdate.Location = new System.Drawing.Point(0, 47);
            this.btnDiPostalUpdate.Name = "btnDiPostalUpdate";
            this.btnDiPostalUpdate.Size = new System.Drawing.Size(164, 35);
            this.btnDiPostalUpdate.TabIndex = 0;
            this.btnDiPostalUpdate.UseVisualStyleBackColor = false;
            this.btnDiPostalUpdate.Click += new System.EventHandler(this.btnDiPostalUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(0, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 35);
            this.btnClear.TabIndex = 0;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDiAddress
            // 
            this.txtDiAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiAddress.Location = new System.Drawing.Point(482, 25);
            this.txtDiAddress.Name = "txtDiAddress";
            this.txtDiAddress.Size = new System.Drawing.Size(264, 25);
            this.txtDiAddress.TabIndex = 3;
            // 
            // txtDiTo
            // 
            this.txtDiTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiTo.Location = new System.Drawing.Point(141, 106);
            this.txtDiTo.Name = "txtDiTo";
            this.txtDiTo.Size = new System.Drawing.Size(177, 25);
            this.txtDiTo.TabIndex = 2;
            // 
            // txtDiPostalId
            // 
            this.txtDiPostalId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiPostalId.Location = new System.Drawing.Point(386, 66);
            this.txtDiPostalId.Name = "txtDiPostalId";
            this.txtDiPostalId.Size = new System.Drawing.Size(73, 20);
            this.txtDiPostalId.TabIndex = 1;
            // 
            // txtDiRefNo
            // 
            this.txtDiRefNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiRefNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiRefNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiRefNo.Location = new System.Drawing.Point(141, 21);
            this.txtDiRefNo.Name = "txtDiRefNo";
            this.txtDiRefNo.Size = new System.Drawing.Size(177, 25);
            this.txtDiRefNo.TabIndex = 1;
            // 
            // txtDiFrom
            // 
            this.txtDiFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiFrom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiFrom.Location = new System.Drawing.Point(141, 63);
            this.txtDiFrom.Name = "txtDiFrom";
            this.txtDiFrom.Size = new System.Drawing.Size(177, 25);
            this.txtDiFrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(324, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(324, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Address";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label8.Location = new System.Drawing.Point(35, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ref No";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(35, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "To name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(35, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attach Document";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvDiPostal);
            this.panel1.Controls.Add(this.txtDiPostalSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 305);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By User Name";
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalEdit);
            this.pnlDgvBtn.Controls.Add(this.btnDiPostalDelete);
            this.pnlDgvBtn.Location = new System.Drawing.Point(715, 114);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(164, 144);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnDiPostalEdit
            // 
            this.btnDiPostalEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiPostalEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiPostalEdit.BackgroundImage")));
            this.btnDiPostalEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiPostalEdit.FlatAppearance.BorderSize = 0;
            this.btnDiPostalEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalEdit.Location = new System.Drawing.Point(32, 81);
            this.btnDiPostalEdit.Name = "btnDiPostalEdit";
            this.btnDiPostalEdit.Size = new System.Drawing.Size(103, 60);
            this.btnDiPostalEdit.TabIndex = 3;
            this.btnDiPostalEdit.UseVisualStyleBackColor = false;
            this.btnDiPostalEdit.Click += new System.EventHandler(this.btnDiPostalEdit_Click);
            // 
            // btnDiPostalDelete
            // 
            this.btnDiPostalDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiPostalDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiPostalDelete.BackgroundImage")));
            this.btnDiPostalDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiPostalDelete.FlatAppearance.BorderSize = 0;
            this.btnDiPostalDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiPostalDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiPostalDelete.Location = new System.Drawing.Point(32, 3);
            this.btnDiPostalDelete.Name = "btnDiPostalDelete";
            this.btnDiPostalDelete.Size = new System.Drawing.Size(103, 60);
            this.btnDiPostalDelete.TabIndex = 3;
            this.btnDiPostalDelete.UseVisualStyleBackColor = false;
            this.btnDiPostalDelete.Click += new System.EventHandler(this.btnDiPostalDelete_Click);
            // 
            // dgvDiPostal
            // 
            this.dgvDiPostal.AllowUserToAddRows = false;
            this.dgvDiPostal.AllowUserToDeleteRows = false;
            this.dgvDiPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDiPostal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.dgvDiPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiPostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiPostal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostalId,
            this.RefNo,
            this.MailFrom,
            this.FromAddress,
            this.ToName,
            this.Date,
            this.Note});
            this.dgvDiPostal.Location = new System.Drawing.Point(39, 60);
            this.dgvDiPostal.Name = "dgvDiPostal";
            this.dgvDiPostal.ReadOnly = true;
            this.dgvDiPostal.RowHeadersWidth = 50;
            this.dgvDiPostal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiPostal.Size = new System.Drawing.Size(653, 226);
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
            this.txtDiPostalSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiPostalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.txtDiPostalSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiPostalSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDiPostalSearch.Location = new System.Drawing.Point(267, 18);
            this.txtDiPostalSearch.Name = "txtDiPostalSearch";
            this.txtDiPostalSearch.Size = new System.Drawing.Size(281, 25);
            this.txtDiPostalSearch.TabIndex = 1;
            this.txtDiPostalSearch.TextChanged += new System.EventHandler(this.txtDiPostalSearch_TextChanged);
            // 
            // pnlDiPostalTop
            // 
            this.pnlDiPostalTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDiPostalTop.Controls.Add(this.label9);
            this.pnlDiPostalTop.Controls.Add(this.btnDiPostalClose);
            this.pnlDiPostalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDiPostalTop.Location = new System.Drawing.Point(0, 0);
            this.pnlDiPostalTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDiPostalTop.Name = "pnlDiPostalTop";
            this.pnlDiPostalTop.Size = new System.Drawing.Size(923, 71);
            this.pnlDiPostalTop.TabIndex = 5;
            // 
            // PostalDispatchedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPostalForm);
            this.Controls.Add(this.pnlDiPostalTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostalDispatchedModule";
            this.Text = "PostalDispatchedModule";
            this.Load += new System.EventHandler(this.PostalDispatchedModule_Load);
            this.pnlPostalForm.ResumeLayout(false);
            this.pnlPostalForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiPostal)).EndInit();
            this.pnlDiPostalTop.ResumeLayout(false);
            this.pnlDiPostalTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDiPostalClose;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDiPostalTop;
    }
}