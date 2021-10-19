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
        private int longitude = 40;
        private int PixelLongitude = 10;

        System.Drawing.Graphics x;
        int[,] celulas;
        public Form1()
        {
            InitializeComponent();
            celulas = new int[longitude, longitude];
        }


        // VIVAS = 1
        // MUERTAS = 0;
        private void btnRandom_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < longitude; i++)
            {
                for(int j = 0; j < longitude; j++)
                {
                    celulas[i,j] = 0;
                }
            }

            Random rand = new Random(); // GENERAMOS LOS VALORES DE 0 O 1 PARA RECONOCER SI ESTA VIVA O MUERTA
            for (int i = 0; i < longitude; i++)
            {
                for (int j = 0; j < longitude; j++)
                {
                    celulas[i,j] = rand.Next(0,2);
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

            Console.ForegroundColor = ConsoleColor.White;// ME DECLINE POR LA CLASE BIT


            for(int i = 0; i < longitude; i++)
            {
                for(int j = 0; j < longitude; j++)
                {
                    if(celulas[i,j] == 0)
                    {
                        PaintPlace(bit, i, j, Color.White);
                    } else
                    {
                        PaintPlace(bit, i, j, Color.PeachPuff);
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrIteracion.Enabled = true; // INICIA AL OBJETO TIMER PARA QUE ITERE
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrIteracion.Enabled = false; // PAUSA LOS MILISENGUDOS DEL TIMER CON EL "FALSE"
        }


        private void IniciaJuego()
        {
            int[,] celulasIniciales = new int[longitude, longitude];  // ESTADO INICIAL DEL JUEGO Y CON EL QUE ITERAREMOS
            for (int i = 0; i < longitude; i++)
            {
                for (int j = 0; j < longitude; j++)
                {
                    if (celulas[i, j] == 0)
                    {
                        celulasIniciales[i,j] = VerificarEstado(i,j,false);  // CONDICIONAMOS AL METODO DE VERIFICACION EL LLENADO O NO DE LAS CASILLAS
                    } else
                    {
                        celulasIniciales[i,j] = VerificarEstado(i,j,true);
                    }
                }
            }

            celulas = celulasIniciales;
        }


        public int VerificarEstado(int i,int j,bool IsAlive)
        {
            int CelulasVivas = 0; // INICIAMOS LA VARIABLE EN 0 PARA LLEVAR EL CONTEO DE SI ESTAN O NO 3 CELULAS VIVAS

            if( i > 0 && j > 0)
            {
                if( celulas[i - 1, j - 1] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (j > 0)
            {
                if (celulas[i , j -1] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (i < longitude - 1 && j > 0) // CUBRIMOS LOS COSTADOS
            {
                if (celulas[i + 1, j - 1] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (i > 0)
            {
                if (celulas[i - 1, j] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (i < longitude - 1)  // BORDES
            {
                if (celulas[i + 1, j] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (i > 0 && j < longitude - 1)
            {
                if (celulas[i - 1, j + 1] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (j < longitude - 1)
            {
                if (celulas[i , j + 1] == 1)
                {
                    CelulasVivas++;
                }
            }


            if (i < longitude - 1 && j < longitude - 1)
            {
                if (celulas[i + 1, j + 1] == 1)
                {
                    CelulasVivas++;
                }
            }

            // CONDICIONAL A VERIFICAR SI EL ESTADO ES VIVA O MUERTA SEGUN EL CONTEO

            if(IsAlive)
            {
                return (CelulasVivas == 2 || CelulasVivas == 3) ? 1 : 0; // TERNARIO PARA SABER SI ES KAPUT
            } else
            {
                return CelulasVivas == 3 ? 1 : 0;
            }
            
        }

        private void tmrIteracion_Tick(object sender, EventArgs e)
        {
            IniciaJuego();
            MatrizShow();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
