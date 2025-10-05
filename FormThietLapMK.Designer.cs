namespace FormDNDK
{
    partial class FormThietLapMK
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
            label4 = new Label();
            tb_pass = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            btn_hoantat = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(276, 31);
            label1.TabIndex = 2;
            label1.Text = "Thiết lập mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 93);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 5;
            label4.Text = "MẬT KHẨU MỚI";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(110, 128);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(266, 27);
            tb_pass.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 202);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 171);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 11;
            label2.Text = "XÁC NHẬN MẬT KHẨU MỚI";
            // 
            // btn_hoantat
            // 
            btn_hoantat.BackColor = Color.DarkCyan;
            btn_hoantat.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hoantat.ForeColor = SystemColors.ButtonHighlight;
            btn_hoantat.Location = new Point(134, 271);
            btn_hoantat.Name = "btn_hoantat";
            btn_hoantat.Size = new Size(223, 38);
            btn_hoantat.TabIndex = 13;
            btn_hoantat.Text = "HOÀN TẤT";
            btn_hoantat.UseVisualStyleBackColor = false;
            btn_hoantat.Click += btn_hoantat_Click;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2903837;
            pictureBox2.Location = new Point(382, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2903837;
            pictureBox1.Location = new Point(382, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FormThietLapMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(512, 381);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(btn_hoantat);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(tb_pass);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormThietLapMK";
            Text = "FormThietLapMK";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox tb_pass;
        private TextBox textBox1;
        private Label label2;
        private Button btn_hoantat;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}