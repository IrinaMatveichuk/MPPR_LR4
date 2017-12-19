using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.ChangeMatrix();
            this.Hide();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = textBox21.Text;
        }
        private void textBox31_TextChanged_1(object sender, EventArgs e)
        {
            textBox13.Text = textBox31.Text;
        }
        private void textBox32_TextChanged_1(object sender, EventArgs e)
        {
            textBox23.Text = textBox32.Text;
        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = textBox41.Text;
        }
        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = textBox42.Text;
        }
        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            textBox34.Text = textBox43.Text;
        }
        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            textBox15.Text = textBox51.Text;
        }
        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = textBox52.Text;
        }
        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            textBox35.Text = textBox53.Text;
        }
        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            textBox45.Text = textBox54.Text;
        }
        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            textBox16.Text = textBox61.Text;
        }
        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            textBox26.Text = textBox62.Text;
        }
        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            textBox36.Text = textBox63.Text;
        }
        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            textBox46.Text = textBox64.Text;
        }
        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            textBox56.Text = textBox65.Text;
        }
        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = textBox71.Text;
        }
        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            textBox27.Text = textBox72.Text;
        }
        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            textBox37.Text = textBox73.Text;
        }
        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            textBox47.Text = textBox74.Text;
        }
        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            textBox57.Text = textBox75.Text;
        }
        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            textBox67.Text = textBox76.Text;
        }
        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            textBox18.Text = textBox81.Text;
        }
        private void textBox82_TextChanged(object sender, EventArgs e)
        {
            textBox28.Text = textBox82.Text;
        }
        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            textBox38.Text = textBox83.Text;
        }
        private void textBox84_TextChanged(object sender, EventArgs e)
        {
            textBox48.Text = textBox84.Text;
        }
        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            textBox58.Text = textBox85.Text;
        }
        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            textBox68.Text = textBox86.Text;
        }
        private void textBox87_TextChanged(object sender, EventArgs e)
        {
            textBox78.Text = textBox87.Text;
        }
        private void textBox91_TextChanged(object sender, EventArgs e)
        {
            textBox19.Text = textBox91.Text;
        }
        private void textBox92_TextChanged(object sender, EventArgs e)
        {
            textBox29.Text = textBox92.Text;
        }
        private void textBox93_TextChanged(object sender, EventArgs e)
        {
            textBox39.Text = textBox93.Text;
        }
        private void textBox94_TextChanged(object sender, EventArgs e)
        {
            textBox49.Text = textBox94.Text;
        }
        private void textBox95_TextChanged(object sender, EventArgs e)
        {
            textBox59.Text = textBox95.Text;
        }
        private void textBox96_TextChanged(object sender, EventArgs e)
        {
            textBox69.Text = textBox96.Text;
        }
        private void textBox97_TextChanged(object sender, EventArgs e)
        {
            textBox79.Text = textBox97.Text;
        }
        private void textBox98_TextChanged(object sender, EventArgs e)
        {
            textBox89.Text = textBox98.Text;
        }
        private void textBox101_TextChanged(object sender, EventArgs e)
        {
            textBox110.Text = textBox101.Text;
        }
        private void textBox102_TextChanged(object sender, EventArgs e)
        {
            textBox210.Text = textBox102.Text;
        }
        private void textBox103_TextChanged(object sender, EventArgs e)
        {
            textBox310.Text = textBox103.Text;
        }
        private void textBox104_TextChanged(object sender, EventArgs e)
        {
            textBox410.Text = textBox104.Text;
        }
        private void textBox105_TextChanged(object sender, EventArgs e)
        {
            textBox510.Text = textBox105.Text;
        }
        private void textBox106_TextChanged(object sender, EventArgs e)
        {
            textBox610.Text = textBox106.Text;
        }
        private void textBox107_TextChanged(object sender, EventArgs e)
        {
            textBox710.Text = textBox107.Text;
        }
        private void textBox108_TextChanged(object sender, EventArgs e)
        {
            textBox810.Text = textBox108.Text;
        }
        private void textBox109_TextChanged(object sender, EventArgs e)
        {
            textBox910.Text = textBox109.Text;
        }
    }
}
