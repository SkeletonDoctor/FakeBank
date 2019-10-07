namespace BankingReMake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_money = new System.Windows.Forms.Label();
            this.add_funds = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            this.store_opener = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Number:";
            // 
            // user_money
            // 
            this.user_money.AutoSize = true;
            this.user_money.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_money.Location = new System.Drawing.Point(795, 58);
            this.user_money.Name = "user_money";
            this.user_money.Size = new System.Drawing.Size(44, 32);
            this.user_money.TabIndex = 2;
            this.user_money.Text = "-$";
            this.user_money.Click += new System.EventHandler(this.user_money_Click);
            // 
            // add_funds
            // 
            this.add_funds.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_funds.Location = new System.Drawing.Point(926, 568);
            this.add_funds.Name = "add_funds";
            this.add_funds.Size = new System.Drawing.Size(83, 23);
            this.add_funds.TabIndex = 3;
            this.add_funds.Text = "Add Funds";
            this.add_funds.UseVisualStyleBackColor = true;
            this.add_funds.Click += new System.EventHandler(this.add_funds_Click);
            // 
            // add_user
            // 
            this.add_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.Location = new System.Drawing.Point(6, 568);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(92, 23);
            this.add_user.TabIndex = 4;
            this.add_user.Text = "Add Users";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // store_opener
            // 
            this.store_opener.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store_opener.Location = new System.Drawing.Point(476, 568);
            this.store_opener.Name = "store_opener";
            this.store_opener.Size = new System.Drawing.Size(106, 23);
            this.store_opener.TabIndex = 5;
            this.store_opener.Text = "Online Store";
            this.store_opener.UseVisualStyleBackColor = true;
            this.store_opener.Click += new System.EventHandler(this.store_opener_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Main Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1045, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "____________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.store_opener);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.add_funds);
            this.Controls.Add(this.user_money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_money;
        private System.Windows.Forms.Button add_funds;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Button store_opener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

