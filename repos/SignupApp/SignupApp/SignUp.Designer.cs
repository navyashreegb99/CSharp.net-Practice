
namespace SignupApp
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTransactionMsg = new System.Windows.Forms.Label();
            this.lblSMSMsg = new System.Windows.Forms.Label();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkTranscactions = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(484, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransactionMsg);
            this.groupBox1.Controls.Add(this.lblSMSMsg);
            this.groupBox1.Controls.Add(this.chkReports);
            this.groupBox1.Controls.Add(this.chkTranscactions);
            this.groupBox1.Controls.Add(this.chkSMS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // lblTransactionMsg
            // 
            this.lblTransactionMsg.AutoSize = true;
            this.lblTransactionMsg.Location = new System.Drawing.Point(365, 106);
            this.lblTransactionMsg.Name = "lblTransactionMsg";
            this.lblTransactionMsg.Size = new System.Drawing.Size(35, 23);
            this.lblTransactionMsg.TabIndex = 4;
            this.lblTransactionMsg.Text = ".....";
            // 
            // lblSMSMsg
            // 
            this.lblSMSMsg.AutoSize = true;
            this.lblSMSMsg.Location = new System.Drawing.Point(365, 29);
            this.lblSMSMsg.Name = "lblSMSMsg";
            this.lblSMSMsg.Size = new System.Drawing.Size(35, 23);
            this.lblSMSMsg.TabIndex = 3;
            this.lblSMSMsg.Text = ".....";
            this.lblSMSMsg.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReports.Location = new System.Drawing.Point(135, 69);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(90, 23);
            this.chkReports.TabIndex = 2;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // chkTranscactions
            // 
            this.chkTranscactions.AutoSize = true;
            this.chkTranscactions.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTranscactions.Location = new System.Drawing.Point(135, 108);
            this.chkTranscactions.Name = "chkTranscactions";
            this.chkTranscactions.Size = new System.Drawing.Size(181, 23);
            this.chkTranscactions.TabIndex = 1;
            this.chkTranscactions.Text = "Transaction Reports";
            this.chkTranscactions.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMS.Location = new System.Drawing.Point(135, 29);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(163, 23);
            this.chkSMS.TabIndex = 0;
            this.chkSMS.Text = "SMS notifications";
            this.chkSMS.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(631, 404);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(87, 26);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSMSMsg;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkTranscactions;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.Label lblTransactionMsg;
        private System.Windows.Forms.Label btnSignUp;
    }
}

