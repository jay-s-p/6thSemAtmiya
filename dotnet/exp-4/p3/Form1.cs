using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=ZZZ;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;

            conn.Open();

            MessageBox.Show(conn.State.ToString());

            cmd = new SqlCommand("SELECT * FROM BX", conn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["name"].ToString());
            }
            conn.Close();
        }
    }
}
