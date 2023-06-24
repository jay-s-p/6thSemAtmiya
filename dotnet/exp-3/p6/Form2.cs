namespace p6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name, string items, string payment)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = items;
            label3.Text = payment;
        }
    }
}
