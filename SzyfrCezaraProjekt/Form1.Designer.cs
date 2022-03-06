namespace SzyfrCezaraProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RozszyfrowanyTXT = new System.Windows.Forms.TextBox();
            this.ZaszyfrowanyTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Zaszyfruj_btn = new System.Windows.Forms.Button();
            this.Rozszyfruj_btn = new System.Windows.Forms.Button();
            this.PrzyciskCzyszczeniaTXTrozszyfrowane = new System.Windows.Forms.Button();
            this.PrzyciskCzyszczeniaTXTzaszyfrowane = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Klucz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImportujTXTbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.WyeksportujTXTbtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // RozszyfrowanyTXT
            // 
            this.RozszyfrowanyTXT.Location = new System.Drawing.Point(30, 79);
            this.RozszyfrowanyTXT.Multiline = true;
            this.RozszyfrowanyTXT.Name = "RozszyfrowanyTXT";
            this.RozszyfrowanyTXT.Size = new System.Drawing.Size(806, 157);
            this.RozszyfrowanyTXT.TabIndex = 0;
            this.RozszyfrowanyTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ZaszyfrowanyTXT
            // 
            this.ZaszyfrowanyTXT.Location = new System.Drawing.Point(30, 349);
            this.ZaszyfrowanyTXT.Multiline = true;
            this.ZaszyfrowanyTXT.Name = "ZaszyfrowanyTXT";
            this.ZaszyfrowanyTXT.Size = new System.Drawing.Size(806, 166);
            this.ZaszyfrowanyTXT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rozszyfrowany tekst";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaszyfrowany tekst";
            // 
            // Zaszyfruj_btn
            // 
            this.Zaszyfruj_btn.Location = new System.Drawing.Point(144, 50);
            this.Zaszyfruj_btn.Name = "Zaszyfruj_btn";
            this.Zaszyfruj_btn.Size = new System.Drawing.Size(75, 23);
            this.Zaszyfruj_btn.TabIndex = 4;
            this.Zaszyfruj_btn.Text = "Zaszyfruj";
            this.Zaszyfruj_btn.UseVisualStyleBackColor = true;
            this.Zaszyfruj_btn.Click += new System.EventHandler(this.Zaszyfruj_Click);
            // 
            // Rozszyfruj_btn
            // 
            this.Rozszyfruj_btn.Location = new System.Drawing.Point(144, 320);
            this.Rozszyfruj_btn.Name = "Rozszyfruj_btn";
            this.Rozszyfruj_btn.Size = new System.Drawing.Size(75, 23);
            this.Rozszyfruj_btn.TabIndex = 5;
            this.Rozszyfruj_btn.Text = "Rozszyfruj";
            this.Rozszyfruj_btn.UseVisualStyleBackColor = true;
            this.Rozszyfruj_btn.Click += new System.EventHandler(this.Rozszyfruj_Click);
            // 
            // PrzyciskCzyszczeniaTXTrozszyfrowane
            // 
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.Location = new System.Drawing.Point(749, 48);
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.Name = "PrzyciskCzyszczeniaTXTrozszyfrowane";
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.Size = new System.Drawing.Size(75, 23);
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.TabIndex = 6;
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.Text = "Wyczyść";
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.UseVisualStyleBackColor = true;
            this.PrzyciskCzyszczeniaTXTrozszyfrowane.Click += new System.EventHandler(this.PrzyciskCzyszczeniaTXTrozszyfrowane_Click);
            // 
            // PrzyciskCzyszczeniaTXTzaszyfrowane
            // 
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.Location = new System.Drawing.Point(748, 319);
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.Name = "PrzyciskCzyszczeniaTXTzaszyfrowane";
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.Size = new System.Drawing.Size(75, 23);
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.TabIndex = 7;
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.Text = "Wyczyść";
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.UseVisualStyleBackColor = true;
            this.PrzyciskCzyszczeniaTXTzaszyfrowane.Click += new System.EventHandler(this.PrzyciskCzyszczeniaTXTzaszyfrowane_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wprowadź Klucz:";
            // 
            // Klucz
            // 
            this.Klucz.Location = new System.Drawing.Point(133, 16);
            this.Klucz.Name = "Klucz";
            this.Klucz.Size = new System.Drawing.Size(25, 23);
            this.Klucz.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Importuj plik TXT";
            // 
            // ImportujTXTbtn
            // 
            this.ImportujTXTbtn.Location = new System.Drawing.Point(473, 48);
            this.ImportujTXTbtn.Name = "ImportujTXTbtn";
            this.ImportujTXTbtn.Size = new System.Drawing.Size(75, 23);
            this.ImportujTXTbtn.TabIndex = 11;
            this.ImportujTXTbtn.Text = "Importuj";
            this.ImportujTXTbtn.UseVisualStyleBackColor = true;
            this.ImportujTXTbtn.Click += new System.EventHandler(this.ImportujTXTbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wyeksportuj do TXT";
            // 
            // WyeksportujTXTbtn
            // 
            this.WyeksportujTXTbtn.Location = new System.Drawing.Point(488, 320);
            this.WyeksportujTXTbtn.Name = "WyeksportujTXTbtn";
            this.WyeksportujTXTbtn.Size = new System.Drawing.Size(85, 23);
            this.WyeksportujTXTbtn.TabIndex = 13;
            this.WyeksportujTXTbtn.Text = "Wyeksportuj";
            this.WyeksportujTXTbtn.UseVisualStyleBackColor = true;
            this.WyeksportujTXTbtn.Click += new System.EventHandler(this.WyeksportujTXTbtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 545);
            this.Controls.Add(this.WyeksportujTXTbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ImportujTXTbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Klucz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrzyciskCzyszczeniaTXTzaszyfrowane);
            this.Controls.Add(this.PrzyciskCzyszczeniaTXTrozszyfrowane);
            this.Controls.Add(this.Rozszyfruj_btn);
            this.Controls.Add(this.Zaszyfruj_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZaszyfrowanyTXT);
            this.Controls.Add(this.RozszyfrowanyTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Szyfr Cezara";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox RozszyfrowanyTXT;
        private TextBox ZaszyfrowanyTXT;
        private Label label1;
        private Label label2;
        private Button Zaszyfruj_btn;
        private Button Rozszyfruj_btn;
        private Button PrzyciskCzyszczeniaTXTrozszyfrowane;
        private Button PrzyciskCzyszczeniaTXTzaszyfrowane;
        private Label label3;
        private TextBox Klucz;
        private Label label4;
        private Button ImportujTXTbtn;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private Button WyeksportujTXTbtn;
        private SaveFileDialog saveFileDialog1;
    }
}