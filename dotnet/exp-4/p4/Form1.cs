﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p4
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=ZZZ;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True";
            conn.Open();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO BX VALUES('"+ID.Text+"', '"+NAME.Text+"')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One row INSERTED");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BX SET id='" + ID.Text + "', name='" + NAME.Text + "' WHERE id='" + updatedID.Text + "'", conn);
            cmd.BeginExecuteNonQuery();
            MessageBox.Show("One row UPDATED.");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM BX WHERE ID='" + updatedID.Text+"'", conn);
            cmd.BeginExecuteNonQuery();
            MessageBox.Show("One row DELETED.");
        }
    }
}
