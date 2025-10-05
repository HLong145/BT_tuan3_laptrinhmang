namespace FormDNDK
{
    partial class FormDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_sdtmail = new TextBox();
            tb_pass = new TextBox();
            btn_dangnhap = new Button();
            cb_remember = new CheckBox();
            btn_forgotpass = new Button();
            btn_taotk = new Button();
            cb_captcha = new CheckBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 33);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 82);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 1;
            label2.Text = "Đăng nhập để tiếp tục";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 140);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 2;
            label3.Text = "SỐ ĐIỆN THOẠI HAY EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 233);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "MẬT KHẨU";
            // 
            // tb_sdtmail
            // 
            tb_sdtmail.Location = new Point(78, 179);
            tb_sdtmail.Name = "tb_sdtmail";
            tb_sdtmail.Size = new Size(236, 27);
            tb_sdtmail.TabIndex = 4;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(78, 277);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(236, 27);
            tb_pass.TabIndex = 5;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.Teal;
            btn_dangnhap.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.ForeColor = SystemColors.ButtonHighlight;
            btn_dangnhap.Location = new Point(78, 352);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(236, 44);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "ĐĂNG NHẬP";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // cb_remember
            // 
            cb_remember.AutoSize = true;
            cb_remember.Location = new Point(15, 432);
            cb_remember.Name = "cb_remember";
            cb_remember.Size = new Size(129, 24);
            cb_remember.TabIndex = 7;
            cb_remember.Text = "Remember me";
            cb_remember.UseVisualStyleBackColor = true;
            // 
            // btn_forgotpass
            // 
            btn_forgotpass.BackColor = Color.LightCyan;
            btn_forgotpass.FlatAppearance.BorderSize = 0;
            btn_forgotpass.FlatStyle = FlatStyle.Flat;
            btn_forgotpass.Location = new Point(192, 432);
            btn_forgotpass.Name = "btn_forgotpass";
            btn_forgotpass.Size = new Size(221, 29);
            btn_forgotpass.TabIndex = 8;
            btn_forgotpass.Text = "FORGOT PASSWORD?";
            btn_forgotpass.UseVisualStyleBackColor = false;
            btn_forgotpass.Click += btn_forgotpass_Click;
            // 
            // btn_taotk
            // 
            btn_taotk.BackColor = Color.LightCyan;
            btn_taotk.FlatAppearance.BorderSize = 0;
            btn_taotk.FlatStyle = FlatStyle.Flat;
            btn_taotk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_taotk.Location = new Point(78, 467);
            btn_taotk.Name = "btn_taotk";
            btn_taotk.Size = new Size(221, 31);
            btn_taotk.TabIndex = 9;
            btn_taotk.Text = "TẠO TÀI KHOẢN";
            btn_taotk.UseVisualStyleBackColor = false;
            btn_taotk.Click += btn_taotk_Click;
            // 
            // cb_captcha
            // 
            cb_captcha.AutoSize = true;
            cb_captcha.BackColor = SystemColors.ControlLight;
            cb_captcha.FlatStyle = FlatStyle.Popup;
            cb_captcha.Location = new Point(88, 516);
            cb_captcha.Name = "cb_captcha";
            cb_captcha.Size = new Size(131, 24);
            cb_captcha.TabIndex = 10;
            cb_captcha.Text = "I'm not a robot ";
            cb_captcha.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = Properties.Resources.RecaptchaLogo_svg;
            pictureBox1.Location = new Point(246, 504);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(78, 504);
            button1.Name = "button1";
            button1.Size = new Size(221, 48);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.png_clipart_white_telephone_logo_computer_icons_telephone_mobile_phones_telephone_number_miscellaneous_text_thumbnail_removebg_preview;
            pictureBox4.Location = new Point(320, 168);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2903837;
            pictureBox2.Location = new Point(320, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images_removebg_preview;
            pictureBox5.Location = new Point(374, 168);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_UIT_updated_svg;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(427, 682);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(cb_captcha);
            Controls.Add(btn_taotk);
            Controls.Add(btn_forgotpass);
            Controls.Add(cb_remember);
            Controls.Add(btn_dangnhap);
            Controls.Add(tb_pass);
            Controls.Add(tb_sdtmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_sdtmail;
        private TextBox tb_pass;
        private Button btn_dangnhap;
        private CheckBox cb_remember;
        private Button btn_forgotpass;
        private Button btn_taotk;
        private CheckBox cb_captcha;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}