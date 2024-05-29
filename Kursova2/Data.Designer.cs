namespace Kursova2
{
    partial class Data
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
            textBox1 = new TextBox();
            startBttn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            avatarComboBox = new ComboBox();
            colorComboBox = new ComboBox();
            modeComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            backBttn = new Button();
            exitBttn = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(46, 66);
            label1.Name = "label1";
            label1.Size = new Size(289, 34);
            label1.TabIndex = 0;
            label1.Text = "Enter your data!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 146);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // startBttn
            // 
            startBttn.BackColor = SystemColors.ActiveCaption;
            startBttn.Cursor = Cursors.Hand;
            startBttn.FlatStyle = FlatStyle.Popup;
            startBttn.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            startBttn.Location = new Point(349, 476);
            startBttn.Margin = new Padding(3, 4, 3, 4);
            startBttn.Name = "startBttn";
            startBttn.Size = new Size(203, 49);
            startBttn.TabIndex = 4;
            startBttn.Text = "Start";
            startBttn.UseVisualStyleBackColor = false;
            startBttn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(56, 146);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noImagee;
            pictureBox1.Location = new Point(620, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // avatarComboBox
            // 
            avatarComboBox.BackColor = SystemColors.Window;
            avatarComboBox.FormattingEnabled = true;
            avatarComboBox.Location = new Point(60, 278);
            avatarComboBox.Name = "avatarComboBox";
            avatarComboBox.Size = new Size(151, 28);
            avatarComboBox.TabIndex = 8;
            avatarComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Location = new Point(217, 278);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(151, 28);
            colorComboBox.TabIndex = 9;
            colorComboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // modeComboBox
            // 
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Location = new Point(374, 278);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(151, 28);
            modeComboBox.TabIndex = 10;
            modeComboBox.SelectedIndexChanged += modeComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(60, 235);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 11;
            label3.Text = "Avatar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(217, 235);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 12;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(374, 235);
            label5.Name = "label5";
            label5.Size = new Size(61, 22);
            label5.TabIndex = 13;
            label5.Text = "Mode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(60, 399);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 14;
            label6.Text = "Summary";
            // 
            // backBttn
            // 
            backBttn.BackColor = SystemColors.AppWorkspace;
            backBttn.Cursor = Cursors.Hand;
            backBttn.FlatStyle = FlatStyle.Popup;
            backBttn.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            backBttn.Location = new Point(59, 476);
            backBttn.Name = "backBttn";
            backBttn.Size = new Size(186, 49);
            backBttn.TabIndex = 15;
            backBttn.Text = "Back";
            backBttn.UseVisualStyleBackColor = false;
            backBttn.Click += backBttn_Click;
            // 
            // exitBttn
            // 
            exitBttn.BackColor = SystemColors.AppWorkspace;
            exitBttn.Cursor = Cursors.Hand;
            exitBttn.FlatStyle = FlatStyle.Popup;
            exitBttn.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitBttn.Location = new Point(669, 476);
            exitBttn.Name = "exitBttn";
            exitBttn.Size = new Size(186, 49);
            exitBttn.TabIndex = 16;
            exitBttn.Text = "Exit";
            exitBttn.UseVisualStyleBackColor = false;
            exitBttn.Click += exitBttn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(329, 560);
            label8.Name = "label8";
            label8.Size = new Size(264, 19);
            label8.TabIndex = 17;
            label8.Text = "©Made by Rennie and Stephie";
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(exitBttn);
            Controls.Add(backBttn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(modeComboBox);
            Controls.Add(colorComboBox);
            Controls.Add(avatarComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(startBttn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Data";
            Text = "Data";
            Load += Data_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button startBttn;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox avatarComboBox;
        private ComboBox colorComboBox;
        private ComboBox modeComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button backBttn;
        private Button exitBttn;
        private Label label8;
    }
}