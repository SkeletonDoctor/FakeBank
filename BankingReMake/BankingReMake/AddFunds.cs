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
    public partial class AddFunds : Form
    {
        public AddFunds()
        {
            InitializeComponent();
            user_ID.Focus();
        }
        string SavePath = @"C:\Users\Public\Documents\UserSavesForm";

        private void user_ID_TextChanged(object sender, EventArgs e)
        {
            if(!File.Exists(SavePath + user_ID.Text))
            {
                invalid_label.Text = "USER ID NOT FOUND";
            }
            else
            {
                invalid_label.Text = "";
            }
        }

        private void user_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_pay_Click(object sender, EventArgs e)
        {
            if(File.Exists(SavePath + user_ID.Text)){
                float AmountAdd = float.Parse(File.ReadAllText(SavePath + user_ID.Text));
                string TotalAdded = (AmountAdd + float.Parse(user_amount.Text)).ToString();
                File.WriteAllText(SavePath + user_ID.Text, TotalAdded.ToString());
                this.Close();
            }
            
        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
