/*
Design a Window formWhich use any five controls.
*/
namespace p6
{
    public partial class Form1 : Form
    {
        string name = null;
        string items = null;
        string payment = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            name = "Hello " + inputName.Text;
            items = "Items : ";
            payment = "Payment method : ";

            if (checkTV.Checked)
                items += "Television";
            if (checkRadio.Checked)
                if (checkTV.Checked)
                    items += " and Radio.";
                else
                    items += "Radio.";

            if (radioCOD.Checked)
                payment += "COD";
            else
                payment += "Online Payment";

            Form2 form2 = new Form2(name, items, payment);
            form2.Show();
        }
    }
}