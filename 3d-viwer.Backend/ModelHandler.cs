using _3d_viwer.Backend.ModelLoader;
using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_viwer.Backend
{
    public class ModelHandler
    {
        OBJloader loader;
        ImportWindow importWindow;

        public ModelHandler() {
            loader = new OBJloader();
            importWindow = new ImportWindow();
        }

        public void Handler(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);
        }
    }
}
