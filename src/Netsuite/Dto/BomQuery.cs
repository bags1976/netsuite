namespace Netsuite.Dto
{
    public class BomQuery : Bom
    {
        public string PreferredLocation { get; set; }
        public string DefaultForLocation { get; set; }
    }
}
