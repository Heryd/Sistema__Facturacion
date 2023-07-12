using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Capa_Presentacion
{
    public class Gradient_Label_Bounds : Label
    {
        private Color rightColor = Color.FromArgb(24, 24, 24);
        private Color leftColor = Color.FromArgb(40, 40, 40);
        private Color borderColor = Color.PaleVioletRed;
        private int borderRadius = 15;
        private int borderSize = 0;
        private ContentAlignment textAlign = ContentAlignment.MiddleCenter;

        [Category("RJ Advanced Option")]
        [Description("El color del lado derecho del degradado.")]
        public Color RightColor
        {
            get { return rightColor; }
            set
            {
                rightColor = value;
                Invalidate();
            }
        }

        [Category("RJ Advanced Option")]
        [Description("El color del lado izquierdo del degradado.")]
        public Color LeftColor
        {
            get { return leftColor; }
            set
            {
                leftColor = value;
                Invalidate();
            }
        }

        [Category("RJ Advanced Option")]
        [Description("El radio de los bordes curvos de nuestro label.")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("RJ Advanced Option")]
        [Description("El tamaño de los bordes de nuestro label.")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("La alineación del texto dentro del label.")]
        public override ContentAlignment TextAlign
        {
            get { return textAlign; }
            set
            {
                textAlign = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Center;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, rightColor, leftColor, 180f);
            pevent.Graphics.FillRectangle(lgb, ClientRectangle);
            lgb.Dispose();


            SizeF textSize = pevent.Graphics.MeasureString(Text, Font);

            // Calcular la posición del texto basado en la alineación seleccionada
            float textX = 0;
            float textY = (Height - textSize.Height) / 2; // Posición vertical centrada por defecto

            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    textX = 0;
                    break;
                case ContentAlignment.TopCenter:
                    textX = (Width - textSize.Width) / 2;
                    break;
                case ContentAlignment.TopRight:
                    textX = Width - textSize.Width;
                    break;
                case ContentAlignment.MiddleLeft:
                    textX = 0;
                    textY = (Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    textX = (Width - textSize.Width) / 2;
                    textY = (Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    textX = Width - textSize.Width;
                    textY = (Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    textX = 0;
                    textY = Height - textSize.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    textX = (Width - textSize.Width) / 2;
                    textY = Height - textSize.Height;
                    break;
                case ContentAlignment.BottomRight:
                    textX = Width - textSize.Width;
                    textY = Height - textSize.Height;
                    break;
            }

            pevent.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textX, textY);

        }

        public Gradient_Label_Bounds()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Label_Resize);
        }

        private void Label_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
