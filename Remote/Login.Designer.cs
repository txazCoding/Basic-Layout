namespace Remote
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            GlowLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(331, 161);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(331, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.AnimatedGIF = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.WhiteSmoke;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnLogin.BorderThickness = 1;
            btnLogin.CustomBorderColor = Color.White;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(64, 64, 64);
            btnLogin.FillColor2 = Color.FromArgb(64, 64, 64);
            btnLogin.FocusedColor = Color.FromArgb(64, 0, 64);
            btnLogin.Font = new Font("Verdana", 9.75F);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.Gray;
            btnLogin.HoverState.FillColor2 = Color.Gray;
            btnLogin.HoverState.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btnLogin.ImageAlign = HorizontalAlignment.Left;
            btnLogin.Location = new Point(331, 242);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.FromArgb(64, 0, 64);
            btnLogin.PressedDepth = 50;
            btnLogin.ShadowDecoration.BorderRadius = 10;
            btnLogin.ShadowDecoration.Color = Color.FromArgb(64, 0, 64);
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(100, 32);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseTransparentBackground = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // GlowLabel
            // 
            GlowLabel.AutoSize = true;
            GlowLabel.BackColor = Color.Transparent;
            GlowLabel.CausesValidation = false;
            GlowLabel.Font = new Font("Verdana", 11.25F);
            GlowLabel.ForeColor = Color.White;
            GlowLabel.Location = new Point(283, 161);
            GlowLabel.Name = "GlowLabel";
            GlowLabel.Size = new Size(42, 18);
            GlowLabel.TabIndex = 14;
            GlowLabel.Text = "User";
            GlowLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.Font = new Font("Verdana", 11.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 202);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 15;
            label1.Text = "Pass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(799, 448);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // guna2GradientButton4
            // 
            guna2GradientButton4.Animated = true;
            guna2GradientButton4.AnimatedGIF = true;
            guna2GradientButton4.BackColor = Color.Transparent;
            guna2GradientButton4.BorderColor = Color.WhiteSmoke;
            guna2GradientButton4.BorderRadius = 5;
            guna2GradientButton4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2GradientButton4.BorderThickness = 1;
            guna2GradientButton4.CustomBorderColor = Color.White;
            guna2GradientButton4.CustomizableEdges = customizableEdges3;
            guna2GradientButton4.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton4.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton4.FillColor = Color.FromArgb(64, 64, 64);
            guna2GradientButton4.FillColor2 = Color.FromArgb(64, 64, 64);
            guna2GradientButton4.FocusedColor = Color.FromArgb(64, 0, 64);
            guna2GradientButton4.Font = new Font("Verdana", 9.75F);
            guna2GradientButton4.ForeColor = Color.White;
            guna2GradientButton4.HoverState.FillColor = Color.Gray;
            guna2GradientButton4.HoverState.FillColor2 = Color.Gray;
            guna2GradientButton4.Location = new Point(762, 12);
            guna2GradientButton4.Name = "guna2GradientButton4";
            guna2GradientButton4.PressedColor = Color.FromArgb(64, 0, 64);
            guna2GradientButton4.PressedDepth = 50;
            guna2GradientButton4.ShadowDecoration.BorderRadius = 10;
            guna2GradientButton4.ShadowDecoration.Color = Color.FromArgb(64, 0, 64);
            guna2GradientButton4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton4.Size = new Size(26, 26);
            guna2GradientButton4.TabIndex = 19;
            guna2GradientButton4.Text = "Button4";
            guna2GradientButton4.UseTransparentBackground = true;
            guna2GradientButton4.Click += guna2GradientButton4_Click;
            // 
            // guna2GradientButton3
            // 
            guna2GradientButton3.Animated = true;
            guna2GradientButton3.AnimatedGIF = true;
            guna2GradientButton3.BackColor = Color.Transparent;
            guna2GradientButton3.BorderColor = Color.WhiteSmoke;
            guna2GradientButton3.BorderRadius = 5;
            guna2GradientButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2GradientButton3.BorderThickness = 1;
            guna2GradientButton3.CustomBorderColor = Color.White;
            guna2GradientButton3.CustomizableEdges = customizableEdges5;
            guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton3.FillColor = Color.FromArgb(64, 64, 64);
            guna2GradientButton3.FillColor2 = Color.FromArgb(64, 64, 64);
            guna2GradientButton3.FocusedColor = Color.FromArgb(64, 0, 64);
            guna2GradientButton3.Font = new Font("Verdana", 9.75F);
            guna2GradientButton3.ForeColor = Color.White;
            guna2GradientButton3.HoverState.FillColor = Color.Gray;
            guna2GradientButton3.HoverState.FillColor2 = Color.Gray;
            guna2GradientButton3.Location = new Point(730, 12);
            guna2GradientButton3.Name = "guna2GradientButton3";
            guna2GradientButton3.PressedColor = Color.FromArgb(64, 0, 64);
            guna2GradientButton3.PressedDepth = 50;
            guna2GradientButton3.ShadowDecoration.BorderRadius = 10;
            guna2GradientButton3.ShadowDecoration.Color = Color.FromArgb(64, 0, 64);
            guna2GradientButton3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientButton3.Size = new Size(26, 26);
            guna2GradientButton3.TabIndex = 18;
            guna2GradientButton3.Text = "Button4";
            guna2GradientButton3.UseTransparentBackground = true;
            guna2GradientButton3.Click += guna2GradientButton3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 43, 43);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 49);
            panel2.TabIndex = 20;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2GradientButton4);
            Controls.Add(guna2GradientButton3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(GlowLabel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Label GlowLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Panel panel2;
    }
}