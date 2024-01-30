namespace _3d_viewer
{
    partial class Background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            Top = new Panel();
            Camera = new PictureBox();
            Github = new PictureBox();
            AciraMenu = new PictureBox();
            Exit = new PictureBox();
            Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Camera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AciraMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // Top
            // 
            Top.BackColor = Color.Transparent;
            Top.BackgroundImage = (Image)resources.GetObject("Top.BackgroundImage");
            Top.Controls.Add(Camera);
            Top.Controls.Add(Github);
            Top.Controls.Add(AciraMenu);
            Top.Controls.Add(Exit);
            Top.Location = new Point(0, 0);
            Top.Name = "Top";
            Top.Size = new Size(1280, 85);
            Top.TabIndex = 1;
            // 
            // Camera
            // 
            Camera.BackColor = Color.Transparent;
            Camera.Image = (Image)resources.GetObject("Camera.Image");
            Camera.Location = new Point(575, 10);
            Camera.Name = "Camera";
            Camera.Size = new Size(65, 65);
            Camera.TabIndex = 2;
            Camera.TabStop = false;
            // 
            // Github
            // 
            Github.BackColor = Color.Transparent;
            Github.Image = (Image)resources.GetObject("Github.Image");
            Github.Location = new Point(640, 10);
            Github.Name = "Github";
            Github.Size = new Size(65, 65);
            Github.TabIndex = 4;
            Github.TabStop = false;
            // 
            // AciraMenu
            // 
            AciraMenu.BackColor = Color.Transparent;
            AciraMenu.Image = (Image)resources.GetObject("AciraMenu.Image");
            AciraMenu.Location = new Point(11, 10);
            AciraMenu.Name = "AciraMenu";
            AciraMenu.Size = new Size(65, 65);
            AciraMenu.TabIndex = 3;
            AciraMenu.TabStop = false;
            AciraMenu.Click += AciraMenu_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImageLayout = ImageLayout.Center;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1202, 10);
            Exit.Name = "Exit";
            Exit.Size = new Size(65, 65);
            Exit.TabIndex = 2;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // Background
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(Top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Background";
            Text = "Form1";
            Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Camera).EndInit();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)AciraMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Top;
        private PictureBox Exit;
        private PictureBox AciraMenu;
        private PictureBox Github;
        private PictureBox Camera;
    }
}
