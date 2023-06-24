namespace Zzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string name = "Hello " + inputName.Text;
            string items = "Your items are " + (checkTV.Checked ? "Television" + (checkRadio.Checked ? " and Radio." : "") : "" + (checkRadio.Checked ? "Radio." : "."));
            string payment = "Your payment is " + (radioCOD.Checked ? "COD" : "Online Payment");
            Form2 form2 = new Form2(name, items, payment);
            form2.Show();
        }
    }
}