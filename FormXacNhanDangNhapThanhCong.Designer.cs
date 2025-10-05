namespace FormDNDK
{
    partial class FormXacNhanDangNhapThanhCong
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
            lb_Welcome = new Label();
            btn_dangxuat = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lb_Welcome
            // 
            lb_Welcome.AutoSize = true;
            lb_Welcome.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Welcome.Location = new Point(163, 66);
            lb_Welcome.Name = "lb_Welcome";
            lb_Welcome.Size = new Size(127, 31);
            lb_Welcome.TabIndex = 0;
            lb_Welcome.Text = "Welcome!";
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.BackColor = Color.Aquamarine;
            btn_dangxuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangxuat.Location = new Point(376, 12);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(144, 29);
            btn_dangxuat.TabIndex = 2;
            btn_dangxuat.Text = "ĐĂNG XUẤT";
            btn_dangxuat.UseVisualStyleBackColor = false;
            btn_dangxuat.Click += btn_dangxuat_Click;
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
            // FormXacNhanDangNhapThanhCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(525, 581);
            Controls.Add(pictureBox4);
            Controls.Add(btn_dangxuat);
            Controls.Add(lb_Welcome);
            Name = "FormXacNhanDangNhapThanhCong";
            Text = "FormXacNhanDangNhapThanhCong";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Welcome;
        private Button btn_dangxuat;
        private PictureBox pictureBox4;
    }
}