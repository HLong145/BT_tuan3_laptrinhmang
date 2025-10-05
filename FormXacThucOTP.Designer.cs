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
            btn_dangky = new Button();
            button1 = new Button();
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
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.DarkCyan;
            btn_dangky.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangky.ForeColor = SystemColors.ButtonHighlight;
            btn_dangky.Location = new Point(136, 192);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(223, 38);
            btn_dangky.TabIndex = 12;
            btn_dangky.Text = "TIẾP TỤC";
            btn_dangky.UseVisualStyleBackColor = false;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(136, 244);
            button1.Name = "button1";
            button1.Size = new Size(223, 38);
            button1.TabIndex = 13;
            button1.Text = "GỬI LẠI MÃ";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormXacThucOTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(512, 381);
            Controls.Add(button1);
            Controls.Add(btn_dangky);
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
        private Button btn_dangky;
        private Button button1;
    }
}