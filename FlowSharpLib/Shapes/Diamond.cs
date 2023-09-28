using System.Drawing;

namespace FlowSharpLib
{
	public class Diamond : GraphicElement
	{
		protected Point[] path;

		public Diamond(Canvas canvas) : base(canvas)
		{
			HasCornerConnections = false;
		}

		public override void UpdatePath()
		{
			path = new Point[]
			{
				new Point(DisplayRectangle.X,                             DisplayRectangle.Y + DisplayRectangle.Height/2),
				new Point(DisplayRectangle.X + DisplayRectangle.Width/2,		DisplayRectangle.Y),
				new Point(DisplayRectangle.X + DisplayRectangle.Width,    DisplayRectangle.Y + DisplayRectangle.Height/2),
				new Point(DisplayRectangle.X + DisplayRectangle.Width/2,		DisplayRectangle.Y + DisplayRectangle.Height),
			};
		}

		public override void Draw(Graphics gr)
		{
			gr.FillPolygon(FillBrush, path);
			gr.DrawPolygon(BorderPen, path);
			base.Draw(gr);
		}
	}
}
