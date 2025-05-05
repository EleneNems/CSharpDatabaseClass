namespace Classwork_4
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
            this.booksLoadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.booksDeleteBtn = new System.Windows.Forms.Button();
            this.booksEditBtn = new System.Windows.Forms.Button();
            this.booksAddBtn = new System.Windows.Forms.Button();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publishYearTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.addReaderComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.authorDeleteBtn = new System.Windows.Forms.Button();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.authorEditBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.authorAddBtn = new System.Windows.Forms.Button();
            this.authorLastnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorFirstnameTxt = new System.Windows.Forms.TextBox();
            this.authorLoadBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.readerComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.readerLastnameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readerFirstnameTxt = new System.Windows.Forms.TextBox();
            this.readersLoadBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 592);
            this.dataGridView1.TabIndex = 7;
            // 
            // booksLoadBtn
            // 
            this.booksLoadBtn.Location = new System.Drawing.Point(55, 19);
            this.booksLoadBtn.Name = "booksLoadBtn";
            this.booksLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.booksLoadBtn.TabIndex = 9;
            this.booksLoadBtn.Text = "Load";
            this.booksLoadBtn.UseVisualStyleBackColor = true;
            this.booksLoadBtn.Click += new System.EventHandler(this.booksLoadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Books";
            // 
            // booksDeleteBtn
            // 
            this.booksDeleteBtn.Location = new System.Drawing.Point(207, 158);
            this.booksDeleteBtn.Name = "booksDeleteBtn";
            this.booksDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.booksDeleteBtn.TabIndex = 12;
            this.booksDeleteBtn.Text = "Delete";
            this.booksDeleteBtn.UseVisualStyleBackColor = true;
            this.booksDeleteBtn.Click += new System.EventHandler(this.booksDeleteBtn_Click);
            // 
            // booksEditBtn
            // 
            this.booksEditBtn.Location = new System.Drawing.Point(116, 158);
            this.booksEditBtn.Name = "booksEditBtn";
            this.booksEditBtn.Size = new System.Drawing.Size(75, 23);
            this.booksEditBtn.TabIndex = 11;
            this.booksEditBtn.Text = "Edit";
            this.booksEditBtn.UseVisualStyleBackColor = true;
            this.booksEditBtn.Click += new System.EventHandler(this.booksEditBtn_Click);
            // 
            // booksAddBtn
            // 
            this.booksAddBtn.Location = new System.Drawing.Point(15, 158);
            this.booksAddBtn.Name = "booksAddBtn";
            this.booksAddBtn.Size = new System.Drawing.Size(75, 23);
            this.booksAddBtn.TabIndex = 10;
            this.booksAddBtn.Text = "Add";
            this.booksAddBtn.UseVisualStyleBackColor = true;
            this.booksAddBtn.Click += new System.EventHandler(this.booksAddBtn_Click);
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(76, 57);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 13;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(12, 60);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(27, 13);
            this.A.TabIndex = 14;
            this.A.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Publish year";
            // 
            // publishYearTxt
            // 
            this.publishYearTxt.Location = new System.Drawing.Point(76, 83);
            this.publishYearTxt.Name = "publishYearTxt";
            this.publishYearTxt.Size = new System.Drawing.Size(100, 20);
            this.publishYearTxt.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.addAuthorComboBox);
            this.panel1.Controls.Add(this.addReaderComboBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bookComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.booksDeleteBtn);
            this.panel1.Controls.Add(this.publishYearTxt);
            this.panel1.Controls.Add(this.booksEditBtn);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.booksAddBtn);
            this.panel1.Controls.Add(this.titleTxt);
            this.panel1.Controls.Add(this.booksLoadBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(520, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 184);
            this.panel1.TabIndex = 17;
            // 
            // addAuthorComboBox
            // 
            this.addAuthorComboBox.FormattingEnabled = true;
            this.addAuthorComboBox.Location = new System.Drawing.Point(97, 136);
            this.addAuthorComboBox.Name = "addAuthorComboBox";
            this.addAuthorComboBox.Size = new System.Drawing.Size(79, 21);
            this.addAuthorComboBox.TabIndex = 25;
            // 
            // addReaderComboBox
            // 
            this.addReaderComboBox.FormattingEnabled = true;
            this.addReaderComboBox.Location = new System.Drawing.Point(97, 109);
            this.addReaderComboBox.Name = "addReaderComboBox";
            this.addReaderComboBox.Size = new System.Drawing.Size(79, 21);
            this.addReaderComboBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Author";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Reader";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id";
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(207, 21);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(79, 21);
            this.bookComboBox.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.authorDeleteBtn);
            this.panel2.Controls.Add(this.authorComboBox);
            this.panel2.Controls.Add(this.authorEditBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.authorAddBtn);
            this.panel2.Controls.Add(this.authorLastnameTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.authorFirstnameTxt);
            this.panel2.Controls.Add(this.authorLoadBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(520, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 186);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Id";
            // 
            // authorDeleteBtn
            // 
            this.authorDeleteBtn.Location = new System.Drawing.Point(202, 160);
            this.authorDeleteBtn.Name = "authorDeleteBtn";
            this.authorDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.authorDeleteBtn.TabIndex = 19;
            this.authorDeleteBtn.Text = "Delete";
            this.authorDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // authorComboBox
            // 
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(202, 22);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(79, 21);
            this.authorComboBox.TabIndex = 22;
            // 
            // authorEditBtn
            // 
            this.authorEditBtn.Location = new System.Drawing.Point(111, 160);
            this.authorEditBtn.Name = "authorEditBtn";
            this.authorEditBtn.Size = new System.Drawing.Size(75, 23);
            this.authorEditBtn.TabIndex = 18;
            this.authorEditBtn.Text = "Edit";
            this.authorEditBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "lastname";
            // 
            // authorAddBtn
            // 
            this.authorAddBtn.Location = new System.Drawing.Point(10, 160);
            this.authorAddBtn.Name = "authorAddBtn";
            this.authorAddBtn.Size = new System.Drawing.Size(75, 23);
            this.authorAddBtn.TabIndex = 17;
            this.authorAddBtn.Text = "Add";
            this.authorAddBtn.UseVisualStyleBackColor = true;
            // 
            // authorLastnameTxt
            // 
            this.authorLastnameTxt.Location = new System.Drawing.Point(76, 107);
            this.authorLastnameTxt.Name = "authorLastnameTxt";
            this.authorLastnameTxt.Size = new System.Drawing.Size(100, 20);
            this.authorLastnameTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "firstname";
            // 
            // authorFirstnameTxt
            // 
            this.authorFirstnameTxt.Location = new System.Drawing.Point(76, 61);
            this.authorFirstnameTxt.Name = "authorFirstnameTxt";
            this.authorFirstnameTxt.Size = new System.Drawing.Size(100, 20);
            this.authorFirstnameTxt.TabIndex = 13;
            // 
            // authorLoadBtn
            // 
            this.authorLoadBtn.Location = new System.Drawing.Point(50, 20);
            this.authorLoadBtn.Name = "authorLoadBtn";
            this.authorLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.authorLoadBtn.TabIndex = 9;
            this.authorLoadBtn.Text = "Load";
            this.authorLoadBtn.UseVisualStyleBackColor = true;
            this.authorLoadBtn.Click += new System.EventHandler(this.authorLoadBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Author";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.readerComboBox);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.readerLastnameTxt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.readerFirstnameTxt);
            this.panel3.Controls.Add(this.readersLoadBtn);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(520, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 186);
            this.panel3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // readerComboBox
            // 
            this.readerComboBox.FormattingEnabled = true;
            this.readerComboBox.Location = new System.Drawing.Point(202, 22);
            this.readerComboBox.Name = "readerComboBox";
            this.readerComboBox.Size = new System.Drawing.Size(79, 21);
            this.readerComboBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "lastname";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // readerLastnameTxt
            // 
            this.readerLastnameTxt.Location = new System.Drawing.Point(76, 107);
            this.readerLastnameTxt.Name = "readerLastnameTxt";
            this.readerLastnameTxt.Size = new System.Drawing.Size(100, 20);
            this.readerLastnameTxt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "firstname";
            // 
            // readerFirstnameTxt
            // 
            this.readerFirstnameTxt.Location = new System.Drawing.Point(76, 61);
            this.readerFirstnameTxt.Name = "readerFirstnameTxt";
            this.readerFirstnameTxt.Size = new System.Drawing.Size(100, 20);
            this.readerFirstnameTxt.TabIndex = 13;
            // 
            // readersLoadBtn
            // 
            this.readersLoadBtn.Location = new System.Drawing.Point(60, 20);
            this.readersLoadBtn.Name = "readersLoadBtn";
            this.readersLoadBtn.Size = new System.Drawing.Size(75, 23);
            this.readersLoadBtn.TabIndex = 9;
            this.readersLoadBtn.Text = "Load";
            this.readersLoadBtn.UseVisualStyleBackColor = true;
            this.readersLoadBtn.Click += new System.EventHandler(this.readersLoadBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Readers";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button booksLoadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button booksDeleteBtn;
        private System.Windows.Forms.Button booksEditBtn;
        private System.Windows.Forms.Button booksAddBtn;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox publishYearTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorLastnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorFirstnameTxt;
        private System.Windows.Forms.Button authorLoadBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button authorDeleteBtn;
        private System.Windows.Forms.Button authorEditBtn;
        private System.Windows.Forms.Button authorAddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox readerComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox readerLastnameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox readerFirstnameTxt;
        private System.Windows.Forms.Button readersLoadBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox addAuthorComboBox;
        private System.Windows.Forms.ComboBox addReaderComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

