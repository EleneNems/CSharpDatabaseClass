namespace Classwork_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.IsbnText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.StockText = new System.Windows.Forms.TextBox();
            this.IDComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.publishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(264, 229);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(124, 49);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(100, 20);
            this.titleText.TabIndex = 2;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(124, 92);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(100, 20);
            this.authorText.TabIndex = 3;
            // 
            // IsbnText
            // 
            this.IsbnText.Location = new System.Drawing.Point(124, 135);
            this.IsbnText.Name = "IsbnText";
            this.IsbnText.Size = new System.Drawing.Size(100, 20);
            this.IsbnText.TabIndex = 4;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(124, 182);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 20);
            this.PriceText.TabIndex = 5;
            // 
            // StockText
            // 
            this.StockText.Location = new System.Drawing.Point(124, 229);
            this.StockText.Name = "StockText";
            this.StockText.Size = new System.Drawing.Size(100, 20);
            this.StockText.TabIndex = 6;
            // 
            // IDComboBox
            // 
            this.IDComboBox.FormattingEnabled = true;
            this.IDComboBox.Location = new System.Drawing.Point(363, 179);
            this.IDComboBox.Name = "IDComboBox";
            this.IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.IDComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Published Date";
            // 
            // publishDatePicker
            // 
            this.publishDatePicker.Location = new System.Drawing.Point(124, 277);
            this.publishDatePicker.Name = "publishDatePicker";
            this.publishDatePicker.Size = new System.Drawing.Size(100, 20);
            this.publishDatePicker.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(264, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(409, 224);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(409, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 608);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.publishDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDComboBox);
            this.Controls.Add(this.StockText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.IsbnText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox IsbnText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox StockText;
        private System.Windows.Forms.ComboBox IDComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker publishDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

