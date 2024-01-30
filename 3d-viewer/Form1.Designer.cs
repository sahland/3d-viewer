using _3d_viewer.Properties;

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
            Top.BackgroundImage = Resources.Top;
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
            Camera.Image = Resources.Camera;
            Camera.Location = new Point(575, 10);
            Camera.Name = "Camera";
            Camera.Size = new Size(65, 65);
            Camera.TabIndex = 2;
            Camera.TabStop = false;
            // 
            // Github
            // 
            Github.BackColor = Color.Transparent;
            Github.Image = Resources.Github;
            Github.Location = new Point(640, 10);
            Github.Name = "Github";
            Github.Size = new Size(65, 65);
            Github.TabIndex = 4;
            Github.TabStop = false;
            // 
            // AciraMenu
            // 
            AciraMenu.BackColor = Color.Transparent;
            AciraMenu.Image = Resources.Akira;
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
            Exit.Image = Resources.Exit;
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
            BackgroundImage = Resources.Background;
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

        private void LMenu()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Background));
            LeftMenu = new Panel();
            Import = new PictureBox();
            NextModel = new PictureBox();
            NextScene = new PictureBox();
            Info = new PictureBox();
            Close = new PictureBox();

            LeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Import).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextScene).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            SuspendLayout();
            // 
            // LeftMenu
            // 
            LeftMenu.BackColor = Color.Transparent;
            LeftMenu.BackgroundImage = Resources.LeftMenu;
            LeftMenu.Controls.Add(Import);
            LeftMenu.Controls.Add(NextModel);
            LeftMenu.Controls.Add(NextScene);
            LeftMenu.Controls.Add(Info);
            LeftMenu.Controls.Add(Close);
            LeftMenu.Location = new Point(4, 99);
            LeftMenu.Name = "LeftMenu";
            LeftMenu.Size = new Size(80, 378);
            LeftMenu.TabIndex = 1;
            // 
            // Import
            // 
            Import.BackColor = Color.Transparent;
            Import.Image = Resources.Import;
            Import.Location = new Point(8, 8);
            Import.Name = "Import";
            Import.Size = new Size(65, 65);
            Import.TabIndex = 2;
            Import.TabStop = false;
            // 
            // NextModel
            // 
            NextModel.BackColor = Color.Transparent;
            NextModel.Image = Resources.NextModel;
            NextModel.Location = new Point(8, 80);
            NextModel.Name = "NextModel";
            NextModel.Size = new Size(65, 65);
            NextModel.TabIndex = 2;
            NextModel.TabStop = false;
            // 
            // NextScene
            // 
            NextScene.BackColor = Color.Transparent;
            NextScene.Image = Resources.NextScene;
            NextScene.Location = new Point(8, 155);
            NextScene.Name = "NextScene";
            NextScene.Size = new Size(65, 65);
            NextScene.TabIndex = 2;
            NextScene.TabStop = false;
            // 
            // Info
            // 
            Info.BackColor = Color.Transparent;
            Info.Image = Resources.Info;
            Info.Location = new Point(8, 230);
            Info.Name = "Info";
            Info.Size = new Size(65, 65);
            Info.TabIndex = 2;
            Info.TabStop = false;
            // 
            // Close
            // 
            Close.BackColor = Color.Transparent;
            Close.Image = Resources.Close;
            Close.Location = new Point(8, 305);
            Close.Name = "Close";
            Close.Size = new Size(65, 65);
            Close.TabIndex = 2;
            Close.TabStop = false;
            Close.Click += Close_Click;

        }

        #endregion
        private Panel Top;
        private PictureBox Exit;
        private PictureBox AciraMenu;
        private PictureBox Github;
        private PictureBox Camera;

        private Panel LeftMenu;
        private PictureBox Import;
        private PictureBox NextModel;
        private PictureBox NextScene;
        private PictureBox Info;
        private PictureBox Close;


    }
}
