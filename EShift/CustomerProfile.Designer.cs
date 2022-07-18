namespace EShift
{
    partial class CustomerProfile
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnm = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(699, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(59, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(299, 21);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(146, 20);
            this.txtContact.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(299, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Location = new System.Drawing.Point(28, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 143);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(551, 10);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 96);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtUnm);
            this.panel2.Controls.Add(this.txtUID);
            this.panel2.Controls.Add(this.txtPwd2);
            this.panel2.Controls.Add(this.txtPwd1);
            this.panel2.Location = new System.Drawing.Point(28, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 145);
            this.panel2.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(603, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 78);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "User Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(249, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Password\r\n(ReType)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "User ID";
            // 
            // txtUnm
            // 
            this.txtUnm.Location = new System.Drawing.Point(78, 88);
            this.txtUnm.Name = "txtUnm";
            this.txtUnm.Size = new System.Drawing.Size(151, 20);
            this.txtUnm.TabIndex = 1;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(79, 23);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(146, 20);
            this.txtUID.TabIndex = 0;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(341, 84);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(161, 20);
            this.txtPwd2.TabIndex = 2;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(341, 27);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(161, 20);
            this.txtPwd1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(32, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 19);
            this.lblWelcome.TabIndex = 6;
            // 
            // CustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "CustomerProfile";
            this.Text = "CustomerProfile";
            this.Load += new System.EventHandler(this.CustomerProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUnm;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel lblWelcome;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd1;
    }
}