namespace Netsuite.Dto
{
    public class BomQuery : Bom
    {
        public int ComponentId { get; set; }
        public string UnitsId { get; set; }
        public decimal Quantity { get; set; }
        public decimal BomQuantity { get; set; }
        public decimal ComponentYield { get; set; }
        public string ItemSource { get; set; }
        public string PreferredLocation { get; set; }
        public string DefaultForLocation { get; set; }
        public string ComponentItemType { get; set; }
        public string UnitsName { get; set; }
    }
}
