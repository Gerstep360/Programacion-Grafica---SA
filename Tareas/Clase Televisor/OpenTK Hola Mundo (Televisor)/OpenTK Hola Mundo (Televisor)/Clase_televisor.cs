using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_Hola_Mundo__Televisor_
{
    internal class Clase_televisor
    {
        private float[] vertdata;
        private Vector3[] coldata;
        private int[] indicedata;
        public Vector3 position; // Posición relativa del televisor
        private int vbo_position;
        private int vbo_color;
        private int ibo_elements;

        public Clase_televisor(Vector3 position, int vbo_position, int vbo_color, int ibo_elements)
        {
            this.position = position;
            this.vbo_position = vbo_position;
            this.vbo_color = vbo_color;
            this.ibo_elements = ibo_elements;
            Dibujo_coordenadas();
        }
        public void Dibujo_coordenadas()
        {
            vertdata = new float[]
                        {

                  -0.55f+position.X, 0.35f+position.Y, -0.1f+position.Z,
                  0.55f+position.X, 0.35f+position.Y,  -0.1f+position.Z,
                  0.55f+position.X, -0.35f+position.Y, -0.1f+position.Z,
                  -0.55f+position.X,-0.35f+position.Y, -0.1f+position.Z,

                  -0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,
                  -0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,

                  0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,
                  0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,

                  -0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  -0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,
                  -0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,
                  -0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,

                  -0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,
                  0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,
                  -0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,

                  -0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, 0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,
                  -0.6f+position.X, 0.4f+position.Y, -0.1f+position.Z,

                  -0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, 0.1f+position.Z,
                  0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,
                  -0.6f+position.X, -0.4f+position.Y, -0.1f+position.Z,

                  -0.2f+position.X, -0.5f+position.Y, 0.2f+position.Z,
                  0.2f+position.X, -0.5f+position.Y, 0.2f+position.Z,
                  0.2f+position.X, -0.6f+position.Y, 0.2f+position.Z,
                  -0.2f+position.X, -0.6f+position.Y, 0.2f+position.Z,

                  -0.2f+position.X, -0.5f+position.Y, -0.2f+position.Z,
                  0.2f+position.X, -0.5f+position.Y, -0.2f+position.Z,
                  0.2f+position.X, -0.6f+position.Y, -0.2f+position.Z,
                  -0.2f+position.X, -0.6f+position.Y, -0.2f+position.Z,

                  -0.2f+position.X, -0.5f+position.Y, 0.2f+position.Z,
                  -0.2f+position.X, -0.5f+position.Y, -0.2f+position.Z,
                  -0.2f+position.X, -0.6f+position.Y, -0.2f+position.Z,
                  -0.2f+position.X, -0.6f+position.Y, 0.2f+position.Z,

                  0.2f+position.X, -0.5f+position.Y, 0.2f+position.Z,
                  0.2f+position.X, -0.5f+position.Y, -0.2f+position.Z,
                  0.2f+position.X, -0.6f+position.Y, -0.2f+position.Z,
                  0.2f+position.X, -0.6f+position.Y, 0.2f+position.Z,

                  0.0f+position.X, 0.4f+position.Y, 0.0f+position.Z,
                  0.05f+position.X, 0.4f+position.Y, 0.0f+position.Z,
                  0.05f+position.X, -0.5f+position.Y, 0.0f+position.Z,
                  0.0f+position.X, -0.5f+position.Y, 0.0f+position.Z,

                  0.05f+position.X, 0.4f+position.Y, 0.0f+position.Z,
                  0.05f+position.X, -0.5f+position.Y, 0.0f+position.Z,
                  0.05f+position.X, -0.5f+position.Y, -0.05f+position.Z,
                  0.05f+position.X, 0.4f+position.Y, -0.05f+position.Z,

                  0.0f+position.X, 0.4f+position.Y, 0.0f+position.Z,
                  0.0f+position.X, 0.4f+position.Y, -0.05f+position.Z,
                  0.0f+position.X, -0.5f+position.Y, -0.05f+position.Z,
                  0.0f+position.X, -0.5f+position.Y, 0.0f+position.Z,

                  0.0f+position.X, 0.4f+position.Y, -0.05f+position.Z,
                  0.05f+position.X, 0.4f+position.Y, -0.05f+position.Z,
                  0.05f+position.X, -0.5f+position.Y, -0.05f+position.Z,
                  0.0f+position.X, -0.5f+position.Y, -0.05f+position.Z
                        };


            coldata = new Vector3[]
            {

                  new Vector3(2.0f, 2.0f, 2.0f),
                  new Vector3(2.0f, 2.0f, 2.0f),
                  new Vector3(2.0f, 2.0f, 2.0f),
                  new Vector3(2.0f, 2.0f, 2.0f),


                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),


                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),


                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),
                  new Vector3(0.7f, 0.7f, 0.7f),

                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),


                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),


                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),
                  new Vector3(0.2f, 0.2f, 0.2f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),

                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f),
                  new Vector3(0.0f, 0.0f, 0.0f)
            };

            indicedata = new int[]
{
    // Caras delanteras
    24, 25, 26, 26, 27, 24,  // Cara frontal del primer conjunto
    28, 29, 30, 30, 31, 28,  // Cara frontal del segundo conjunto
    32, 33, 34, 34, 35, 32,  // Cara frontal del tercer conjunto
    36, 37, 38, 38, 39, 36,  // Cara frontal del cuarto conjunto
    40, 41, 42, 42, 43, 40,  // Cara frontal del quinto conjunto
    44, 45, 46, 46, 47, 44,  // Cara frontal del sexto conjunto
    48, 49, 50, 50, 51, 48,  // Cara frontal del séptimo conjunto
    52, 53, 54, 54, 55, 52,  // Cara frontal del octavo conjunto
    56, 57, 58, 58, 59, 56,  // Cara frontal del noveno conjunto
    12, 13, 14, 14, 15, 12,  // Cara frontal del décimo conjunto
    
    // Caras traseras (invertidas para tapar las caras frontales)
     // Cara trasera del primer conjunto
    7, 6, 5, 5, 4, 7,  // Cara trasera del segundo conjunto
    11, 10, 9, 9, 8, 11,  // Cara trasera del tercer conjunto
    15, 14, 13, 13, 12, 15,  // Cara trasera del cuarto conjunto
    19, 18, 17, 17, 16, 19,  // Cara trasera del quinto conjunto
    23, 22, 21, 21, 20, 23,  // Cara trasera del sexto conjunto
    0, 1, 2, 2, 3, 0,
};

            // Configurar el buffer de datos de posición
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData(BufferTarget.ArrayBuffer, vertdata.Length * sizeof(float), vertdata, BufferUsageHint.StaticDraw);

            // Configurar el buffer de datos de color
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_color);
            GL.BufferData(BufferTarget.ArrayBuffer, coldata.Length * Vector3.SizeInBytes, coldata, BufferUsageHint.StaticDraw);

            // Configurar el buffer de elementos
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indicedata.Length * sizeof(int)), indicedata, BufferUsageHint.StaticDraw);
        
    }
        public void Dibujar()
        {
            GL.PushMatrix(); // Guarda la matriz de transformación actual

            // Aplica la transformación de traslación para mover el televisor a su posición relativa
            GL.Translate(position);

            // Configurar atributos de vértices
            GL.EnableVertexAttribArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);

            GL.EnableVertexAttribArray(1);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_color);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 0, 0);

            // Dibujar
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
            GL.DrawElements(BeginMode.Triangles, indicedata.Length, DrawElementsType.UnsignedInt, IntPtr.Zero);

            // Restaurar el estado
            GL.DisableVertexAttribArray(0);
            GL.DisableVertexAttribArray(1);
            GL.PopMatrix(); // Restaura la matriz de transformación anterior
        }

        public void InicializarBuffers()
        {
            // Generar identificadores para los buffers
            GL.GenBuffers(1, out vbo_position);
            GL.GenBuffers(1, out vbo_color);
            GL.GenBuffers(1, out ibo_elements);

            // Configurar el buffer de datos de posición
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData(BufferTarget.ArrayBuffer, vertdata.Length * sizeof(float), vertdata, BufferUsageHint.StaticDraw);

            // Configurar el buffer de datos de color
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_color);
            GL.BufferData(BufferTarget.ArrayBuffer, coldata.Length * Vector3.SizeInBytes, coldata, BufferUsageHint.StaticDraw);

            // Configurar el buffer de elementos
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ibo_elements);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indicedata.Length * sizeof(int), indicedata, BufferUsageHint.StaticDraw);
        }

        public void LimpiarBuffers()
        {
            // Eliminar los buffers
            GL.DeleteBuffer(vbo_position);
            GL.DeleteBuffer(vbo_color);
            GL.DeleteBuffer(ibo_elements);
        }



    }
}
