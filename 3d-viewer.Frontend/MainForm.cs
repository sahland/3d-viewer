using _3d_viwer.Backend;
using _3d_viwer.Backend.Lighting;
using _3d_viwer.Backend.ModelLoader;
using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3d_viewer.Frontend
{
    public partial class MainForm : Form
    {
        Tests test;
        ImportWindow iw;
        StandardLighting sl;
        
        public MainForm()
        {
            InitializeComponent();

            test = new Tests();
            iw = new ImportWindow();
            

            infoControl = new InfoControl();
            ofd = new OpenFileDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            LeftMenu.Visible = false;
            _lMenuIsOpen = false;
        }

        private void AciraMenu_Click(object sender, EventArgs e)
        {
            
            if(_lMenuIsOpen)
            {
                return;
            }

            LeftPanel();
            Controls.Add(LeftMenu);
            LeftMenu.BringToFront();
            _lMenuIsOpen = true;         
        }

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sahland/3d-viewer");
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Controls.Add(infoControl);
            infoControl.BringToFront();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            iw.openWindow(ofd);
        }


        #region OPENGL
        private void GLwindow_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            gl = GLwindow.OpenGL;

            test.testRender(gl);
        }

        private void GLwindow_OpenGLInitialized(object sender, EventArgs e)
        {
            gl = GLwindow.OpenGL;
            //gl.ClearColor(197.0f / 255.0f, 144.0f / 255.0f, 191.0f / 255.0f, 1.0f);
            //gl.ClearColor(0.8f, 0.8f, 0.8f, 1.0f);

            sl = new StandardLighting();

            sl.StandLight(gl);
        }
        #endregion
    }
}
