
using System.Windows.Forms;

namespace ogrenciNotHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hesapla_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projenotortalamasi = new System.Windows.Forms.NumericUpDown();
            this.sinavoran2 = new System.Windows.Forms.NumericUpDown();
            this.sinavoran1 = new System.Windows.Forms.NumericUpDown();
            this.gecmenotu = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projeOran = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projenotortalamasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavoran2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavoran1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gecmenotu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeOran)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.Sınav";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2.Sınav";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "proje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyUp);
            // 
            // hesapla_btn
            // 
            this.hesapla_btn.Location = new System.Drawing.Point(225, 117);
            this.hesapla_btn.Name = "hesapla_btn";
            this.hesapla_btn.Size = new System.Drawing.Size(235, 142);
            this.hesapla_btn.TabIndex = 10;
            this.hesapla_btn.Text = "Hesapla";
            this.hesapla_btn.UseVisualStyleBackColor = true;
            this.hesapla_btn.Click += new System.EventHandler(this.hesapla_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 147);
            this.listBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(43, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 142);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.projenotortalamasi);
            this.panel2.Controls.Add(this.sinavoran2);
            this.panel2.Controls.Add(this.sinavoran1);
            this.panel2.Controls.Add(this.gecmenotu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(43, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 49);
            this.panel2.TabIndex = 13;
            // 
            // projenotortalamasi
            // 
            this.projenotortalamasi.Location = new System.Drawing.Point(247, 19);
            this.projenotortalamasi.Name = "projenotortalamasi";
            this.projenotortalamasi.Size = new System.Drawing.Size(46, 20);
            this.projenotortalamasi.TabIndex = 9;
            // 
            // sinavoran2
            // 
            this.sinavoran2.Location = new System.Drawing.Point(155, 18);
            this.sinavoran2.Name = "sinavoran2";
            this.sinavoran2.Size = new System.Drawing.Size(46, 20);
            this.sinavoran2.TabIndex = 8;
            // 
            // sinavoran1
            // 
            this.sinavoran1.Location = new System.Drawing.Point(49, 18);
            this.sinavoran1.Name = "sinavoran1";
            this.sinavoran1.Size = new System.Drawing.Size(46, 20);
            this.sinavoran1.TabIndex = 5;
            // 
            // gecmenotu
            // 
            this.gecmenotu.Location = new System.Drawing.Point(367, 18);
            this.gecmenotu.Name = "gecmenotu";
            this.gecmenotu.Size = new System.Drawing.Size(46, 20);
            this.gecmenotu.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sınav 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Geçme Notu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Proje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sınav 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Oranlar";
            // 
            // projeOran
            // 
            this.projeOran.Location = new System.Drawing.Point(243, 18);
            this.projeOran.Name = "projeOran";
            this.projeOran.Size = new System.Drawing.Size(46, 20);
            this.projeOran.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hesapla_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projenotortalamasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavoran2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavoran1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gecmenotu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeOran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button hesapla_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown sinavoran2;
        private System.Windows.Forms.NumericUpDown sinavoran1;
        private System.Windows.Forms.NumericUpDown projeOran;
        private System.Windows.Forms.NumericUpDown gecmenotu;
        private NumericUpDown projeoranim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private NumericUpDown projenotortalamasi;
    }
}

