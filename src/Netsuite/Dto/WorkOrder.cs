using System;

namespace Netsuite.Dto
{
    public class WorkOrder : TransactionQuery
    {
        public string ManufacturingRouting { get; set; }
        public bool IsWip { get; set; }
        public decimal Quantity { get; set; }
        public string BillOfMaterials { get; set; }
        public string Units { get; set; }
        public bool Firmed { get; set; }
        public string Location { get; set; }
        // transaction id which originated the order
        public string CreatedFrom { get; set; }
        public string SourceTransaction { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ActualProductionStartDate { get; set; }
        public DateTime? ActualProductionEndDate { get; set; }
        public string BillOfMaterialsRevision { get; set; }
        public string Subsidiary { get; set; }
        public string ExternalId { get; set; }
    }
}
