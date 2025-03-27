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
using Timer = System.Windows.Forms.Timer;

namespace GymWorld
{
    public partial class MainGymForm : Form
    {
        public GymContext context;
        public int UserId;
        private Timer timer;
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym1.gif",
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym2.gif",
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\gym3.gif"
        };
        //
        private string[] trainerPaths = new string[]
        {
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer4.gif",
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer5.gif",
            "C:\\Users\\dell\\source\\repos\\EntityFramework\\Day 3\\GymWorld\\imgs\\trainer6.gif"
        };
        public MainGymForm(int curId)
        {
            context = new GymContext();
            InitializeComponent();
            UserId = curId;

            pictureBox1.Image = Image.FromFile(imagePaths[currentImageIndex]);
            pictureBox2.Image = Image.FromFile(trainerPaths[currentImageIndex]);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.StartPosition = FormStartPosition.CenterScreen;



            // Initialize Timer
            timer = new Timer();
            timer.Interval = 1500;  // 3000 ms = 3 seconds
            timer.Tick += Timer_Tick;  // Handle the Tick event

            // Start the timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Change the image in the PictureBox
            pictureBox1.Image = Image.FromFile(imagePaths[currentImageIndex]);
            pictureBox2.Image = Image.FromFile(trainerPaths[currentImageIndex]);


            // Move to the next image index
            currentImageIndex++;

            // If we reach the end of the array, start over from the first image
            if (currentImageIndex >= imagePaths.Length)
            {
                currentImageIndex = 0;
            }
        }
        private void MainGymForm_Load(object sender, EventArgs e)
        {
            var curUser = context.Members.Where(u => u.MemberId == UserId).FirstOrDefault();
            label2.Text = curUser.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            ClassForm classForm = new ClassForm(UserId);
            classForm.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            TrainerForm trainerForm = new TrainerForm(UserId);

            trainerForm.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            TrainingForm trainerForm = new TrainingForm(UserId);

            trainerForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
