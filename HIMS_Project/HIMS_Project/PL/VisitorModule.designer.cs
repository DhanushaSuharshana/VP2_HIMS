
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
            this.btnVClrAll = new System.Windows.Forms.Button();
            this.pnlFormBtn = new System.Windows.Forms.Panel();
            this.btnVSave = new System.Windows.Forms.Button();
            this.btnVUpdate = new System.Windows.Forms.Button();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.pnlDgvBtns = new System.Windows.Forms.Panel();
            this.btnVDelete = new System.Windows.Forms.Button();
            this.btnVEdit = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFormBtn.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            this.pnlDgvBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(720, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnVClose
            // 
            this.btnVClose.FlatAppearance.BorderSize = 0;
            this.btnVClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnVClose.ForeColor = System.Drawing.Color.Orange;
            this.btnVClose.Location = new System.Drawing.Point(12, 6);
            this.btnVClose.Name = "btnVClose";
            this.btnVClose.Size = new System.Drawing.Size(31, 31);
            this.btnVClose.TabIndex = 1;
            this.btnVClose.Text = "X";
            this.btnVClose.UseVisualStyleBackColor = true;
            this.btnVClose.Click += new System.EventHandler(this.btnVClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Module";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtVisitorNo);
            this.pnlForm.Controls.Add(this.pnlFormBtn);
            this.pnlForm.Controls.Add(this.txtVOutTime);
            this.pnlForm.Controls.Add(this.txtVInTime);
            this.pnlForm.Controls.Add(this.dtpVDate);
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
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 46);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(720, 232);
            this.pnlForm.TabIndex = 1;
            // 
            // txtVisitorNo
            // 
            this.txtVisitorNo.BackColor = System.Drawing.Color.Orange;
            this.txtVisitorNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisitorNo.ForeColor = System.Drawing.Color.White;
            this.txtVisitorNo.Location = new System.Drawing.Point(27, 32);
            this.txtVisitorNo.Multiline = true;
            this.txtVisitorNo.Name = "txtVisitorNo";
            this.txtVisitorNo.Size = new System.Drawing.Size(52, 26);
            this.txtVisitorNo.TabIndex = 26;
            this.txtVisitorNo.Visible = false;
            // 
            // txtVOutTime
            // 
            this.txtVOutTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVOutTime.BackColor = System.Drawing.Color.Orange;
            this.txtVOutTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVOutTime.ForeColor = System.Drawing.Color.White;
            this.txtVOutTime.Location = new System.Drawing.Point(489, 104);
            this.txtVOutTime.Multiline = true;
            this.txtVOutTime.Name = "txtVOutTime";
            this.txtVOutTime.Size = new System.Drawing.Size(204, 25);
            this.txtVOutTime.TabIndex = 25;
            // 
            // txtVInTime
            // 
            this.txtVInTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVInTime.BackColor = System.Drawing.Color.Orange;
            this.txtVInTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVInTime.ForeColor = System.Drawing.Color.White;
            this.txtVInTime.Location = new System.Drawing.Point(489, 72);
            this.txtVInTime.Multiline = true;
            this.txtVInTime.Name = "txtVInTime";
            this.txtVInTime.Size = new System.Drawing.Size(204, 25);
            this.txtVInTime.TabIndex = 24;
            // 
            // dtpVDate
            // 
            this.dtpVDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVDate.Location = new System.Drawing.Point(489, 135);
            this.dtpVDate.Name = "dtpVDate";
            this.dtpVDate.Size = new System.Drawing.Size(204, 24);
            this.dtpVDate.TabIndex = 23;
            // 
            // txtVNote
            // 
            this.txtVNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVNote.BackColor = System.Drawing.Color.Orange;
            this.txtVNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVNote.ForeColor = System.Drawing.Color.White;
            this.txtVNote.Location = new System.Drawing.Point(489, 14);
            this.txtVNote.Multiline = true;
            this.txtVNote.Name = "txtVNote";
            this.txtVNote.Size = new System.Drawing.Size(204, 53);
            this.txtVNote.TabIndex = 19;
            // 
            // txtVNIC
            // 
            this.txtVNIC.BackColor = System.Drawing.Color.Orange;
            this.txtVNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVNIC.ForeColor = System.Drawing.Color.White;
            this.txtVNIC.Location = new System.Drawing.Point(130, 135);
            this.txtVNIC.Multiline = true;
            this.txtVNIC.Name = "txtVNIC";
            this.txtVNIC.Size = new System.Drawing.Size(207, 25);
            this.txtVNIC.TabIndex = 15;
            // 
            // txtVContact
            // 
            this.txtVContact.BackColor = System.Drawing.Color.Orange;
            this.txtVContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVContact.ForeColor = System.Drawing.Color.White;
            this.txtVContact.Location = new System.Drawing.Point(130, 103);
            this.txtVContact.Multiline = true;
            this.txtVContact.Name = "txtVContact";
            this.txtVContact.Size = new System.Drawing.Size(207, 25);
            this.txtVContact.TabIndex = 14;
            // 
            // txtVName
            // 
            this.txtVName.BackColor = System.Drawing.Color.Orange;
            this.txtVName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVName.ForeColor = System.Drawing.Color.White;
            this.txtVName.Location = new System.Drawing.Point(130, 71);
            this.txtVName.Multiline = true;
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(207, 25);
            this.txtVName.TabIndex = 13;
            // 
            // txtVPurpose
            // 
            this.txtVPurpose.BackColor = System.Drawing.Color.Orange;
            this.txtVPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVPurpose.ForeColor = System.Drawing.Color.White;
            this.txtVPurpose.Location = new System.Drawing.Point(130, 13);
            this.txtVPurpose.Multiline = true;
            this.txtVPurpose.Name = "txtVPurpose";
            this.txtVPurpose.Size = new System.Drawing.Size(207, 53);
            this.txtVPurpose.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Purpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "NIC Number";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(404, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(400, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "In Time";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(400, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Out Time";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(400, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Note";
            // 
            // btnVClrAll
            // 
            this.btnVClrAll.BackColor = System.Drawing.Color.Orange;
            this.btnVClrAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVClrAll.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVClrAll.ForeColor = System.Drawing.Color.White;
            this.btnVClrAll.Location = new System.Drawing.Point(569, 0);
            this.btnVClrAll.Name = "btnVClrAll";
            this.btnVClrAll.Size = new System.Drawing.Size(97, 37);
            this.btnVClrAll.TabIndex = 22;
            this.btnVClrAll.Text = "C l e a r";
            this.btnVClrAll.UseVisualStyleBackColor = false;
            this.btnVClrAll.Click += new System.EventHandler(this.btnVClrAll_Click);
            // 
            // pnlFormBtn
            // 
            this.pnlFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBtn.Controls.Add(this.btnVSave);
            this.pnlFormBtn.Controls.Add(this.btnVUpdate);
            this.pnlFormBtn.Controls.Add(this.btnVClrAll);
            this.pnlFormBtn.Location = new System.Drawing.Point(27, 177);
            this.pnlFormBtn.Name = "pnlFormBtn";
            this.pnlFormBtn.Size = new System.Drawing.Size(666, 37);
            this.pnlFormBtn.TabIndex = 2;
            // 
            // btnVSave
            // 
            this.btnVSave.BackColor = System.Drawing.Color.Orange;
            this.btnVSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVSave.ForeColor = System.Drawing.Color.White;
            this.btnVSave.Location = new System.Drawing.Point(382, 0);
            this.btnVSave.Name = "btnVSave";
            this.btnVSave.Size = new System.Drawing.Size(89, 37);
            this.btnVSave.TabIndex = 24;
            this.btnVSave.Text = "S a v e";
            this.btnVSave.UseVisualStyleBackColor = false;
            this.btnVSave.Click += new System.EventHandler(this.btnVSave_Click);
            // 
            // btnVUpdate
            // 
            this.btnVUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnVUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVUpdate.Location = new System.Drawing.Point(471, 0);
            this.btnVUpdate.Name = "btnVUpdate";
            this.btnVUpdate.Size = new System.Drawing.Size(98, 37);
            this.btnVUpdate.TabIndex = 23;
            this.btnVUpdate.Text = "U p d a t e";
            this.btnVUpdate.UseVisualStyleBackColor = false;
            this.btnVUpdate.Click += new System.EventHandler(this.btnVUpdate_Click);
            // 
            // pnlDgv
            // 
            this.pnlDgv.AutoScroll = true;
            this.pnlDgv.Controls.Add(this.pnlDgvBtns);
            this.pnlDgv.Controls.Add(this.txtVisitorSearch);
            this.pnlDgv.Controls.Add(this.label11);
            this.pnlDgv.Controls.Add(this.dgvVisitor);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDgv.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.pnlDgv.Location = new System.Drawing.Point(0, 278);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(720, 311);
            this.pnlDgv.TabIndex = 5;
            // 
            // pnlDgvBtns
            // 
            this.pnlDgvBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBtns.Controls.Add(this.btnVDelete);
            this.pnlDgvBtns.Controls.Add(this.btnVEdit);
            this.pnlDgvBtns.Location = new System.Drawing.Point(496, 9);
            this.pnlDgvBtns.Name = "pnlDgvBtns";
            this.pnlDgvBtns.Size = new System.Drawing.Size(197, 34);
            this.pnlDgvBtns.TabIndex = 6;
            // 
            // btnVDelete
            // 
            this.btnVDelete.BackColor = System.Drawing.Color.Orange;
            this.btnVDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDelete.ForeColor = System.Drawing.Color.White;
            this.btnVDelete.Location = new System.Drawing.Point(33, 0);
            this.btnVDelete.Name = "btnVDelete";
            this.btnVDelete.Size = new System.Drawing.Size(89, 34);
            this.btnVDelete.TabIndex = 7;
            this.btnVDelete.Text = "D e l e t e";
            this.btnVDelete.UseVisualStyleBackColor = false;
            this.btnVDelete.Click += new System.EventHandler(this.btnVDelete_Click);
            // 
            // btnVEdit
            // 
            this.btnVEdit.BackColor = System.Drawing.Color.Orange;
            this.btnVEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVEdit.ForeColor = System.Drawing.Color.White;
            this.btnVEdit.Location = new System.Drawing.Point(122, 0);
            this.btnVEdit.Name = "btnVEdit";
            this.btnVEdit.Size = new System.Drawing.Size(75, 34);
            this.btnVEdit.TabIndex = 6;
            this.btnVEdit.Text = "E d i t";
            this.btnVEdit.UseVisualStyleBackColor = false;
            this.btnVEdit.Click += new System.EventHandler(this.btnVEdit_Click);
            // 
            // txtVisitorSearch
            // 
            this.txtVisitorSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisitorSearch.BackColor = System.Drawing.Color.Orange;
            this.txtVisitorSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisitorSearch.Location = new System.Drawing.Point(178, 11);
            this.txtVisitorSearch.Multiline = true;
            this.txtVisitorSearch.Name = "txtVisitorSearch";
            this.txtVisitorSearch.Size = new System.Drawing.Size(293, 26);
            this.txtVisitorSearch.TabIndex = 7;
            this.txtVisitorSearch.TextChanged += new System.EventHandler(this.txtVisitorSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(7, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Search By User Name";
            // 
            // dgvVisitor
            // 
            this.dgvVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisitor.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvVisitor.Location = new System.Drawing.Point(13, 52);
            this.dgvVisitor.Name = "dgvVisitor";
            this.dgvVisitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitor.Size = new System.Drawing.Size(690, 239);
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
            // VisitorModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 590);
            this.Controls.Add(this.pnlDgv);
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
            this.pnlDgvBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitor)).EndInit();
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
        private System.Windows.Forms.TextBox txtVNIC;
        private System.Windows.Forms.TextBox txtVContact;
        private System.Windows.Forms.TextBox txtVName;
        private System.Windows.Forms.TextBox txtVPurpose;
        private System.Windows.Forms.Button btnVClrAll;
        private System.Windows.Forms.Panel pnlFormBtn;
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
        private System.Windows.Forms.TextBox txtVisitorSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVisitorNo;
        private System.Windows.Forms.TextBox txtVOutTime;
        private System.Windows.Forms.TextBox txtVInTime;
        private System.Windows.Forms.DateTimePicker dtpVDate;
        private System.Windows.Forms.TextBox txtVNote;
    }
}