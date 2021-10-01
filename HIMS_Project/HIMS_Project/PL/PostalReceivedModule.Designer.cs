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
            this.pnlPostalForm = new System.Windows.Forms.Panel();
            this.pnlformButtons = new System.Windows.Forms.Panel();
            this.btnRePostalSave = new System.Windows.Forms.Button();
            this.btnRePostalUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvBtn = new System.Windows.Forms.Panel();
            this.btnRePostalEdit = new System.Windows.Forms.Button();
            this.btnRePostalDelete = new System.Windows.Forms.Button();
            this.dgvRePostal = new System.Windows.Forms.DataGridView();
            this.txtRePostalSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReFrom = new System.Windows.Forms.TextBox();
            this.txtReTo = new System.Windows.Forms.TextBox();
            this.txtReAddress = new System.Windows.Forms.TextBox();
            this.txtReNote = new System.Windows.Forms.TextBox();
            this.pnlRePostalTop.SuspendLayout();
            this.pnlPostalForm.SuspendLayout();
            this.pnlformButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDgvBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePostal)).BeginInit();
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
            this.pnlRePostalTop.Size = new System.Drawing.Size(800, 42);
            this.pnlRePostalTop.TabIndex = 4;
            // 
            // btnRePostalClose
            // 
            this.btnRePostalClose.BackColor = System.Drawing.Color.White;
            this.btnRePostalClose.FlatAppearance.BorderSize = 0;
            this.btnRePostalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRePostalClose.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePostalClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(27)))), ((int)(((byte)(64)))));
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postal Module";
            // 
            // pnlPostalForm
            // 
            this.pnlPostalForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPostalForm.Controls.Add(this.txtReNote);
            this.pnlPostalForm.Controls.Add(this.txtReAddress);
            this.pnlPostalForm.Controls.Add(this.txtReTo);
            this.pnlPostalForm.Controls.Add(this.txtReFrom);
            this.pnlPostalForm.Controls.Add(this.label7);
            this.pnlPostalForm.Controls.Add(this.label6);
            this.pnlPostalForm.Controls.Add(this.label5);
            this.pnlPostalForm.Controls.Add(this.label4);
            this.pnlPostalForm.Controls.Add(this.label2);
            this.pnlPostalForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPostalForm.Location = new System.Drawing.Point(0, 42);
            this.pnlPostalForm.Name = "pnlPostalForm";
            this.pnlPostalForm.Size = new System.Drawing.Size(800, 132);
            this.pnlPostalForm.TabIndex = 5;
            // 
            // pnlformButtons
            // 
            this.pnlformButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlformButtons.Controls.Add(this.btnRePostalSave);
            this.pnlformButtons.Controls.Add(this.btnRePostalUpdate);
            this.pnlformButtons.Controls.Add(this.btnClear);
            this.pnlformButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlformButtons.Location = new System.Drawing.Point(0, 174);
            this.pnlformButtons.Name = "pnlformButtons";
            this.pnlformButtons.Size = new System.Drawing.Size(800, 34);
            this.pnlformButtons.TabIndex = 14;
            // 
            // btnRePostalSave
            // 
            this.btnRePostalSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalSave.Location = new System.Drawing.Point(575, 0);
            this.btnRePostalSave.Name = "btnRePostalSave";
            this.btnRePostalSave.Size = new System.Drawing.Size(75, 34);
            this.btnRePostalSave.TabIndex = 0;
            this.btnRePostalSave.Text = "Save";
            this.btnRePostalSave.UseVisualStyleBackColor = true;
            // 
            // btnRePostalUpdate
            // 
            this.btnRePostalUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalUpdate.Location = new System.Drawing.Point(650, 0);
            this.btnRePostalUpdate.Name = "btnRePostalUpdate";
            this.btnRePostalUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnRePostalUpdate.TabIndex = 0;
            this.btnRePostalUpdate.Text = "Update";
            this.btnRePostalUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(725, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnlDgvBtn);
            this.panel1.Controls.Add(this.dgvRePostal);
            this.panel1.Controls.Add(this.txtRePostalSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 251);
            this.panel1.TabIndex = 15;
            // 
            // pnlDgvBtn
            // 
            this.pnlDgvBtn.Controls.Add(this.btnRePostalEdit);
            this.pnlDgvBtn.Controls.Add(this.btnRePostalDelete);
            this.pnlDgvBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvBtn.Location = new System.Drawing.Point(0, 213);
            this.pnlDgvBtn.Name = "pnlDgvBtn";
            this.pnlDgvBtn.Size = new System.Drawing.Size(800, 38);
            this.pnlDgvBtn.TabIndex = 4;
            // 
            // btnRePostalEdit
            // 
            this.btnRePostalEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalEdit.Location = new System.Drawing.Point(646, 0);
            this.btnRePostalEdit.Name = "btnRePostalEdit";
            this.btnRePostalEdit.Size = new System.Drawing.Size(77, 38);
            this.btnRePostalEdit.TabIndex = 3;
            this.btnRePostalEdit.Text = "Edit";
            this.btnRePostalEdit.UseVisualStyleBackColor = true;
            // 
            // btnRePostalDelete
            // 
            this.btnRePostalDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRePostalDelete.Location = new System.Drawing.Point(723, 0);
            this.btnRePostalDelete.Name = "btnRePostalDelete";
            this.btnRePostalDelete.Size = new System.Drawing.Size(77, 38);
            this.btnRePostalDelete.TabIndex = 3;
            this.btnRePostalDelete.Text = "Delete";
            this.btnRePostalDelete.UseVisualStyleBackColor = true;
            // 
            // dgvRePostal
            // 
            this.dgvRePostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRePostal.Location = new System.Drawing.Point(7, 38);
            this.dgvRePostal.Name = "dgvRePostal";
            this.dgvRePostal.Size = new System.Drawing.Size(788, 169);
            this.dgvRePostal.TabIndex = 2;
            // 
            // txtRePostalSearch
            // 
            this.txtRePostalSearch.Location = new System.Drawing.Point(143, 11);
            this.txtRePostalSearch.Name = "txtRePostalSearch";
            this.txtRePostalSearch.Size = new System.Drawing.Size(250, 20);
            this.txtRePostalSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search By User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attach Document";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "To name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // txtReFrom
            // 
            this.txtReFrom.Location = new System.Drawing.Point(89, 19);
            this.txtReFrom.Name = "txtReFrom";
            this.txtReFrom.Size = new System.Drawing.Size(304, 20);
            this.txtReFrom.TabIndex = 1;
            // 
            // txtReTo
            // 
            this.txtReTo.Location = new System.Drawing.Point(89, 55);
            this.txtReTo.Name = "txtReTo";
            this.txtReTo.Size = new System.Drawing.Size(304, 20);
            this.txtReTo.TabIndex = 2;
            // 
            // txtReAddress
            // 
            this.txtReAddress.Location = new System.Drawing.Point(512, 19);
            this.txtReAddress.Name = "txtReAddress";
            this.txtReAddress.Size = new System.Drawing.Size(264, 20);
            this.txtReAddress.TabIndex = 3;
            // 
            // txtReNote
            // 
            this.txtReNote.Location = new System.Drawing.Point(512, 55);
            this.txtReNote.Multiline = true;
            this.txtReNote.Name = "txtReNote";
            this.txtReNote.Size = new System.Drawing.Size(264, 58);
            this.txtReNote.TabIndex = 4;
            // 
            // PostalReceivedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlformButtons);
            this.Controls.Add(this.pnlPostalForm);
            this.Controls.Add(this.pnlRePostalTop);
            this.Name = "PostalReceivedModule";
            this.Text = "PostalReceivedModule";
            this.Load += new System.EventHandler(this.PostalReceivedModule_Load);
            this.pnlRePostalTop.ResumeLayout(false);
            this.pnlRePostalTop.PerformLayout();
            this.pnlPostalForm.ResumeLayout(false);
            this.pnlPostalForm.PerformLayout();
            this.pnlformButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRePostal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRePostalTop;
        private System.Windows.Forms.Button btnRePostalClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPostalForm;
        private System.Windows.Forms.Panel pnlformButtons;
        private System.Windows.Forms.Button btnRePostalSave;
        private System.Windows.Forms.Button btnRePostalUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvBtn;
        private System.Windows.Forms.Button btnRePostalEdit;
        private System.Windows.Forms.Button btnRePostalDelete;
        private System.Windows.Forms.DataGridView dgvRePostal;
        private System.Windows.Forms.TextBox txtRePostalSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReNote;
        private System.Windows.Forms.TextBox txtReAddress;
        private System.Windows.Forms.TextBox txtReTo;
        private System.Windows.Forms.TextBox txtReFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}