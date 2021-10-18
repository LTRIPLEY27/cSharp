using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElJocDeLaVie
{
    public partial class Form1 : Form
    {
        // ATRIBUTOS
        private int longitude = 30;
        private int PixelLongitude = 10;
        int[,] celulas;
        public Form1()
        {
            InitializeComponent();
            celulas = new int[longitude, longitude];
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < longitude; i++)
            {
                for(int j = 0; j < longitude; j++)
                {
                    celulas[i, j] = 0;
                }
            }

            Random rand = new Random();
            for (int i = 0; i < longitude; i++)
            {
                for (int j = 0; j < longitude; j++)
                {
                    celulas[i, j] = rand.Next(0,2);
                }
            }

            MatrizShow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatrizShow();
        }

        private void MatrizShow()
        {
            Bitmap bit = new Bitmap(pictureBox1.Width, pictureBox1.Height); // DIMENSIONES DE LA MATRIZ
            for(int i = 0; i < longitude; i++)
            {
                for(int j = 0; j < longitude; j++)
                {
                    if(celulas[i,j] == 0)
                    {
                        PaintPlace(bit, i, j, Color.Red);
                    } else
                    {
                        PaintPlace(bit, i, j, Color.Black);
                    }
                }
            }

            pictureBox1.Image = bit;
        }

        private void PaintPlace(Bitmap bit, int a, int b, Color color) // RECIBE POR PARAMETROS LAS VARIABLES A TRABAJAR Y DEFINIDAS EN MATRIZSHOW
        {
            for (int i = 0; i < PixelLongitude; i++)
            {
                for(int j = 0; j < PixelLongitude; j++)
                {
                    bit.SetPixel(i + (a * PixelLongitude), j + (b * PixelLongitude), color);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
