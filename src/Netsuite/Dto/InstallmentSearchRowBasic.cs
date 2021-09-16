namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InstallmentSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] amountField;

        private SearchColumnDoubleField[] amountPaidField;

        private SearchColumnDoubleField[] amountRemainingField;

        private SearchColumnLongField[] daysOverdueField;

        private SearchColumnDateField[] dueDateField;

        private SearchColumnDoubleField[] fxAmountField;

        private SearchColumnDoubleField[] fxAmountPaidField;

        private SearchColumnDoubleField[] fxAmountRemainingField;

        private SearchColumnLongField[] installmentNumberField;

        private SearchColumnStringField[] statusField;

        private SearchColumnCustomField[] customFieldListField;

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
        [System.Xml.Serialization.XmlElementAttribute("amountPaid")]
        public SearchColumnDoubleField[] amountPaid {
            get {
                return this.amountPaidField;
            }
            set {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amountRemaining")]
        public SearchColumnDoubleField[] amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysOverdue")]
        public SearchColumnLongField[] daysOverdue {
            get {
                return this.daysOverdueField;
            }
            set {
                this.daysOverdueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dueDate")]
        public SearchColumnDateField[] dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fxAmountPaid")]
        public SearchColumnDoubleField[] fxAmountPaid {
            get {
                return this.fxAmountPaidField;
            }
            set {
                this.fxAmountPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxAmountRemaining")]
        public SearchColumnDoubleField[] fxAmountRemaining {
            get {
                return this.fxAmountRemainingField;
            }
            set {
                this.fxAmountRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("installmentNumber")]
        public SearchColumnLongField[] installmentNumber {
            get {
                return this.installmentNumberField;
            }
            set {
                this.installmentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnStringField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}