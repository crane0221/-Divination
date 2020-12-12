using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 占卜
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mm, dd;
            int m,d,s;
            mm = dateTimePicker1.Value.Month.ToString();
            dd = dateTimePicker1.Value.Day.ToString();
            m = int.Parse(mm);
            d = int.Parse(dd);
            s = (m * 2 + d) % 3;
            if (s == 0)
            {
                richTextBox1.Text = "普通";
            }
            else if (s == 1)
            {
                richTextBox1.Text = "吉";
            }
            else if (s == 2)
            {
                richTextBox1.Text = "大吉";
            }
        }
    }
}
