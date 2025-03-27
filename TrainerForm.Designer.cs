namespace GymWorld
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            button4 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(636, 337);
            button2.Name = "button2";
            button2.Size = new Size(184, 62);
            button2.TabIndex = 7;
            button2.Text = "Leave";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(636, 337);
            button1.Name = "button1";
            button1.Size = new Size(184, 62);
            button1.TabIndex = 6;
            button1.Text = "Pick";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(94, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(453, 322);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuText;
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 38);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += trainerbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(585, 241);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 8;
            label1.Text = "You Don't Have a Trainer";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(804, 544);
            label3.Name = "label3";
            label3.Size = new Size(103, 45);
            label3.TabIndex = 9;
            label3.Text = "VIP";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(33, 532);
            button4.Name = "button4";
            button4.Size = new Size(139, 57);
            button4.TabIndex = 13;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(636, 273);
            label2.Name = "label2";
            label2.Size = new Size(208, 38);
            label2.TabIndex = 14;
            label2.Text = "IFPP MoEmad";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 70);
            panel1.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(105, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 35);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(39, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 35);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(942, 611);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(comboBox1);
            Name = "TrainerForm";
            Text = "Mo Salama";
            Load += TrainerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Button button4;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}