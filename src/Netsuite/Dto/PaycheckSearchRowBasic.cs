namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PaycheckSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] accountField;

        private SearchColumnDateField[] amendedDateField;

        private SearchColumnDoubleField[] amountField;

        private SearchColumnLongField[] batchNumberField;

        private SearchColumnDateField[] checkDateField;

        private SearchColumnSelectField[] employeeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] hasGLImpactField;

        private SearchColumnDoubleField[] hoursField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] payrollItemField;

        private SearchColumnSelectField[] payrollItemTypeField;

        private SearchColumnDoubleField[] subjectWagesField;

        private SearchColumnDoubleField[] taxableWagesField;

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
        [System.Xml.Serialization.XmlElementAttribute("amendedDate")]
        public SearchColumnDateField[] amendedDate {
            get {
                return this.amendedDateField;
            }
            set {
                this.amendedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("batchNumber")]
        public SearchColumnLongField[] batchNumber {
            get {
                return this.batchNumberField;
            }
            set {
                this.batchNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("checkDate")]
        public SearchColumnDateField[] checkDate {
            get {
                return this.checkDateField;
            }
            set {
                this.checkDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employee")]
        public SearchColumnSelectField[] employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hasGLImpact")]
        public SearchColumnBooleanField[] hasGLImpact {
            get {
                return this.hasGLImpactField;
            }
            set {
                this.hasGLImpactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hours")]
        public SearchColumnDoubleField[] hours {
            get {
                return this.hoursField;
            }
            set {
                this.hoursField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("payrollItem")]
        public SearchColumnSelectField[] payrollItem {
            get {
                return this.payrollItemField;
            }
            set {
                this.payrollItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payrollItemType")]
        public SearchColumnSelectField[] payrollItemType {
            get {
                return this.payrollItemTypeField;
            }
            set {
                this.payrollItemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subjectWages")]
        public SearchColumnDoubleField[] subjectWages {
            get {
                return this.subjectWagesField;
            }
            set {
                this.subjectWagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxableWages")]
        public SearchColumnDoubleField[] taxableWages {
            get {
                return this.taxableWagesField;
            }
            set {
                this.taxableWagesField = value;
            }
        }
    }
}