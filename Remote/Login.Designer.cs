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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            GlowLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
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
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
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
    }
}