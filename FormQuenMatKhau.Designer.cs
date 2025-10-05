namespace FormDNDK
{
    partial class FormQuenMatKhau
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_ten = new TextBox();
            btn_dangky = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 29);
            label3.Name = "label3";
            label3.Size = new Size(201, 31);
            label3.TabIndex = 3;
            label3.Text = "Quên mật khẩu ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(421, 40);
            label2.TabIndex = 4;
            label2.Text = "Điền email hoặc số điện thoại gắn với tài khoản của bạn để \r\nnhận đường dẫn thay đổi mật khẩu";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 145);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Email/SĐT";
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(95, 182);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(246, 27);
            tb_ten.TabIndex = 7;
            tb_ten.TextChanged += tb_ten_TextChanged;
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.DarkCyan;
            btn_dangky.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangky.ForeColor = SystemColors.ButtonHighlight;
            btn_dangky.Location = new Point(106, 242);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(223, 38);
            btn_dangky.TabIndex = 11;
            btn_dangky.Text = "TIẾP TỤC";
            btn_dangky.UseVisualStyleBackColor = false;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(106, 298);
            button1.Name = "button1";
            button1.Size = new Size(223, 42);
            button1.TabIndex = 12;
            button1.Text = "QUAY LẠI ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(440, 429);
            Controls.Add(button1);
            Controls.Add(btn_dangky);
            Controls.Add(tb_ten);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormQuenMatKhau";
            Text = "FormQuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_ten;
        private Button btn_dangky;
        private Button button1;
    }
}