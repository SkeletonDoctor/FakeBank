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
    public partial class OnlineStore : Form
    {
        public OnlineStore()
        {
            InitializeComponent();
            item_num.Focus();
        }
        string SavePath = @"C:\Users\Public\Documents\UserSavesForm";
        float total_amount = 0f;
        private void item_num_TextChanged(object sender, EventArgs e)
        {
            if(File.Exists(SavePath + item_num.Text))
            {
                item_price.Text = File.ReadAllText(SavePath + item_num.Text);
            }
            if(!File.Exists(SavePath + item_num.Text))
            {
                item_price.Text = "0";
            }
        }

        private void total_due_Click(object sender, EventArgs e)
        {

        }

        private void add_item_Click(object sender, EventArgs e)
        {
            add_items_form AddItems = new add_items_form();
            AddItems.ShowDialog();
        }

        private void add_cart_Click(object sender, EventArgs e)
        {
            if(File.Exists(SavePath + item_num.Text)){
                total_amount = total_amount + float.Parse(item_price.Text);
                total_due.Text = total_amount.ToString();
                item_num.Text = "";
                item_num.Focus();
            }
        }

        private void OnlineStore_Load(object sender, EventArgs e)
        {

        }

        private void user_ID_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(SavePath + user_ID.Text))
            {
                invalid_ID.Text = "CARD NUMBER NOT FOUND";
            }
            else
            {
                invalid_ID.Text = "";
            }
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            if(File.Exists(SavePath + user_ID.Text))
            {
                string AmoutUserHas = File.ReadAllText(SavePath + user_ID.Text);
                string AmountTaken = (float.Parse(AmoutUserHas) - total_amount).ToString();
                File.WriteAllText(SavePath + user_ID.Text, AmountTaken);
                this.Close();
            }
        }

        private void user_refund_Click(object sender, EventArgs e)
        {
            string AmoutUserHas = File.ReadAllText(SavePath + user_ID.Text);
            string AmountTaken = (float.Parse(AmoutUserHas) + total_amount).ToString();
            File.WriteAllText(SavePath + user_ID.Text, AmountTaken);
            this.Close();
        }

        private void invalid_ID_Click(object sender, EventArgs e)
        {

        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
