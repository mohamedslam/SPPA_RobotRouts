﻿using System.Collections.Generic;
using System.Drawing;

namespace FlowSharpLib
{
    public class LeftTriangle : GraphicElement
    {
        protected Point[] path;

        public LeftTriangle(Canvas canvas) : base(canvas)
        {
        }

        public override List<ConnectionPoint> GetConnectionPoints()
        {
            List<ConnectionPoint> connectionPoints = new List<ConnectionPoint>();
            connectionPoints.Add(new ConnectionPoint(GripType.LeftMiddle, DisplayRectangle.LeftMiddle()));
            connectionPoints.Add(new ConnectionPoint(GripType.RightMiddle, DisplayRectangle.RightMiddle()));
            connectionPoints.Add(new ConnectionPoint(GripType.TopRight, DisplayRectangle.TopRightCorner()));
            connectionPoints.Add(new ConnectionPoint(GripType.BottomRight, DisplayRectangle.BottomRightCorner()));

            return connectionPoints;
        }

        public override void UpdatePath()
        {
            path = new Point[]
            {
                new Point(DisplayRectangle.X,                             DisplayRectangle.Y + DisplayRectangle.Height/2),        // left, middle
                new Point(DisplayRectangle.X + DisplayRectangle.Width,          DisplayRectangle.Y),                              // right, top
                new Point(DisplayRectangle.X + DisplayRectangle.Width,          DisplayRectangle.Y + DisplayRectangle.Height),          // right, bottom
                new Point(DisplayRectangle.X,                             DisplayRectangle.Y + DisplayRectangle.Height/2),        // left, middle
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
