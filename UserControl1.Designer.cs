
namespace MoodlePortal
{
    partial class UCAdminPocetna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentBtn = new System.Windows.Forms.Button();
            this.nastavnikBtn = new System.Windows.Forms.Button();
            this.kursBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(383, 392);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(101, 38);
            this.nazadBtn.TabIndex = 9;
            this.nazadBtn.Text = "NAZAD";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Izaberite podatke koje zelite prikazati";
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(74, 280);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(103, 39);
            this.studentBtn.TabIndex = 7;
            this.studentBtn.Text = "STUDENTI";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // nastavnikBtn
            // 
            this.nastavnikBtn.Location = new System.Drawing.Point(74, 216);
            this.nastavnikBtn.Name = "nastavnikBtn";
            this.nastavnikBtn.Size = new System.Drawing.Size(103, 39);
            this.nastavnikBtn.TabIndex = 6;
            this.nastavnikBtn.Text = "NASTAVNICI";
            this.nastavnikBtn.UseVisualStyleBackColor = true;
            this.nastavnikBtn.Click += new System.EventHandler(this.nastavnikBtn_Click);
            // 
            // kursBtn
            // 
            this.kursBtn.Location = new System.Drawing.Point(74, 152);
            this.kursBtn.Name = "kursBtn";
            this.kursBtn.Size = new System.Drawing.Size(103, 37);
            this.kursBtn.TabIndex = 5;
            this.kursBtn.Text = "KURSEVI";
            this.kursBtn.UseVisualStyleBackColor = true;
            // 
            // UCAdminPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.nastavnikBtn);
            this.Controls.Add(this.kursBtn);
            this.Name = "UCAdminPocetna";
            this.Size = new System.Drawing.Size(780, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button nastavnikBtn;
        private System.Windows.Forms.Button kursBtn;
    }
}
