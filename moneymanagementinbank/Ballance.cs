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
    public partial class Ballance : Form
    {
        public Ballance()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = 0;
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
                conn.Open();
                string que = "SELECT * FROM account WHERE (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "');";

                SqlCommand cms = new SqlCommand(que, conn);
                m = cms.ExecuteNonQuery();

                SqlDataReader sdr = cms.ExecuteReader();
                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        textBox4.Text = (sdr["ballance"].ToString());

                    }
                    conn.Close();
                   
                }
                else 
                {
                    textBox4.Text = "";

                    MessageBox.Show("No Account Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
