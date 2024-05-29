namespace Kursova2
{
    partial class Help
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
            backBttn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backBttn
            // 
            backBttn.BackColor = SystemColors.ActiveCaption;
            backBttn.Cursor = Cursors.Hand;
            backBttn.FlatStyle = FlatStyle.Popup;
            backBttn.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            backBttn.Location = new Point(50, 498);
            backBttn.Margin = new Padding(3, 4, 3, 4);
            backBttn.Name = "backBttn";
            backBttn.Size = new Size(122, 43);
            backBttn.TabIndex = 0;
            backBttn.Text = "Back";
            backBttn.UseVisualStyleBackColor = false;
            backBttn.Click += backBttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(330, 75);
            label1.Name = "label1";
            label1.Size = new Size(205, 34);
            label1.TabIndex = 1;
            label1.Text = "How to play";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(50, 172);
            label2.Name = "label2";
            label2.Size = new Size(255, 22);
            label2.TabIndex = 2;
            label2.Text = "1. Enter your username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(50, 214);
            label3.Name = "label3";
            label3.Size = new Size(246, 22);
            label3.TabIndex = 3;
            label3.Text = "2. Choose your avatar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(50, 258);
            label4.Name = "label4";
            label4.Size = new Size(381, 22);
            label4.TabIndex = 4;
            label4.Text = "3. Choose the color of your avatar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(50, 307);
            label5.Name = "label5";
            label5.Size = new Size(389, 22);
            label5.TabIndex = 5;
            label5.Text = "4. Choose the mode you want to play";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(50, 355);
            label6.Name = "label6";
            label6.Size = new Size(366, 22);
            label6.TabIndex = 6;
            label6.Text = "5. Press space to start and pause";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.keys;
            pictureBox1.Location = new Point(665, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(50, 433);
            label7.Name = "label7";
            label7.Size = new Size(213, 22);
            label7.TabIndex = 8;
            label7.Text = "7. Enjoy our game :)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(306, 552);
            label8.Name = "label8";
            label8.Size = new Size(264, 19);
            label8.TabIndex = 9;
            label8.Text = "©Made by Rennie and Stephie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(50, 396);
            label9.Name = "label9";
            label9.Size = new Size(591, 22);
            label9.TabIndex = 10;
            label9.Text = "6. Use the left and right arrows to destroy the blocks";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 600);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backBttn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Help";
            Text = "Help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBttn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}