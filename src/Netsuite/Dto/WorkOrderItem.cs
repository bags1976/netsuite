namespace Netsuite.Dto
{
    public class WorkOrderItem : TransactionLineQuery
    {
        public string ItemId { get; set; }
        public string ItemType { get; set; }
    }
}
