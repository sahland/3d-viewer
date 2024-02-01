using _3d_viwer.Backend;
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
        Tests test = new Tests();
        
        public MainForm()
        {
            InitializeComponent();
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
            _lMenuIsOpen = true;
        }

        private void GLwindow_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = GLwindow.OpenGL;

            test.testRender(gl);
        }
    }
}
