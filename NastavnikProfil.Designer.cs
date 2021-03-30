
namespace MoodlePortal
{
    partial class NastavnikProfil
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
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.updatePnl = new System.Windows.Forms.Panel();
            this.updateSaveBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.jmbgLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.prezimeLbl = new System.Windows.Forms.Label();
            this.imeLbl = new System.Windows.Forms.Label();
            this.updatePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.Location = new System.Drawing.Point(281, 301);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(75, 23);
            this.izmeniBtn.TabIndex = 19;
            this.izmeniBtn.Text = "IZMENI";
            this.izmeniBtn.UseVisualStyleBackColor = true;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // updatePnl
            // 
            this.updatePnl.Controls.Add(this.updateSaveBtn);
            this.updatePnl.Controls.Add(this.emailBox);
            this.updatePnl.Controls.Add(this.prezimeBox);
            this.updatePnl.Controls.Add(this.imeBox);
            this.updatePnl.Location = new System.Drawing.Point(435, 33);
            this.updatePnl.Name = "updatePnl";
            this.updatePnl.Size = new System.Drawing.Size(303, 341);
            this.updatePnl.TabIndex = 18;
            // 
            // updateSaveBtn
            // 
            this.updateSaveBtn.Location = new System.Drawing.Point(18, 275);
            this.updateSaveBtn.Name = "updateSaveBtn";
            this.updateSaveBtn.Size = new System.Drawing.Size(85, 24);
            this.updateSaveBtn.TabIndex = 5;
            this.updateSaveBtn.Text = "SACUVAJ";
            this.updateSaveBtn.UseVisualStyleBackColor = true;
            this.updateSaveBtn.Click += new System.EventHandler(this.updateSaveBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(18, 127);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 2;
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(18, 78);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 22);
            this.prezimeBox.TabIndex = 1;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(18, 35);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 22);
            this.imeBox.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(63, 403);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // jmbgLbl
            // 
            this.jmbgLbl.AutoSize = true;
            this.jmbgLbl.Location = new System.Drawing.Point(278, 24);
            this.jmbgLbl.Name = "jmbgLbl";
            this.jmbgLbl.Size = new System.Drawing.Size(46, 17);
            this.jmbgLbl.TabIndex = 14;
            this.jmbgLbl.Text = "Jmbg:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 150);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(274, 157);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(94, 17);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email adresa:";
            // 
            // prezimeLbl
            // 
            this.prezimeLbl.AutoSize = true;
            this.prezimeLbl.Location = new System.Drawing.Point(278, 108);
            this.prezimeLbl.Name = "prezimeLbl";
            this.prezimeLbl.Size = new System.Drawing.Size(63, 17);
            this.prezimeLbl.TabIndex = 11;
            this.prezimeLbl.Text = "Prezime:";
            // 
            // imeLbl
            // 
            this.imeLbl.AutoSize = true;
            this.imeLbl.Location = new System.Drawing.Point(278, 65);
            this.imeLbl.Name = "imeLbl";
            this.imeLbl.Size = new System.Drawing.Size(34, 17);
            this.imeLbl.TabIndex = 10;
            this.imeLbl.Text = "Ime:";
            // 
            // NastavnikProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.updatePnl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.jmbgLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.prezimeLbl);
            this.Controls.Add(this.imeLbl);
            this.Name = "NastavnikProfil";
            this.Text = "NastavnikProfil";
            this.updatePnl.ResumeLayout(false);
            this.updatePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Panel updatePnl;
        private System.Windows.Forms.Button updateSaveBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label jmbgLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label prezimeLbl;
        private System.Windows.Forms.Label imeLbl;
    }
}