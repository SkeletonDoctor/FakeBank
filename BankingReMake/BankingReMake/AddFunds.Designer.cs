namespace BankingReMake
{
    partial class AddFunds
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
            this.user_ID = new System.Windows.Forms.TextBox();
            this.user_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_pay = new System.Windows.Forms.Button();
            this.invalid_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_ID
            // 
            this.user_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_ID.Location = new System.Drawing.Point(301, 128);
            this.user_ID.Name = "user_ID";
            this.user_ID.Size = new System.Drawing.Size(100, 22);
            this.user_ID.TabIndex = 0;
            this.user_ID.TextChanged += new System.EventHandler(this.user_ID_TextChanged);
            // 
            // user_amount
            // 
            this.user_amount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_amount.Location = new System.Drawing.Point(301, 155);
            this.user_amount.Name = "user_amount";
            this.user_amount.Size = new System.Drawing.Size(100, 22);
            this.user_amount.TabIndex = 1;
            this.user_amount.TextChanged += new System.EventHandler(this.user_amount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // user_pay
            // 
            this.user_pay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pay.Location = new System.Drawing.Point(315, 192);
            this.user_pay.Name = "user_pay";
            this.user_pay.Size = new System.Drawing.Size(75, 23);
            this.user_pay.TabIndex = 4;
            this.user_pay.Text = "Add";
            this.user_pay.UseVisualStyleBackColor = true;
            this.user_pay.Click += new System.EventHandler(this.user_pay_Click);
            // 
            // invalid_label
            // 
            this.invalid_label.AutoSize = true;
            this.invalid_label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_label.ForeColor = System.Drawing.Color.Red;
            this.invalid_label.Location = new System.Drawing.Point(435, 135);
            this.invalid_label.Name = "invalid_label";
            this.invalid_label.Size = new System.Drawing.Size(0, 14);
            this.invalid_label.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Funds";
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(713, 415);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(75, 23);
            this.close1.TabIndex = 7;
            this.close1.Text = "Close";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // AddFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invalid_label);
            this.Controls.Add(this.user_pay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_amount);
            this.Controls.Add(this.user_ID);
            this.Name = "AddFunds";
            this.Text = "AddFunds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_ID;
        private System.Windows.Forms.TextBox user_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button user_pay;
        private System.Windows.Forms.Label invalid_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close1;
    }
}