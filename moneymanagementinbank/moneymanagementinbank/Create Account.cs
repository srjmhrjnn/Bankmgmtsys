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
    public partial class View : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KRKE7MJ\\SQLEXPRESS;Initial Catalog=userinfo;Integrated Security=True");
        string imglocuser = "";
        string imglocsign = "";
        
        public View()
        {
            InitializeComponent();
            string querrr = "SELECT pre,post FROM acnumgen;";
            conn.Open();
            SqlCommand cmdddd = new SqlCommand(querrr, conn);
            SqlDataReader sdr = cmdddd.ExecuteReader();
            sdr.Read();

            if (sdr.HasRows)
            {

                string txt = sdr[0].ToString() + sdr[1].ToString();
                label16.Text = txt;
            }
            conn.Close();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try 
            {OpenFileDialog dlg= new OpenFileDialog();
            dlg.Filter="JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "select Account Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imglocuser = dlg.FileName.ToString();
                pictUser.ImageLocation = imglocuser;
            }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label16.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || comboBox1.Text=="")
            {
                MessageBox.Show("Enter all the required fields");
            }
            else
            {
                try
                {
                    string value = "";
                    bool isChecked1 = radioButton1.Checked;
                    bool isChecked2 = radioButton2.Checked;
                    if (isChecked1)
                        value = radioButton1.Text;
                    if (isChecked2)
                        value = radioButton2.Text;


                    byte[] images1 = null;
                    FileStream stream = new FileStream(imglocuser, FileMode.Open, FileAccess.Read);
                    BinaryReader bns = new BinaryReader(stream);
                    images1 = bns.ReadBytes((int)stream.Length);

                    byte[] images2 = null;
                    FileStream streama = new FileStream(imglocsign, FileMode.Open, FileAccess.Read);
                    BinaryReader bnsa = new BinaryReader(streama);
                    images2 = bnsa.ReadBytes((int)streama.Length);
                     
                    
                    string query = "insert into account(id,f_name,l_name,gender,address,father_name,mother_name,m_status,nationality,dob,c_num,ballance,typea,photo,usign) values('" + this.label16.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + value + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox9.Text + "','" + Int32.Parse("0") + "','" + this.comboBox1.Text + "','@images1','@images2');";
                    string qqq = "update acnumgen set post=post+1;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlCommand ccc = new SqlCommand(qqq, conn);
                    cmd.Parameters.Add(new SqlParameter("images1", images1));
                    cmd.Parameters.Add(new SqlParameter("images2", images2));
                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    ccc.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(n.ToString() + " " + "Account Created");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictUser_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
