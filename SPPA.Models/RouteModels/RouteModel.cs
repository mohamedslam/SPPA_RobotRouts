using System;
using System.Collections.Generic;
using System.Text;

namespace SPPA.Models.RouteModels
{
  public  class RouteModel
    {
        public PointArea FromPoint { get; set; }
        public PointArea ToPoint { get; set; }
        public List<PointArea> RoutePoints { get; set; }

    }
}
