using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_viwer.Backend.Lighting
{
    public sealed class StandardLighting
    {
        Single[] _globalAmbient;
        Single[] _lightZeroPos;
        Single[] _lightZeroAmbient;
        Single[] _lightZeroDiffuse;
        Single[] _lightZeroSpecular;

        public void StandLight(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_DEPTH_TEST);

            _globalAmbient = new Single[] { 0.2f, 0.2f, 0.2f, 1.0f };
            _lightZeroPos = new Single[] { 0.0f, 5.0f, 10.0f, 1.0f };
            _lightZeroAmbient = new Single[] { 0.2f, 0.2f, 0.2f, 1.0f };
            _lightZeroDiffuse = new Single[] { 0.2f, 0.2f, 0.2f, 1.0f };
            _lightZeroSpecular = new Single[] { 0.8f, 0.8f, 0.8f, 1.0f };

            Single[] lmodelAmbient = new Single[] { 0.2f, 0.2f, 0.2f, 1.0f };
            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, lmodelAmbient);

            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, _globalAmbient);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, _lightZeroPos);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, _lightZeroAmbient);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, _lightZeroDiffuse);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, _lightZeroSpecular);
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT0);

            gl.ShadeModel(OpenGL.GL_SMOOTH);
        }
    }
}
