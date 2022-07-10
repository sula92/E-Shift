namespace EShift
{
    partial class AdminDashboard
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
            this.customerMngt = new System.Windows.Forms.Button();
            this.btnEmpMngt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUserMngt = new System.Windows.Forms.Button();
            this.btnJobMngt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerMngt
            // 
            this.customerMngt.Location = new System.Drawing.Point(130, 77);
            this.customerMngt.Name = "customerMngt";
            this.customerMngt.Size = new System.Drawing.Size(100, 85);
            this.customerMngt.TabIndex = 0;
            this.customerMngt.Text = "Customer Management";
            this.customerMngt.UseVisualStyleBackColor = true;
            this.customerMngt.Click += new System.EventHandler(this.customerMngt_Click);
            // 
            // btnEmpMngt
            // 
            this.btnEmpMngt.Location = new System.Drawing.Point(280, 77);
            this.btnEmpMngt.Name = "btnEmpMngt";
            this.btnEmpMngt.Size = new System.Drawing.Size(104, 85);
            this.btnEmpMngt.TabIndex = 1;
            this.btnEmpMngt.Text = "Employee Management";
            this.btnEmpMngt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lorry Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUserMngt
            // 
            this.btnUserMngt.Location = new System.Drawing.Point(130, 210);
            this.btnUserMngt.Name = "btnUserMngt";
            this.btnUserMngt.Size = new System.Drawing.Size(122, 83);
            this.btnUserMngt.TabIndex = 3;
            this.btnUserMngt.Text = "User Management";
            this.btnUserMngt.UseVisualStyleBackColor = true;
            // 
            // btnJobMngt
            // 
            this.btnJobMngt.Location = new System.Drawing.Point(313, 210);
            this.btnJobMngt.Name = "btnJobMngt";
            this.btnJobMngt.Size = new System.Drawing.Size(111, 83);
            this.btnJobMngt.TabIndex = 4;
            this.btnJobMngt.Text = "Job Management";
            this.btnJobMngt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 96);
            this.button1.TabIndex = 5;
            this.button1.Text = "Containern Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 85);
            this.button3.TabIndex = 6;
            this.button3.Text = "Product Management";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(645, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 90);
            this.button4.TabIndex = 7;
            this.button4.Text = "Unit Management";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJobMngt);
            this.Controls.Add(this.btnUserMngt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEmpMngt);
            this.Controls.Add(this.customerMngt);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerMngt;
        private System.Windows.Forms.Button btnEmpMngt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUserMngt;
        private System.Windows.Forms.Button btnJobMngt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}