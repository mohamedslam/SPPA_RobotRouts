using SPPA.Models.AreaModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlowSharpLib
{
    public class Canvas : Panel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Action<Canvas> PaintComplete { get; set; }
		public Color BackgroundColor { get { return canvasBrush.Color; } }
		public BaseController Controller { get; set; }
		public Bitmap Bitmap { get { return bitmap; } }

		protected SolidBrush canvasBrush;   
        protected Size gridSpacing;
        protected Bitmap bitmap;
        protected Point origin = new Point(0, 0);
        protected Point dragOffset = new Point(0, 0);

		protected Graphics graphics;
		protected Graphics antiAliasGraphics;

        public Graphics Graphics { get { return graphics; } }
        public Graphics AntiAliasGraphics { get { return antiAliasGraphics; } }

        protected AreaProperitesModel AreaProperites { get; set; }
        protected int  heightArea { get; set; }
        
        public Canvas(AreaProperitesModel areaProperites)
        {           
            AreaProperites = areaProperites;    
            GridCoordinatesVerticalPoints = new List<Point>();
            GridCoordinatesHorizontalPoints = new List<Point>();
            DoubleBuffered = true;
            canvasBrush = new SolidBrush(Color.White);           
            gridSpacing = new Size(areaProperites.CellWidth, areaProperites.CellHeight);
            Paint += OnPaint;


        }

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);

			if (disposing)
			{
				graphics.Dispose();
				antiAliasGraphics.Dispose();
				canvasBrush.Dispose();              
				bitmap.Dispose();
			}
		}

		public void Initialize(Control parent)
        {
            Dock = DockStyle.Fill;
            parent.Controls.Add(this);

            if (FindForm().WindowState != FormWindowState.Minimized)
            {
                CreateBitmap();
            }

            parent.Resize += (sndr, args) =>
            {
                if (FindForm().WindowState != FormWindowState.Minimized)
                {
                    bitmap?.Dispose();
                    CreateBitmap();
                    Invalidate();
                }
            };
        }

        public void DrawImage(Bitmap img, Rectangle r)
        {
            Graphics.DrawImage(img, r);
        }

        public Bitmap GetImage(Rectangle r)
        {
            return bitmap.Clone(r, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        public void CopyToScreen(Rectangle r)
        {
			Bitmap b = bitmap.Clone(r, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics grScreen = CreateGraphics();
            grScreen.DrawImage(b, r);
			b.Dispose();
            grScreen.Dispose();
        }

        public bool OnScreen(Rectangle r)
        {
            return r.X < bitmap.Width && r.Y < bitmap.Height && r.Location.X + r.Width >= 0 && r.Location.Y + r.Height >= 0 && r.Width > 0 && r.Height > 0;
        }

        public void Drag(Point p)
        {
            dragOffset = new Point((dragOffset.X + p.X) % gridSpacing.Width, (dragOffset.Y + p.Y) % gridSpacing.Height);
        }

        public Rectangle Clip(Rectangle r)
        {
            int x = r.X.Max(0);
            int y = r.Y.Max(0);
            int width = (r.X + r.Width).Min(bitmap.Width) - r.X;
            int height = (r.Y + r.Height).Min(bitmap.Height) - r.Y;

            width += r.X - x;
            height += r.Y - y;

            return new Rectangle(x, y, width, height);
        }

		public void CreateBitmap(int w, int h)
		{
			bitmap = new Bitmap(w, h);
			CreateGraphicsObjects();
		}

//        Knowing that you can calcuate the largest bitmap you can create.

//The max is object size is 2GB:2,147,483,648
//Default bitmap is 32bpp(4 bytes), the largest area we can have is 2GB / 4 = 536,870,912
//If we want a square, the largest we can get is sqrt(2GB/4) = 23,170
//So the following code works fine:

//Bitmap b = new Bitmap(23170, 23170);
//        But the following fails:

//Bitmap b = new Bitmap(23171, 23170);
//        If you want to store an image with larger dimensions, you would have to change the pixel format to a lower number of bpp:

//Bitmap b = new Bitmap(65535, 65535, PixelFormat.Format4bppIndexed);
        protected void CreateBitmap()
        {
            try
            {
               bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
                 // bitmap = new Bitmap(23170, 23170);
                CreateGraphicsObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

		protected void CreateGraphicsObjects()
		{
			graphics = Graphics.FromImage(bitmap);
			antiAliasGraphics = Graphics.FromImage(bitmap);
			antiAliasGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
		}
      
		protected void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = Graphics;
            DrawBackground(gr);
           
            DrawGrid(gr);
            PaintComplete(this);
            e.Graphics.DrawImage(bitmap, origin);
           
        }

        protected virtual void DrawBackground(Graphics gr)
        {
			gr.Clear(canvasBrush.Color);
        }
        public List<Point> GridCoordinatesVerticalPoints { get; set; }
        public List<Point> GridCoordinatesHorizontalPoints { get; set; }

        /// <summary>
        /// main methods for create Grid Area's lines virtical and horizntal
        /// </summary>
        /// <param name="gr">object control graphic which will display Grid Area </param>
        protected virtual void DrawGrid(Graphics gr)
        {
            GridCoordinatesVerticalPoints.Clear();
            GridCoordinatesHorizontalPoints.Clear();
            DrawVerticalGridLines(gr);
            DrawHorizontalGridLines(gr);
            DrawCardinatsPoints(gr);
        }

        public void DrawCardinatsPoints(Graphics gr) {
            foreach (var pointV in GridCoordinatesVerticalPoints)
            {
                foreach (var pointH in GridCoordinatesHorizontalPoints)
                {
                    Pen blackPen = new Pen(Color.Black, 3);

                    // Create rectangle for ellipse.
                 
                        DrawEllipse(gr, blackPen,
                                                  new PointF(pointV.X - 2.5f, pointH.Y - 2.5f),
                                                  new SizeF(5.0f, 5.0f));
                }
            }
        }
        public void DrawEllipse(Graphics gr,Pen pen,PointF fromPoint,SizeF size) {
            RectangleF rec = new RectangleF(fromPoint,size);
         gr.DrawEllipse(pen, rec);
        }

        /// <summary>
        /// create Grid Area's lines virtical
        /// </summary>
        /// <param name="gr">object control graphic which will display Grid Area</param>
        public void DrawVerticalGridLines(Graphics gr)
        {
            this.DisplayRectangle.Height.Step2(
                gridSpacing.Height, 
                ((y) =>
                  DisplayRectangle.Width.Step2(gridSpacing.Width, (x) =>
                      DrawLineVertical(gr,new Point( x + dragOffset.X, 0),
                                           new Point( x + dragOffset.X, DisplayRectangle.Height))))
              );
    
        }

        /// <summary>
        /// create Grid Area's lines virtical
        /// </summary>
        /// <param name="gr">object control graphic which will display Grid Area</param>
        public void DrawHorizontalGridLines(Graphics gr)
        {            
            this.DisplayRectangle.Width.Step2
                (gridSpacing.Width,
                ((x) =>
                    DisplayRectangle.Height.Step2(gridSpacing.Height, (y) =>
                        DrawLineHorizontal(gr,new Point( 0, y+dragOffset.Y), 
                                              new Point(DisplayRectangle.Width, y+dragOffset.Y))
                )));
             
        }

        /// <summary>
        /// Drow Graphic Vertical line and Record Every Point in Area
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="fromPoint">Start Point of Line</param>
        /// <param name="toPoint">End Point of Line</param>
        protected void DrawLineVertical(Graphics gr,Point fromPoint, Point toPoint)
        {            
            Pen gridPenVertical = penDashProperites(Color.LightBlue, 0.5f, 3, 2, 1);
            gr.DrawLine(gridPenVertical, fromPoint, toPoint);
        
            GridCoordinatesVerticalPoints.Add(fromPoint);
        }

        protected void DrawLineHorizontal(Graphics gr, Point fromPoint, Point toPoint)
        {           
            Pen gridPenHorizntal = penDashProperites(Color.DeepSkyBlue, 1f, 3,2,1);
            gr.DrawLine(gridPenHorizntal, fromPoint, toPoint);
          
            GridCoordinatesHorizontalPoints.Add(fromPoint);
        }

        protected Pen penDashProperites(Color color,float penSize,params float[] dashValues) {            
            Pen gridPen = new Pen(color, penSize);
            gridPen.DashPattern = dashValues;
            return gridPen;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.ResumeLayout(false);

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
    }
}
