using System;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copy1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cut1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void paste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox2.Cut();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }
    }
}
