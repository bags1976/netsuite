namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountingTransactionSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchMultiSelectField accountingBookField;

        private SearchMultiSelectField accountTypeField;

        private SearchDoubleField altSalesAmountField;

        private SearchDoubleField altSalesNetAmountField;

        private SearchDoubleField amountField;

        private SearchBooleanField bookSpecificTransactionField;

        private SearchMultiSelectField catchUpPeriodField;

        private SearchDoubleField creditAmountField;

        private SearchBooleanField customGLField;

        private SearchDoubleField debitAmountField;

        private SearchBooleanField deferRevRecField;

        private SearchDoubleField exchangeRateField;

        private SearchDoubleField grossAmountField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField multiSubsidiaryField;

        private SearchDoubleField netAmountField;

        private SearchBooleanField postingField;

        private SearchDoubleField quantityRevCommittedField;

        private SearchDoubleField recognizedRevenueField;

        private SearchEnumMultiSelectField revCommitStatusField;

        private SearchEnumMultiSelectField revenueStatusField;

        private SearchDateField revRecEndDateField;

        private SearchBooleanField revRecOnRevCommitmentField;

        private SearchDateField revRecStartDateField;

        private SearchMultiSelectField subsidiaryField;

        private SearchBooleanField tranIsVsoeBundleField;

        private SearchEnumMultiSelectField typeField;

        private SearchDoubleField vsoeAllocationField;

        /// <remarks/>
        public SearchMultiSelectField account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField altSalesAmount {
            get {
                return this.altSalesAmountField;
            }
            set {
                this.altSalesAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField altSalesNetAmount {
            get {
                return this.altSalesNetAmountField;
            }
            set {
                this.altSalesNetAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField bookSpecificTransaction {
            get {
                return this.bookSpecificTransactionField;
            }
            set {
                this.bookSpecificTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField creditAmount {
            get {
                return this.creditAmountField;
            }
            set {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField customGL {
            get {
                return this.customGLField;
            }
            set {
                this.customGLField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField debitAmount {
            get {
                return this.debitAmountField;
            }
            set {
                this.debitAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField multiSubsidiary {
            get {
                return this.multiSubsidiaryField;
            }
            set {
                this.multiSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField netAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField posting {
            get {
                return this.postingField;
            }
            set {
                this.postingField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityRevCommitted {
            get {
                return this.quantityRevCommittedField;
            }
            set {
                this.quantityRevCommittedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recognizedRevenue {
            get {
                return this.recognizedRevenueField;
            }
            set {
                this.recognizedRevenueField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField revCommitStatus {
            get {
                return this.revCommitStatusField;
            }
            set {
                this.revCommitStatusField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField revenueStatus {
            get {
                return this.revenueStatusField;
            }
            set {
                this.revenueStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDateField revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField revRecOnRevCommitment {
            get {
                return this.revRecOnRevCommitmentField;
            }
            set {
                this.revRecOnRevCommitmentField = value;
            }
        }

        /// <remarks/>
        public SearchDateField revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField tranIsVsoeBundle {
            get {
                return this.tranIsVsoeBundleField;
            }
            set {
                this.tranIsVsoeBundleField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vsoeAllocation {
            get {
                return this.vsoeAllocationField;
            }
            set {
                this.vsoeAllocationField = value;
            }
        }
    }
}