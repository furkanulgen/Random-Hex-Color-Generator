using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomColor
{
    public partial class Form1 : Form
    {
        Class1 TestClass = new Class1();
        int list = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            string Hex = TestClass.HexOlustur();
            Color clr = TestClass.ConvertToArgb(Hex);
            button2.ForeColor = clr;
            button2.BackColor = clr;
            listBox1.Items.Add(Hex);
            listBox1.SelectedIndex = list;
            list++;
            textBox1.Text = Hex;
            textBox2.Text = clr.ToArgb().ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color clr = TestClass.ConvertToArgb(listBox1.SelectedItem.ToString());
            
            button2.Text = "Hex : " + listBox1.SelectedItem.ToString() +" | | " + " ARGB : " + clr;
            button2.ForeColor=clr;
            textBox1.Text = listBox1.SelectedItem.ToString();
            textBox2.Text = clr.ToArgb().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list = 0;
            textBox1.Text = null;
            textBox2.Text = null;
            button2.Text = null;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ShutDownBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub : https://github.com/bynarr0w\nDiscord : narr0w#5737\nLinkedIn : https://www.linkedin.com/in/furkanulgen/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShutDownBtn.Text = "Ani Çıkış";
            ResetBtn.Text = "Resetle";
            button1.Text = "Renk Oluştur";
            button3.Text = "Listeyi Temizle";
            button4.Text = "Hakkımda";
            DarkGrayBtn.Text = "Koyu Gri";
            tanBtn.Text = "Bronz";
            redBtn.Text = "Kırmızı";
            blackBtn.Text = "Siyah";
            cyanBtn.Text = "Camgöbeği";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShutDownBtn.Text = "Shutdown";
            ResetBtn.Text = "Restart";
            button1.Text = "Create Color";
            button3.Text = "Clear List";
            button4.Text = "About Me";
            DarkGrayBtn.Text = "DarkGray";
            tanBtn.Text = "Tan";
            redBtn.Text = "Red";
            blackBtn.Text = "Black";
            cyanBtn.Text = "Cyan";
        }

        private void DarkGrayBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.Black;
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tan;
            this.ForeColor = Color.Black;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.LimeGreen;
        }

        private void cyanBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            this.ForeColor = Color.Black;
        }
    }
}
