namespace HALLRENTAL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 42);
            this.panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // username
            // 
            this.username.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.username.BorderColorIdle = System.Drawing.Color.DeepPink;
            this.username.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.username.BorderThickness = 3;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.isPassword = false;
            this.username.Location = new System.Drawing.Point(310, 94);
            this.username.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(370, 56);
            this.username.TabIndex = 2;
            this.username.Text = "User Name";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.password.BorderColorIdle = System.Drawing.Color.DeepPink;
            this.password.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.password.BorderThickness = 3;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(310, 180);
            this.password.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(370, 56);
            this.password.TabIndex = 3;
            this.password.Text = "Pass Word :";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login
            // 
            this.login.ActiveBorderThickness = 1;
            this.login.ActiveCornerRadius = 20;
            this.login.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.login.ActiveForecolor = System.Drawing.Color.White;
            this.login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.ButtonText = "Log In";
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.IdleBorderThickness = 1;
            this.login.IdleCornerRadius = 20;
            this.login.IdleFillColor = System.Drawing.Color.White;
            this.login.IdleForecolor = System.Drawing.Color.Black;
            this.login.IdleLineColor = System.Drawing.Color.DeepPink;
            this.login.Location = new System.Drawing.Point(310, 270);
            this.login.Margin = new System.Windows.Forms.Padding(5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(177, 42);
            this.login.TabIndex = 4;
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.ActiveBorderThickness = 1;
            this.signup.ActiveCornerRadius = 20;
            this.signup.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.signup.ActiveForecolor = System.Drawing.Color.White;
            this.signup.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup.BackgroundImage")));
            this.signup.ButtonText = "Sign Up";
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.Black;
            this.signup.IdleBorderThickness = 1;
            this.signup.IdleCornerRadius = 20;
            this.signup.IdleFillColor = System.Drawing.Color.White;
            this.signup.IdleForecolor = System.Drawing.Color.Black;
            this.signup.IdleLineColor = System.Drawing.Color.DeepPink;
            this.signup.Location = new System.Drawing.Point(497, 270);
            this.signup.Margin = new System.Windows.Forms.Padding(5);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(177, 42);
            this.signup.TabIndex = 5;
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(319, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(22, 94);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(266, 218);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 379);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 signup;
        private Bunifu.Framework.UI.BunifuThinButton2 login;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuMetroTextbox username;
    }
}

