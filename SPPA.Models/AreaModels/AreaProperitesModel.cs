using SPPA.Models.Enumurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPA.Models.AreaModels
{
   public class AreaProperitesModel
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double AreaSquarSize { get {

                return Width * Height;
            } }       
        public List<AreaCellProperitesModel> AreaCells { get; set; }
        public int CountCellWidth { get; set; }
        public int CountCellHeight { get; set; }
        public int CellWidth { get {
                //96 DPI  it mean 96 pixcel in 1 inch and every 1 ince =2.54
                return Convert.ToInt32(VSR * (96 / 2.54));
            } }
        public int CellHeight { get {
                //96 DPI  it mean 96 pixcel in 1 inch and every 1 ince =2.54
                return Convert.ToInt32(VSR * (96 / 2.54));
            } }
        public AreaFigureShape AreaShape { get; set; }
        public UnitAreaSize UnitSize { get; set; }
        public int VSR { get; set; }
    }
}
