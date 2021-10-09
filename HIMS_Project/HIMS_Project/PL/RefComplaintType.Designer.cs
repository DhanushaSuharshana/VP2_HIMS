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
            this.btnComTypeClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCTypeId = new System.Windows.Forms.TextBox();
            this.btnCTypeSave = new System.Windows.Forms.Button();
            this.btnCTypeUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCTypeEdit = new System.Windows.Forms.Button();
            this.btnCTypeDelete = new System.Windows.Forms.Button();
            this.dgvComplaintType = new System.Windows.Forms.DataGridView();
            this.TypeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCTypeSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComTypeClose
            // 
            this.btnComTypeClose.BackColor = System.Drawing.Color.White;
            this.btnComTypeClose.FlatAppearance.BorderSize = 0;
            this.btnComTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComTypeClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComTypeClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnComTypeClose.Location = new System.Drawing.Point(14, 12);
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
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Varela Round", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Type";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(283, 247);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type Description";
            // 
            // txtCTypeId
            // 
            this.txtCTypeId.Location = new System.Drawing.Point(139, 247);
            this.txtCTypeId.Name = "txtCTypeId";
            this.txtCTypeId.Size = new System.Drawing.Size(54, 20);
            this.txtCTypeId.TabIndex = 1;
            this.txtCTypeId.Visible = false;
            // 
            // btnCTypeSave
            // 
            this.btnCTypeSave.Location = new System.Drawing.Point(139, 289);
            this.btnCTypeSave.Name = "btnCTypeSave";
            this.btnCTypeSave.Size = new System.Drawing.Size(75, 34);
            this.btnCTypeSave.TabIndex = 0;
            this.btnCTypeSave.Text = "Save";
            this.btnCTypeSave.UseVisualStyleBackColor = true;
            this.btnCTypeSave.Click += new System.EventHandler(this.btnCTypeSave_Click);
            // 
            // btnCTypeUpdate
            // 
            this.btnCTypeUpdate.Location = new System.Drawing.Point(364, 289);
            this.btnCTypeUpdate.Name = "btnCTypeUpdate";
            this.btnCTypeUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnCTypeUpdate.TabIndex = 0;
            this.btnCTypeUpdate.Text = "Update";
            this.btnCTypeUpdate.UseVisualStyleBackColor = true;
            this.btnCTypeUpdate.Click += new System.EventHandler(this.btnCTypeUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(458, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCTypeEdit
            // 
            this.btnCTypeEdit.Location = new System.Drawing.Point(381, 635);
            this.btnCTypeEdit.Name = "btnCTypeEdit";
            this.btnCTypeEdit.Size = new System.Drawing.Size(77, 33);
            this.btnCTypeEdit.TabIndex = 3;
            this.btnCTypeEdit.Text = "Edit";
            this.btnCTypeEdit.UseVisualStyleBackColor = true;
            this.btnCTypeEdit.Click += new System.EventHandler(this.btnCTypeEdit_Click);
            // 
            // btnCTypeDelete
            // 
            this.btnCTypeDelete.Location = new System.Drawing.Point(458, 635);
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
            this.dgvComplaintType.Location = new System.Drawing.Point(132, 366);
            this.dgvComplaintType.Name = "dgvComplaintType";
            this.dgvComplaintType.ReadOnly = true;
            this.dgvComplaintType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaintType.Size = new System.Drawing.Size(403, 251);
            this.dgvComplaintType.TabIndex = 2;
            this.dgvComplaintType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComplaintType_CellClick);
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
            // txtCTypeSearch
            // 
            this.txtCTypeSearch.Location = new System.Drawing.Point(285, 340);
            this.txtCTypeSearch.Name = "txtCTypeSearch";
            this.txtCTypeSearch.Size = new System.Drawing.Size(250, 20);
            this.txtCTypeSearch.TabIndex = 1;
            this.txtCTypeSearch.TextChanged += new System.EventHandler(this.txtCTypeSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By Description";
            // 
            // RefComplaintType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1327, 806);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComTypeClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCTypeId);
            this.Controls.Add(this.btnCTypeEdit);
            this.Controls.Add(this.btnCTypeDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCTypeSearch);
            this.Controls.Add(this.dgvComplaintType);
            this.Controls.Add(this.btnCTypeSave);
            this.Controls.Add(this.btnCTypeUpdate);
            this.Controls.Add(this.btnClear);
            this.Name = "RefComplaintType";
            this.Text = "RefComplaintType";
            this.Load += new System.EventHandler(this.RefComplaintType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComTypeClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCTypeId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCTypeSave;
        private System.Windows.Forms.Button btnCTypeUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCTypeEdit;
        private System.Windows.Forms.Button btnCTypeDelete;
        private System.Windows.Forms.DataGridView dgvComplaintType;
        private System.Windows.Forms.TextBox txtCTypeSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescription;
    }
}