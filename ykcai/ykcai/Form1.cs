using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ykcai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            this.labelResult.Text = this.textBoxOp1.Text + this.textBoxOp2.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBox0p1.Text);
            var y = int.Parse(this.textBox0p2.Text);
            var z = x + y;
            this.labelResule.Text = z.ToString();
        }
    }
}
