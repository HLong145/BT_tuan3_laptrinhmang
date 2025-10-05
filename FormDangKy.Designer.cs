namespace FormDNDK
{
    partial class FormDangKy
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
            btn_formdn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_ten = new TextBox();
            tb_sdtmail = new TextBox();
            tb_pass = new TextBox();
            tb_passok = new TextBox();
            btn_dangky = new Button();
            cb_captcha = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Tạo tài khoản mới";
            // 
            // btn_formdn
            // 
            btn_formdn.FlatAppearance.BorderSize = 0;
            btn_formdn.FlatStyle = FlatStyle.Flat;
            btn_formdn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_formdn.Location = new Point(55, 82);
            btn_formdn.Name = "btn_formdn";
            btn_formdn.Size = new Size(414, 29);
            btn_formdn.TabIndex = 1;
            btn_formdn.Text = "Đã đăng ký? Đăng nhập tại đây";
            btn_formdn.UseVisualStyleBackColor = true;
            btn_formdn.Click += btn_formdn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 128);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 2;
            label2.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 210);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 3;
            label3.Text = "SỐ ĐIỆN THOẠI HAY EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 289);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "MẬT KHẨU";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(152, 368);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 5;
            label5.Text = "XÁC NHẬN MẬT KHẨU";
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(152, 162);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(203, 27);
            tb_ten.TabIndex = 6;
            // 
            // tb_sdtmail
            // 
            tb_sdtmail.Location = new Point(152, 244);
            tb_sdtmail.Name = "tb_sdtmail";
            tb_sdtmail.Size = new Size(203, 27);
            tb_sdtmail.TabIndex = 7;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(152, 328);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(203, 27);
            tb_pass.TabIndex = 8;
            // 
            // tb_passok
            // 
            tb_passok.Location = new Point(152, 409);
            tb_passok.Name = "tb_passok";
            tb_passok.PasswordChar = '*';
            tb_passok.Size = new Size(203, 27);
            tb_passok.TabIndex = 9;
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.DarkCyan;
            btn_dangky.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangky.ForeColor = SystemColors.ButtonHighlight;
            btn_dangky.Location = new Point(152, 461);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(203, 47);
            btn_dangky.TabIndex = 10;
            btn_dangky.Text = "ĐĂNG KÝ";
            btn_dangky.UseVisualStyleBackColor = false;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // cb_captcha
            // 
            cb_captcha.AutoSize = true;
            cb_captcha.BackColor = SystemColors.ControlLight;
            cb_captcha.Location = new Point(132, 538);
            cb_captcha.Name = "cb_captcha";
            cb_captcha.Size = new Size(130, 24);
            cb_captcha.TabIndex = 11;
            cb_captcha.Text = "I'm not a robot";
            cb_captcha.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 526);
            button1.Name = "button1";
            button1.Size = new Size(277, 47);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = Properties.Resources.RecaptchaLogo_svg;
            pictureBox1.Location = new Point(312, 526);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2903837;
            pictureBox2.Location = new Point(370, 311);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._2903837;
            pictureBox3.Location = new Point(370, 392);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.png_clipart_white_telephone_logo_computer_icons_telephone_mobile_phones_telephone_number_miscellaneous_text_thumbnail_removebg_preview;
            pictureBox4.Location = new Point(361, 232);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images_removebg_preview;
            pictureBox5.Location = new Point(412, 232);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Logo_UIT_updated_svg;
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(512, 619);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cb_captcha);
            Controls.Add(btn_dangky);
            Controls.Add(tb_passok);
            Controls.Add(tb_pass);
            Controls.Add(tb_sdtmail);
            Controls.Add(tb_ten);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_formdn);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormDangKy";
            Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_formdn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_ten;
        private TextBox tb_sdtmail;
        private TextBox tb_pass;
        private TextBox tb_passok;
        private Button btn_dangky;
        private CheckBox cb_captcha;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}