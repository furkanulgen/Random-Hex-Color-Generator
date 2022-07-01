namespace RandomColor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DarkGrayBtn = new System.Windows.Forms.Button();
            this.tanBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.blackBtn = new System.Windows.Forms.Button();
            this.cyanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(473, 30);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hex :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ARGB :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.Location = new System.Drawing.Point(12, 188);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(90, 23);
            this.ShutDownBtn.TabIndex = 8;
            this.ShutDownBtn.Text = "Shutdown";
            this.ShutDownBtn.UseVisualStyleBackColor = true;
            this.ShutDownBtn.Click += new System.EventHandler(this.ShutDownBtnClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(108, 188);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(90, 23);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Restart";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "About Me";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Türkçe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "English";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DarkGrayBtn
            // 
            this.DarkGrayBtn.Location = new System.Drawing.Point(12, 217);
            this.DarkGrayBtn.Name = "DarkGrayBtn";
            this.DarkGrayBtn.Size = new System.Drawing.Size(90, 23);
            this.DarkGrayBtn.TabIndex = 13;
            this.DarkGrayBtn.Text = "DarkGray";
            this.DarkGrayBtn.UseVisualStyleBackColor = true;
            this.DarkGrayBtn.Click += new System.EventHandler(this.DarkGrayBtn_Click);
            // 
            // tanBtn
            // 
            this.tanBtn.Location = new System.Drawing.Point(108, 217);
            this.tanBtn.Name = "tanBtn";
            this.tanBtn.Size = new System.Drawing.Size(90, 23);
            this.tanBtn.TabIndex = 14;
            this.tanBtn.Text = "Tan";
            this.tanBtn.UseVisualStyleBackColor = true;
            this.tanBtn.Click += new System.EventHandler(this.tanBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(204, 217);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(90, 23);
            this.redBtn.TabIndex = 15;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // blackBtn
            // 
            this.blackBtn.Location = new System.Drawing.Point(300, 217);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(90, 23);
            this.blackBtn.TabIndex = 16;
            this.blackBtn.Text = "Black";
            this.blackBtn.UseVisualStyleBackColor = true;
            this.blackBtn.Click += new System.EventHandler(this.blackBtn_Click);
            // 
            // cyanBtn
            // 
            this.cyanBtn.Location = new System.Drawing.Point(395, 217);
            this.cyanBtn.Name = "cyanBtn";
            this.cyanBtn.Size = new System.Drawing.Size(90, 23);
            this.cyanBtn.TabIndex = 17;
            this.cyanBtn.Text = "Cyan";
            this.cyanBtn.UseVisualStyleBackColor = true;
            this.cyanBtn.Click += new System.EventHandler(this.cyanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 252);
            this.Controls.Add(this.cyanBtn);
            this.Controls.Add(this.blackBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.tanBtn);
            this.Controls.Add(this.DarkGrayBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ShutDownBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Create Color => HEX || ARGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ShutDownBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button DarkGrayBtn;
        private System.Windows.Forms.Button tanBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blackBtn;
        private System.Windows.Forms.Button cyanBtn;
    }
}

