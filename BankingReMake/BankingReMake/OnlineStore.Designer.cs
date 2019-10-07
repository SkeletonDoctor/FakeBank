namespace BankingReMake
{
    partial class OnlineStore
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
            this.item_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_due = new System.Windows.Forms.Label();
            this.add_item = new System.Windows.Forms.Button();
            this.add_cart = new System.Windows.Forms.Button();
            this.item_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pay_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.user_ID = new System.Windows.Forms.TextBox();
            this.user_refund = new System.Windows.Forms.Button();
            this.invalid_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item_num
            // 
            this.item_num.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_num.Location = new System.Drawing.Point(67, 157);
            this.item_num.Name = "item_num";
            this.item_num.Size = new System.Drawing.Size(100, 21);
            this.item_num.TabIndex = 0;
            this.item_num.TextChanged += new System.EventHandler(this.item_num_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item #:";
            // 
            // total_due
            // 
            this.total_due.AutoSize = true;
            this.total_due.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_due.Location = new System.Drawing.Point(89, 230);
            this.total_due.Name = "total_due";
            this.total_due.Size = new System.Drawing.Size(14, 13);
            this.total_due.TabIndex = 2;
            this.total_due.Text = "0";
            this.total_due.Click += new System.EventHandler(this.total_due_Click);
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.Location = new System.Drawing.Point(453, 157);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(75, 23);
            this.add_item.TabIndex = 3;
            this.add_item.Text = "Add Items";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // add_cart
            // 
            this.add_cart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cart.Location = new System.Drawing.Point(173, 155);
            this.add_cart.Name = "add_cart";
            this.add_cart.Size = new System.Drawing.Size(87, 23);
            this.add_cart.TabIndex = 4;
            this.add_cart.Text = "Add to Cart";
            this.add_cart.UseVisualStyleBackColor = true;
            this.add_cart.Click += new System.EventHandler(this.add_cart_Click);
            // 
            // item_price
            // 
            this.item_price.AutoSize = true;
            this.item_price.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price.Location = new System.Drawing.Point(89, 190);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(14, 13);
            this.item_price.TabIndex = 5;
            this.item_price.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cart Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Price:";
            // 
            // pay_button
            // 
            this.pay_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_button.Location = new System.Drawing.Point(467, 538);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(75, 23);
            this.pay_button.TabIndex = 8;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Card Num:";
            // 
            // user_ID
            // 
            this.user_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_ID.Location = new System.Drawing.Point(361, 538);
            this.user_ID.Name = "user_ID";
            this.user_ID.Size = new System.Drawing.Size(100, 21);
            this.user_ID.TabIndex = 11;
            this.user_ID.TextChanged += new System.EventHandler(this.user_ID_TextChanged);
            // 
            // user_refund
            // 
            this.user_refund.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_refund.Location = new System.Drawing.Point(604, 538);
            this.user_refund.Name = "user_refund";
            this.user_refund.Size = new System.Drawing.Size(75, 23);
            this.user_refund.TabIndex = 12;
            this.user_refund.Text = "Refund";
            this.user_refund.UseVisualStyleBackColor = true;
            this.user_refund.Click += new System.EventHandler(this.user_refund_Click);
            // 
            // invalid_ID
            // 
            this.invalid_ID.AutoSize = true;
            this.invalid_ID.BackColor = System.Drawing.SystemColors.Control;
            this.invalid_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_ID.ForeColor = System.Drawing.Color.Red;
            this.invalid_ID.Location = new System.Drawing.Point(358, 509);
            this.invalid_ID.Name = "invalid_ID";
            this.invalid_ID.Size = new System.Drawing.Size(0, 13);
            this.invalid_ID.TabIndex = 13;
            this.invalid_ID.Click += new System.EventHandler(this.invalid_ID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Online Store";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Checkout";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Shopping Cart";
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(904, 538);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(75, 23);
            this.close1.TabIndex = 17;
            this.close1.Text = "Close";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // OnlineStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 573);
            this.Controls.Add(this.close1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invalid_ID);
            this.Controls.Add(this.user_refund);
            this.Controls.Add(this.user_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_price);
            this.Controls.Add(this.add_cart);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.total_due);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_num);
            this.Name = "OnlineStore";
            this.Text = "OnlineStore";
            this.Load += new System.EventHandler(this.OnlineStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_due;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button add_cart;
        private System.Windows.Forms.Label item_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_ID;
        private System.Windows.Forms.Button user_refund;
        private System.Windows.Forms.Label invalid_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button close1;
    }
}