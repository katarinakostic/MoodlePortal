
namespace MoodlePortal
{
    partial class KursProfil
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
            this.kodBox = new System.Windows.Forms.TextBox();
            this.godinaBox = new System.Windows.Forms.TextBox();
            this.nazivBox = new System.Windows.Forms.TextBox();
            this.pristupniKodLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sifraKursaLbl = new System.Windows.Forms.Label();
            this.izborniLbl = new System.Windows.Forms.Label();
            this.godinaLbl = new System.Windows.Forms.Label();
            this.nazivLbl = new System.Windows.Forms.Label();
            this.izborniComboBox = new System.Windows.Forms.ComboBox();
            this.updatePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.Location = new System.Drawing.Point(40, 287);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(75, 23);
            this.izmeniBtn.TabIndex = 19;
            this.izmeniBtn.Text = "IZMENI";
            this.izmeniBtn.UseVisualStyleBackColor = true;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // updatePnl
            // 
            this.updatePnl.Controls.Add(this.izborniComboBox);
            this.updatePnl.Controls.Add(this.updateSaveBtn);
            this.updatePnl.Controls.Add(this.kodBox);
            this.updatePnl.Controls.Add(this.godinaBox);
            this.updatePnl.Controls.Add(this.nazivBox);
            this.updatePnl.Location = new System.Drawing.Point(269, 22);
            this.updatePnl.Name = "updatePnl";
            this.updatePnl.Size = new System.Drawing.Size(280, 312);
            this.updatePnl.TabIndex = 18;
            // 
            // updateSaveBtn
            // 
            this.updateSaveBtn.Location = new System.Drawing.Point(18, 266);
            this.updateSaveBtn.Name = "updateSaveBtn";
            this.updateSaveBtn.Size = new System.Drawing.Size(85, 24);
            this.updateSaveBtn.TabIndex = 5;
            this.updateSaveBtn.Text = "SACUVAJ";
            this.updateSaveBtn.UseVisualStyleBackColor = true;
            this.updateSaveBtn.Click += new System.EventHandler(this.updateSaveBtn_Click);
            // 
            // kodBox
            // 
            this.kodBox.Location = new System.Drawing.Point(18, 180);
            this.kodBox.Name = "kodBox";
            this.kodBox.Size = new System.Drawing.Size(100, 22);
            this.kodBox.TabIndex = 4;
            // 
            // godinaBox
            // 
            this.godinaBox.Location = new System.Drawing.Point(18, 91);
            this.godinaBox.Name = "godinaBox";
            this.godinaBox.Size = new System.Drawing.Size(100, 22);
            this.godinaBox.TabIndex = 2;
            // 
            // nazivBox
            // 
            this.nazivBox.Location = new System.Drawing.Point(18, 46);
            this.nazivBox.Name = "nazivBox";
            this.nazivBox.Size = new System.Drawing.Size(100, 22);
            this.nazivBox.TabIndex = 1;
            // 
            // pristupniKodLbl
            // 
            this.pristupniKodLbl.AutoSize = true;
            this.pristupniKodLbl.Location = new System.Drawing.Point(37, 205);
            this.pristupniKodLbl.Name = "pristupniKodLbl";
            this.pristupniKodLbl.Size = new System.Drawing.Size(94, 17);
            this.pristupniKodLbl.TabIndex = 17;
            this.pristupniKodLbl.Text = "Pristupni kod:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(40, 391);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sifraKursaLbl
            // 
            this.sifraKursaLbl.AutoSize = true;
            this.sifraKursaLbl.Location = new System.Drawing.Point(35, 33);
            this.sifraKursaLbl.Name = "sifraKursaLbl";
            this.sifraKursaLbl.Size = new System.Drawing.Size(80, 17);
            this.sifraKursaLbl.TabIndex = 14;
            this.sifraKursaLbl.Text = "Sifra kursa:";
            // 
            // izborniLbl
            // 
            this.izborniLbl.AutoSize = true;
            this.izborniLbl.Location = new System.Drawing.Point(37, 160);
            this.izborniLbl.Name = "izborniLbl";
            this.izborniLbl.Size = new System.Drawing.Size(114, 17);
            this.izborniLbl.TabIndex = 12;
            this.izborniLbl.Text = "Izborni predmet: ";
            // 
            // godinaLbl
            // 
            this.godinaLbl.AutoSize = true;
            this.godinaLbl.Location = new System.Drawing.Point(37, 116);
            this.godinaLbl.Name = "godinaLbl";
            this.godinaLbl.Size = new System.Drawing.Size(167, 17);
            this.godinaLbl.TabIndex = 11;
            this.godinaLbl.Text = "Godina na kojoj se slusa:";
            // 
            // nazivLbl
            // 
            this.nazivLbl.AutoSize = true;
            this.nazivLbl.Location = new System.Drawing.Point(37, 73);
            this.nazivLbl.Name = "nazivLbl";
            this.nazivLbl.Size = new System.Drawing.Size(47, 17);
            this.nazivLbl.TabIndex = 10;
            this.nazivLbl.Text = "Naziv:";
            // 
            // izborniComboBox
            // 
            this.izborniComboBox.FormattingEnabled = true;
            this.izborniComboBox.Location = new System.Drawing.Point(18, 135);
            this.izborniComboBox.Name = "izborniComboBox";
            this.izborniComboBox.Size = new System.Drawing.Size(100, 24);
            this.izborniComboBox.TabIndex = 41;
            // 
            // KursProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.updatePnl);
            this.Controls.Add(this.pristupniKodLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sifraKursaLbl);
            this.Controls.Add(this.izborniLbl);
            this.Controls.Add(this.godinaLbl);
            this.Controls.Add(this.nazivLbl);
            this.Name = "KursProfil";
            this.Text = "KursProfil";
            this.updatePnl.ResumeLayout(false);
            this.updatePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Panel updatePnl;
        private System.Windows.Forms.Button updateSaveBtn;
        private System.Windows.Forms.TextBox kodBox;
        private System.Windows.Forms.TextBox godinaBox;
        private System.Windows.Forms.TextBox nazivBox;
        private System.Windows.Forms.Label pristupniKodLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label sifraKursaLbl;
        private System.Windows.Forms.Label izborniLbl;
        private System.Windows.Forms.Label godinaLbl;
        private System.Windows.Forms.Label nazivLbl;
        private System.Windows.Forms.ComboBox izborniComboBox;
    }
}