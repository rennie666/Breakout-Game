namespace Kursova2
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
            startBttn = new Button();
            helpBttn = new Button();
            exitBttn = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(265, 75);
            label1.Name = "label1";
            label1.Size = new Size(376, 49);
            label1.TabIndex = 0;
            label1.Text = "I like to move it";
            // 
            // startBttn
            // 
            startBttn.BackColor = SystemColors.ActiveCaption;
            startBttn.Cursor = Cursors.Hand;
            startBttn.FlatStyle = FlatStyle.Popup;
            startBttn.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            startBttn.Location = new Point(337, 166);
            startBttn.Margin = new Padding(3, 4, 3, 4);
            startBttn.Name = "startBttn";
            startBttn.Size = new Size(243, 63);
            startBttn.TabIndex = 1;
            startBttn.Text = "Start";
            startBttn.UseVisualStyleBackColor = false;
            startBttn.Click += button1_Click;
            // 
            // helpBttn
            // 
            helpBttn.BackColor = SystemColors.ActiveCaption;
            helpBttn.Cursor = Cursors.Hand;
            helpBttn.FlatStyle = FlatStyle.Popup;
            helpBttn.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            helpBttn.Location = new Point(337, 291);
            helpBttn.Margin = new Padding(3, 4, 3, 4);
            helpBttn.Name = "helpBttn";
            helpBttn.Size = new Size(243, 63);
            helpBttn.TabIndex = 2;
            helpBttn.Text = "How to play";
            helpBttn.UseVisualStyleBackColor = false;
            helpBttn.Click += helpBttn_Click;
            // 
            // exitBttn
            // 
            exitBttn.BackColor = SystemColors.ActiveCaption;
            exitBttn.Cursor = Cursors.Hand;
            exitBttn.FlatStyle = FlatStyle.Popup;
            exitBttn.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exitBttn.Location = new Point(337, 417);
            exitBttn.Margin = new Padding(3, 4, 3, 4);
            exitBttn.Name = "exitBttn";
            exitBttn.Size = new Size(243, 62);
            exitBttn.TabIndex = 3;
            exitBttn.Text = "Exit";
            exitBttn.UseVisualStyleBackColor = false;
            exitBttn.Click += exitBttn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(325, 559);
            label8.Name = "label8";
            label8.Size = new Size(264, 19);
            label8.TabIndex = 10;
            label8.Text = "©Made by Rennie and Stephie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(exitBttn);
            Controls.Add(helpBttn);
            Controls.Add(startBttn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startBttn;
        private Button helpBttn;
        private Button exitBttn;
        private Label label8;
    }
}