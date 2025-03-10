namespace Lecture_3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UserIDCombobox = new System.Windows.Forms.ComboBox();
            this.TotalAmountTxt = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.InsertProcedureBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrderDatePicker);
            this.panel1.Controls.Add(this.UserIDCombobox);
            this.panel1.Controls.Add(this.TotalAmountTxt);
            this.panel1.Location = new System.Drawing.Point(1, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 261);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "UserID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TotalAmount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "OrderDate";
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(163, 49);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(184, 20);
            this.OrderDatePicker.TabIndex = 10;
            // 
            // UserIDCombobox
            // 
            this.UserIDCombobox.FormattingEnabled = true;
            this.UserIDCombobox.Location = new System.Drawing.Point(226, 167);
            this.UserIDCombobox.Name = "UserIDCombobox";
            this.UserIDCombobox.Size = new System.Drawing.Size(121, 21);
            this.UserIDCombobox.TabIndex = 3;
            // 
            // TotalAmountTxt
            // 
            this.TotalAmountTxt.Location = new System.Drawing.Point(244, 107);
            this.TotalAmountTxt.Name = "TotalAmountTxt";
            this.TotalAmountTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalAmountTxt.TabIndex = 1;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(69, 371);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // InsertProcedureBtn
            // 
            this.InsertProcedureBtn.Location = new System.Drawing.Point(192, 371);
            this.InsertProcedureBtn.Name = "InsertProcedureBtn";
            this.InsertProcedureBtn.Size = new System.Drawing.Size(121, 23);
            this.InsertProcedureBtn.TabIndex = 13;
            this.InsertProcedureBtn.Text = "InsertProcedureButton";
            this.InsertProcedureBtn.UseVisualStyleBackColor = true;
            this.InsertProcedureBtn.Click += new System.EventHandler(this.InsertProcedureBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.InsertProcedureBtn);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox UserIDCombobox;
        private System.Windows.Forms.TextBox TotalAmountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button InsertProcedureBtn;
    }
}

