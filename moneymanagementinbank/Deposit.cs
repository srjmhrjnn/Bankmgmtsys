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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string value = "";
            bool isChecked1 = radioButton1.Checked;
            bool isChecked2 = radioButton2.Checked;
            if (isChecked1)
                value = "Deposit with " + radioButton1.Text;
            if (isChecked2)
                value = "Deposit with " + radioButton2.Text;
                string query = "update account set ballance=ballance+'" + Int32.Parse(this.textBox4.Text) + "' where (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "');";
                string quer = "select * from account where (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "')";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand comm = new SqlCommand(quer, conn);
                conn.Open();
                int n = cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlDataReader sdr = comm.ExecuteReader();
                sdr.Read();
                string bal = sdr[11].ToString();
                bal = bal.Remove(bal.Length - 3);
                
                conn.Close();
               
                string que = "insert into statemt(t_date,a_id,t_info,t_change,t_ballance) values('" + this.dateTimePicker1.Text  + "','" + this.textBox1.Text + "','" + value + "','" + Int32.Parse(this.textBox4.Text) + "' ,'" + Int32.Parse(bal) + "')";
                SqlCommand cm = new SqlCommand(que, conn);
                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(n.ToString() + " " + "Account Deposited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

   
    }
}
