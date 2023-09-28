﻿using System.ComponentModel;

namespace FlowSharpLib
{
	public class LineProperties : ElementProperties
	{
		[Category("Endcaps")]
		public AvailableLineCap StartCap { get; set; }
		[Category("Endcaps")]
		public AvailableLineCap EndCap { get; set; }

		public LineProperties(Line el) : base(el)
		{
			StartCap = el.StartCap;
			EndCap = el.EndCap;
		}

		public override void Update(GraphicElement el, string label)
		{
            // X1
            //(label == nameof(StartCap)).If(() => this.ChangePropertyWithUndoRedo<AvailableLineCap>(el, nameof(StartCap), nameof(StartCap)));
            //(label == nameof(EndCap)).If(() => this.ChangePropertyWithUndoRedo<AvailableLineCap>(el, nameof(EndCap), nameof(EndCap)));
            (label == nameof(StartCap)).If(() => ((Connector)el).StartCap = StartCap);
            (label == nameof(EndCap)).If(() => ((Connector)el).EndCap = EndCap);
            base.Update(el, label);
        }
    }
}