using GymWorld.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GymWorld
{
    public partial class TrainingForm : Form
    {
        public int UserId;
        public GymContext context;
        public TrainingForm(int id)
        {
            UserId = id;
            InitializeComponent();
            context = new GymContext();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            var curTrainerId = context.Members.Where(x => x.MemberId == UserId)
                .Select(x => x.TrainerId).FirstOrDefault();
            if (curTrainerId == 7)
            {
                comboBox1.Items.Add("Biceps");
                comboBox1.Items.Add("Shoulder");
            }
            else if (curTrainerId == 1)
            {
                comboBox1.Items.Add("ABS Six Pack");
                comboBox1.Items.Add("Bench Press");
                comboBox1.Items.Add("Triceps Dumbel");
                comboBox1.Items.Add("Front Leg");
            }

            // Optionally set a default selected item (if needed)
            comboBox1.SelectedIndex = 0;

            // Set PictureBox SizeMode to StretchImage to stretch the GIF to fit
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display the first image based on the default selection
            DisplayImageBasedOnComboBoxSelection();
        }
        private void DisplayImageBasedOnComboBoxSelection()
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Select the corresponding image based on the ComboBox selection
            var curTrainerId = context.Members.Where(x => x.MemberId == UserId)
                .Select(x => x.TrainerId).FirstOrDefault();
            string imagePath = "";
            if (curTrainerId == 7)
            {
                imagePath = selectedItem switch
                {
                    "Biceps" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer3\\biceps.gif",
                    "Shoulder" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer3\\shoulder.gif",
                    _ => throw new ArgumentException("Unknown selection")
                };
            }
            else if (curTrainerId == 1)
            {
                imagePath = selectedItem switch
                {
                    "ABS Six Pack" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer1\\abs.gif",
                    "Bench Press" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer1\\chest.gif",
                    "Triceps Dumbel" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer1\\triceps.gif",
                    "Front Leg" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer1\\Leg.gif",

                    _ => throw new ArgumentException("Unknown selection")
                };
            }
            else
            {

            }
            // Load the selected GIF into the PictureBox
            pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayImageBasedOnComboBoxSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Close();
            lg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainGymForm mgf = new MainGymForm(UserId);
            mgf.Show();
            this.Close();
        }
    }
}
