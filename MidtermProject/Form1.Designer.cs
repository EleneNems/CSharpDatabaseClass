namespace MidtermProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            ordersGridView = new DataGridView();
            loadOrdersBtn = new Button();
            addOrderBtn = new Button();
            updateOrderBtn = new Button();
            deleteOrderBtn = new Button();
            userComboBox = new ComboBox();
            orderDate = new DateTimePicker();
            totalAmountTxt = new NumericUpDown();
            orderByBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalAmountTxt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 101);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 0;
            label1.Text = "Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 233);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 1;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 281);
            label3.Name = "label3";
            label3.Size = new Size(116, 22);
            label3.TabIndex = 2;
            label3.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 500);
            label5.Name = "label5";
            label5.Size = new Size(345, 29);
            label5.TabIndex = 4;
            label5.Text = "Orders For The Selected User:";
            // 
            // ordersGridView
            // 
            ordersGridView.BackgroundColor = Color.Pink;
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(50, 550);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersWidth = 62;
            ordersGridView.RowTemplate.Height = 33;
            ordersGridView.ShowCellErrors = false;
            ordersGridView.Size = new Size(475, 333);
            ordersGridView.TabIndex = 5;
            ordersGridView.CellContentDoubleClick += ordersGridView_CellContentDoubleClick;
            // 
            // loadOrdersBtn
            // 
            loadOrdersBtn.BackColor = Color.LightPink;
            loadOrdersBtn.FlatAppearance.BorderSize = 0;
            loadOrdersBtn.FlatStyle = FlatStyle.Flat;
            loadOrdersBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loadOrdersBtn.Location = new Point(392, 96);
            loadOrdersBtn.Name = "loadOrdersBtn";
            loadOrdersBtn.Size = new Size(133, 34);
            loadOrdersBtn.TabIndex = 6;
            loadOrdersBtn.Text = "Load Orders";
            loadOrdersBtn.UseVisualStyleBackColor = false;
            loadOrdersBtn.Click += loadOrdersBtn_Click;
            // 
            // addOrderBtn
            // 
            addOrderBtn.BackColor = Color.LightPink;
            addOrderBtn.FlatAppearance.BorderSize = 0;
            addOrderBtn.FlatStyle = FlatStyle.Flat;
            addOrderBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addOrderBtn.Location = new Point(50, 399);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new Size(142, 34);
            addOrderBtn.TabIndex = 7;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.UseVisualStyleBackColor = false;
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // updateOrderBtn
            // 
            updateOrderBtn.BackColor = Color.LightPink;
            updateOrderBtn.FlatAppearance.BorderSize = 0;
            updateOrderBtn.FlatStyle = FlatStyle.Flat;
            updateOrderBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            updateOrderBtn.Location = new Point(221, 399);
            updateOrderBtn.Name = "updateOrderBtn";
            updateOrderBtn.Size = new Size(145, 34);
            updateOrderBtn.TabIndex = 8;
            updateOrderBtn.Text = "Update Order";
            updateOrderBtn.UseVisualStyleBackColor = false;
            updateOrderBtn.Click += updateOrderBtn_Click;
            // 
            // deleteOrderBtn
            // 
            deleteOrderBtn.BackColor = Color.LightPink;
            deleteOrderBtn.FlatAppearance.BorderSize = 0;
            deleteOrderBtn.FlatStyle = FlatStyle.Flat;
            deleteOrderBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteOrderBtn.Location = new Point(392, 399);
            deleteOrderBtn.Name = "deleteOrderBtn";
            deleteOrderBtn.Size = new Size(133, 34);
            deleteOrderBtn.TabIndex = 9;
            deleteOrderBtn.Text = "Delete Order";
            deleteOrderBtn.UseVisualStyleBackColor = false;
            deleteOrderBtn.Click += deleteOrderBtn_Click;
            // 
            // userComboBox
            // 
            userComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(123, 96);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(182, 30);
            userComboBox.TabIndex = 13;
            // 
            // orderDate
            // 
            orderDate.Checked = false;
            orderDate.CustomFormat = "dd-MM-yyyy";
            orderDate.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            orderDate.Location = new Point(345, 233);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(180, 30);
            orderDate.TabIndex = 14;
            orderDate.Value = new DateTime(2025, 3, 25, 0, 0, 0, 0);
            // 
            // totalAmountTxt
            // 
            totalAmountTxt.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            totalAmountTxt.Location = new Point(345, 285);
            totalAmountTxt.Name = "totalAmountTxt";
            totalAmountTxt.Size = new Size(180, 30);
            totalAmountTxt.TabIndex = 15;
            // 
            // orderByBtn
            // 
            orderByBtn.BackColor = Color.LightPink;
            orderByBtn.FlatAppearance.BorderSize = 0;
            orderByBtn.FlatStyle = FlatStyle.Flat;
            orderByBtn.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            orderByBtn.Location = new Point(233, 906);
            orderByBtn.Name = "orderByBtn";
            orderByBtn.Size = new Size(112, 34);
            orderByBtn.TabIndex = 16;
            orderByBtn.Text = "Order by";
            orderByBtn.UseVisualStyleBackColor = false;
            orderByBtn.Click += orderByBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(567, 952);
            Controls.Add(orderByBtn);
            Controls.Add(totalAmountTxt);
            Controls.Add(orderDate);
            Controls.Add(userComboBox);
            Controls.Add(deleteOrderBtn);
            Controls.Add(updateOrderBtn);
            Controls.Add(addOrderBtn);
            Controls.Add(loadOrdersBtn);
            Controls.Add(ordersGridView);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalAmountTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private DataGridView ordersGridView;
        private Button loadOrdersBtn;
        private Button addOrderBtn;
        private Button updateOrderBtn;
        private Button deleteOrderBtn;
        private ComboBox userComboBox;
        private DateTimePicker orderDate;
        private NumericUpDown totalAmountTxt;
        private Button orderByBtn;
    }
}
