using System.Drawing;

namespace _3d_viewer.Frontend
{
    partial class InfoControl
    {
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Camera = new System.Windows.Forms.PictureBox();
            this.CameraText = new System.Windows.Forms.Label();
            this.GithubText = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.PictureBox();
            this.ImportText = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.PictureBox();
            this.NextSceneText = new System.Windows.Forms.Label();
            this.NextScene = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Camera
            // 
            this.Camera.BackColor = System.Drawing.Color.Transparent;
            this.Camera.Image = global::_3d_viewer.Frontend.Properties.Resources.Camera;
            this.Camera.Location = new System.Drawing.Point(3, 3);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(65, 65);
            this.Camera.TabIndex = 0;
            this.Camera.TabStop = false;
            // 
            // CameraText
            // 
            this.CameraText.AutoSize = true;
            this.CameraText.BackColor = System.Drawing.Color.Transparent;
            this.CameraText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CameraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CameraText.Location = new System.Drawing.Point(74, 27);
            this.CameraText.Name = "CameraText";
            this.CameraText.Size = new System.Drawing.Size(198, 19);
            this.CameraText.TabIndex = 1;
            this.CameraText.Text = "СМЕНА ПЕРСПЕКТИВЫ";
            // 
            // GithubText
            // 
            this.GithubText.AutoSize = true;
            this.GithubText.BackColor = System.Drawing.Color.Transparent;
            this.GithubText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GithubText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GithubText.Location = new System.Drawing.Point(74, 98);
            this.GithubText.Name = "GithubText";
            this.GithubText.Size = new System.Drawing.Size(265, 19);
            this.GithubText.TabIndex = 3;
            this.GithubText.Text = "ИСХОДНЫЙ КОД ПРИЛОЖЕНИЯ";
            // 
            // Github
            // 
            this.Github.BackColor = System.Drawing.Color.Transparent;
            this.Github.Image = global::_3d_viewer.Frontend.Properties.Resources.Github;
            this.Github.Location = new System.Drawing.Point(3, 74);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(65, 65);
            this.Github.TabIndex = 2;
            this.Github.TabStop = false;
            // 
            // ImportText
            // 
            this.ImportText.AutoSize = true;
            this.ImportText.BackColor = System.Drawing.Color.Transparent;
            this.ImportText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImportText.Location = new System.Drawing.Point(74, 169);
            this.ImportText.Name = "ImportText";
            this.ImportText.Size = new System.Drawing.Size(229, 19);
            this.ImportText.TabIndex = 5;
            this.ImportText.Text = "ИМПОРТИРОВАТЬ МОДЕЛЬ";
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.Color.Transparent;
            this.Import.Image = global::_3d_viewer.Frontend.Properties.Resources.Import;
            this.Import.Location = new System.Drawing.Point(3, 145);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(65, 65);
            this.Import.TabIndex = 4;
            this.Import.TabStop = false;
            // 
            // NextSceneText
            // 
            this.NextSceneText.AutoSize = true;
            this.NextSceneText.BackColor = System.Drawing.Color.Transparent;
            this.NextSceneText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextSceneText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextSceneText.Location = new System.Drawing.Point(74, 240);
            this.NextSceneText.Name = "NextSceneText";
            this.NextSceneText.Size = new System.Drawing.Size(134, 19);
            this.NextSceneText.TabIndex = 7;
            this.NextSceneText.Text = "СМЕНА СЦЕНЫ";
            // 
            // NextScene
            // 
            this.NextScene.BackColor = System.Drawing.Color.Transparent;
            this.NextScene.Image = global::_3d_viewer.Frontend.Properties.Resources.NextScene;
            this.NextScene.Location = new System.Drawing.Point(3, 216);
            this.NextScene.Name = "NextScene";
            this.NextScene.Size = new System.Drawing.Size(65, 65);
            this.NextScene.TabIndex = 6;
            this.NextScene.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "СМЕНА ПЕРСПЕКТИВЫ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_3d_viewer.Frontend.Properties.Resources.Camera;
            this.pictureBox1.Location = new System.Drawing.Point(3, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Image = global::_3d_viewer.Frontend.Properties.Resources.Close;
            this.Close.Location = new System.Drawing.Point(382, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(65, 65);
            this.Close.TabIndex = 10;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // InfoControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::_3d_viewer.Frontend.Properties.Resources.Background;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextSceneText);
            this.Controls.Add(this.NextScene);
            this.Controls.Add(this.ImportText);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.GithubText);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.CameraText);
            this.Controls.Add(this.Camera);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(400, 200);
            this.Name = "InfoControl";
            this.Size = new System.Drawing.Size(450, 356);
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Camera;
        private System.Windows.Forms.Label CameraText;
        private System.Windows.Forms.Label GithubText;
        private System.Windows.Forms.PictureBox Github;
        private System.Windows.Forms.Label ImportText;
        private System.Windows.Forms.PictureBox Import;
        private System.Windows.Forms.Label NextSceneText;
        private System.Windows.Forms.PictureBox NextScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Close;
    }
}
