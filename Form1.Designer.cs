namespace baithuchanh3_freeuts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lb_cuaso = new Label();
            lb_Dangnhap = new Label();
            lb_MatKhau = new Label();
            txt_dangnhap = new TextBox();
            txt_MatKhau = new TextBox();
            checkBox1 = new CheckBox();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
            tool_ThongBao = new ToolTip(components);
            help_Thongbao = new HelpProvider();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 524);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_cuaso
            // 
            lb_cuaso.AutoSize = true;
            lb_cuaso.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_cuaso.Location = new Point(676, 49);
            lb_cuaso.Name = "lb_cuaso";
            lb_cuaso.Size = new Size(254, 38);
            lb_cuaso.TabIndex = 1;
            lb_cuaso.Text = "Cửa sổ đăng nhập";
            // 
            // lb_Dangnhap
            // 
            lb_Dangnhap.AutoSize = true;
            lb_Dangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Dangnhap.Location = new Point(549, 166);
            lb_Dangnhap.Name = "lb_Dangnhap";
            lb_Dangnhap.Size = new Size(138, 25);
            lb_Dangnhap.TabIndex = 2;
            lb_Dangnhap.Text = "Tên đăng nhập";
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MatKhau.Location = new Point(549, 224);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(93, 25);
            lb_MatKhau.TabIndex = 3;
            lb_MatKhau.Text = "Mật khẩu";
            // 
            // txt_dangnhap
            // 
            txt_dangnhap.Location = new Point(710, 164);
            txt_dangnhap.Name = "txt_dangnhap";
            txt_dangnhap.Size = new Size(273, 27);
            txt_dangnhap.TabIndex = 5;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(710, 224);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(273, 27);
            txt_MatKhau.TabIndex = 6;
            txt_MatKhau.TextChanged += txt_MatKhau_TextChanged;
            txt_MatKhau.KeyPress += txt_MatKhau_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(710, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(610, 347);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(119, 50);
            btn_DangNhap.TabIndex = 8;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(824, 347);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(119, 50);
            btn_Thoat.TabIndex = 9;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 468);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhấn F1 để được hướng dẫn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1046, 767);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(checkBox1);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_dangnhap);
            Controls.Add(label4);
            Controls.Add(lb_MatKhau);
            Controls.Add(lb_Dangnhap);
            Controls.Add(lb_cuaso);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_cuaso;
        private Label lb_Dangnhap;
        private Label lb_MatKhau;
        private TextBox txt_dangnhap;
        private TextBox txt_MatKhau;
        private CheckBox checkBox1;
        private Button btn_DangNhap;
        private Button btn_Thoat;
        private ToolTip tool_ThongBao;
        private HelpProvider help_Thongbao;
        private Label label4;
    }
}