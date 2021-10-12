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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefSpecialtyArea));
            this.pnlSpAreaTop = new System.Windows.Forms.Panel();
            this.btnSpAreaClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSpAreaEdit = new System.Windows.Forms.Button();
            this.btnSpAreaDelete = new System.Windows.Forms.Button();
            this.dgvSpArea = new System.Windows.Forms.DataGridView();
            this.SAreaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSpAreaSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnSpAreaSave = new System.Windows.Forms.Button();
            this.btnSpAreaUpdate = new System.Windows.Forms.Button();
            this.pnlSpAreaForm = new System.Windows.Forms.Panel();
            this.txtSpAreaId = new System.Windows.Forms.TextBox();
            this.txtSpDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlSpAreaTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpArea)).BeginInit();
            this.pnlformButtons.SuspendLayout();
            this.pnlSpAreaForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pnlSpAreaTop.Size = new System.Drawing.Size(754, 42);
            this.pnlSpAreaTop.TabIndex = 7;
            // 
            // btnSpAreaClose
            // 
            this.btnSpAreaClose.BackColor = System.Drawing.Color.White;
            this.btnSpAreaClose.FlatAppearance.BorderSize = 0;
            this.btnSpAreaClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpAreaClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpAreaClose.ForeColor = System.Drawing.Color.OrangeRed;
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specialty Area";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.pnlSpAreaForm);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 42);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(385, 543);
            this.pnlLeft.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvSpArea);
            this.panel1.Controls.Add(this.txtSpAreaSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 405);
            this.panel1.TabIndex = 18;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnClear);
            this.pnlDgvBtn.Controls.Add(this.btnSpAreaEdit);
            this.pnlDgvBtn.Controls.Add(this.btnSpAreaDelete);
            this.pnlDgvBtn.Location = new System.Drawing.Point(14, 71);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(353, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(111, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C l e a r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSpAreaEdit
            // 
            this.btnSpAreaEdit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSpAreaEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaEdit.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnSpAreaEdit.ForeColor = System.Drawing.Color.White;
            this.btnSpAreaEdit.Location = new System.Drawing.Point(186, 0);
            this.btnSpAreaEdit.Name = "btnSpAreaEdit";
            this.btnSpAreaEdit.Size = new System.Drawing.Size(77, 38);
            this.btnSpAreaEdit.TabIndex = 3;
            this.btnSpAreaEdit.Text = "E d i t";
            this.btnSpAreaEdit.UseVisualStyleBackColor = false;
            this.btnSpAreaEdit.Click += new System.EventHandler(this.btnSpAreaEdit_Click);
            // 
            // btnSpAreaDelete
            // 
            this.btnSpAreaDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSpAreaDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaDelete.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnSpAreaDelete.ForeColor = System.Drawing.Color.White;
            this.btnSpAreaDelete.Location = new System.Drawing.Point(263, 0);
            this.btnSpAreaDelete.Name = "btnSpAreaDelete";
            this.btnSpAreaDelete.Size = new System.Drawing.Size(90, 38);
            this.btnSpAreaDelete.TabIndex = 3;
            this.btnSpAreaDelete.Text = "D e l e t e";
            this.btnSpAreaDelete.UseVisualStyleBackColor = false;
            this.btnSpAreaDelete.Click += new System.EventHandler(this.btnSpAreaDelete_Click);
            // 
            // dgvSpArea
            // 
            this.dgvSpArea.AllowUserToAddRows = false;
            this.dgvSpArea.AllowUserToDeleteRows = false;
            this.dgvSpArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpArea.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SAreaID,
            this.SDescription});
            this.dgvSpArea.Location = new System.Drawing.Point(14, 118);
            this.dgvSpArea.Name = "dgvSpArea";
            this.dgvSpArea.ReadOnly = true;
            this.dgvSpArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpArea.Size = new System.Drawing.Size(353, 278);
            this.dgvSpArea.TabIndex = 2;
            this.dgvSpArea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpArea_CellClick);
            // 
            // SAreaID
            // 
            this.SAreaID.DataPropertyName = "SAreaID";
            this.SAreaID.HeaderText = "Specialty #";
            this.SAreaID.Name = "SAreaID";
            this.SAreaID.ReadOnly = true;
            this.SAreaID.Width = 80;
            // 
            // SDescription
            // 
            this.SDescription.DataPropertyName = "SDescription";
            this.SDescription.HeaderText = "Specialty Area";
            this.SDescription.Name = "SDescription";
            this.SDescription.ReadOnly = true;
            this.SDescription.Width = 230;
            // 
            // txtSpAreaSearch
            // 
            this.txtSpAreaSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpAreaSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.txtSpAreaSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpAreaSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.txtSpAreaSearch.ForeColor = System.Drawing.Color.White;
            this.txtSpAreaSearch.Location = new System.Drawing.Point(14, 37);
            this.txtSpAreaSearch.Multiline = true;
            this.txtSpAreaSearch.Name = "txtSpAreaSearch";
            this.txtSpAreaSearch.Size = new System.Drawing.Size(353, 26);
            this.txtSpAreaSearch.TabIndex = 1;
            this.txtSpAreaSearch.TextChanged += new System.EventHandler(this.txtSpAreaSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(97, 15);
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
            this.pnlformButtons.Controls.Add(this.btnSpAreaSave);
            this.pnlformButtons.Controls.Add(this.btnSpAreaUpdate);
            this.pnlformButtons.Location = new System.Drawing.Point(27, 91);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(340, 34);
            this.pnlformButtons.TabIndex = 17;
            // 
            // btnSpAreaSave
            // 
            this.btnSpAreaSave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSpAreaSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaSave.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnSpAreaSave.ForeColor = System.Drawing.Color.White;
            this.btnSpAreaSave.Location = new System.Drawing.Point(157, 0);
            this.btnSpAreaSave.Name = "btnSpAreaSave";
            this.btnSpAreaSave.Size = new System.Drawing.Size(82, 34);
            this.btnSpAreaSave.TabIndex = 0;
            this.btnSpAreaSave.Text = "S a v e";
            this.btnSpAreaSave.UseVisualStyleBackColor = false;
            this.btnSpAreaSave.Click += new System.EventHandler(this.btnSpAreaSave_Click);
            // 
            // btnSpAreaUpdate
            // 
            this.btnSpAreaUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSpAreaUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSpAreaUpdate.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.btnSpAreaUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSpAreaUpdate.Location = new System.Drawing.Point(239, 0);
            this.btnSpAreaUpdate.Name = "btnSpAreaUpdate";
            this.btnSpAreaUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnSpAreaUpdate.TabIndex = 0;
            this.btnSpAreaUpdate.Text = "U p d a t e";
            this.btnSpAreaUpdate.UseVisualStyleBackColor = false;
            this.btnSpAreaUpdate.Click += new System.EventHandler(this.btnSpAreaUpdate_Click);
            // 
            // pnlSpAreaForm
            // 
            this.pnlSpAreaForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSpAreaForm.Controls.Add(this.txtSpAreaId);
            this.pnlSpAreaForm.Controls.Add(this.pnlformButtons);
            this.pnlSpAreaForm.Controls.Add(this.txtSpDescription);
            this.pnlSpAreaForm.Controls.Add(this.label4);
            this.pnlSpAreaForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpAreaForm.Location = new System.Drawing.Point(0, 0);
            this.pnlSpAreaForm.Name = "pnlSpAreaForm";
            this.pnlSpAreaForm.Size = new System.Drawing.Size(385, 141);
            this.pnlSpAreaForm.TabIndex = 8;
            // 
            // txtSpAreaId
            // 
            this.txtSpAreaId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpAreaId.BackColor = System.Drawing.Color.OrangeRed;
            this.txtSpAreaId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpAreaId.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.txtSpAreaId.ForeColor = System.Drawing.Color.White;
            this.txtSpAreaId.Location = new System.Drawing.Point(141, 20);
            this.txtSpAreaId.Multiline = true;
            this.txtSpAreaId.Name = "txtSpAreaId";
            this.txtSpAreaId.Size = new System.Drawing.Size(54, 20);
            this.txtSpAreaId.TabIndex = 1;
            this.txtSpAreaId.Visible = false;
            // 
            // txtSpDescription
            // 
            this.txtSpDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpDescription.BackColor = System.Drawing.Color.OrangeRed;
            this.txtSpDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F);
            this.txtSpDescription.ForeColor = System.Drawing.Color.White;
            this.txtSpDescription.Location = new System.Drawing.Point(27, 47);
            this.txtSpDescription.Multiline = true;
            this.txtSpDescription.Name = "txtSpDescription";
            this.txtSpDescription.Size = new System.Drawing.Size(340, 26);
            this.txtSpDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Specialty Area";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(385, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 543);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // RefSpecialtyArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 585);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSpAreaTop);
            this.Name = "RefSpecialtyArea";
            this.Text = "RefSpecialtyArea";
            this.Load += new System.EventHandler(this.RefSpecialtyArea_Load);
            this.pnlSpAreaTop.ResumeLayout(false);
            this.pnlSpAreaTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpArea)).EndInit();
            this.pnlformButtons.ResumeLayout(false);
            this.pnlSpAreaForm.ResumeLayout(false);
            this.pnlSpAreaForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpAreaTop;
        private System.Windows.Forms.Button btnSpAreaClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnSpAreaEdit;
        private System.Windows.Forms.Button btnSpAreaDelete;
        private System.Windows.Forms.DataGridView dgvSpArea;
        private System.Windows.Forms.TextBox txtSpAreaSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnSpAreaSave;
        private System.Windows.Forms.Button btnSpAreaUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlSpAreaForm;
        private System.Windows.Forms.TextBox txtSpAreaId;
        private System.Windows.Forms.TextBox txtSpDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAreaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}