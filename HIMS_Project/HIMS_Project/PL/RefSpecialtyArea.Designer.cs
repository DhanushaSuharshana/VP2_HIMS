namespace HIMS_Project.PL
{
    partial class RefSpecialtyArea
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
            this.pnlSpAreaTop = new System.Windows.Forms.Panel();
            this.btnSpAreaClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSpAreaForm = new System.Windows.Forms.Panel();
            this.txtSpDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.txtSpAreaId = new System.Windows.Forms.TextBox();
            this.btnSpAreaSave = new System.Windows.Forms.Button();
            this.btnSpAreaUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnSpAreaEdit = new System.Windows.Forms.Button();
            this.btnSpAreaDelete = new System.Windows.Forms.Button();
            this.dgvSpArea = new System.Windows.Forms.DataGridView();
            this.SAreaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSpAreaSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSpAreaTop.SuspendLayout();
            this.pnlSpAreaForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpAreaTop
            // 
            this.pnlSpAreaTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSpAreaTop.Controls.Add(this.btnSpAreaClose);
            this.pnlSpAreaTop.Controls.Add(this.label1);
            this.pnlSpAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpAreaTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSpAreaTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSpAreaTop.Name = "pnlSpAreaTop";
            this.pnlSpAreaTop.Size = new System.Drawing.Size(746, 42);
            this.pnlSpAreaTop.TabIndex = 6;
            // 
            // btnSpAreaClose
            // 
            this.btnSpAreaClose.BackColor = System.Drawing.Color.White;
            this.btnSpAreaClose.FlatAppearance.BorderSize = 0;
            this.btnSpAreaClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpAreaClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpAreaClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
            this.btnSpAreaClose.Location = new System.Drawing.Point(12, 5);
            this.btnSpAreaClose.Name = "btnSpAreaClose";
            this.btnSpAreaClose.Size = new System.Drawing.Size(32, 32);
            this.btnSpAreaClose.TabIndex = 1;
            this.btnSpAreaClose.Text = "X";
            this.btnSpAreaClose.UseVisualStyleBackColor = false;
            this.btnSpAreaClose.Click += new System.EventHandler(this.btnSpAreaClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specialty Area";
            // 
            // pnlSpAreaForm
            // 
            this.pnlSpAreaForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSpAreaForm.Controls.Add(this.txtSpDescription);
            this.pnlSpAreaForm.Controls.Add(this.label4);
            this.pnlSpAreaForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpAreaForm.Location = new System.Drawing.Point(0, 42);
            this.pnlSpAreaForm.Name = "pnlSpAreaForm";
            this.pnlSpAreaForm.Size = new System.Drawing.Size(746, 62);
            this.pnlSpAreaForm.TabIndex = 7;
            // 
            // txtSpDescription
            // 
            this.txtSpDescription.Location = new System.Drawing.Point(165, 18);
            this.txtSpDescription.Name = "txtSpDescription";
            this.txtSpDescription.Size = new System.Drawing.Size(250, 20);
            this.txtSpDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Specialty Area";
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.txtSpAreaId);
            this.pnlformButtons.Controls.Add(this.btnSpAreaSave);
            this.pnlformButtons.Controls.Add(this.btnSpAreaUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 104);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(746, 34);
            this.pnlformButtons.TabIndex = 16;
            // 
            // txtSpAreaId
            // 
            this.txtSpAreaId.Location = new System.Drawing.Point(126, 6);
            this.txtSpAreaId.Name = "txtSpAreaId";
            this.txtSpAreaId.Size = new System.Drawing.Size(54, 20);
            this.txtSpAreaId.TabIndex = 1;
            this.txtSpAreaId.Visible = false;
            // 
            // btnSpAreaSave
            // 
            this.btnSpAreaSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaSave.Location = new System.Drawing.Point(521, 0);
            this.btnSpAreaSave.Name = "btnSpAreaSave";
            this.btnSpAreaSave.Size = new System.Drawing.Size(75, 34);
            this.btnSpAreaSave.TabIndex = 0;
            this.btnSpAreaSave.Text = "Save";
            this.btnSpAreaSave.UseVisualStyleBackColor = true;
            this.btnSpAreaSave.Click += new System.EventHandler(this.btnSpAreaSave_Click);
            // 
            // btnSpAreaUpdate
            // 
            this.btnSpAreaUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaUpdate.Location = new System.Drawing.Point(596, 0);
            this.btnSpAreaUpdate.Name = "btnSpAreaUpdate";
            this.btnSpAreaUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnSpAreaUpdate.TabIndex = 0;
            this.btnSpAreaUpdate.Text = "Update";
            this.btnSpAreaUpdate.UseVisualStyleBackColor = true;
            this.btnSpAreaUpdate.Click += new System.EventHandler(this.btnSpAreaUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(671, 0);
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
            this.panel1.Controls.Add(this.dgvSpArea);
            this.panel1.Controls.Add(this.txtSpAreaSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 313);
            this.panel1.TabIndex = 17;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnSpAreaEdit);
            this.pnlDgvBtn.Controls.Add(this.btnSpAreaDelete);
            this.pnlDgvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvBtn.Location = new System.Drawing.Point(0, 280);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(746, 33);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnSpAreaEdit
            // 
            this.btnSpAreaEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaEdit.Location = new System.Drawing.Point(592, 0);
            this.btnSpAreaEdit.Name = "btnSpAreaEdit";
            this.btnSpAreaEdit.Size = new System.Drawing.Size(77, 33);
            this.btnSpAreaEdit.TabIndex = 3;
            this.btnSpAreaEdit.Text = "Edit";
            this.btnSpAreaEdit.UseVisualStyleBackColor = true;
            this.btnSpAreaEdit.Click += new System.EventHandler(this.btnSpAreaEdit_Click);
            // 
            // btnSpAreaDelete
            // 
            this.btnSpAreaDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaDelete.Location = new System.Drawing.Point(669, 0);
            this.btnSpAreaDelete.Name = "btnSpAreaDelete";
            this.btnSpAreaDelete.Size = new System.Drawing.Size(77, 33);
            this.btnSpAreaDelete.TabIndex = 3;
            this.btnSpAreaDelete.Text = "Delete";
            this.btnSpAreaDelete.UseVisualStyleBackColor = true;
            this.btnSpAreaDelete.Click += new System.EventHandler(this.btnSpAreaDelete_Click);
            // 
            // dgvSpArea
            // 
            this.dgvSpArea.AllowUserToAddRows = false;
            this.dgvSpArea.AllowUserToDeleteRows = false;
            this.dgvSpArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SAreaID,
            this.SDescription});
            this.dgvSpArea.Location = new System.Drawing.Point(20, 38);
            this.dgvSpArea.Name = "dgvSpArea";
            this.dgvSpArea.ReadOnly = true;
            this.dgvSpArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpArea.Size = new System.Drawing.Size(395, 236);
            this.dgvSpArea.TabIndex = 2;
            this.dgvSpArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpArea_CellClick);
            // 
            // SAreaID
            // 
            this.SAreaID.DataPropertyName = "SAreaID";
            this.SAreaID.HeaderText = "Specialty #";
            this.SAreaID.Name = "SAreaID";
            this.SAreaID.ReadOnly = true;
            // 
            // SDescription
            // 
            this.SDescription.DataPropertyName = "SDescription";
            this.SDescription.HeaderText = "Specialty Area";
            this.SDescription.Name = "SDescription";
            this.SDescription.ReadOnly = true;
            this.SDescription.Width = 250;
            // 
            // txtSpAreaSearch
            // 
            this.txtSpAreaSearch.Location = new System.Drawing.Point(165, 11);
            this.txtSpAreaSearch.Name = "txtSpAreaSearch";
            this.txtSpAreaSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSpAreaSearch.TabIndex = 1;
            this.txtSpAreaSearch.TextChanged += new System.EventHandler(this.txtSpAreaSearch_TextChanged);
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
            // RefSpecialtyArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlformButtons);
            this.Controls.Add(this.pnlSpAreaForm);
            this.Controls.Add(this.pnlSpAreaTop);
            this.Name = "RefSpecialtyArea";
            this.Text = "RefSpecialtyArea";
            this.Load += new System.EventHandler(this.RefSpecialtyArea_Load);
            this.pnlSpAreaTop.ResumeLayout(false);
            this.pnlSpAreaTop.PerformLayout();
            this.pnlSpAreaForm.ResumeLayout(false);
            this.pnlSpAreaForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.pnlformButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpAreaTop;
        private System.Windows.Forms.Button btnSpAreaClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSpAreaForm;
        private System.Windows.Forms.TextBox txtSpDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.TextBox txtSpAreaId;
        private System.Windows.Forms.Button btnSpAreaSave;
        private System.Windows.Forms.Button btnSpAreaUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnSpAreaEdit;
        private System.Windows.Forms.Button btnSpAreaDelete;
        private System.Windows.Forms.DataGridView dgvSpArea;
        private System.Windows.Forms.TextBox txtSpAreaSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAreaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDescription;
    }
}