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
            btn_tieptuc = new Button();
            btn_dangnhap = new Button();
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
            tb_ten.Size = new Size(255, 27);
            tb_ten.TabIndex = 7;
            tb_ten.TextChanged += tb_ten_TextChanged;
            // 
            // btn_tieptuc
            // 
            btn_tieptuc.BackColor = Color.DarkCyan;
            btn_tieptuc.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tieptuc.ForeColor = SystemColors.ButtonHighlight;
            btn_tieptuc.Location = new Point(106, 242);
            btn_tieptuc.Name = "btn_tieptuc";
            btn_tieptuc.Size = new Size(223, 38);
            btn_tieptuc.TabIndex = 11;
            btn_tieptuc.Text = "TIẾP TỤC";
            btn_tieptuc.UseVisualStyleBackColor = false;
            btn_tieptuc.Click += btn_tieptuc_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.DarkCyan;
            btn_dangnhap.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.ForeColor = SystemColors.ButtonHighlight;
            btn_dangnhap.Location = new Point(106, 298);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(223, 42);
            btn_dangnhap.TabIndex = 12;
            btn_dangnhap.Text = "QUAY LẠI ĐĂNG NHẬP";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(440, 429);
            Controls.Add(btn_dangnhap);
            Controls.Add(btn_tieptuc);
            Controls.Add(tb_ten);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Margin = new Padding(2);
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
        private Button btn_tieptuc;
        private Button btn_dangnhap;
    }
}