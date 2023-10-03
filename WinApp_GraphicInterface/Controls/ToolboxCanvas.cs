using System.Drawing;
using FlowSharpLib;
using SPPA.Models.AreaModels;

namespace WinApp_GraphicInterface
{
	public class ToolboxCanvas : Canvas
	{
		public ToolboxCanvas(AreaProperitesModel areaProperites) :base( areaProperites)
		{ 
		
		}
		protected override void DrawBackground(Graphics gr)
		{
			gr.Clear(Color.LightGray);
		}

		protected override void DrawGrid(Graphics gr)
		{
		}
	}
}
