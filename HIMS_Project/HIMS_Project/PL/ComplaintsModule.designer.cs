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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplaintsModule));
            this.pnlComplaintTop = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnComplaintClose = new System.Windows.Forms.Button();
            this.pnlComplaintForm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnComplaintSave = new System.Windows.Forms.Button();
            this.btnComplaintUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComplaintBy = new System.Windows.Forms.ComboBox();
            this.cmbComplaintType = new System.Windows.Forms.ComboBox();
            this.txtCDescription = new System.Windows.Forms.TextBox();
            this.txtComplaintNote = new System.Windows.Forms.TextBox();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.txtComplaintId = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnComplaintEdit = new System.Windows.Forms.Button();
            this.btnComplaintDelete = new System.Windows.Forms.Button();
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.ComplaintId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplaintBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComplaintSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlComplaintTop.SuspendLayout();
            this.pnlComplaintForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlComplaintTop
            // 
            this.pnlComplaintTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlComplaintTop.Controls.Add(this.label10);
            this.pnlComplaintTop.Controls.Add(this.btnComplaintClose);
            this.pnlComplaintTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComplaintTop.Location = new System.Drawing.Point(0, 0);
            this.pnlComplaintTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlComplaintTop.Name = "pnlComplaintTop";
            this.pnlComplaintTop.Size = new System.Drawing.Size(1295, 71);
            this.pnlComplaintTop.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label10.Location = new System.Drawing.Point(484, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 39);
            this.label10.TabIndex = 7;
            this.label10.Text = "Complaint Module";
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
            // pnlComplaintForm
            // 
            this.pnlComplaintForm.BackColor = System.Drawing.Color.White;
            this.pnlComplaintForm.Controls.Add(this.label5);
            this.pnlComplaintForm.Controls.Add(this.pnlformButtons);
            this.pnlComplaintForm.Controls.Add(this.label4);
            this.pnlComplaintForm.Controls.Add(this.label3);
            this.pnlComplaintForm.Controls.Add(this.label13);
            this.pnlComplaintForm.Controls.Add(this.label12);
            this.pnlComplaintForm.Controls.Add(this.label11);
            this.pnlComplaintForm.Controls.Add(this.label1);
            this.pnlComplaintForm.Controls.Add(this.cmbComplaintBy);
            this.pnlComplaintForm.Controls.Add(this.cmbComplaintType);
            this.pnlComplaintForm.Controls.Add(this.txtCDescription);
            this.pnlComplaintForm.Controls.Add(this.txtComplaintNote);
            this.pnlComplaintForm.Controls.Add(this.txtActionTaken);
            this.pnlComplaintForm.Controls.Add(this.txtComplaintId);
            this.pnlComplaintForm.Controls.Add(this.txtPhoneNo);
            this.pnlComplaintForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComplaintForm.Location = new System.Drawing.Point(0, 71);
            this.pnlComplaintForm.Name = "pnlComplaintForm";
            this.pnlComplaintForm.Size = new System.Drawing.Size(1295, 181);
            this.pnlComplaintForm.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label5.Location = new System.Drawing.Point(1008, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Note";
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlformButtons.Controls.Add(this.btnComplaintSave);
            this.pnlformButtons.Controls.Add(this.btnComplaintUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Location = new System.Drawing.Point(983, 86);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(312, 67);
            this.pnlformButtons.TabIndex = 15;
            // 
            // btnComplaintSave
            // 
            this.btnComplaintSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComplaintSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplaintSave.BackgroundImage")));
            this.btnComplaintSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplaintSave.FlatAppearance.BorderSize = 0;
            this.btnComplaintSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComplaintSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintSave.Location = new System.Drawing.Point(0, 2);
            this.btnComplaintSave.Name = "btnComplaintSave";
            this.btnComplaintSave.Size = new System.Drawing.Size(103, 60);
            this.btnComplaintSave.TabIndex = 0;
            this.btnComplaintSave.UseVisualStyleBackColor = true;
            this.btnComplaintSave.Click += new System.EventHandler(this.btnComplaintSave_Click);
            // 
            // btnComplaintUpdate
            // 
            this.btnComplaintUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComplaintUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplaintUpdate.BackgroundImage")));
            this.btnComplaintUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplaintUpdate.FlatAppearance.BorderSize = 0;
            this.btnComplaintUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComplaintUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintUpdate.Location = new System.Drawing.Point(102, 2);
            this.btnComplaintUpdate.Name = "btnComplaintUpdate";
            this.btnComplaintUpdate.Size = new System.Drawing.Size(103, 60);
            this.btnComplaintUpdate.TabIndex = 0;
            this.btnComplaintUpdate.UseVisualStyleBackColor = true;
            this.btnComplaintUpdate.Click += new System.EventHandler(this.btnComplaintUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(205, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 60);
            this.btnClear.TabIndex = 0;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(505, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Complaint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(507, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Complaint By";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label13.Location = new System.Drawing.Point(12, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Attach Document";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label12.Location = new System.Drawing.Point(12, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Action Taken";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label11.Location = new System.Drawing.Point(12, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "Phone #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Complaint Type";
            // 
            // cmbComplaintBy
            // 
            this.cmbComplaintBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.cmbComplaintBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComplaintBy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.cmbComplaintBy.ForeColor = System.Drawing.Color.White;
            this.cmbComplaintBy.FormattingEnabled = true;
            this.cmbComplaintBy.Location = new System.Drawing.Point(640, 9);
            this.cmbComplaintBy.Name = "cmbComplaintBy";
            this.cmbComplaintBy.Size = new System.Drawing.Size(337, 32);
            this.cmbComplaintBy.TabIndex = 5;
            // 
            // cmbComplaintType
            // 
            this.cmbComplaintType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.cmbComplaintType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComplaintType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.cmbComplaintType.ForeColor = System.Drawing.Color.White;
            this.cmbComplaintType.FormattingEnabled = true;
            this.cmbComplaintType.Location = new System.Drawing.Point(162, 13);
            this.cmbComplaintType.Name = "cmbComplaintType";
            this.cmbComplaintType.Size = new System.Drawing.Size(337, 32);
            this.cmbComplaintType.TabIndex = 5;
            // 
            // txtCDescription
            // 
            this.txtCDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.txtCDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtCDescription.ForeColor = System.Drawing.Color.White;
            this.txtCDescription.Location = new System.Drawing.Point(640, 54);
            this.txtCDescription.Multiline = true;
            this.txtCDescription.Name = "txtCDescription";
            this.txtCDescription.Size = new System.Drawing.Size(337, 75);
            this.txtCDescription.TabIndex = 4;
            // 
            // txtComplaintNote
            // 
            this.txtComplaintNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplaintNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.txtComplaintNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplaintNote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtComplaintNote.ForeColor = System.Drawing.Color.White;
            this.txtComplaintNote.Location = new System.Drawing.Point(1070, 9);
            this.txtComplaintNote.Multiline = true;
            this.txtComplaintNote.Name = "txtComplaintNote";
            this.txtComplaintNote.Size = new System.Drawing.Size(179, 25);
            this.txtComplaintNote.TabIndex = 4;
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.txtActionTaken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActionTaken.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtActionTaken.ForeColor = System.Drawing.Color.White;
            this.txtActionTaken.Location = new System.Drawing.Point(163, 102);
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(337, 25);
            this.txtActionTaken.TabIndex = 2;
            // 
            // txtComplaintId
            // 
            this.txtComplaintId.Location = new System.Drawing.Point(1070, 40);
            this.txtComplaintId.Name = "txtComplaintId";
            this.txtComplaintId.Size = new System.Drawing.Size(73, 20);
            this.txtComplaintId.TabIndex = 1;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtPhoneNo.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNo.Location = new System.Drawing.Point(163, 57);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(337, 25);
            this.txtPhoneNo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvComplaint);
            this.panel1.Controls.Add(this.txtComplaintSearch);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 238);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search By Complaint Person or Complaint content";
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDgvBtn.Controls.Add(this.btnComplaintEdit);
            this.pnlDgvBtn.Controls.Add(this.btnComplaintDelete);
            this.pnlDgvBtn.Location = new System.Drawing.Point(908, 75);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(141, 151);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnComplaintEdit
            // 
            this.btnComplaintEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComplaintEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplaintEdit.BackgroundImage")));
            this.btnComplaintEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplaintEdit.FlatAppearance.BorderSize = 0;
            this.btnComplaintEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComplaintEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintEdit.Location = new System.Drawing.Point(5, 3);
            this.btnComplaintEdit.Name = "btnComplaintEdit";
            this.btnComplaintEdit.Size = new System.Drawing.Size(131, 60);
            this.btnComplaintEdit.TabIndex = 3;
            this.btnComplaintEdit.UseVisualStyleBackColor = true;
            this.btnComplaintEdit.Click += new System.EventHandler(this.btnComplaintEdit_Click);
            // 
            // btnComplaintDelete
            // 
            this.btnComplaintDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComplaintDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplaintDelete.BackgroundImage")));
            this.btnComplaintDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplaintDelete.FlatAppearance.BorderSize = 0;
            this.btnComplaintDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComplaintDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaintDelete.Location = new System.Drawing.Point(5, 88);
            this.btnComplaintDelete.Name = "btnComplaintDelete";
            this.btnComplaintDelete.Size = new System.Drawing.Size(131, 60);
            this.btnComplaintDelete.TabIndex = 3;
            this.btnComplaintDelete.UseVisualStyleBackColor = true;
            this.btnComplaintDelete.Click += new System.EventHandler(this.btnComplaintDelete_Click);
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.AllowUserToAddRows = false;
            this.dgvComplaint.AllowUserToDeleteRows = false;
            this.dgvComplaint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.dgvComplaint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComplaintId,
            this.ComplaintBy,
            this.Contact,
            this.ComDescription,
            this.CDescription,
            this.ActionTaken,
            this.Note});
            this.dgvComplaint.Location = new System.Drawing.Point(12, 63);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.ReadOnly = true;
            this.dgvComplaint.RowHeadersWidth = 70;
            this.dgvComplaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaint.Size = new System.Drawing.Size(890, 163);
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
            this.txtComplaintSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(148)))));
            this.txtComplaintSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplaintSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtComplaintSearch.ForeColor = System.Drawing.Color.White;
            this.txtComplaintSearch.Location = new System.Drawing.Point(528, 17);
            this.txtComplaintSearch.Name = "txtComplaintSearch";
            this.txtComplaintSearch.Size = new System.Drawing.Size(374, 25);
            this.txtComplaintSearch.TabIndex = 1;
            this.txtComplaintSearch.TextChanged += new System.EventHandler(this.txtComplaintSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1311, 900);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ComplaintsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1295, 764);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlComplaintForm);
            this.Controls.Add(this.pnlComplaintTop);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComplaintTop;
        private System.Windows.Forms.Button btnComplaintClose;
        private System.Windows.Forms.Panel pnlComplaintForm;
        private System.Windows.Forms.TextBox txtComplaintNote;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.TextBox txtComplaintId;
        private System.Windows.Forms.TextBox txtPhoneNo;
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
        private System.Windows.Forms.TextBox txtCDescription;
        private System.Windows.Forms.ComboBox cmbComplaintBy;
        private System.Windows.Forms.ComboBox cmbComplaintType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplaintBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}