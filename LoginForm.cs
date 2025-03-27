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
    public partial class LoginForm : Form
    {
        public GymContext context;
        public LoginForm()
        {
            InitializeComponent();
            context = new GymContext();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var Email = email_txt.Text;
            var Password = pass_txt.Text;

            if (Email.IsNullOrEmpty() || Password.IsNullOrEmpty())
            {
                MessageBox.Show("Email Or Password Or Both Are Empty !!");
                return;
            }
            bool Exist = context.Members.Where(e => e.Email.ToLower() == Email.ToLower() && e.Password == Password).Any();

            if (Exist)
            {
                this.Hide();
                int id = context.Members.Where(x => x.Email == Email).FirstOrDefault().MemberId;
                MainGymForm mainGymForm = new MainGymForm(id);
                mainGymForm.Show();
            }
            else
            {
                MessageBox.Show("Email Or Password is incorrect !!");
            }
        }

        private void reg_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
