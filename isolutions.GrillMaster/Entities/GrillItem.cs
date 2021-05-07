using System;

namespace isolutions.GrillMaster.Entities
{
    public class GrillItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string Duration { get; set; }
        public int Quantity { get; set; }
    }
}
