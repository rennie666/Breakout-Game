using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova2
{
    using System.Diagnostics.Eventing.Reader;
    using System.Drawing;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

    public partial class Data : Form
    {
        string avatar;
        string color;
        string username;
        public static string datUsername;
        public static string mode;
        public static string imageName;

        public Data()
        {
            InitializeComponent();
            colorComboBox.Enabled = false;
            startBttn.Enabled = true;
            datUsername = textBox1.Text;

        }

        private void Data_Load(object sender, EventArgs e)
        {
            avatarComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            avatarComboBox.Items.AddRange(new string[] { "Triangle", "Circle", "Square" });
            colorComboBox.Items.AddRange(new string[] { "Red", "Green", "Blue" });
            modeComboBox.Items.AddRange(new string[] { "Easy", "Normal", "Hard" });

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            datUsername = textBox1.Text.Trim();
            UpdateStatusLabel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorComboBox.Enabled = avatarComboBox.SelectedIndex != -1;
            UpdateAvatarPicture();
            UpdateStatusLabel();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAvatarPicture();
            UpdateStatusLabel();
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel();
        }


        private bool AllFieldsFilled()
        {
            bool usernameFilled = !string.IsNullOrEmpty(textBox1.Text.Trim());
            bool avatarSelected = avatarComboBox.SelectedIndex != -1;
            bool colorSelected = colorComboBox.SelectedIndex != -1;
            bool modeSelected = modeComboBox.SelectedIndex != -1;

            return usernameFilled && avatarSelected && colorSelected && modeSelected;
        }


        private void UpdateAvatarPicture()
        {
            avatar = avatarComboBox.SelectedItem?.ToString();
            color = colorComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(avatar) || string.IsNullOrEmpty(color))
            {
                pictureBox1.Image = Properties.Resources.noImagee;
                return;
            }

            imageName = $"{color.ToLower()}_{avatar.ToLower()}";


            switch (imageName)
            {
                case "red_triangle":
                    pictureBox1.Image = Properties.Resources._red_triangle;
                    break;
                case "green_triangle":
                    pictureBox1.Image = Properties.Resources._green_triangle;
                    break;
                case "blue_triangle":
                    pictureBox1.Image = Properties.Resources._blue_triangle;
                    break;
                case "red_circle":
                    pictureBox1.Image = Properties.Resources._red_circle;
                    break;
                case "green_circle":
                    pictureBox1.Image = Properties.Resources._green_circle;
                    break;
                case "blue_circle":
                    pictureBox1.Image = Properties.Resources._blue_circle;
                    break;
                case "red_square":
                    pictureBox1.Image = Properties.Resources._red_square;
                    break;
                case "green_square":
                    pictureBox1.Image = Properties.Resources._green_square;
                    break;
                case "blue_square":
                    pictureBox1.Image = Properties.Resources._blue_square;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.noImage;
                    break;
            }
        }

        private void UpdateStatusLabel()
        {
            username = textBox1.Text.Trim();
            avatar = avatarComboBox.SelectedItem?.ToString();
            color = colorComboBox.SelectedItem?.ToString();
            mode = modeComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(avatar) && !string.IsNullOrEmpty(color) && !string.IsNullOrEmpty(mode))
            {
                label6.Text = $"{username} is playing with {color} {avatar} on {mode} mode.";
            }
            else
            {
                label6.Text = "";
            }
        }
        private void ShowErrorList()
        {
            List<string> errorMessages = new List<string>();

            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                errorMessages.Add("Missing username!");
            }

            if (avatarComboBox.SelectedIndex == -1)
            {
                errorMessages.Add("Choose your avatar!");
            }

            if (colorComboBox.SelectedIndex == -1)
            {
                errorMessages.Add("Choose the color of your avatar!");
            }

            if (modeComboBox.SelectedIndex == -1)
            {
                errorMessages.Add("Choose the mode you want to play on!");
            }

            if (errorMessages.Any())
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllFieldsFilled())
                {
                    Game game = new Game();
                    game.Show();
                }
                else
                {
                    ShowErrorList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void backBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

