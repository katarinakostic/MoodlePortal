
namespace MoodlePortal
{
    partial class UCStudent
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
            this.listViewStudenti = new System.Windows.Forms.ListView();
            this.prikaziStudenteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brindeksaBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.indeksDeleteTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewStudenti
            // 
            this.listViewStudenti.HideSelection = false;
            this.listViewStudenti.Location = new System.Drawing.Point(84, 151);
            this.listViewStudenti.Name = "listViewStudenti";
            this.listViewStudenti.Size = new System.Drawing.Size(436, 290);
            this.listViewStudenti.TabIndex = 0;
            this.listViewStudenti.UseCompatibleStateImageBehavior = false;
            this.listViewStudenti.View = System.Windows.Forms.View.List;
            // 
            // prikaziStudenteBtn
            // 
            this.prikaziStudenteBtn.Location = new System.Drawing.Point(84, 96);
            this.prikaziStudenteBtn.Name = "prikaziStudenteBtn";
            this.prikaziStudenteBtn.Size = new System.Drawing.Size(187, 38);
            this.prikaziStudenteBtn.TabIndex = 1;
            this.prikaziStudenteBtn.Text = "Prikazi sve studente";
            this.prikaziStudenteBtn.UseVisualStyleBackColor = true;
            this.prikaziStudenteBtn.Click += new System.EventHandler(this.prikaziStudenteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(257, 466);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(95, 47);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "DODAJ";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj indeksa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // brindeksaBox
            // 
            this.brindeksaBox.Location = new System.Drawing.Point(124, 466);
            this.brindeksaBox.Name = "brindeksaBox";
            this.brindeksaBox.Size = new System.Drawing.Size(100, 22);
            this.brindeksaBox.TabIndex = 7;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(124, 490);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 22);
            this.imeBox.TabIndex = 8;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(124, 542);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 10;
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(124, 518);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 22);
            this.prezimeBox.TabIndex = 9;
            // 
            // indeksDeleteTxt
            // 
            this.indeksDeleteTxt.Location = new System.Drawing.Point(503, 471);
            this.indeksDeleteTxt.Name = "indeksDeleteTxt";
            this.indeksDeleteTxt.Size = new System.Drawing.Size(100, 22);
            this.indeksDeleteTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Broj indeksa";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(503, 517);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "OBRISI";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // UCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.indeksDeleteTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.prezimeBox);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.brindeksaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.prikaziStudenteBtn);
            this.Controls.Add(this.listViewStudenti);
            this.Name = "UCStudent";
            this.Size = new System.Drawing.Size(725, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudenti;
        private System.Windows.Forms.Button prikaziStudenteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brindeksaBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox indeksDeleteTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
    }
}
