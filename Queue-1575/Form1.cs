using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_1575
{
    public partial class Form1 : Form
    {
        Queue<string> musteri = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (musteri.Count > 0)
            {
                label1.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("müşteriler bitti");
            }
        }
    }
}
