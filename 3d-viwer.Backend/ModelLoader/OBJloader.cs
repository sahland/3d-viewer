using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.IO;

namespace _3d_viwer.Backend
{
    public sealed class OBJloader
    {
        private List<Vertex> Vertices;
        private List<Material> Materials;

        public OBJloader() {
            Vertices = new List<Vertex>();
            Materials = new List<Material>();
        }

        public void Load(string filePath)
        {
            Vertices.Clear();

            string[] lines = File.ReadAllLines(filePath);
            Material currentMaterial = new Material();

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                switch (parts[0])
                {
                    case "v":
                        Vertices.Add(new Vertex(
                            Single.Parse(parts[1]),
                            Single.Parse(parts[2]),
                            Single.Parse(parts[3])
                        ));
                        break;
                    case "usemtl":
                        currentMaterial = GetMaterial(parts[1]);
                        break;
                    case "f":
                        break;   
                }
            }
        }

        private Material GetMaterial(string name)
        {
            Material material = Materials.Find(m => m.Name == name);

            if (material == null)
            {
                material = new Material();
                material.Name = name;
                Materials.Add(material);
            }

            return material;
        }

        private void ParseFace(string[] parts, Material material)
        {
            for(int i = 1; i <= 3; i++)
            {
                Int32 vertexIndex = Int32.Parse(parts[i].Split('/')[0]);
                Int32 texCoordIndex = Int32.Parse(parts[i].Split('/')[1]);
                Int32 normalIndex = Int32.Parse(parts[i].Split('/')[2]);
            }
        }
    }
}
