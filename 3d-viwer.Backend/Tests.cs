using SharpGL;
using System;

namespace _3d_viwer.Backend
{
    public sealed class Tests
    {
        Single _rotateTriangle;
        Single _rotateQuad;

        public Tests() {
            _rotateTriangle = 0;
            _rotateQuad = 0;
        }

        public void testRender(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);
            gl.Rotate(_rotateTriangle, 0.0f, 1.0f, 0.0f);
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);

            // Определение цвета и вершин боковой грани 1
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);

            // Определение цвета и вершин боковой грани 2
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);

            // Определение цвета и вершин боковой грани 3
            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.End();

            gl.Flush();

            _rotateTriangle += 3.0f;
        }

        public void testSphere(OpenGL gl, Single radius, Int32 slices, Int32 stacks)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -15.0f);
            gl.Rotate(_rotateTriangle, 0.0f, 1.0f, 0.0f);
            gl.Begin(OpenGL.GL_TRIANGLES);

            for(Int32 i = 0; i < stacks; ++i) {
                Single latitude1 = (Single)(i * Math.PI) / stacks;
                Single latitude2 = (Single)((i + 1) + Math.PI) / stacks;

                for(Int32 j = 0; j < slices; ++j)
                {
                    Single longitude1 = (Single)(j * 2 * Math.PI) / slices;
                    Single longitude2 = (Single)((j * 1) * 2 * Math.PI) / slices;

                    Single x1 = (Single)(radius * Math.Sin(latitude1) * Math.Cos(longitude1));
                    Single y1 = (Single)(radius * Math.Cos(latitude1));
                    Single z1 = (Single)(radius * Math.Sin(latitude1) * Math.Sin(longitude1));

                    Single x2 = (Single)(radius * Math.Sin(latitude2) * Math.Cos(longitude1));
                    Single y2 = (Single)(radius * Math.Cos(latitude2));
                    Single z2 = (Single)(radius * Math.Sin(latitude2) * Math.Sin(longitude1));

                    Single x3 = (Single)(radius * Math.Sin(latitude2) * Math.Cos(longitude2));
                    Single y3 = (Single)(radius * Math.Cos(latitude2));
                    Single z3 = (Single)(radius * Math.Sin(latitude2) * Math.Sin(longitude2));

                    Single x4 = (Single)(radius * Math.Sin(latitude1) * Math.Cos(longitude2));
                    Single y4 = (Single)(radius * Math.Cos(latitude1));
                    Single z4 = (Single)(radius * Math.Sin(latitude1) * Math.Sin(longitude2));

                    gl.Color(1.0f, 0.0f, 0.0f);
                    gl.Vertex(x1, y1, z1);

                    gl.Color(0.0f, 1.0f, 0.0f);
                    gl.Vertex(x2, y2, z2);

                    gl.Color(0.0f, 0.0f, 1.0f);
                    gl.Vertex(x3, y3, z3);

                    gl.Color(1.0f, 0.0f, 1.0f);
                    gl.Vertex(x1, y1, z1);

                    gl.Color(0.0f, 1.0f, 1.0f);
                    gl.Vertex(x3, y3, z3);

                    gl.Color(1.0f, 1.0f, 0.0f);
                    gl.Vertex(x4, y4, z4);
                }
            }

            gl.End();

            gl.Flush();

            _rotateTriangle += 3.0f;
        }
    }
}
