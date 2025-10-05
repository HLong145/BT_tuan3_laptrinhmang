namespace FormDNDK
{
    partial class FormXacThucOTP
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
            tb_s1 = new TextBox();
            tb_s6 = new TextBox();
            tb_s3 = new TextBox();
            tb_s2 = new TextBox();
            tb_s5 = new TextBox();
            tb_s4 = new TextBox();
            btn_tieptuc = new Button();
            btn_guilaima = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(206, 31);
            label1.TabIndex = 1;
            label1.Text = "Xác thực mã OTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(479, 20);
            label2.TabIndex = 5;
            label2.Text = "Vui lòng nhập mã OTP vừa gửi tới email hoặc số điện thoại của bạn ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_s1
            // 
            tb_s1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s1.Location = new Point(57, 112);
            tb_s1.Margin = new Padding(2);
            tb_s1.Name = "tb_s1";
            tb_s1.Size = new Size(45, 43);
            tb_s1.TabIndex = 6;
            // 
            // tb_s6
            // 
            tb_s6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s6.Location = new Point(416, 112);
            tb_s6.Margin = new Padding(2);
            tb_s6.Name = "tb_s6";
            tb_s6.Size = new Size(45, 43);
            tb_s6.TabIndex = 7;
            // 
            // tb_s3
            // 
            tb_s3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s3.Location = new Point(192, 112);
            tb_s3.Margin = new Padding(2);
            tb_s3.Name = "tb_s3";
            tb_s3.Size = new Size(45, 43);
            tb_s3.TabIndex = 8;
            // 
            // tb_s2
            // 
            tb_s2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s2.Location = new Point(128, 112);
            tb_s2.Margin = new Padding(2);
            tb_s2.Name = "tb_s2";
            tb_s2.Size = new Size(45, 43);
            tb_s2.TabIndex = 9;
            // 
            // tb_s5
            // 
            tb_s5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s5.Location = new Point(341, 112);
            tb_s5.Margin = new Padding(2);
            tb_s5.Name = "tb_s5";
            tb_s5.Size = new Size(45, 43);
            tb_s5.TabIndex = 10;
            // 
            // tb_s4
            // 
            tb_s4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_s4.Location = new Point(271, 112);
            tb_s4.Margin = new Padding(2);
            tb_s4.Name = "tb_s4";
            tb_s4.Size = new Size(45, 43);
            tb_s4.TabIndex = 11;
            // 
            // btn_tieptuc
            // 
            btn_tieptuc.BackColor = Color.DarkCyan;
            btn_tieptuc.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tieptuc.ForeColor = SystemColors.ButtonHighlight;
            btn_tieptuc.Location = new Point(136, 192);
            btn_tieptuc.Name = "btn_tieptuc";
            btn_tieptuc.Size = new Size(223, 38);
            btn_tieptuc.TabIndex = 12;
            btn_tieptuc.Text = "TIẾP TỤC";
            btn_tieptuc.UseVisualStyleBackColor = false;
            btn_tieptuc.Click += btn_tieptuc_Click;
            // 
            // btn_guilaima
            // 
            btn_guilaima.BackColor = Color.DarkCyan;
            btn_guilaima.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guilaima.ForeColor = SystemColors.ButtonHighlight;
            btn_guilaima.Location = new Point(136, 244);
            btn_guilaima.Name = "btn_guilaima";
            btn_guilaima.Size = new Size(223, 38);
            btn_guilaima.TabIndex = 13;
            btn_guilaima.Text = "GỬI LẠI MÃ";
            btn_guilaima.UseVisualStyleBackColor = false;
            btn_guilaima.Click += btn_guilaima_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Logo_UIT_updated_svg;
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // FormXacThucOTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(512, 381);
            Controls.Add(pictureBox4);
            Controls.Add(btn_guilaima);
            Controls.Add(btn_tieptuc);
            Controls.Add(tb_s4);
            Controls.Add(tb_s5);
            Controls.Add(tb_s2);
            Controls.Add(tb_s3);
            Controls.Add(tb_s6);
            Controls.Add(tb_s1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormXacThucOTP";
            Text = "FormXacThucOTP";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_s1;
        private TextBox tb_s6;
        private TextBox tb_s3;
        private TextBox tb_s2;
        private TextBox tb_s5;
        private TextBox tb_s4;
        private Button btn_tieptuc;
        private Button btn_guilaima;
        private PictureBox pictureBox4;
    }
}