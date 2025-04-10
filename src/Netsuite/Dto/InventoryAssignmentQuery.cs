using System;

namespace Netsuite.Dto
{
    public class InventoryAssignmentQuery
    {
        public decimal ReservedQuantity { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
