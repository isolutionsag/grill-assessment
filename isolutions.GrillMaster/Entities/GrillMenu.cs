using System;
using System.Collections.Generic;

namespace isolutions.GrillMaster.Entities
{
    public class GrillMenu
    {
        public Guid Id { get; set; }
        public string Menu { get; set; }
        public List<GrillItem> Items { get; set; }
    }
}
