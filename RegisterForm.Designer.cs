namespace GymWorld
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pass_txt = new TextBox();
            email_txt = new TextBox();
            comboBox1 = new ComboBox();
            name_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            reg_btn = new Button();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pass_txt
            // 
            pass_txt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            pass_txt.Location = new Point(276, 240);
            pass_txt.Name = "pass_txt";
            pass_txt.PasswordChar = '*';
            pass_txt.Size = new Size(198, 39);
            pass_txt.TabIndex = 2;
            // 
            // email_txt
            // 
            email_txt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            email_txt.Location = new Point(276, 171);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(198, 39);
            email_txt.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(276, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 40);
            comboBox1.TabIndex = 3;
            // 
            // name_txt
            // 
            name_txt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            name_txt.Location = new Point(276, 103);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(198, 39);
            name_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 103);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 171);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // reg_btn
            // 
            reg_btn.BackColor = Color.DarkRed;
            reg_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            reg_btn.ForeColor = Color.White;
            reg_btn.Location = new Point(250, 411);
            reg_btn.Name = "reg_btn";
            reg_btn.Size = new Size(161, 55);
            reg_btn.TabIndex = 8;
            reg_btn.Text = "Register";
            reg_btn.UseVisualStyleBackColor = false;
            reg_btn.Click += reg_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 240);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(183, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 43);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 298);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 7;
            label4.Text = "Membership";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            linkLabel1.ForeColor = SystemColors.ControlText;
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(392, 352);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 32);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(433, 43);
            label7.Name = "label7";
            label7.Size = new Size(207, 45);
            label7.TabIndex = 13;
            label7.Text = "Become VIP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(214, 352);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 10;
            label5.Text = "Already Have ?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pass_txt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(reg_btn);
            groupBox1.Controls.Add(email_txt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(name_txt);
            groupBox1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(145, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 491);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 159);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-41, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 159);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 542);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox pass_txt;
        private TextBox email_txt;
        private ComboBox comboBox1;
        private TextBox name_txt;
        private Label label1;
        private Label label2;
        private Button reg_btn;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label5;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}