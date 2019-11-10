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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update account set ballance=ballance-'" + Int32.Parse(this.textBox7.Text) + "' where (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "');";
                string quer = "select * from account where (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "')";
                string value1 = "Transfer from";
                string value2 = "Transfer to";
                SqlCommand comm = new SqlCommand(quer, conn);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int m = cmd.ExecuteNonQuery();
                
                conn.Close();
                conn.Open();
                SqlDataReader sdr = comm.ExecuteReader();
                sdr.Read();
                string bal = sdr[11].ToString();
                bal = bal.Remove(bal.Length - 3);

                conn.Close();
                string que1 = "insert into statemt(t_date,a_id,t_info,t_change,t_ballance) values('" + this.dateTimePicker1.Text + "','" + this.textBox1.Text + "','" + value1 + "','" + Int32.Parse(this.textBox7.Text) + "' ,'" + Int32.Parse(bal) + "')";
                SqlCommand cms1 = new SqlCommand(que1, conn);

                string que = "update account set ballance=ballance+'" + Int32.Parse(this.textBox7.Text) + "' where (id = '" + this.textBox4.Text + "' AND f_name= '" + this.textBox5.Text + "' AND l_name= '" + this.textBox6.Text + "');";
                string quer2 = "select * from account where (id = '" + this.textBox4.Text + "' AND f_name= '" + this.textBox5.Text + "' AND l_name= '" + this.textBox6.Text + "')";
                SqlCommand cm2 = new SqlCommand(quer2, conn);
                SqlCommand cm = new SqlCommand(que, conn);
                conn.Open();
                int n = m + cm.ExecuteNonQuery();
                
                conn.Close();
                conn.Open();
                SqlDataReader sdr2 = cm2.ExecuteReader();
                sdr2.Read();
                string bal2 = sdr2[11].ToString();
                bal2 = bal2.Remove(bal2.Length - 3);

                conn.Close();
                string que2 = "insert into statemt(t_date,a_id,t_info,t_change,t_ballance) values('" + this.dateTimePicker1.Text + "','" + this.textBox4.Text + "','" + value2 + "','" + Int32.Parse(this.textBox7.Text) + "' ,'" + Int32.Parse(bal2) + "')";
                SqlCommand cms2 = new SqlCommand(que2, conn);

                conn.Open();
                cms1.ExecuteNonQuery();
                cms2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(n.ToString() + " " + "Account Balance transfered Successfully");
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

        private void button3_Click(object sender, EventArgs e)
        {
            viewac vac = new viewac();
            vac.Show();
        }
    }
}
