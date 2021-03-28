
namespace MoodlePortal
{
    partial class UCKursCrud
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sifraSearchBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.sifraDeleteTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.izborniBox = new System.Windows.Forms.TextBox();
            this.godinaStudijaBox = new System.Windows.Forms.TextBox();
            this.nazivBox = new System.Windows.Forms.TextBox();
            this.sifraKursaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.listViewKurs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(394, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(76, 38);
            this.searchBtn.TabIndex = 39;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Pretrazi po sifri:";
            // 
            // sifraSearchBox
            // 
            this.sifraSearchBox.Location = new System.Drawing.Point(277, 49);
            this.sifraSearchBox.Name = "sifraSearchBox";
            this.sifraSearchBox.Size = new System.Drawing.Size(100, 22);
            this.sifraSearchBox.TabIndex = 37;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(504, 460);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 36;
            this.deleteBtn.Text = "OBRISI";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // sifraDeleteTxt
            // 
            this.sifraDeleteTxt.Location = new System.Drawing.Point(504, 414);
            this.sifraDeleteTxt.Name = "sifraDeleteTxt";
            this.sifraDeleteTxt.Size = new System.Drawing.Size(100, 22);
            this.sifraDeleteTxt.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sifra kursa:";
            // 
            // izborniBox
            // 
            this.izborniBox.Location = new System.Drawing.Point(125, 485);
            this.izborniBox.Name = "izborniBox";
            this.izborniBox.Size = new System.Drawing.Size(100, 22);
            this.izborniBox.TabIndex = 33;
            // 
            // godinaStudijaBox
            // 
            this.godinaStudijaBox.Location = new System.Drawing.Point(125, 461);
            this.godinaStudijaBox.Name = "godinaStudijaBox";
            this.godinaStudijaBox.Size = new System.Drawing.Size(100, 22);
            this.godinaStudijaBox.TabIndex = 32;
            // 
            // nazivBox
            // 
            this.nazivBox.Location = new System.Drawing.Point(125, 433);
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.Size = new System.Drawing.Size(100, 22);
            this.nazivBox.TabIndex = 31;
            // 
            // sifraKursaBox
            // 
            this.sifraKursaBox.Location = new System.Drawing.Point(125, 409);
            this.sifraKursaBox.Name = "sifraKursaBox";
            this.sifraKursaBox.Size = new System.Drawing.Size(100, 22);
            this.sifraKursaBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Izborni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Godina studija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sifra  kursa:";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(258, 409);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(95, 47);
            this.insertBtn.TabIndex = 25;
            this.insertBtn.Text = "DODAJ";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(22, 33);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(156, 38);
            this.showBtn.TabIndex = 24;
            this.showBtn.Text = "Prikazi sve kurseve";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // listViewKurs
            // 
            this.listViewKurs.HideSelection = false;
            this.listViewKurs.Location = new System.Drawing.Point(22, 88);
            this.listViewKurs.Name = "listViewKurs";
            this.listViewKurs.Size = new System.Drawing.Size(436, 290);
            this.listViewKurs.TabIndex = 23;
            this.listViewKurs.UseCompatibleStateImageBehavior = false;
            this.listViewKurs.View = System.Windows.Forms.View.List;
            this.listViewKurs.SelectedIndexChanged += new System.EventHandler(this.listViewKurs_SelectedIndexChanged);
            // 
            // UCKursCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sifraSearchBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.sifraDeleteTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.izborniBox);
            this.Controls.Add(this.godinaStudijaBox);
            this.Controls.Add(this.nazivBox);
            this.Controls.Add(this.sifraKursaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.listViewKurs);
            this.Name = "UCKursCrud";
            this.Size = new System.Drawing.Size(725, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifraSearchBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox sifraDeleteTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox izborniBox;
        private System.Windows.Forms.TextBox godinaStudijaBox;
        private System.Windows.Forms.TextBox nazivBox;
        private System.Windows.Forms.TextBox sifraKursaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ListView listViewKurs;
    }
}
