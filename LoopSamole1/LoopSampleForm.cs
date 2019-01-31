using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_LoopSamole
{
    public partial class LoopSampleForm : Form
    {
        public LoopSampleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            // iが10以下である間ループする
            do
            {
                textBox1.Text += i + " / ";
                i++;
            }
            while (i <= 10);

            MessageBox.Show("ループ終了。iは「" + i.ToString() + "」");
        }
    }
}
