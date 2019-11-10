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
    public partial class Deleteaccount : Form
    {
        
        public Deleteaccount()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                string query = "delete from account where (id = '"+this.textBox1.Text+"' AND f_name= '"+this.textBox2.Text+"' AND l_name= '"+this.textBox3.Text+"');";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int n=cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(n.ToString()+" "+"Account Deleted Successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
