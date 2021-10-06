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
            this.pnlCTypeTop = new System.Windows.Forms.Panel();
            this.btnComTypeClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCTypeForm = new System.Windows.Forms.Panel();
            this.txtCTypeId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnCTypeSave = new System.Windows.Forms.Button();
            this.btnCTypeUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnCTypeEdit = new System.Windows.Forms.Button();
            this.btnCTypeDelete = new System.Windows.Forms.Button();
            this.dgvComplaintType = new System.Windows.Forms.DataGridView();
            this.txtCTypeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCTypeTop.SuspendLayout();
            this.pnlCTypeForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).BeginInit();
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
            this.pnlCTypeTop.Size = new System.Drawing.Size(427, 42);
            this.pnlCTypeTop.TabIndex = 5;
            // 
            // btnComTypeClose
            // 
            this.btnComTypeClose.BackColor = System.Drawing.Color.White;
            this.btnComTypeClose.FlatAppearance.BorderSize = 0;
            this.btnComTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComTypeClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComTypeClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Type";
            // 
            // pnlCTypeForm
            // 
            this.pnlCTypeForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCTypeForm.Controls.Add(this.txtDescription);
            this.pnlCTypeForm.Controls.Add(this.label4);
            this.pnlCTypeForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCTypeForm.Location = new System.Drawing.Point(0, 42);
            this.pnlCTypeForm.Name = "pnlCTypeForm";
            this.pnlCTypeForm.Size = new System.Drawing.Size(427, 62);
            this.pnlCTypeForm.TabIndex = 6;
            // 
            // txtCTypeId
            // 
            this.txtCTypeId.Location = new System.Drawing.Point(126, 6);
            this.txtCTypeId.Name = "txtCTypeId";
            this.txtCTypeId.Size = new System.Drawing.Size(54, 20);
            this.txtCTypeId.TabIndex = 1;
            this.txtCTypeId.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(165, 18);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type Description";
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.txtCTypeId);
            this.pnlformButtons.Controls.Add(this.btnCTypeSave);
            this.pnlformButtons.Controls.Add(this.btnCTypeUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 104);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(427, 34);
            this.pnlformButtons.TabIndex = 15;
            // 
            // btnCTypeSave
            // 
            this.btnCTypeSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeSave.Location = new System.Drawing.Point(202, 0);
            this.btnCTypeSave.Name = "btnCTypeSave";
            this.btnCTypeSave.Size = new System.Drawing.Size(75, 34);
            this.btnCTypeSave.TabIndex = 0;
            this.btnCTypeSave.Text = "Save";
            this.btnCTypeSave.UseVisualStyleBackColor = true;
            this.btnCTypeSave.Click += new System.EventHandler(this.btnCTypeSave_Click);
            // 
            // btnCTypeUpdate
            // 
            this.btnCTypeUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeUpdate.Location = new System.Drawing.Point(277, 0);
            this.btnCTypeUpdate.Name = "btnCTypeUpdate";
            this.btnCTypeUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnCTypeUpdate.TabIndex = 0;
            this.btnCTypeUpdate.Text = "Update";
            this.btnCTypeUpdate.UseVisualStyleBackColor = true;
            this.btnCTypeUpdate.Click += new System.EventHandler(this.btnCTypeUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(352, 0);
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
            this.panel1.Controls.Add(this.dgvComplaintType);
            this.panel1.Controls.Add(this.txtCTypeSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 313);
            this.panel1.TabIndex = 16;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnCTypeEdit);
            this.pnlDgvBtn.Controls.Add(this.btnCTypeDelete);
            this.pnlDgvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvBtn.Location = new System.Drawing.Point(0, 280);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(427, 33);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnCTypeEdit
            // 
            this.btnCTypeEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeEdit.Location = new System.Drawing.Point(273, 0);
            this.btnCTypeEdit.Name = "btnCTypeEdit";
            this.btnCTypeEdit.Size = new System.Drawing.Size(77, 33);
            this.btnCTypeEdit.TabIndex = 3;
            this.btnCTypeEdit.Text = "Edit";
            this.btnCTypeEdit.UseVisualStyleBackColor = true;
            this.btnCTypeEdit.Click += new System.EventHandler(this.btnCTypeEdit_Click);
            // 
            // btnCTypeDelete
            // 
            this.btnCTypeDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCTypeDelete.Location = new System.Drawing.Point(350, 0);
            this.btnCTypeDelete.Name = "btnCTypeDelete";
            this.btnCTypeDelete.Size = new System.Drawing.Size(77, 33);
            this.btnCTypeDelete.TabIndex = 3;
            this.btnCTypeDelete.Text = "Delete";
            this.btnCTypeDelete.UseVisualStyleBackColor = true;
            this.btnCTypeDelete.Click += new System.EventHandler(this.btnCTypeDelete_Click);
            // 
            // dgvComplaintType
            // 
            this.dgvComplaintType.AllowUserToAddRows = false;
            this.dgvComplaintType.AllowUserToDeleteRows = false;
            this.dgvComplaintType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaintType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeNo,
            this.ComDescription});
            this.dgvComplaintType.Location = new System.Drawing.Point(20, 38);
            this.dgvComplaintType.Name = "dgvComplaintType";
            this.dgvComplaintType.ReadOnly = true;
            this.dgvComplaintType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaintType.Size = new System.Drawing.Size(394, 213);
            this.dgvComplaintType.TabIndex = 2;
            this.dgvComplaintType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaintType_CellClick);
            // 
            // txtCTypeSearch
            // 
            this.txtCTypeSearch.Location = new System.Drawing.Point(158, 11);
            this.txtCTypeSearch.Name = "txtCTypeSearch";
            this.txtCTypeSearch.Size = new System.Drawing.Size(250, 20);
            this.txtCTypeSearch.TabIndex = 1;
            this.txtCTypeSearch.TextChanged += new System.EventHandler(this.txtCTypeSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By Description";
            // 
            // TypeNo
            // 
            this.TypeNo.DataPropertyName = "TypeNo";
            this.TypeNo.HeaderText = "Type No";
            this.TypeNo.Name = "TypeNo";
            this.TypeNo.ReadOnly = true;
            // 
            // ComDescription
            // 
            this.ComDescription.DataPropertyName = "ComDescription";
            this.ComDescription.HeaderText = "Complaint Description";
            this.ComDescription.Name = "ComDescription";
            this.ComDescription.ReadOnly = true;
            this.ComDescription.Width = 250;
            // 
            // RefComplaintType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlformButtons);
            this.Controls.Add(this.pnlCTypeForm);
            this.Controls.Add(this.pnlCTypeTop);
            this.Name = "RefComplaintType";
            this.Text = "RefComplaintType";
            this.Load += new System.EventHandler(this.RefComplaintType_Load);
            this.pnlCTypeTop.ResumeLayout(false);
            this.pnlCTypeTop.PerformLayout();
            this.pnlCTypeForm.ResumeLayout(false);
            this.pnlCTypeForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.pnlformButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCTypeTop;
        private System.Windows.Forms.Button btnComTypeClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCTypeForm;
        private System.Windows.Forms.TextBox txtCTypeId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnCTypeSave;
        private System.Windows.Forms.Button btnCTypeUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnCTypeEdit;
        private System.Windows.Forms.Button btnCTypeDelete;
        private System.Windows.Forms.DataGridView dgvComplaintType;
        private System.Windows.Forms.TextBox txtCTypeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
    }
}