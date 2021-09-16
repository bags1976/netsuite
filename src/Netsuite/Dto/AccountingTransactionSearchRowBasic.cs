namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountingTransactionSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] accountField;

        private SearchColumnSelectField[] accountingBookField;

        private SearchColumnStringField[] accountTypeField;

        private SearchColumnDoubleField[] altSalesAmountField;

        private SearchColumnDoubleField[] altSalesNetAmountField;

        private SearchColumnDoubleField[] amountField;

        private SearchColumnStringField[] baseCurrencyField;

        private SearchColumnStringField[] catchUpPeriodField;

        private SearchColumnDoubleField[] creditAmountField;

        private SearchColumnBooleanField[] customGLField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnDoubleField[] debitAmountField;

        private SearchColumnBooleanField[] deferRevRecField;

        private SearchColumnDoubleField[] exchangeRateField;

        private SearchColumnDoubleField[] fxAmountField;

        private SearchColumnDoubleField[] grossAmountField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnBooleanField[] multiSubsidiaryField;

        private SearchColumnDoubleField[] netAmountField;

        private SearchColumnBooleanField[] postingField;

        private SearchColumnDoubleField[] quantityRevCommittedField;

        private SearchColumnDoubleField[] recognizedRevenueField;

        private SearchColumnEnumSelectField[] revCommitStatusField;

        private SearchColumnEnumSelectField[] revenueStatusField;

        private SearchColumnDateField[] revRecEndDateField;

        private SearchColumnBooleanField[] revRecOnRevCommitmentField;

        private SearchColumnDateField[] revRecStartDateField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnBooleanField[] tranIsVsoeBundleField;

        private SearchColumnDoubleField[] vsoeAllocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("account")]
        public SearchColumnSelectField[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnSelectField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountType")]
        public SearchColumnStringField[] accountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altSalesAmount")]
        public SearchColumnDoubleField[] altSalesAmount {
            get {
                return this.altSalesAmountField;
            }
            set {
                this.altSalesAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altSalesNetAmount")]
        public SearchColumnDoubleField[] altSalesNetAmount {
            get {
                return this.altSalesNetAmountField;
            }
            set {
                this.altSalesNetAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amount")]
        public SearchColumnDoubleField[] amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseCurrency")]
        public SearchColumnStringField[] baseCurrency {
            get {
                return this.baseCurrencyField;
            }
            set {
                this.baseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("catchUpPeriod")]
        public SearchColumnStringField[] catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditAmount")]
        public SearchColumnDoubleField[] creditAmount {
            get {
                return this.creditAmountField;
            }
            set {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customGL")]
        public SearchColumnBooleanField[] customGL {
            get {
                return this.customGLField;
            }
            set {
                this.customGLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateCreated")]
        public SearchColumnDateField[] dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("debitAmount")]
        public SearchColumnDoubleField[] debitAmount {
            get {
                return this.debitAmountField;
            }
            set {
                this.debitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferRevRec")]
        public SearchColumnBooleanField[] deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("exchangeRate")]
        public SearchColumnDoubleField[] exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxAmount")]
        public SearchColumnDoubleField[] fxAmount {
            get {
                return this.fxAmountField;
            }
            set {
                this.fxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grossAmount")]
        public SearchColumnDoubleField[] grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("multiSubsidiary")]
        public SearchColumnBooleanField[] multiSubsidiary {
            get {
                return this.multiSubsidiaryField;
            }
            set {
                this.multiSubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("netAmount")]
        public SearchColumnDoubleField[] netAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("posting")]
        public SearchColumnBooleanField[] posting {
            get {
                return this.postingField;
            }
            set {
                this.postingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityRevCommitted")]
        public SearchColumnDoubleField[] quantityRevCommitted {
            get {
                return this.quantityRevCommittedField;
            }
            set {
                this.quantityRevCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recognizedRevenue")]
        public SearchColumnDoubleField[] recognizedRevenue {
            get {
                return this.recognizedRevenueField;
            }
            set {
                this.recognizedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revCommitStatus")]
        public SearchColumnEnumSelectField[] revCommitStatus {
            get {
                return this.revCommitStatusField;
            }
            set {
                this.revCommitStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revenueStatus")]
        public SearchColumnEnumSelectField[] revenueStatus {
            get {
                return this.revenueStatusField;
            }
            set {
                this.revenueStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecEndDate")]
        public SearchColumnDateField[] revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecOnRevCommitment")]
        public SearchColumnBooleanField[] revRecOnRevCommitment {
            get {
                return this.revRecOnRevCommitmentField;
            }
            set {
                this.revRecOnRevCommitmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecStartDate")]
        public SearchColumnDateField[] revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranIsVsoeBundle")]
        public SearchColumnBooleanField[] tranIsVsoeBundle {
            get {
                return this.tranIsVsoeBundleField;
            }
            set {
                this.tranIsVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeAllocation")]
        public SearchColumnDoubleField[] vsoeAllocation {
            get {
                return this.vsoeAllocationField;
            }
            set {
                this.vsoeAllocationField = value;
            }
        }
    }
}