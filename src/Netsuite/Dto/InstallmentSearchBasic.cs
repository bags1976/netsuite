namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InstallmentSearchBasic : SearchRecordBasic {

        private SearchDoubleField amountField;

        private SearchDoubleField amountPaidField;

        private SearchDoubleField amountRemainingField;

        private SearchLongField daysOverdueField;

        private SearchDateField dueDateField;

        private SearchDoubleField fxAmountField;

        private SearchDoubleField fxAmountPaidField;

        private SearchDoubleField fxAmountRemainingField;

        private SearchLongField installmentNumberField;

        private SearchCustomField[] customFieldListField;

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
        public SearchDoubleField amountPaid {
            get {
                return this.amountPaidField;
            }
            set {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchLongField daysOverdue {
            get {
                return this.daysOverdueField;
            }
            set {
                this.daysOverdueField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxAmount {
            get {
                return this.fxAmountField;
            }
            set {
                this.fxAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxAmountPaid {
            get {
                return this.fxAmountPaidField;
            }
            set {
                this.fxAmountPaidField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxAmountRemaining {
            get {
                return this.fxAmountRemainingField;
            }
            set {
                this.fxAmountRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchLongField installmentNumber {
            get {
                return this.installmentNumberField;
            }
            set {
                this.installmentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}