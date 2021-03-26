
namespace MoodlePortal
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginAsAdmin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.adminUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginAsAdmin);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.adminUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(83, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 221);
            this.panel1.TabIndex = 4;
            // 
            // loginAsAdmin
            // 
            this.loginAsAdmin.Location = new System.Drawing.Point(27, 154);
            this.loginAsAdmin.Name = "loginAsAdmin";
            this.loginAsAdmin.Size = new System.Drawing.Size(75, 23);
            this.loginAsAdmin.TabIndex = 4;
            this.loginAsAdmin.Text = "LOGIN";
            this.loginAsAdmin.UseVisualStyleBackColor = true;
            this.loginAsAdmin.Click += new System.EventHandler(this.loginAsAdmin_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(107, 99);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 3;
            // 
            // adminUsername
            // 
            this.adminUsername.Location = new System.Drawing.Point(107, 41);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(100, 22);
            this.adminUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(657, 164);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(75, 23);
            this.izlazBtn.TabIndex = 5;
            this.izlazBtn.Text = "EXIT";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlazBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginAsAdmin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox adminUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izlazBtn;
    }
}

