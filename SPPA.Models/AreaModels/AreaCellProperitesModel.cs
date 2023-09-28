using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models.AreaModels
{
    public class AreaCellProperitesModel
    {
        public int CellIndex { get; set; }
        public int CellWidth { get; set; }
        public int CellHeight { get; set; }
        public int CellDigonal { get; set; }
        public PointArea CellPointXh1{get;set;}
        public PointArea CellPointXh2 { get; set; }
        public PointArea CellEndPoint { get; set; }
    }
}
