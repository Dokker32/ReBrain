using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Dicom;
using Dicom.Imaging;
using OpenGL;
using System.Collections.Generic;


namespace ReBrain
{
    public partial class Form1 : Form
    {
        float ColorR, ColorG, ColorB;

        private void glControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
            }
        }

        public Form1()
        {
            InitializeComponent();

            Color c = Form1.DefaultBackColor;
            ColorR = (float)c.R / 255;
            ColorG = (float)c.G / 255;
            ColorB = (float)c.B / 255;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Gl.Initialize();

            Gl.Viewport(0, 0, glControl2.Size.Width, glControl2.Size.Height);
            Gl.LoadIdentity();
            Gl.ClearColor(ColorR, ColorG, ColorB, 1.0f);

        }
    }
}
