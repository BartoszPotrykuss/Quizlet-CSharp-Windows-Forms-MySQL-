namespace kinda_Quizlet
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.polski = new System.Windows.Forms.Label();
            this.poprawnosc = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LPoprawa = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LPoprawne = new System.Windows.Forms.Label();
            this.lNiepoprawne = new System.Windows.Forms.Label();
            this.lPozostalo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Połącz z bazą danych";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj słowo: ";
            // 
            // polski
            // 
            this.polski.AutoSize = true;
            this.polski.Location = new System.Drawing.Point(204, 143);
            this.polski.Name = "polski";
            this.polski.Size = new System.Drawing.Size(0, 13);
            this.polski.TabIndex = 4;
            // 
            // poprawnosc
            // 
            this.poprawnosc.AutoSize = true;
            this.poprawnosc.Location = new System.Drawing.Point(393, 219);
            this.poprawnosc.Name = "poprawnosc";
            this.poprawnosc.Size = new System.Drawing.Size(0, 13);
            this.poprawnosc.TabIndex = 5;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(324, 94);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(129, 40);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Visible = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // LPoprawa
            // 
            this.LPoprawa.AutoSize = true;
            this.LPoprawa.Location = new System.Drawing.Point(253, 246);
            this.LPoprawa.Name = "LPoprawa";
            this.LPoprawa.Size = new System.Drawing.Size(140, 13);
            this.LPoprawa.TabIndex = 9;
            this.LPoprawa.Text = "Wpisz poprawną odpowiedź";
            this.LPoprawa.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(660, 137);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(660, 190);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(660, 246);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Poprawne: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Niepoprawne: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pozostało: ";
            // 
            // LPoprawne
            // 
            this.LPoprawne.AutoSize = true;
            this.LPoprawne.Location = new System.Drawing.Point(725, 118);
            this.LPoprawne.Name = "LPoprawne";
            this.LPoprawne.Size = new System.Drawing.Size(13, 13);
            this.LPoprawne.TabIndex = 16;
            this.LPoprawne.Text = "0";
            // 
            // lNiepoprawne
            // 
            this.lNiepoprawne.AutoSize = true;
            this.lNiepoprawne.Location = new System.Drawing.Point(736, 171);
            this.lNiepoprawne.Name = "lNiepoprawne";
            this.lNiepoprawne.Size = new System.Drawing.Size(13, 13);
            this.lNiepoprawne.TabIndex = 17;
            this.lNiepoprawne.Text = "0";
            // 
            // lPozostalo
            // 
            this.lPozostalo.AutoSize = true;
            this.lPozostalo.Location = new System.Drawing.Point(728, 227);
            this.lPozostalo.Name = "lPozostalo";
            this.lPozostalo.Size = new System.Drawing.Size(13, 13);
            this.lPozostalo.TabIndex = 18;
            this.lPozostalo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lPozostalo);
            this.Controls.Add(this.lNiepoprawne);
            this.Controls.Add(this.LPoprawne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LPoprawa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.poprawnosc);
            this.Controls.Add(this.polski);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label polski;
        private System.Windows.Forms.Label poprawnosc;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LPoprawa;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LPoprawne;
        private System.Windows.Forms.Label lNiepoprawne;
        private System.Windows.Forms.Label lPozostalo;
        private System.Windows.Forms.Label label5;
    }
}

