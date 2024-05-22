using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Obsługa zdarzenia dla przycisku "Draw Sinus"
        private void btnDrawSin_Click(object sender, EventArgs e)
        {
           DrawGraph(Math.Sin, Color.Blue);
        }

        // Obsługa zdarzenia dla przycisku "Draw Cosinus"
        private void btnDrawCosinus_Click(object sender, EventArgs e)
        {
            DrawGraph(Math.Cos, Color.Red);
        }

        // Metoda do rysowania wykresu funkcji trygonometrycznej
        private void DrawGraph(Func<double, double> trigFunction, Color color)
        {
            Bitmap bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                Pen axisPen = new Pen(Color.Black, 2);
                Pen graphPen = new Pen(color, 2);

                // Rysowanie osi
                g.DrawLine(axisPen, 0, panelDraw.Height / 2, panelDraw.Width, panelDraw.Height / 2);
                g.DrawLine(axisPen, panelDraw.Width / 2, 0, panelDraw.Width / 2, panelDraw.Height);

                // Rysowanie wykresu
                for (int x = -panelDraw.Width / 2; x < panelDraw.Width / 2; x++)
                {
                    double radians = x * (Math.PI / 180);
                    double y = trigFunction(radians);

                    int screenX = x + panelDraw.Width / 2;
                    int screenY = (int)(-y * 50 + panelDraw.Height / 2); // Skalowanie i przesunięcie

                    if (x != -panelDraw.Width / 2)
                    {
                        g.DrawLine(graphPen, previousScreenX, previousScreenY, screenX, screenY);
                    }

                    previousScreenX = screenX;
                    previousScreenY = screenY;
                }
            }
            panelDraw.BackgroundImage = bitmap;
        }

        private int previousScreenX;
        private int previousScreenY;
    }
}
