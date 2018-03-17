namespace HALLRENTAL
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slider1 = new HALLRENTAL.user_controls.slider();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.halls1 = new HALLRENTAL.user_controls.halls();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 337);
            this.panel2.TabIndex = 1;
            // 
            // view
            // 
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(0, 140);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(175, 57);
            this.view.TabIndex = 1;
            this.view.Text = "View Halls";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(0, 77);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(175, 57);
            this.home.TabIndex = 2;
            this.home.Text = "Home Page";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = " I\'m so lucky that my event centre was listed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "After signing up with ogaVenue, bookings have really increased.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "event centers.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "We offer quality ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customers Review";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "About us";
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.White;
            this.slider1.Location = new System.Drawing.Point(172, 42);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(524, 299);
            this.slider1.TabIndex = 20;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(201, 347);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(99, 29);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(378, 347);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(99, 29);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(546, 347);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(99, 29);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // halls1
            // 
            this.halls1.BackColor = System.Drawing.Color.White;
            this.halls1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.halls1.Location = new System.Drawing.Point(170, 42);
            this.halls1.Name = "halls1";
            this.halls1.Size = new System.Drawing.Size(526, 299);
            this.halls1.TabIndex = 25;
            // 
            // dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 379);
            this.Controls.Add(this.halls1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private user_controls.slider slider1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private user_controls.halls halls1;
    }
}