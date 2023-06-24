using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bxTableAdapter.Fill(this.masterDataSet.bx);

            SqlConnection conn = new SqlConnection(@"Data Source=ZZZ;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True");
            conn.Open();
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * from BX", conn);
            DataSet DataSet1 = new DataSet();
            dataAdapter.Fill(DataSet1, "stud");

            DataSet1.WriteXml("stud.xml");
            
            webBrowser1.Url = new Uri(AppDomain.CurrentDomain.BaseDirectory +"stud.xml");
        }
    }
}
