namespace QLyCHBanDoAnVat
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
            lbTenCH = new Label();
            txtLoginName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btDangNhap = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbTenCH
            // 
            lbTenCH.Location = new Point(0, 0);
            lbTenCH.Margin = new Padding(2, 0, 2, 0);
            lbTenCH.Name = "lbTenCH";
            lbTenCH.Size = new Size(77, 18);
            lbTenCH.TabIndex = 6;
            // 
            // txtLoginName
            // 
            txtLoginName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginName.Location = new Point(585, 238);
            txtLoginName.Margin = new Padding(2, 2, 2, 2);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(342, 47);
            txtLoginName.TabIndex = 1;
            txtLoginName.TextChanged += txtLoginName_TextChanged;
            txtLoginName.KeyPress += txtLoginName_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(585, 339);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(342, 47);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 3;
            label1.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(212, 339);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 41);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // btDangNhap
            // 
            btDangNhap.Location = new Point(511, 438);
            btDangNhap.Margin = new Padding(2, 2, 2, 2);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(134, 60);
            btDangNhap.TabIndex = 5;
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(475, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 81);
            label3.TabIndex = 7;
            label3.Text = "AELSB";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(556, 446);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 570);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtLoginName);
            Controls.Add(lbTenCH);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "AELSB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTenCH;
        private TextBox txtLoginName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btDangNhap;
        private Label label3;
        private PictureBox pictureBox1;
    }
}