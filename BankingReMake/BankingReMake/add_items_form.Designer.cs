namespace BankingReMake
{
    partial class add_items_form
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
            this.add_item = new System.Windows.Forms.Button();
            this.item_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.item_cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.Location = new System.Drawing.Point(345, 206);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(75, 23);
            this.add_item.TabIndex = 0;
            this.add_item.Text = "Add Item";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // item_id
            // 
            this.item_id.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_id.Location = new System.Drawing.Point(320, 120);
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(100, 21);
            this.item_id.TabIndex = 1;
            this.item_id.TextChanged += new System.EventHandler(this.item_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item #:";
            // 
            // item_cost
            // 
            this.item_cost.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_cost.Location = new System.Drawing.Point(320, 147);
            this.item_cost.Name = "item_cost";
            this.item_cost.Size = new System.Drawing.Size(48, 21);
            this.item_cost.TabIndex = 3;
            this.item_cost.TextChanged += new System.EventHandler(this.item_cost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Items to Store";
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(899, 542);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(75, 23);
            this.close1.TabIndex = 8;
            this.close1.Text = "Close";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // add_items_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 577);
            this.Controls.Add(this.close1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.add_item);
            this.Name = "add_items_form";
            this.Text = "add_items_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close1;
    }
}