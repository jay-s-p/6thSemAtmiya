using System;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.bx' table. You can move, or remove it, as needed.
            this.bxTableAdapter.Fill(this.masterDataSet.bx);

        }
    }
}
