namespace BankingReMake
{
    partial class AddUserForm
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
            this.add_userBox = new System.Windows.Forms.TextBox();
            this.add_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_userButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_userBox
            // 
            this.add_userBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_userBox.Location = new System.Drawing.Point(336, 147);
            this.add_userBox.Name = "add_userBox";
            this.add_userBox.Size = new System.Drawing.Size(100, 22);
            this.add_userBox.TabIndex = 0;
            this.add_userBox.TextChanged += new System.EventHandler(this.add_userBox_TextChanged);
            // 
            // add_userName
            // 
            this.add_userName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_userName.Location = new System.Drawing.Point(336, 105);
            this.add_userName.Name = "add_userName";
            this.add_userName.Size = new System.Drawing.Size(100, 22);
            this.add_userName.TabIndex = 1;
            this.add_userName.TextChanged += new System.EventHandler(this.add_userName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card Number:";
            // 
            // add_userButton
            // 
            this.add_userButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_userButton.Location = new System.Drawing.Point(349, 194);
            this.add_userButton.Name = "add_userButton";
            this.add_userButton.Size = new System.Drawing.Size(75, 23);
            this.add_userButton.TabIndex = 4;
            this.add_userButton.Text = "Add";
            this.add_userButton.UseVisualStyleBackColor = true;
            this.add_userButton.Click += new System.EventHandler(this.add_userButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Users";
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(713, 415);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(75, 23);
            this.close1.TabIndex = 6;
            this.close1.Text = "Close";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_userButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_userName);
            this.Controls.Add(this.add_userBox);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_userBox;
        private System.Windows.Forms.TextBox add_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_userButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close1;
    }
}