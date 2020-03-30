using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Material
    {
        public Guid MaterialID { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string DrawingNumber { get; set; }
        public decimal Budget { get; set; }
    }
}
