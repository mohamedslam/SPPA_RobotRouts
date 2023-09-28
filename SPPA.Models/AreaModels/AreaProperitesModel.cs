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
        public int CountCellHeght { get; set; }
        public AreaFigureShape AreaShape { get; set; }
        public UnitAreaSize UnitSize { get; set; }
        public int VSR { get; set; }
    }
}
