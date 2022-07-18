namespace EShift
{
    partial class ManageJob
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmdRequest = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDesAdd = new System.Windows.Forms.RichTextBox();
            this.txtStartingAdd = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFromDate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbToDate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbCustomerFilter = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddProduct = new System.Windows.Forms.Button();
            this.cmbUID = new System.Windows.Forms.ComboBox();
            this.cmdRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(904, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdRequest
            // 
            this.cmdRequest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdRequest.Controls.Add(this.cmbUID);
            this.cmdRequest.Controls.Add(this.cmbStatus);
            this.cmdRequest.Controls.Add(this.btnDelete);
            this.cmdRequest.Controls.Add(this.btnUpdate);
            this.cmdRequest.Controls.Add(this.btnAddNew);
            this.cmdRequest.Controls.Add(this.txtDesAdd);
            this.cmdRequest.Controls.Add(this.txtStartingAdd);
            this.cmdRequest.Controls.Add(this.dateTimePicker1);
            this.cmdRequest.Controls.Add(this.txtCId);
            this.cmdRequest.Controls.Add(this.label2);
            this.cmdRequest.Controls.Add(this.txtId);
            this.cmdRequest.Controls.Add(this.label6);
            this.cmdRequest.Controls.Add(this.label3);
            this.cmdRequest.Controls.Add(this.label4);
            this.cmdRequest.Controls.Add(this.label7);
            this.cmdRequest.Controls.Add(this.label5);
            this.cmdRequest.Controls.Add(this.label9);
            this.cmdRequest.Controls.Add(this.label1);
            this.cmdRequest.Location = new System.Drawing.Point(0, 1);
            this.cmdRequest.Name = "cmdRequest";
            this.cmdRequest.Size = new System.Drawing.Size(396, 499);
            this.cmdRequest.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(261, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(139, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(12, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 31);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "+AddNew";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtDesAdd
            // 
            this.txtDesAdd.Location = new System.Drawing.Point(109, 314);
            this.txtDesAdd.Name = "txtDesAdd";
            this.txtDesAdd.Size = new System.Drawing.Size(279, 96);
            this.txtDesAdd.TabIndex = 3;
            this.txtDesAdd.Text = "";
            // 
            // txtStartingAdd
            // 
            this.txtStartingAdd.Location = new System.Drawing.Point(109, 202);
            this.txtStartingAdd.Name = "txtStartingAdd";
            this.txtStartingAdd.Size = new System.Drawing.Size(279, 96);
            this.txtStartingAdd.TabIndex = 3;
            this.txtStartingAdd.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(232, 59);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(156, 20);
            this.txtCId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(150, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 20);
            this.txtId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "DESTINATION\r\nADDRESS";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "STARTING\r\nADDRESS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(258, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "UNIT\r\nID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(174, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CUS_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(566, 178);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(232, 100);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(156, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(183, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // cmbFromDate
            // 
            this.cmbFromDate.FormattingEnabled = true;
            this.cmbFromDate.Location = new System.Drawing.Point(14, 61);
            this.cmbFromDate.Name = "cmbFromDate";
            this.cmbFromDate.Size = new System.Drawing.Size(156, 21);
            this.cmbFromDate.TabIndex = 7;
            this.cmbFromDate.SelectedIndexChanged += new System.EventHandler(this.cmbFromDate_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Filter By Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Filter By Customer";
            // 
            // cmbToDate
            // 
            this.cmbToDate.FormattingEnabled = true;
            this.cmbToDate.Location = new System.Drawing.Point(330, 61);
            this.cmbToDate.Name = "cmbToDate";
            this.cmbToDate.Size = new System.Drawing.Size(156, 21);
            this.cmbToDate.TabIndex = 7;
            this.cmbToDate.SelectedIndexChanged += new System.EventHandler(this.cmbToDate_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Filter By Date";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(14, 63);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(156, 21);
            this.cmbStatusFilter.TabIndex = 7;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // cmbCustomerFilter
            // 
            this.cmbCustomerFilter.FormattingEnabled = true;
            this.cmbCustomerFilter.Location = new System.Drawing.Point(330, 63);
            this.cmbCustomerFilter.Name = "cmbCustomerFilter";
            this.cmbCustomerFilter.Size = new System.Drawing.Size(156, 21);
            this.cmbCustomerFilter.TabIndex = 7;
            this.cmbCustomerFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerFilter_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(59, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "From";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(391, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbFromDate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbToDate);
            this.panel1.Location = new System.Drawing.Point(413, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.cmbStatusFilter);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cmbCustomerFilter);
            this.panel2.Location = new System.Drawing.Point(413, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 114);
            this.panel2.TabIndex = 10;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.DarkBlue;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.Color.Lavender;
            this.AddProduct.Location = new System.Drawing.Point(413, 32);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(146, 29);
            this.AddProduct.TabIndex = 11;
            this.AddProduct.Text = "Add Products";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cmbUID
            // 
            this.cmbUID.FormattingEnabled = true;
            this.cmbUID.Location = new System.Drawing.Point(295, 150);
            this.cmbUID.Name = "cmbUID";
            this.cmbUID.Size = new System.Drawing.Size(93, 21);
            this.cmbUID.TabIndex = 7;
            // 
            // ManageJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 497);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdRequest);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "ManageJob";
            this.Text = "ManageJob";
            this.Load += new System.EventHandler(this.ManageJob_Load);
            this.cmdRequest.ResumeLayout(false);
            this.cmdRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel cmdRequest;
        private System.Windows.Forms.RichTextBox txtStartingAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.RichTextBox txtDesAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFromDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbCustomerFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.ComboBox cmbUID;
    }
}