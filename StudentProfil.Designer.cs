
namespace MoodlePortal
{
    partial class StudentProfil
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
            this.imeLbl = new System.Windows.Forms.Label();
            this.prezimeLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brindeksaLbl = new System.Windows.Forms.Label();
            this.godinaUpisaLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.upisanaGodinaLbl = new System.Windows.Forms.Label();
            this.updatePnl = new System.Windows.Forms.Panel();
            this.updateSaveBtn = new System.Windows.Forms.Button();
            this.godinaStudijaBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.izmeniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updatePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLbl
            // 
            this.imeLbl.AutoSize = true;
            this.imeLbl.Location = new System.Drawing.Point(238, 65);
            this.imeLbl.Name = "imeLbl";
            this.imeLbl.Size = new System.Drawing.Size(34, 17);
            this.imeLbl.TabIndex = 0;
            this.imeLbl.Text = "Ime:";
            // 
            // prezimeLbl
            // 
            this.prezimeLbl.AutoSize = true;
            this.prezimeLbl.Location = new System.Drawing.Point(238, 108);
            this.prezimeLbl.Name = "prezimeLbl";
            this.prezimeLbl.Size = new System.Drawing.Size(63, 17);
            this.prezimeLbl.TabIndex = 1;
            this.prezimeLbl.Text = "Prezime:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(234, 157);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(94, 17);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email adresa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // brindeksaLbl
            // 
            this.brindeksaLbl.AutoSize = true;
            this.brindeksaLbl.Location = new System.Drawing.Point(238, 24);
            this.brindeksaLbl.Name = "brindeksaLbl";
            this.brindeksaLbl.Size = new System.Drawing.Size(90, 17);
            this.brindeksaLbl.TabIndex = 4;
            this.brindeksaLbl.Text = "Broj indeksa:";
            // 
            // godinaUpisaLbl
            // 
            this.godinaUpisaLbl.AutoSize = true;
            this.godinaUpisaLbl.Location = new System.Drawing.Point(232, 202);
            this.godinaUpisaLbl.Name = "godinaUpisaLbl";
            this.godinaUpisaLbl.Size = new System.Drawing.Size(96, 17);
            this.godinaUpisaLbl.TabIndex = 5;
            this.godinaUpisaLbl.Text = "Godina upisa:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(23, 403);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // upisanaGodinaLbl
            // 
            this.upisanaGodinaLbl.AutoSize = true;
            this.upisanaGodinaLbl.Location = new System.Drawing.Point(234, 241);
            this.upisanaGodinaLbl.Name = "upisanaGodinaLbl";
            this.upisanaGodinaLbl.Size = new System.Drawing.Size(111, 17);
            this.upisanaGodinaLbl.TabIndex = 7;
            this.upisanaGodinaLbl.Text = "Upisana godina:";
            // 
            // updatePnl
            // 
            this.updatePnl.Controls.Add(this.updateSaveBtn);
            this.updatePnl.Controls.Add(this.godinaStudijaBox);
            this.updatePnl.Controls.Add(this.emailBox);
            this.updatePnl.Controls.Add(this.prezimeBox);
            this.updatePnl.Controls.Add(this.imeBox);
            this.updatePnl.Location = new System.Drawing.Point(395, 33);
            this.updatePnl.Name = "updatePnl";
            this.updatePnl.Size = new System.Drawing.Size(303, 341);
            this.updatePnl.TabIndex = 8;
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
            // godinaStudijaBox
            // 
            this.godinaStudijaBox.Location = new System.Drawing.Point(18, 216);
            this.godinaStudijaBox.Name = "godinaStudijaBox";
            this.godinaStudijaBox.Size = new System.Drawing.Size(100, 22);
            this.godinaStudijaBox.TabIndex = 4;
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
            // izmeniBtn
            // 
            this.izmeniBtn.Location = new System.Drawing.Point(241, 301);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(75, 23);
            this.izmeniBtn.TabIndex = 9;
            this.izmeniBtn.Text = "IZMENI";
            this.izmeniBtn.UseVisualStyleBackColor = true;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // StudentProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.updatePnl);
            this.Controls.Add(this.upisanaGodinaLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.godinaUpisaLbl);
            this.Controls.Add(this.brindeksaLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.prezimeLbl);
            this.Controls.Add(this.imeLbl);
            this.Name = "StudentProfil";
            this.Text = "StudentProfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updatePnl.ResumeLayout(false);
            this.updatePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeLbl;
        private System.Windows.Forms.Label prezimeLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label brindeksaLbl;
        private System.Windows.Forms.Label godinaUpisaLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label upisanaGodinaLbl;
        private System.Windows.Forms.Panel updatePnl;
        private System.Windows.Forms.Button updateSaveBtn;
        private System.Windows.Forms.TextBox godinaStudijaBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Button izmeniBtn;
    }
}