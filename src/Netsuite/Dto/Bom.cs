using System;

namespace Netsuite.Dto
{
    public class Bom : Record
    {
        public int AssemblyId { get; set; }
        public int BomId { get; set; }
        public string Subsidiary { get; set; }
        public string BomName { get; set; }
        public DateTime BomCreatedDate { get; set; }
        public bool BomIsInactive { get; set; }
        public string BomExternalId { get; set; }
        public string AssemblyName { get; set; }
        public bool AssemblyIsInactive { get; set; }
        public string AssemblyDescription { get; set; }
        public string RevisionName { get; set; }
        public int RevisionId { get; set; }
        public DateTime RevisionCreatedDate { get; set; }
        public string RevisionExternalId { get; set; }
        public bool RevisionIsInactive { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string Description { get; set; }
        public string ComponentName { get; set; }
        public string RestrictToLocations { get; set; }
        public int ComponentLineId { get; set; }
        public int Units { get; set; }
        public RecordRef CustomForm { get; set; }
        public string Name { get; set; }
        public bool UsedOnAssembly { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool UseComponentYield { get; set; }
        public string Memo { get; set; }
        public RecordRef LegacyBomForAssembly { get; set; }
        public bool AvailableForAllAssemblies { get; set; }
        public bool IncludeChildren { get; set; }
    }
}
