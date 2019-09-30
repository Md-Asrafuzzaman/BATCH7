namespace MyWindowsFormsApp
{
    partial class OrdersUI
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
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.iteamNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalOrderPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(241, 85);
            this.showDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.RowTemplate.Height = 28;
            this.showDataGridView.Size = new System.Drawing.Size(517, 281);
            this.showDataGridView.TabIndex = 31;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(43, 341);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 25);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(43, 296);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 25);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(137, 296);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(69, 25);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(138, 251);
            this.showButton.Margin = new System.Windows.Forms.Padding(2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(69, 27);
            this.showButton.TabIndex = 29;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(46, 251);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 27);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // iteamNameTextBox
            // 
            this.iteamNameTextBox.Location = new System.Drawing.Point(138, 161);
            this.iteamNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iteamNameTextBox.Multiline = true;
            this.iteamNameTextBox.Name = "iteamNameTextBox";
            this.iteamNameTextBox.Size = new System.Drawing.Size(93, 18);
            this.iteamNameTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Iteam Name";
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(138, 192);
            this.orderQuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderQuantityTextBox.Multiline = true;
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(93, 18);
            this.orderQuantityTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity";
            // 
            // totalOrderPriceTextBox
            // 
            this.totalOrderPriceTextBox.Location = new System.Drawing.Point(138, 224);
            this.totalOrderPriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalOrderPriceTextBox.Multiline = true;
            this.totalOrderPriceTextBox.Name = "totalOrderPriceTextBox";
            this.totalOrderPriceTextBox.Size = new System.Drawing.Size(93, 18);
            this.totalOrderPriceTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Price";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(138, 128);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTextBox.Multiline = true;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(94, 18);
            this.customerNameTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Name";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(138, 93);
            this.orderIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderIdTextBox.Multiline = true;
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(93, 21);
            this.orderIdTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID";
            // 
            // OrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.iteamNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderQuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalOrderPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "OrdersUI";
            this.Text = "OrdersUI";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox iteamNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalOrderPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}