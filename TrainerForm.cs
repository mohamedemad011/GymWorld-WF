using GymWorld.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymWorld
{
    public partial class TrainerForm : Form
    {
        public int curId;
        public GymContext context;
        public TrainerForm(int id)
        {
            context = new GymContext();
            InitializeComponent();
            curId = id;
            comboBox1.Items.Add("IFPP MoEmad");
            comboBox1.Items.Add("IFPP MoSalama");
            comboBox1.Items.Add("IFPP MoKhaled");

            // Optionally set a default selected item (if needed)
            comboBox1.SelectedIndex = 0;

            // Set PictureBox SizeMode to StretchImage to stretch the GIF to fit
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display the first image based on the default selection
            DisplayImageBasedOnComboBoxSelection();
        }
        private void DisplayImageBasedOnComboBoxSelection()
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Select the corresponding image based on the ComboBox selection
            string imagePath = selectedItem switch
            {
                "IFPP MoEmad" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer4.gif",
                "IFPP MoSalama" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer5.gif",
                "IFPP MoKhaled" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer6.gif",
                _ => throw new ArgumentException("Unknown selection")
            };

            // Load the selected GIF into the PictureBox
            pictureBox3.Image = Image.FromFile(imagePath);
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {

            var curTrainer = context.Members.Where(x => x.MemberId == curId && x.TrainerId != null)
                .Select(x => x.Trainer.Name)
                .FirstOrDefault();
            if (curTrainer != null)
            {
                label1.Text = $"You Have a Trainer Called";
                label2.Text = curTrainer;
                label2.Visible = true;
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int trainerId = 0;
            if (selectedItem.Equals("IFPP MoEmad")) trainerId = 1;
            else if (selectedItem.Equals("IFPP MoSalama")) trainerId = 6;
            else { trainerId = 7; }

            var curMember = context.Members.Where(x => x.MemberId == curId).FirstOrDefault();
            curMember.TrainerId = null;

            context.Members.Update(curMember);
            context.SaveChanges();
            TrainerForm tf = new TrainerForm(curId);
            this.Close();
            tf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int trainerId = 0;
            if (selectedItem.Equals("IFPP MoEmad")) trainerId = 1;
            else if (selectedItem.Equals("IFPP MoSalama")) trainerId = 6;
            else { trainerId = 7; }

            var curMember = context.Members.Where(x => x.MemberId == curId).FirstOrDefault();
            curMember.TrainerId = trainerId;

            context.Members.Update(curMember);
            context.SaveChanges();
            TrainerForm tf = new TrainerForm(curId);
            this.Close();
            tf.Show();
        }

        private void trainerbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayImageBasedOnComboBoxSelection();
            string selectedItem = comboBox1.SelectedItem.ToString();
            int trainerId = 0;
            if (selectedItem.Equals("IFPP MoEmad")) trainerId = 1;
            else if (selectedItem.Equals("IFPP MoSalama")) trainerId = 6;
            else { trainerId = 7; }

            label1.Visible = true;
            label2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            //MessageBox.Show("test");

            var curTrainer = context.Members.Where(x => x.MemberId == curId && x.TrainerId != null)
               .Select(x => new { x.Trainer.Name, x.TrainerId })
               .FirstOrDefault();
            if (curTrainer is not null && curTrainer.Name.IsNullOrEmpty() == false)
            {
                label1.Text = $"You Have a Trainer Called";
                label2.Text = curTrainer.Name;
                label2.Visible = true;
            }

            var trainers = context.Members.Where(x => x.MemberId == curId).Select(z => z.Trainer.Name)
                .FirstOrDefault();


            if (curTrainer is not null && selectedItem.Equals(curTrainer.Name))
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
                button1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm lgn = new LoginForm();
            lgn.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainGymForm mgf = new MainGymForm(curId);
            mgf.Show();
            this.Close();
        }
    }
}
