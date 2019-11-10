using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace moneymanagementinbank
{
    public partial class statement : Form
    {
        public statement()
        {
            InitializeComponent();
        }

        private void statement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
                conn.Open();
                string que = "SELECT t_id,t_date,a_id,t_info,t_change,t_ballance from statemt WHERE a_id = '" + this.textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(que, conn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbset = new DataTable();
                sda.Fill(dbset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbset);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewac va = new viewac();
            va.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
