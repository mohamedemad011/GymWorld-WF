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

namespace GymWorld
{
    public partial class ClassForm : Form
    {
        public int curId;
        public GymContext context;
        public ClassForm(int id)
        {
            curId = id;
            context = new GymContext();
            InitializeComponent();
            comboBox1.Items.Add("Zomba");
            comboBox1.Items.Add("Bomba");
            comboBox1.Items.Add("Homba");
            this.StartPosition = FormStartPosition.CenterScreen;

            // Optionally set a default selected item (if needed)
            comboBox1.SelectedIndex = 0;

            // Set PictureBox SizeMode to StretchImage to stretch the GIF to fit
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Display the first image based on the default selection
            DisplayImageBasedOnComboBoxSelection();
        }
        private void DisplayImageBasedOnComboBoxSelection()
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Select the corresponding image based on the ComboBox selection
            string imagePath = selectedItem switch
            {
                "Zomba" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym1.gif",
                "Bomba" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym2.gif",
                "Homba" => "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym3.gif",
                _ => throw new ArgumentException("Unknown selection")
            };

            // Load the selected GIF into the PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayImageBasedOnComboBoxSelection();
            var classes = context.MemberClasses.Where(x => x.MemberId == curId).Select(z => z.ClassId).ToList();
            string selectedItem = comboBox1.SelectedItem.ToString();

            button1.Visible = true;
            button2.Visible = false;
            foreach (var nowId in classes)
            {
                string className = context.Classes.Where(z => z.ClassId == nowId).Select(x => x.name).FirstOrDefault();

                if (className.Equals(selectedItem))
                {
                    button1.Visible = false;
                    button2.Visible = true;
                    break;
                }
            }
        }
        private void ClassForm_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string selectedItem = comboBox1.SelectedItem.ToString();
            int classId = 0;
            if (selectedItem.Equals("Zomba")) classId = 1;
            else if (selectedItem.Equals("Bomba")) classId = 2;
            else { classId = 3; }

            MemberClass memberClass = new MemberClass();
            memberClass.ClassId = classId;
            memberClass.MemberId = curId;
            context.MemberClasses.Add(memberClass);
            context.SaveChanges();
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int classId = 0;
            if (selectedItem.Equals("Zomba")) classId = 1;
            else if (selectedItem.Equals("Bomba")) classId = 2;
            else { classId = 3; }

            var curClassMem = context.MemberClasses.Where(x => x.ClassId == classId && x.MemberId == curId).FirstOrDefault();
            context.MemberClasses.Remove(curClassMem);
            context.SaveChanges();
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show(); this.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainGymForm mgf = new MainGymForm(curId);
            mgf.Show();
            this.Close();
        }
    }
}
