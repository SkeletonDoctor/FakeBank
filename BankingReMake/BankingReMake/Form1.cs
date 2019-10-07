using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingReMake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        string SavePath = @"C:\Users\Public\Documents\UserSavesForm";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(SavePath + textBox1.Text))
            {
                user_money.Text = File.ReadAllText(SavePath + textBox1.Text) + "$";
                textBox1.SelectAll();
            }
            else
            {
                user_money.Text = "-$";
            }
        }

        private void user_money_Click(object sender, EventArgs e)
        {

        }

        private void add_funds_Click(object sender, EventArgs e)
        {
            AddFunds addfunds = new AddFunds();
            addfunds.ShowDialog();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            AddUserForm adduser = new AddUserForm();
            adduser.ShowDialog();
        }

        private void store_opener_Click(object sender, EventArgs e)
        {
            OnlineStore store = new OnlineStore();
            store.ShowDialog();
        }
    }
}
