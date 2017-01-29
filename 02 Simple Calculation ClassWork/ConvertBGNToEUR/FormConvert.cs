using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertBGNToEUR
{
    public partial class FormConvert : Form
    {
        public FormConvert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
        void Convert()
        {
            var amount = this.numericUpDown.Value;
            var amountInEuro = amount / 1.95583m;
            this.result.Text = amount + " лева = " + Math.Round(amountInEuro, 2) + " евро";


        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void result2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var amount2 = this.numericUpDown1.Value;
            var amountInBgn = amount2 * 1.95583m;
            this.result2.Text = amount2 + " евро = " + Math.Round(amountInBgn, 2) + " лева";
        }
    }
}
