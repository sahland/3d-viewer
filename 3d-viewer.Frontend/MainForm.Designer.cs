using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using System.ComponentModel;
using _3d_viewer.Frontend.Properties;
using SharpGL.SceneGraph.Cameras;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System;

namespace _3d_viewer.Frontend
{
    partial class MainForm
    {
        private Boolean _lMenuIsOpen;
        private OpenGL gl;
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        
        private void LeftPanel()
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
            Import.Click += Import_Click;
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
            Info.Click += Info_Click;
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
        

        private void InitializeComponent()
        {
            this.GLwindow = new SharpGL.OpenGLControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.Top = new System.Windows.Forms.Panel();
            this.Camera = new System.Windows.Forms.PictureBox();
            this.Github = new System.Windows.Forms.PictureBox();
            this.AciraMenu = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GLwindow)).BeginInit();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AciraMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // GLwindow
            // 
            this.GLwindow.DrawFPS = true;
            this.GLwindow.FrameRate = 60;
            this.GLwindow.Location = new System.Drawing.Point(0, 81);
            this.GLwindow.Name = "GLwindow";
            this.GLwindow.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.GLwindow.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.GLwindow.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.GLwindow.Size = new System.Drawing.Size(1280, 600);
            this.GLwindow.TabIndex = 1;
            this.GLwindow.OpenGLInitialized += new System.EventHandler(this.GLwindow_OpenGLInitialized);
            this.GLwindow.OpenGLDraw += new SharpGL.RenderEventHandler(this.GLwindow_OpenGLDraw);
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.Transparent;
            this.Top.BackgroundImage = global::_3d_viewer.Frontend.Properties.Resources.Top;
            this.Top.Controls.Add(this.Camera);
            this.Top.Controls.Add(this.Github);
            this.Top.Controls.Add(this.AciraMenu);
            this.Top.Controls.Add(this.Exit);
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1280, 85);
            this.Top.TabIndex = 1;
            // 
            // Camera
            // 
            this.Camera.BackColor = System.Drawing.Color.Transparent;
            this.Camera.Image = global::_3d_viewer.Frontend.Properties.Resources.Camera;
            this.Camera.Location = new System.Drawing.Point(575, 10);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(65, 65);
            this.Camera.TabIndex = 2;
            this.Camera.TabStop = false;
            // 
            // Github
            // 
            this.Github.BackColor = System.Drawing.Color.Transparent;
            this.Github.Image = global::_3d_viewer.Frontend.Properties.Resources.Github;
            this.Github.Location = new System.Drawing.Point(640, 10);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(65, 65);
            this.Github.TabIndex = 4;
            this.Github.TabStop = false;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // AciraMenu
            // 
            this.AciraMenu.BackColor = System.Drawing.Color.Transparent;
            this.AciraMenu.Image = global::_3d_viewer.Frontend.Properties.Resources.Akira;
            this.AciraMenu.Location = new System.Drawing.Point(11, 10);
            this.AciraMenu.Name = "AciraMenu";
            this.AciraMenu.Size = new System.Drawing.Size(65, 65);
            this.AciraMenu.TabIndex = 3;
            this.AciraMenu.TabStop = false;
            this.AciraMenu.Click += new System.EventHandler(this.AciraMenu_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Image = global::_3d_viewer.Frontend.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(1202, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 65);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1280, 681);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.GLwindow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Akira";
            ((System.ComponentModel.ISupportInitialize)(this.GLwindow)).EndInit();
            this.Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AciraMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenGLControl GLwindow;
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

        InfoControl infoControl;
        OpenFileDialog ofd;
        
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private BackgroundWorker backgroundWorker3;

    }
}

