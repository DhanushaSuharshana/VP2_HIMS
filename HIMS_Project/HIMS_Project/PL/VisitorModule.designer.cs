
namespace HIMS_Project.PL
{
    partial class VisitorModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtVisitorNo = new System.Windows.Forms.TextBox();
            this.txtVOutTime = new System.Windows.Forms.TextBox();
            this.txtVInTime = new System.Windows.Forms.TextBox();
            this.dtpVDate = new System.Windows.Forms.DateTimePicker();
            this.btnVBrowse = new System.Windows.Forms.Button();
            this.txtVAttachement = new System.Windows.Forms.TextBox();
            this.txtVNote = new System.Windows.Forms.TextBox();
            this.txtVNIC = new System.Windows.Forms.TextBox();
            this.txtVContact = new System.Windows.Forms.TextBox();
            this.txtVName = new System.Windows.Forms.TextBox();
            this.txtVPurpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVClrAll = new System.Windows.Forms.Button();
            this.pnlFormBtn = new System.Windows.Forms.Panel();
            this.btnVSave = new System.Windows.Forms.Button();
            this.btnVUpdate = new System.Windows.Forms.Button();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.txtVisitorSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvVisitor = new System.Windows.Forms.DataGridView();
            this.VisitorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDgvBtns = new System.Windows.Forms.Panel();
            this.btnVDelete = new System.Windows.Forms.Button();
            this.btnVEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFormBtn.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).BeginInit();
            this.pnlDgvBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnVClose
            // 
            this.btnVClose.Location = new System.Drawing.Point(14, 13);
            this.btnVClose.Name = "btnVClose";
            this.btnVClose.Size = new System.Drawing.Size(27, 23);
            this.btnVClose.TabIndex = 1;
            this.btnVClose.Text = "X";
            this.btnVClose.UseVisualStyleBackColor = true;
            this.btnVClose.Click += new System.EventHandler(this.btnVClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Module";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtVisitorNo);
            this.pnlForm.Controls.Add(this.txtVOutTime);
            this.pnlForm.Controls.Add(this.txtVInTime);
            this.pnlForm.Controls.Add(this.dtpVDate);
            this.pnlForm.Controls.Add(this.btnVBrowse);
            this.pnlForm.Controls.Add(this.txtVAttachement);
            this.pnlForm.Controls.Add(this.txtVNote);
            this.pnlForm.Controls.Add(this.txtVNIC);
            this.pnlForm.Controls.Add(this.txtVContact);
            this.pnlForm.Controls.Add(this.txtVName);
            this.pnlForm.Controls.Add(this.txtVPurpose);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.label10);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 46);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(903, 201);
            this.pnlForm.TabIndex = 1;
            // 
            // txtVisitorNo
            // 
            this.txtVisitorNo.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVisitorNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisitorNo.ForeColor = System.Drawing.Color.White;
            this.txtVisitorNo.Location = new System.Drawing.Point(153, 4);
            this.txtVisitorNo.Multiline = true;
            this.txtVisitorNo.Name = "txtVisitorNo";
            this.txtVisitorNo.Size = new System.Drawing.Size(100, 20);
            this.txtVisitorNo.TabIndex = 26;
            this.txtVisitorNo.Visible = false;
            // 
            // txtVOutTime
            // 
            this.txtVOutTime.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVOutTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVOutTime.ForeColor = System.Drawing.Color.White;
            this.txtVOutTime.Location = new System.Drawing.Point(614, 52);
            this.txtVOutTime.Multiline = true;
            this.txtVOutTime.Name = "txtVOutTime";
            this.txtVOutTime.Size = new System.Drawing.Size(274, 20);
            this.txtVOutTime.TabIndex = 25;
            // 
            // txtVInTime
            // 
            this.txtVInTime.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVInTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVInTime.ForeColor = System.Drawing.Color.White;
            this.txtVInTime.Location = new System.Drawing.Point(614, 26);
            this.txtVInTime.Multiline = true;
            this.txtVInTime.Name = "txtVInTime";
            this.txtVInTime.Size = new System.Drawing.Size(273, 20);
            this.txtVInTime.TabIndex = 24;
            // 
            // dtpVDate
            // 
            this.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVDate.Location = new System.Drawing.Point(153, 163);
            this.dtpVDate.Name = "dtpVDate";
            this.dtpVDate.Size = new System.Drawing.Size(285, 20);
            this.dtpVDate.TabIndex = 23;
            // 
            // btnVBrowse
            // 
            this.btnVBrowse.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVBrowse.Location = new System.Drawing.Point(792, 140);
            this.btnVBrowse.Name = "btnVBrowse";
            this.btnVBrowse.Size = new System.Drawing.Size(96, 23);
            this.btnVBrowse.TabIndex = 21;
            this.btnVBrowse.Text = "Browse";
            this.btnVBrowse.UseVisualStyleBackColor = true;
            // 
            // txtVAttachement
            // 
            this.txtVAttachement.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVAttachement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAttachement.ForeColor = System.Drawing.Color.White;
            this.txtVAttachement.Location = new System.Drawing.Point(614, 140);
            this.txtVAttachement.Multiline = true;
            this.txtVAttachement.Name = "txtVAttachement";
            this.txtVAttachement.Size = new System.Drawing.Size(172, 36);
            this.txtVAttachement.TabIndex = 20;
            // 
            // txtVNote
            // 
            this.txtVNote.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVNote.ForeColor = System.Drawing.Color.White;
            this.txtVNote.Location = new System.Drawing.Point(614, 82);
            this.txtVNote.Multiline = true;
            this.txtVNote.Name = "txtVNote";
            this.txtVNote.Size = new System.Drawing.Size(274, 52);
            this.txtVNote.TabIndex = 19;
            // 
            // txtVNIC
            // 
            this.txtVNIC.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVNIC.ForeColor = System.Drawing.Color.White;
            this.txtVNIC.Location = new System.Drawing.Point(153, 137);
            this.txtVNIC.Multiline = true;
            this.txtVNIC.Name = "txtVNIC";
            this.txtVNIC.Size = new System.Drawing.Size(285, 20);
            this.txtVNIC.TabIndex = 15;
            // 
            // txtVContact
            // 
            this.txtVContact.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVContact.ForeColor = System.Drawing.Color.White;
            this.txtVContact.Location = new System.Drawing.Point(153, 111);
            this.txtVContact.Multiline = true;
            this.txtVContact.Name = "txtVContact";
            this.txtVContact.Size = new System.Drawing.Size(285, 20);
            this.txtVContact.TabIndex = 14;
            // 
            // txtVName
            // 
            this.txtVName.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVName.ForeColor = System.Drawing.Color.White;
            this.txtVName.Location = new System.Drawing.Point(153, 85);
            this.txtVName.Multiline = true;
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(285, 20);
            this.txtVName.TabIndex = 13;
            // 
            // txtVPurpose
            // 
            this.txtVPurpose.BackColor = System.Drawing.Color.OrangeRed;
            this.txtVPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVPurpose.ForeColor = System.Drawing.Color.White;
            this.txtVPurpose.Location = new System.Drawing.Point(153, 26);
            this.txtVPurpose.Multiline = true;
            this.txtVPurpose.Name = "txtVPurpose";
            this.txtVPurpose.Size = new System.Drawing.Size(285, 53);
            this.txtVPurpose.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(24, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "NIC Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(501, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "In Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(501, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Out Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(501, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(501, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Attachment";
            // 
            // btnVClrAll
            // 
            this.btnVClrAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVClrAll.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVClrAll.ForeColor = System.Drawing.Color.White;
            this.btnVClrAll.Location = new System.Drawing.Point(806, 0);
            this.btnVClrAll.Name = "btnVClrAll";
            this.btnVClrAll.Size = new System.Drawing.Size(97, 43);
            this.btnVClrAll.TabIndex = 22;
            this.btnVClrAll.Text = "Clear";
            this.btnVClrAll.UseVisualStyleBackColor = true;
            this.btnVClrAll.Click += new System.EventHandler(this.btnVClrAll_Click);
            // 
            // pnlFormBtn
            // 
            this.pnlFormBtn.Controls.Add(this.btnVSave);
            this.pnlFormBtn.Controls.Add(this.btnVUpdate);
            this.pnlFormBtn.Controls.Add(this.btnVClrAll);
            this.pnlFormBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormBtn.Location = new System.Drawing.Point(0, 247);
            this.pnlFormBtn.Name = "pnlFormBtn";
            this.pnlFormBtn.Size = new System.Drawing.Size(903, 43);
            this.pnlFormBtn.TabIndex = 2;
            // 
            // btnVSave
            // 
            this.btnVSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVSave.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVSave.ForeColor = System.Drawing.Color.White;
            this.btnVSave.Location = new System.Drawing.Point(647, 0);
            this.btnVSave.Name = "btnVSave";
            this.btnVSave.Size = new System.Drawing.Size(84, 43);
            this.btnVSave.TabIndex = 24;
            this.btnVSave.Text = "Save";
            this.btnVSave.UseVisualStyleBackColor = true;
            this.btnVSave.Click += new System.EventHandler(this.btnVSave_Click);
            // 
            // btnVUpdate
            // 
            this.btnVUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVUpdate.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVUpdate.Location = new System.Drawing.Point(731, 0);
            this.btnVUpdate.Name = "btnVUpdate";
            this.btnVUpdate.Size = new System.Drawing.Size(75, 43);
            this.btnVUpdate.TabIndex = 23;
            this.btnVUpdate.Text = "Update";
            this.btnVUpdate.UseVisualStyleBackColor = true;
            this.btnVUpdate.Click += new System.EventHandler(this.btnVUpdate_Click);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.txtVisitorSearch);
            this.pnlDgv.Controls.Add(this.label11);
            this.pnlDgv.Controls.Add(this.dgvVisitor);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDgv.Location = new System.Drawing.Point(0, 290);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(903, 188);
            this.pnlDgv.TabIndex = 5;
            // 
            // txtVisitorSearch
            // 
            this.txtVisitorSearch.Location = new System.Drawing.Point(145, 21);
            this.txtVisitorSearch.Name = "txtVisitorSearch";
            this.txtVisitorSearch.Size = new System.Drawing.Size(250, 20);
            this.txtVisitorSearch.TabIndex = 7;
            this.txtVisitorSearch.TextChanged += new System.EventHandler(this.txtVisitorSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Search By User Name";
            // 
            // dgvVisitor
            // 
            this.dgvVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitorNo,
            this.Purpose,
            this.VName,
            this.Contact,
            this.NIC,
            this.VDate,
            this.InTime,
            this.OutTime,
            this.Note});
            this.dgvVisitor.Location = new System.Drawing.Point(3, 54);
            this.dgvVisitor.Name = "dgvVisitor";
            this.dgvVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitor.Size = new System.Drawing.Size(850, 128);
            this.dgvVisitor.TabIndex = 5;
            this.dgvVisitor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitor_CellClick);
            // 
            // VisitorNo
            // 
            this.VisitorNo.DataPropertyName = "VisitorNo";
            this.VisitorNo.HeaderText = "Visitor No";
            this.VisitorNo.Name = "VisitorNo";
            this.VisitorNo.Visible = false;
            // 
            // Purpose
            // 
            this.Purpose.DataPropertyName = "Purpose";
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            // 
            // VName
            // 
            this.VName.DataPropertyName = "VName";
            this.VName.HeaderText = "Name";
            this.VName.Name = "VName";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact No";
            this.Contact.Name = "Contact";
            // 
            // NIC
            // 
            this.NIC.DataPropertyName = "NIC";
            this.NIC.HeaderText = "NIC Number";
            this.NIC.Name = "NIC";
            // 
            // VDate
            // 
            this.VDate.DataPropertyName = "VDate";
            this.VDate.HeaderText = "Date";
            this.VDate.Name = "VDate";
            // 
            // InTime
            // 
            this.InTime.DataPropertyName = "InTime";
            this.InTime.HeaderText = "In Tme";
            this.InTime.Name = "InTime";
            // 
            // OutTime
            // 
            this.OutTime.DataPropertyName = "OutTime";
            this.OutTime.HeaderText = "Out Time";
            this.OutTime.Name = "OutTime";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // pnlDgvBtns
            // 
            this.pnlDgvBtns.Controls.Add(this.btnVDelete);
            this.pnlDgvBtns.Controls.Add(this.btnVEdit);
            this.pnlDgvBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDgvBtns.Location = new System.Drawing.Point(0, 478);
            this.pnlDgvBtns.Name = "pnlDgvBtns";
            this.pnlDgvBtns.Size = new System.Drawing.Size(903, 44);
            this.pnlDgvBtns.TabIndex = 6;
            // 
            // btnVDelete
            // 
            this.btnVDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVDelete.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDelete.ForeColor = System.Drawing.Color.White;
            this.btnVDelete.Location = new System.Drawing.Point(753, 0);
            this.btnVDelete.Name = "btnVDelete";
            this.btnVDelete.Size = new System.Drawing.Size(75, 44);
            this.btnVDelete.TabIndex = 7;
            this.btnVDelete.Text = "Delete";
            this.btnVDelete.UseVisualStyleBackColor = true;
            this.btnVDelete.Click += new System.EventHandler(this.btnVDelete_Click);
            // 
            // btnVEdit
            // 
            this.btnVEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVEdit.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVEdit.Location = new System.Drawing.Point(828, 0);
            this.btnVEdit.Name = "btnVEdit";
            this.btnVEdit.Size = new System.Drawing.Size(75, 44);
            this.btnVEdit.TabIndex = 6;
            this.btnVEdit.Text = "Edit";
            this.btnVEdit.UseVisualStyleBackColor = true;
            this.btnVEdit.Click += new System.EventHandler(this.btnVEdit_Click);
            // 
            // VisitorModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.pnlDgvBtns);
            this.Controls.Add(this.pnlDgv);
            this.Controls.Add(this.pnlFormBtn);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel1);
            this.Name = "VisitorModule";
            this.Text = "VisitorModule";
            this.Load += new System.EventHandler(this.VisitorModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlFormBtn.ResumeLayout(false);
            this.pnlDgv.ResumeLayout(false);
            this.pnlDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).EndInit();
            this.pnlDgvBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVAttachement;
        private System.Windows.Forms.TextBox txtVNote;
        private System.Windows.Forms.TextBox txtVNIC;
        private System.Windows.Forms.TextBox txtVContact;
        private System.Windows.Forms.TextBox txtVName;
        private System.Windows.Forms.TextBox txtVPurpose;
        private System.Windows.Forms.Button btnVClrAll;
        private System.Windows.Forms.Button btnVBrowse;
        private System.Windows.Forms.Panel pnlFormBtn;
        private System.Windows.Forms.DateTimePicker dtpVDate;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvVisitor;
        private System.Windows.Forms.Panel pnlDgvBtns;
        private System.Windows.Forms.Button btnVDelete;
        private System.Windows.Forms.Button btnVEdit;
        private System.Windows.Forms.Button btnVUpdate;
        private System.Windows.Forms.Button btnVSave;
        private System.Windows.Forms.Button btnVClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn VName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox txtVOutTime;
        private System.Windows.Forms.TextBox txtVInTime;
        private System.Windows.Forms.TextBox txtVisitorNo;
        private System.Windows.Forms.TextBox txtVisitorSearch;
        private System.Windows.Forms.Label label11;
    }
}