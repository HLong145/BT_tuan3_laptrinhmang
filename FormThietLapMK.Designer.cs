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
            btn_dangky = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(341, 38);
            label1.TabIndex = 2;
            label1.Text = "Thiết lập mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 5;
            label4.Text = "MẬT KHẨU MỚI";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(138, 160);
            tb_pass.Margin = new Padding(4);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(331, 31);
            tb_pass.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 253);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(331, 31);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 214);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 25);
            label2.TabIndex = 11;
            label2.Text = "XÁC NHẬN MẬT KHẨU MỚI";
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.DarkCyan;
            btn_dangky.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangky.ForeColor = SystemColors.ButtonHighlight;
            btn_dangky.Location = new Point(167, 339);
            btn_dangky.Margin = new Padding(4);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Size = new Size(279, 48);
            btn_dangky.TabIndex = 13;
            btn_dangky.Text = "HOÀN TẤT";
            btn_dangky.UseVisualStyleBackColor = false;
            // 
            // FormThietLapMK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(640, 476);
            Controls.Add(btn_dangky);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(tb_pass);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FormThietLapMK";
            Text = "FormThietLapMK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox tb_pass;
        private TextBox textBox1;
        private Label label2;
        private Button btn_dangky;
    }
}