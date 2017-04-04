namespace OutlookButton
{
    partial class Popup
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
            this.heading_label = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.subject_label = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Location = new System.Drawing.Point(12, 25);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(92, 13);
            this.heading_label.TabIndex = 0;
            this.heading_label.Text = "Heading(Ex. Mr...)";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(131, 22);
            this.txtHeading.MaxLength = 128;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(141, 20);
            this.txtHeading.TabIndex = 1;
            this.txtHeading.Text = "Alexis Richard";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(12, 62);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(73, 13);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email Address";
            // 
            // txtToEmail
            // 
            this.txtToEmail.Location = new System.Drawing.Point(131, 59);
            this.txtToEmail.MaxLength = 128;
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(141, 20);
            this.txtToEmail.TabIndex = 1;
            this.txtToEmail.Text = "Please enter your email address";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(71, 98);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(43, 13);
            this.subject_label.TabIndex = 0;
            this.subject_label.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(131, 95);
            this.txtSubject.MaxLength = 128;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(141, 20);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.Text = "Test this one.";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(15, 131);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(256, 102);
            this.txtBody.TabIndex = 2;
            this.txtBody.Text = "Hello Employer,\n\nYou can type here anything you want because it would be so glad " +
    "for me to get this one.\nI hope you would like to click the below \"Send Now\" butt" +
    "on as interview.\n\nBest regards,\nAlex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(131, 244);
            this.txtFromEmail.MaxLength = 128;
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(141, 20);
            this.txtFromEmail.TabIndex = 1;
            this.txtFromEmail.Text = "ecmascript.guru@gmail.com";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(196, 270);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Now";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtFromEmail);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToEmail);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.heading_label);
            this.Name = "Popup";
            this.Text = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.Button btnSend;
    }
}