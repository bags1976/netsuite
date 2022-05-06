using System;

namespace Netsuite.Dto
{
    public class AccountQuery
    {
        public string Id { get; set; }
        public string Category1099Misc { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string GeneralRate { get; set; }
        public string CashflowRate { get; set; }
        public bool IncludeChildren { get; set; }
        public string Subsidiary { get; set; }
        public string Accttype { get; set; }
        public string Fullname { get; set; }
        public string DisplayNameWithHierarchy { get; set; }
        public string Location { get; set; }
        public bool ReconcileWithMatching { get; set; }
        public string AccountSearchDisplayName { get; set; }
        public bool IsInactive { get; set; }
        public string Parent { get; set; }
        public bool IsSummary { get; set; }
        public string BillableExpensesAcct { get; set; }
        public bool Eliminate { get; set; }
        public string ExternalId { get; set; }
        public bool Inventory { get; set; }
        public string Description { get; set; }
        public bool Revalue { get; set; }
        public string AcctNumber { get; set; }
        public string Class { get; set; }
        public string SspecAcct { get; set; }
        public string AccountSearchDisplayNameCopy { get; set; }
        public string Currency { get; set; }
        public string Department { get; set; }
        public string AccountType { get; set; }
    }
}
