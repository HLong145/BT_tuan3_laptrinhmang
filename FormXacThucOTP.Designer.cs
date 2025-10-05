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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btn_dangky = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(254, 38);
            label1.TabIndex = 1;
            label1.Text = "Xác thực mã OTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(589, 25);
            label2.TabIndex = 5;
            label2.Text = "Vui lòng nhập mã OTP vừa gửi tới email hoặc số điện thoại của bạn ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(71, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 50);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(520, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 50);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(248, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(55, 50);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(160, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(55, 50);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(426, 140);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(55, 50);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(339, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(55, 50);
            textBox6.TabIndex = 11;
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.DarkCyan;
            btn_dangky.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangky.ForeColor = SystemColors.ButtonHighlight;
            btn_dangky.Location = new Point(170, 240);
            btn_dangky.Margin = new Padding(4);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(279, 48);
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
            button1.Location = new Point(170, 305);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(279, 48);
            button1.TabIndex = 13;
            button1.Text = "GỬI LẠI MÃ";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormXacThucOTP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(640, 476);
            Controls.Add(button1);
            Controls.Add(btn_dangky);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormXacThucOTP";
            Text = "FormXacThucOTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btn_dangky;
        private Button button1;
    }
}