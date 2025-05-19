namespace WordleGame
{
    partial class StatisticsForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            valuePlayed = new Label();
            valueWinPercent = new Label();
            valueCurrentStreak = new Label();
            valueMaxStreak = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(191, 51);
            label1.TabIndex = 0;
            label1.Text = "Statistics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(79, 297);
            label3.Name = "label3";
            label3.Size = new Size(84, 27);
            label3.TabIndex = 2;
            label3.Text = "Played:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(242, 297);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 3;
            label4.Text = "Win %:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(393, 297);
            label5.Name = "label5";
            label5.Size = new Size(159, 27);
            label5.TabIndex = 4;
            label5.Text = "Current Streak:";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(604, 297);
            label6.Name = "label6";
            label6.Size = new Size(129, 27);
            label6.TabIndex = 5;
            label6.Text = "Max Streak:";
            // 
            // valuePlayed
            // 
            valuePlayed.AutoSize = true;
            valuePlayed.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valuePlayed.Location = new Point(92, 192);
            valuePlayed.Name = "valuePlayed";
            valuePlayed.Size = new Size(0, 81);
            valuePlayed.TabIndex = 6;
            // 
            // valueWinPercent
            // 
            valueWinPercent.AutoSize = true;
            valueWinPercent.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valueWinPercent.Location = new Point(255, 192);
            valueWinPercent.Name = "valueWinPercent";
            valueWinPercent.Size = new Size(0, 81);
            valueWinPercent.TabIndex = 7;
            // 
            // valueCurrentStreak
            // 
            valueCurrentStreak.AutoSize = true;
            valueCurrentStreak.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valueCurrentStreak.Location = new Point(432, 192);
            valueCurrentStreak.Name = "valueCurrentStreak";
            valueCurrentStreak.Size = new Size(0, 81);
            valueCurrentStreak.TabIndex = 8;
            // 
            // valueMaxStreak
            // 
            valueMaxStreak.AutoSize = true;
            valueMaxStreak.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valueMaxStreak.Location = new Point(633, 192);
            valueMaxStreak.Name = "valueMaxStreak";
            valueMaxStreak.Size = new Size(0, 81);
            valueMaxStreak.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(310, 426);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(159, 58);
            closeButton.TabIndex = 38;
            closeButton.Text = "Go Back";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click_1;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(802, 528);
            Controls.Add(closeButton);
            Controls.Add(valueMaxStreak);
            Controls.Add(valueCurrentStreak);
            Controls.Add(valueWinPercent);
            Controls.Add(valuePlayed);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label valuePlayed;
        private Label valueWinPercent;
        private Label valueCurrentStreak;
        private Label valueMaxStreak;
        private Button closeButton;
    }
}