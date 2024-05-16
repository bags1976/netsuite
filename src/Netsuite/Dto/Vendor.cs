using System;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    public class Vendor : Record
    {
        public string EntityId { get; set; }
        public string EntityTitle { get; set; }
        public string Addressee { get; set; }
        public string AddressKey { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
        public string CustomForm { get; set; }
        public string AltName { get; set; }
        public bool IsPerson { get; set; }
        public string PhoneticName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string DefaultAddress { get; set; }
        public bool IsInactive { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string PrintOnCheckAs { get; set; }
        public string AltPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string AltEmail { get; set; }
        public string Comments { get; set; }
        public string GlobalSubscriptionStatus { get; set; }
        public string Image { get; set; }
        public EmailPreference EmailPreference { get; set; }
        public string Subsidiary { get; set; }
        public string RepresentingSubsidiary { get; set; }
        public string AccountNumber { get; set; }
        public string LegalName { get; set; }
        public string VatRegNumber { get; set; }
        public string ExpenseAccount { get; set; }
        public string PayablesAccount { get; set; }
        public string Terms { get; set; }
        public string Incoterm { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? BalancePrimary { get; set; }
        public decimal? OpeningBalance { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public string OpeningBalanceAccount { get; set; }
        public decimal? Balance { get; set; }
        public decimal? UnbilledOrdersPrimary { get; set; }
        public string Bcnv { get; set; }
        public decimal? UnbilledOrders { get; set; }
        public bool Is1099Eligible { get; set; }
        public bool IsJobResourceVend { get; set; }
        public decimal? LaborCost { get; set; }
        public decimal? PurchaseOrderQuantity { get; set; }
        public decimal? PurchaseOrderAmount { get; set; }
        public decimal? PurchaseOrderQuantityDiff { get; set; }
        public decimal? ReceiptQuantity { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? ReceiptQuantityDiff { get; set; }
        public string WorkCalendar { get; set; }
        public string TaxIdNum { get; set; }
        public string TaxItem { get; set; }
        public bool GiveAccess { get; set; }
        public bool SendEmail { get; set; }
        public bool BillPay { get; set; }
        public bool IsAccountant { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public bool RequirePwdChange { get; set; }
        public bool EligibleForCommission { get; set; }
        public bool EmailTransactions { get; set; }
        public bool PrintTransactions { get; set; }
        public bool FaxTransactions { get; set; }
        public string DefaultTaxReg { get; set; }
        public long? PredictedDays { get; set; }
        public decimal? PredConfidence { get; set; }
        public string InternalId { get; set; }
        public string ExternalId { get; set; }
    }
}