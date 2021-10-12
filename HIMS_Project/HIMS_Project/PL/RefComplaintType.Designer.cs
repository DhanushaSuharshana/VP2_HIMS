namespace HIMS_Project.PL
{
    partial class RefComplaintType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefComplaintType));
            this.pnlCTypeTop = new System.Windows.Forms.Panel();
            this.btnComTypeClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCTypeEdit = new System.Windows.Forms.Button();
            this.btnCTypeDelete = new System.Windows.Forms.Button();
            this.dgvComplaintType = new System.Windows.Forms.DataGridView();
            this.TypeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCTypeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnCTypeSave = new System.Windows.Forms.Button();
            this.btnCTypeUpdate = new System.Windows.Forms.Button();
            this.pnlCTypeForm = new System.Windows.Forms.Panel();
            this.txtCTypeId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCTypeTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).BeginInit();
            this.pnlformButtons.SuspendLayout();
            this.pnlCTypeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCTypeTop
            // 
            this.pnlCTypeTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCTypeTop.Controls.Add(this.btnComTypeClose);
            this.pnlCTypeTop.Controls.Add(this.label1);
            this.pnlCTypeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCTypeTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCTypeTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCTypeTop.Name = "pnlCTypeTop";
            this.pnlCTypeTop.Size = new System.Drawing.Size(754, 42);
            this.pnlCTypeTop.TabIndex = 6;
            // 
            // btnComTypeClose
            // 
            this.btnComTypeClose.BackColor = System.Drawing.Color.White;
            this.btnComTypeClose.FlatAppearance.BorderSize = 0;
            this.btnComTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComTypeClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComTypeClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnComTypeClose.Location = new System.Drawing.Point(12, 5);
            this.btnComTypeClose.Name = "btnComTypeClose";
            this.btnComTypeClose.Size = new System.Drawing.Size(32, 32);
            this.btnComTypeClose.TabIndex = 1;
            this.btnComTypeClose.Text = "X";
            this.btnComTypeClose.UseVisualStyleBackColor = false;
            this.btnComTypeClose.Click += new System.EventHandler(this.btnComTypeClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(297, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Type";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.pnlCTypeForm);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 42);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(385, 543);
            this.pnlLeft.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvComplaintType);
            this.panel1.Controls.Add(this.txtCTypeSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 396);
            this.panel1.TabIndex = 17;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBtn.Controls.Add(this.btnClear);
            this.pnlDgvBtn.Controls.Add(this.btnCTypeEdit);
            this.pnlDgvBtn.Controls.Add(this.btnCTypeDelete);
            this.pnlDgvBtn.Location = new System.Drawing.Point(13, 80);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(359, 33);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(112, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C l e a r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCTypeEdit
            // 
            this.btnCTypeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnCTypeEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnCTypeEdit.ForeColor = System.Drawing.Color.White;
            this.btnCTypeEdit.Location = new System.Drawing.Point(187, 0);
            this.btnCTypeEdit.Name = "btnCTypeEdit";
            this.btnCTypeEdit.Size = new System.Drawing.Size(77, 33);
            this.btnCTypeEdit.TabIndex = 3;
            this.btnCTypeEdit.Text = "E d i t";
            this.btnCTypeEdit.UseVisualStyleBackColor = false;
            this.btnCTypeEdit.Click += new System.EventHandler(this.btnCTypeEdit_Click);
            // 
            // btnCTypeDelete
            // 
            this.btnCTypeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnCTypeDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnCTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnCTypeDelete.Location = new System.Drawing.Point(264, 0);
            this.btnCTypeDelete.Name = "btnCTypeDelete";
            this.btnCTypeDelete.Size = new System.Drawing.Size(95, 33);
            this.btnCTypeDelete.TabIndex = 3;
            this.btnCTypeDelete.Text = "D e l e t e";
            this.btnCTypeDelete.UseVisualStyleBackColor = false;
            this.btnCTypeDelete.Click += new System.EventHandler(this.btnCTypeDelete_Click);
            // 
            // dgvComplaintType
            // 
            this.dgvComplaintType.AllowUserToAddRows = false;
            this.dgvComplaintType.AllowUserToDeleteRows = false;
            this.dgvComplaintType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComplaintType.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaintType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaintType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeNo,
            this.ComDescription});
            this.dgvComplaintType.Location = new System.Drawing.Point(13, 124);
            this.dgvComplaintType.Name = "dgvComplaintType";
            this.dgvComplaintType.ReadOnly = true;
            this.dgvComplaintType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaintType.Size = new System.Drawing.Size(359, 263);
            this.dgvComplaintType.TabIndex = 2;
            this.dgvComplaintType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaintType_CellClick);
            // 
            // TypeNo
            // 
            this.TypeNo.DataPropertyName = "TypeNo";
            this.TypeNo.HeaderText = "Type No";
            this.TypeNo.Name = "TypeNo";
            this.TypeNo.ReadOnly = true;
            this.TypeNo.Width = 80;
            // 
            // ComDescription
            // 
            this.ComDescription.DataPropertyName = "ComDescription";
            this.ComDescription.HeaderText = "Complaint Description";
            this.ComDescription.Name = "ComDescription";
            this.ComDescription.ReadOnly = true;
            this.ComDescription.Width = 235;
            // 
            // txtCTypeSearch
            // 
            this.txtCTypeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTypeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.txtCTypeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCTypeSearch.ForeColor = System.Drawing.Color.White;
            this.txtCTypeSearch.Location = new System.Drawing.Point(13, 42);
            this.txtCTypeSearch.Multiline = true;
            this.txtCTypeSearch.Name = "txtCTypeSearch";
            this.txtCTypeSearch.Size = new System.Drawing.Size(359, 26);
            this.txtCTypeSearch.TabIndex = 1;
            this.txtCTypeSearch.TextChanged += new System.EventHandler(this.txtCTypeSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(114, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By Description";
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.btnCTypeSave);
            this.pnlformButtons.Controls.Add(this.btnCTypeUpdate);
            this.pnlformButtons.Location = new System.Drawing.Point(25, 93);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(347, 34);
            this.pnlformButtons.TabIndex = 16;
            // 
            // btnCTypeSave
            // 
            this.btnCTypeSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnCTypeSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnCTypeSave.ForeColor = System.Drawing.Color.White;
            this.btnCTypeSave.Location = new System.Drawing.Point(177, 0);
            this.btnCTypeSave.Name = "btnCTypeSave";
            this.btnCTypeSave.Size = new System.Drawing.Size(75, 34);
            this.btnCTypeSave.TabIndex = 0;
            this.btnCTypeSave.Text = "S a v e";
            this.btnCTypeSave.UseVisualStyleBackColor = false;
            this.btnCTypeSave.Click += new System.EventHandler(this.btnCTypeSave_Click);
            // 
            // btnCTypeUpdate
            // 
            this.btnCTypeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.btnCTypeUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnCTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCTypeUpdate.Location = new System.Drawing.Point(252, 0);
            this.btnCTypeUpdate.Name = "btnCTypeUpdate";
            this.btnCTypeUpdate.Size = new System.Drawing.Size(95, 34);
            this.btnCTypeUpdate.TabIndex = 0;
            this.btnCTypeUpdate.Text = "U p d a t e";
            this.btnCTypeUpdate.UseVisualStyleBackColor = false;
            this.btnCTypeUpdate.Click += new System.EventHandler(this.btnCTypeUpdate_Click);
            // 
            // pnlCTypeForm
            // 
            this.pnlCTypeForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCTypeForm.Controls.Add(this.pnlformButtons);
            this.pnlCTypeForm.Controls.Add(this.txtCTypeId);
            this.pnlCTypeForm.Controls.Add(this.txtDescription);
            this.pnlCTypeForm.Controls.Add(this.label4);
            this.pnlCTypeForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCTypeForm.Location = new System.Drawing.Point(0, 0);
            this.pnlCTypeForm.Name = "pnlCTypeForm";
            this.pnlCTypeForm.Size = new System.Drawing.Size(385, 144);
            this.pnlCTypeForm.TabIndex = 7;
            // 
            // txtCTypeId
            // 
            this.txtCTypeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.txtCTypeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCTypeId.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.txtCTypeId.ForeColor = System.Drawing.Color.White;
            this.txtCTypeId.Location = new System.Drawing.Point(160, 25);
            this.txtCTypeId.Multiline = true;
            this.txtCTypeId.Name = "txtCTypeId";
            this.txtCTypeId.Size = new System.Drawing.Size(54, 20);
            this.txtCTypeId.TabIndex = 1;
            this.txtCTypeId.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(25, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(347, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type Description";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(385, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 543);
            this.panel3.TabIndex = 13;
            // 
            // RefComplaintType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlCTypeTop);
            this.Name = "RefComplaintType";
            this.Text = "RefComplaintType";
            this.Load += new System.EventHandler(this.RefComplaintType_Load);
            this.pnlCTypeTop.ResumeLayout(false);
            this.pnlCTypeTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).EndInit();
            this.pnlformButtons.ResumeLayout(false);
            this.pnlCTypeForm.ResumeLayout(false);
            this.pnlCTypeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTypeTop;
        private System.Windows.Forms.Button btnComTypeClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnCTypeEdit;
        private System.Windows.Forms.Button btnCTypeDelete;
        private System.Windows.Forms.DataGridView dgvComplaintType;
        private System.Windows.Forms.TextBox txtCTypeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnCTypeSave;
        private System.Windows.Forms.Button btnCTypeUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlCTypeForm;
        private System.Windows.Forms.TextBox txtCTypeId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
        private System.Windows.Forms.Panel panel3;
    }
}