using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Abrir_archivo_BMP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtTextos.Clear();
            OpenFileBMP.ShowDialog();
            string N = OpenFileBMP.FileName;
            string fileE =System.IO.Path.GetExtension(OpenFileBMP.FileName);
            Bitmap picBMP;
            if (fileE == ".bmp" || fileE == ".Bmp")
            {
                FileInfo xFile = new FileInfo(N);
                picBMP = new Bitmap(N, true);
                picBMP.Image = Image.FromFile(N);
                txtTextos.Text = "-------------------------------" + Environment.NewLine;
                txtTextos.Text += "Nombre : " + fileE + Environment.NewLine;
                txtTextos.Text += "Direccion : " + N + Environment.NewLine;
                txtTextos.Text += "Tamaño : " + xFile.Length + " Bytes. " + Environment.NewLine;
                txtTextos.Text += "Ancho : " + picBMP.Width + " Pixeles <---> Resolucion : " + picBMP.HorizontalResolution + Environment.NewLine;
                txtTextos.Text += "Alto : " + picBMP.Height + " Pixeles <---> Resolucion : " + picBMP.VerticalResolution + Environment.NewLine;
                txtTextos.Text += "-------------------------------" + Environment.NewLine;
            }
            else
            {
                txtTextos.Text = "Archivo de imagen no permitido solo .BMP";
            }


        }
    }
}
