using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace moneymanagementinbank
{
    public partial class Mainwindow : Form
    {
        public Mainwindow()
        {
            InitializeComponent();
        }

        private void depositToAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void createAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View ca = new View();
            ca.Show();
        }

        private void deleteAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deleteaccount da = new Deleteaccount();
            da.Show();
        }

        private void depositAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
        }

        private void withdrawFromAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer();
            t.Show();
        }


        private void totalBallanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ballance ba = new Ballance();
            ba.Show();
        }

        private void vIewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewac va = new viewac();
            va.Show();
        }

        private void Mainwindow_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1.Click on Menu to \n->Create Account,\n->View Account,\n->Update Account and \n->Delete Account \n\n 2.Click on Transaction to \n->Deposit Money,\n->Withdraw Money and \n->Fund Transfer \n\n 3.Click on View to \n->View Available Ballance and \n->View Statement");

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project by Suraj Maharjan,Aakriti Jha,Manisha Gaihre and Robin Khadka");
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatea uea = new updatea();
            uea.Show();
        }

        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statement st = new statement();
            st.Show();
        }

       
    }
}
