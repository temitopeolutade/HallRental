namespace HALLRENTAL.user_controls
{
    partial class slider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slider));
            this.slide = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
            this.SuspendLayout();
            // 
            // slide
            // 
            this.slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slide.Image = ((System.Drawing.Image)(resources.GetObject("slide.Image")));
            this.slide.Location = new System.Drawing.Point(0, 0);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(495, 272);
            this.slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slide.TabIndex = 0;
            this.slide.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.slide);
            this.Name = "slider";
            this.Size = new System.Drawing.Size(495, 272);
            ((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
