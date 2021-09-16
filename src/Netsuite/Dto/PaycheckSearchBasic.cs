namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaycheckSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchLongField batchNumberField;

        private SearchDateField checkDateField;

        private SearchMultiSelectField employeeField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField hasGLImpactField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField payrollItemField;

        private SearchMultiSelectField payrollItemTypeField;

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
        public SearchLongField batchNumber {
            get {
                return this.batchNumberField;
            }
            set {
                this.batchNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDateField checkDate {
            get {
                return this.checkDateField;
            }
            set {
                this.checkDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
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
        public SearchBooleanField hasGLImpact {
            get {
                return this.hasGLImpactField;
            }
            set {
                this.hasGLImpactField = value;
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
        public SearchMultiSelectField payrollItem {
            get {
                return this.payrollItemField;
            }
            set {
                this.payrollItemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField payrollItemType {
            get {
                return this.payrollItemTypeField;
            }
            set {
                this.payrollItemTypeField = value;
            }
        }
    }
}