﻿
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
            this.indeksSearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.imageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.godinaStudijaBox = new System.Windows.Forms.TextBox();
            this.godinaUpisaBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStudenti
            // 
            this.listViewStudenti.HideSelection = false;
            this.listViewStudenti.Location = new System.Drawing.Point(47, 98);
            this.listViewStudenti.Name = "listViewStudenti";
            this.listViewStudenti.Size = new System.Drawing.Size(436, 290);
            this.listViewStudenti.TabIndex = 0;
            this.listViewStudenti.UseCompatibleStateImageBehavior = false;
            this.listViewStudenti.View = System.Windows.Forms.View.List;
            this.listViewStudenti.SelectedIndexChanged += new System.EventHandler(this.listViewStudenti_SelectedIndexChanged);
            // 
            // prikaziStudenteBtn
            // 
            this.prikaziStudenteBtn.Location = new System.Drawing.Point(47, 43);
            this.prikaziStudenteBtn.Name = "prikaziStudenteBtn";
            this.prikaziStudenteBtn.Size = new System.Drawing.Size(156, 38);
            this.prikaziStudenteBtn.TabIndex = 1;
            this.prikaziStudenteBtn.Text = "Prikazi sve studente";
            this.prikaziStudenteBtn.UseVisualStyleBackColor = true;
            this.prikaziStudenteBtn.Click += new System.EventHandler(this.prikaziStudenteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(264, 407);
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
            this.label1.Location = new System.Drawing.Point(25, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj indeksa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // brindeksaBox
            // 
            this.brindeksaBox.Location = new System.Drawing.Point(131, 407);
            this.brindeksaBox.Name = "brindeksaBox";
            this.brindeksaBox.Size = new System.Drawing.Size(100, 22);
            this.brindeksaBox.TabIndex = 7;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(131, 431);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 22);
            this.imeBox.TabIndex = 8;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(131, 483);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 10;
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(131, 459);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 22);
            this.prezimeBox.TabIndex = 9;
            // 
            // indeksDeleteTxt
            // 
            this.indeksDeleteTxt.Location = new System.Drawing.Point(510, 412);
            this.indeksDeleteTxt.Name = "indeksDeleteTxt";
            this.indeksDeleteTxt.Size = new System.Drawing.Size(100, 22);
            this.indeksDeleteTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Broj indeksa";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(510, 458);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "OBRISI";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // indeksSearchBox
            // 
            this.indeksSearchBox.Location = new System.Drawing.Point(302, 59);
            this.indeksSearchBox.Name = "indeksSearchBox";
            this.indeksSearchBox.Size = new System.Drawing.Size(100, 22);
            this.indeksSearchBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pretrazi po broju indeksa:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(419, 43);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(76, 38);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // imageBtn
            // 
            this.imageBtn.Location = new System.Drawing.Point(264, 472);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(95, 33);
            this.imageBtn.TabIndex = 17;
            this.imageBtn.Text = "fotografija";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.Click += new System.EventHandler(this.imageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(489, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 234);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // godinaStudijaBox
            // 
            this.godinaStudijaBox.Location = new System.Drawing.Point(131, 535);
            this.godinaStudijaBox.Name = "godinaStudijaBox";
            this.godinaStudijaBox.Size = new System.Drawing.Size(100, 22);
            this.godinaStudijaBox.TabIndex = 22;
            // 
            // godinaUpisaBox
            // 
            this.godinaUpisaBox.Location = new System.Drawing.Point(131, 511);
            this.godinaUpisaBox.Name = "godinaUpisaBox";
            this.godinaUpisaBox.Size = new System.Drawing.Size(100, 22);
            this.godinaUpisaBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Godina studija:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Godina upisa:";
            // 
            // UCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.godinaStudijaBox);
            this.Controls.Add(this.godinaUpisaBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.indeksSearchBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox indeksSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox godinaStudijaBox;
        private System.Windows.Forms.TextBox godinaUpisaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
