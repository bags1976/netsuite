namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class RevRecTemplate : Record {

        private string nameField;

        private RevRecScheduleAmortizationType amortizationTypeField;

        private bool amortizationTypeFieldSpecified;

        private RevRecScheduleRecurrenceType recurrenceTypeField;

        private bool recurrenceTypeFieldSpecified;

        private RevRecScheduleRecogIntervalSrc recogIntervalSrcField;

        private bool recogIntervalSrcFieldSpecified;

        private long amortizationPeriodField;

        private bool amortizationPeriodFieldSpecified;

        private long periodOffsetField;

        private bool periodOffsetFieldSpecified;

        private long revRecOffsetField;

        private bool revRecOffsetFieldSpecified;

        private double initialAmountField;

        private bool initialAmountFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RevRecTemplateRecurrenceList recurrenceListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleAmortizationType amortizationType {
            get {
                return this.amortizationTypeField;
            }
            set {
                this.amortizationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationTypeSpecified {
            get {
                return this.amortizationTypeFieldSpecified;
            }
            set {
                this.amortizationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleRecurrenceType recurrenceType {
            get {
                return this.recurrenceTypeField;
            }
            set {
                this.recurrenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceTypeSpecified {
            get {
                return this.recurrenceTypeFieldSpecified;
            }
            set {
                this.recurrenceTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleRecogIntervalSrc recogIntervalSrc {
            get {
                return this.recogIntervalSrcField;
            }
            set {
                this.recogIntervalSrcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recogIntervalSrcSpecified {
            get {
                return this.recogIntervalSrcFieldSpecified;
            }
            set {
                this.recogIntervalSrcFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long amortizationPeriod {
            get {
                return this.amortizationPeriodField;
            }
            set {
                this.amortizationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationPeriodSpecified {
            get {
                return this.amortizationPeriodFieldSpecified;
            }
            set {
                this.amortizationPeriodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long periodOffset {
            get {
                return this.periodOffsetField;
            }
            set {
                this.periodOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodOffsetSpecified {
            get {
                return this.periodOffsetFieldSpecified;
            }
            set {
                this.periodOffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long revRecOffset {
            get {
                return this.revRecOffsetField;
            }
            set {
                this.revRecOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecOffsetSpecified {
            get {
                return this.revRecOffsetFieldSpecified;
            }
            set {
                this.revRecOffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double initialAmount {
            get {
                return this.initialAmountField;
            }
            set {
                this.initialAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool initialAmountSpecified {
            get {
                return this.initialAmountFieldSpecified;
            }
            set {
                this.initialAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RevRecTemplateRecurrenceList recurrenceList {
            get {
                return this.recurrenceListField;
            }
            set {
                this.recurrenceListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}