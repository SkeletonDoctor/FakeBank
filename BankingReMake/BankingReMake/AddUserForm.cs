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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            add_userName.Focus();
            
        }
        string SavePath = @"C:\Users\Public\Documents\UserSavesForm";
        string UsertoADD;
        string IdtoADD;

        private void add_userName_TextChanged(object sender, EventArgs e)
        {
            UsertoADD = add_userName.Text;
        }

        private void add_userBox_TextChanged(object sender, EventArgs e)
        {
            IdtoADD = add_userBox.Text;
        }

        private void add_userButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(SavePath + IdtoADD, "0");
            this.Close();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
