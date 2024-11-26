using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AguaFiel_App_v1
{
    internal partial class paneld : Panel
    {

        public Color ColorTop { get; set; } = Color.Indigo;
        public Color ColorBottom { get; set; } = Color.Black;
        public int BorderRadius { get; set; } = 30;

        public paneld()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //graficos y suavizado de bordes
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //area del panel con bordes redondeados
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                // Aplica la región redondeada al panel
                this.Region = new Region(path);

                // Dibuja gradiente
                using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F))
                {
                    g.FillPath(lgb, path);
                }
            }

            base.OnPaint(e);
        }

        //esquinas redondeadas
        private GraphicsPath GetRoundedPath(RectangleF rectangle, int radius)
        {
            float diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            // Arcos en las esquinas
            path.StartFigure();
            path.AddArc(rectangle.X, rectangle.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
            path.AddArc(rectangle.Width - diameter, rectangle.Y, diameter, diameter, 270, 90); // Esquina superior derecha
            path.AddArc(rectangle.Width - diameter, rectangle.Height - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
            path.AddArc(rectangle.X, rectangle.Height - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            return path;
        }
    }
}
