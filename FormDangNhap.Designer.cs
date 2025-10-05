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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "Đăng nhập để tiếp tục";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(249, 25);
            label3.TabIndex = 2;
            label3.Text = "SỐ ĐIỆN THOẠI HAY EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 291);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 3;
            label4.Text = "MẬT KHẨU";
            label4.Click += label4_Click;
            // 
            // tb_sdtmail
            // 
            tb_sdtmail.Location = new Point(130, 224);
            tb_sdtmail.Margin = new Padding(4);
            tb_sdtmail.Name = "tb_sdtmail";
            tb_sdtmail.Size = new Size(294, 31);
            tb_sdtmail.TabIndex = 4;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(130, 346);
            tb_pass.Margin = new Padding(4);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(294, 31);
            tb_pass.TabIndex = 5;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.Teal;
            btn_dangnhap.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.ForeColor = SystemColors.ButtonHighlight;
            btn_dangnhap.Location = new Point(130, 440);
            btn_dangnhap.Margin = new Padding(4);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(295, 55);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "ĐĂNG NHẬP";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // cb_remember
            // 
            cb_remember.AutoSize = true;
            cb_remember.Location = new Point(51, 540);
            cb_remember.Margin = new Padding(4);
            cb_remember.Name = "cb_remember";
            cb_remember.Size = new Size(154, 29);
            cb_remember.TabIndex = 7;
            cb_remember.Text = "Remember me";
            cb_remember.UseVisualStyleBackColor = true;
            // 
            // btn_forgotpass
            // 
            btn_forgotpass.BackColor = Color.LightCyan;
            btn_forgotpass.FlatAppearance.BorderSize = 0;
            btn_forgotpass.FlatStyle = FlatStyle.Flat;
            btn_forgotpass.Location = new Point(272, 540);
            btn_forgotpass.Margin = new Padding(4);
            btn_forgotpass.Name = "btn_forgotpass";
            btn_forgotpass.Size = new Size(276, 36);
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
            btn_taotk.Location = new Point(130, 584);
            btn_taotk.Margin = new Padding(4);
            btn_taotk.Name = "btn_taotk";
            btn_taotk.Size = new Size(276, 39);
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
            cb_captcha.Location = new Point(142, 645);
            cb_captcha.Margin = new Padding(4);
            cb_captcha.Name = "cb_captcha";
            cb_captcha.Size = new Size(160, 29);
            cb_captcha.TabIndex = 10;
            cb_captcha.Text = "I'm not a robot ";
            cb_captcha.UseVisualStyleBackColor = false;
            cb_captcha.CheckedChanged += cb_captcha_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.RecaptchaLogo_svg;
            pictureBox1.Location = new Point(340, 630);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 60);
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
            button1.Location = new Point(130, 630);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(276, 60);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(550, 852);
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
            Margin = new Padding(4);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}