namespace FormDNDK
{
    partial class FormChinh
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
            btn_formdangnhap = new Button();
            btn_formdangky = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 80);
            label1.Name = "label1";
            label1.Size = new Size(216, 41);
            label1.TabIndex = 0;
            label1.Text = "CHÀO MỪNG";
            // 
            // btn_formdangnhap
            // 
            btn_formdangnhap.BackColor = Color.Aquamarine;
            btn_formdangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_formdangnhap.Location = new Point(117, 168);
            btn_formdangnhap.Name = "btn_formdangnhap";
            btn_formdangnhap.Size = new Size(144, 29);
            btn_formdangnhap.TabIndex = 1;
            btn_formdangnhap.Text = "ĐĂNG NHẬP";
            btn_formdangnhap.UseVisualStyleBackColor = false;
            btn_formdangnhap.Click += btn_formdangnhap_Click;
            // 
            // btn_formdangky
            // 
            btn_formdangky.BackColor = Color.Aquamarine;
            btn_formdangky.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_formdangky.Location = new Point(350, 168);
            btn_formdangky.Name = "btn_formdangky";
            btn_formdangky.Size = new Size(144, 29);
            btn_formdangky.TabIndex = 2;
            btn_formdangky.Text = "ĐĂNG KÝ";
            btn_formdangky.UseVisualStyleBackColor = false;
            btn_formdangky.Click += btn_formdangky_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Logo_UIT_updated_svg;
            pictureBox4.Location = new Point(33, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(650, 293);
            Controls.Add(pictureBox4);
            Controls.Add(btn_formdangky);
            Controls.Add(btn_formdangnhap);
            Controls.Add(label1);
            Name = "FormChinh";
            Text = "FormChinh";
            Load += FormChinh_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_formdangnhap;
        private Button btn_formdangky;
        private PictureBox pictureBox4;
    }
}