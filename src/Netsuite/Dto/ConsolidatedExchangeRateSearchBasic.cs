namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ConsolidatedExchangeRateSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountingBookField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField fromSubsidiaryField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDerivedRateField;

        private SearchMultiSelectField periodField;

        private SearchDateField periodStartDateField;

        private SearchMultiSelectField toSubsidiaryField;

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
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField fromSubsidiary {
            get {
                return this.fromSubsidiaryField;
            }
            set {
                this.fromSubsidiaryField = value;
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
        public SearchBooleanField isDerivedRate {
            get {
                return this.isDerivedRateField;
            }
            set {
                this.isDerivedRateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public SearchDateField periodStartDate {
            get {
                return this.periodStartDateField;
            }
            set {
                this.periodStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }
    }
}