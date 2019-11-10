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
    public partial class updatea : Form
    {
        public updatea()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
        string imglocuser = "";
        string imglocsign = "";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n=0;
                string value = "";
                bool isChecked1 = radioButton1.Checked;
                bool isChecked2 = radioButton2.Checked;
                if (isChecked1)
                    value = radioButton1.Text;
                if(isChecked2)
                    value = radioButton2.Text;


                

                
                if (textBox2.Text != "")
                {
                    string query = "update account set f_name= '" + this.textBox2.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();

                    conn.Close();
                }
                if (textBox3.Text != "")
                {
                    string query = "update account set l_name= '" + this.textBox3.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n= n+cmd.ExecuteNonQuery();

                    conn.Close();
                }
                if (value != "")
                {
                    string query = "update account set gender= '" + value + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();

                    conn.Close();
                }
                if (textBox4.Text != "")
                {
                    string query = "update account set address= '" + this.textBox4.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();

                    conn.Close();
                }
                if (textBox5.Text != "")
                {
                    string query = "update account set father_name= '" + this.textBox5.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (textBox6.Text != "")
                {
                    string query = "update account set mother_name= '" + this.textBox6.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (textBox7.Text != "")
                {
                    string query = "update account set m_status= '" + this.textBox7.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (textBox8.Text != "")
                {
                    string query = "update account set nationality= '" + this.textBox8.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (this.dateTimePicker1.Text != "")
                {
                    string query = "update account set dob= '" + this.dateTimePicker1.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (textBox9.Text != "")
                {
                    string query = "update account set c_num= '" + this.textBox9.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                if (comboBox1.Text != "")
                {
                    string query = "update account set typea= '" + this.comboBox1.Text + "' where (id = '" + this.textBox1.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }                
                if (pictUser.Image != null)
                {
                    byte[] images1 = null;
                    FileStream stream = new FileStream(imglocuser, FileMode.Open, FileAccess.Read);
                    BinaryReader bns = new BinaryReader(stream);
                    images1 = bns.ReadBytes((int)stream.Length);
                    string query = "update account set photo= '@images1' where (id = '" + this.textBox1.Text + "');";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("images1", images1));
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                 if (pictsign.Image != null)
                {
                    byte[] images2 = null;
                    FileStream streama = new FileStream(imglocsign, FileMode.Open, FileAccess.Read);
                    BinaryReader bnsa = new BinaryReader(streama);
                    images2 = bnsa.ReadBytes((int)streama.Length);
                    string query = "update account set photo= '@images2' where (id = '" + this.textBox1.Text + "');";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("images2", images2));
                    conn.Open();
                    n = n + cmd.ExecuteNonQuery();
                    conn.Close();
                }
                
               
               
                MessageBox.Show(n.ToString() + " " + "Fields Updated");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "select Account Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglocuser = dlg.FileName.ToString();
                    pictUser.ImageLocation = imglocuser;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "select Account Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglocsign = dlg.FileName.ToString();
                    pictsign.ImageLocation = imglocsign;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
