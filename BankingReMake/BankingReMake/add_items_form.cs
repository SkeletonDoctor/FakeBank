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
    public partial class add_items_form : Form
    {
        public add_items_form()
        {
            InitializeComponent();
            item_id.Focus();
        }
        string SavePath = @"C:\Users\Public\Documents\UserSavesForm";
        private void item_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_item_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SavePath + item_id.Text, item_cost.Text);
            item_id.Text = "";
            item_cost.Text = "";
            item_id.Focus();
        }

        private void item_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
