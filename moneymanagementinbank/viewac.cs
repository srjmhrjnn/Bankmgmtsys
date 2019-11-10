using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace moneymanagementinbank
{
    public partial class viewac : Form
    {
        public viewac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
                conn.Open();
                string que = "SELECT id,f_name,l_name,gender,address,father_name,mother_name,m_status,nationality,convert(varchar,dob,101),c_num,ballance,typea,photo,usign FROM account WHERE (id = '" + this.textBox1.Text + "' AND f_name= '" + this.textBox2.Text + "' AND l_name= '" + this.textBox3.Text + "');";

                SqlCommand cmd = new SqlCommand(que, conn);
                
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                if (sdr.HasRows)
                {

                    textBox4.Text = sdr[3].ToString();
                    textBox5.Text = sdr[4].ToString();
                    textBox6.Text = sdr[5].ToString();
                    textBox7.Text = sdr[6].ToString();
                    textBox8.Text = sdr[7].ToString();
                    textBox9.Text = sdr[8].ToString();
                    textBox10.Text = sdr[9].ToString();
                    textBox11.Text = sdr[10].ToString();
                    textBox12.Text = sdr[11].ToString();
                    textBox13.Text = sdr[12].ToString();
                    byte[] photo = ((byte[])sdr[13]);
                    byte[] usign = ((byte[])sdr[14]);

                   
                    if (photo == null)
                    {
                        pictUser.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(photo);
                        //Image im1=Image.FromStream(ms);
                        pictUser.Image = null;
                    }
                    if (usign == null)
                    {
                        pictsign.Image = null;
                    }
                    else
                    {
                        MemoryStream mstreama = new MemoryStream(usign);
                        //Image im2= Image.FromStream(mstreama);
                        pictsign.Image = null;
                    }

                }
                else
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    pictUser.Image = null;
                    pictsign.Image = null;
                    MessageBox.Show("No Account Found");
                }


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
