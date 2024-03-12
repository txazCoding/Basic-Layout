namespace Remote
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            mainpanel = new Panel();
            button4 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            mainpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F);
            button1.Location = new Point(7, 45);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F);
            button2.Location = new Point(7, 92);
            button2.Name = "button2";
            button2.Size = new Size(175, 41);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F);
            button3.Location = new Point(7, 139);
            button3.Name = "button3";
            button3.Size = new Size(175, 41);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(label2);
            mainpanel.Location = new Point(187, 44);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(614, 407);
            mainpanel.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(765, 10);
            button4.Name = "button4";
            button4.Size = new Size(26, 26);
            button4.TabIndex = 0;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 452);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 13);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 3;
            label1.Text = "Basic Layout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 171);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 0;
            label2.Text = "hi :)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel mainpanel;
        private Panel panel1;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}
