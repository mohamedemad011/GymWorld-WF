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
    public partial class RegisterForm : Form
    {
        public GymContext context;
        public RegisterForm()
        {
            InitializeComponent();
            context = new GymContext();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            var Memberships = context.Memberships.ToList();
            comboBox1.DataSource = Memberships;
            comboBox1.ValueMember = "MembershipId";
            comboBox1.DisplayMember = "Type";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            var Name = name_txt.Text;
            var Email = email_txt.Text;
            var Pass = pass_txt.Text;
            var contain = comboBox1.Text;
            var MembershipId = (int) comboBox1.SelectedValue;
            
            if(Name.IsNullOrEmpty() || Email.IsNullOrEmpty() || Pass.IsNullOrEmpty()
                || contain.IsNullOrEmpty())
            {
                MessageBox.Show("Some Fields Are Empty, Fill Them !!");
                return;
            }
            Member member = new Member();   
            member.Name = Name;
            member.Email = Email;
            member.Password = Pass;
            member.MembershipId = MembershipId;
            
            context.Members.Add(member);
            context.SaveChanges();
            MessageBox.Show("Registered Successfully !! ");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
