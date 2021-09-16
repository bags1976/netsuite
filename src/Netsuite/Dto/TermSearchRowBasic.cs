namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TermSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] dateDrivenField;

        private SearchColumnLongField[] dayDiscountExpiresField;

        private SearchColumnLongField[] dayOfMonthNetDueField;

        private SearchColumnLongField[] daysUntilExpiryField;

        private SearchColumnLongField[] daysUntilNetDueField;

        private SearchColumnDoubleField[] discountPercentField;

        private SearchColumnDoubleField[] discountPercentDateDrivenField;

        private SearchColumnLongField[] dueNextMonthIfWithinDaysField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] installmentField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnStringField[] nameField;

        private SearchColumnBooleanField[] preferredField;

        private SearchColumnLongField[] recurrenceCountField;

        private SearchColumnStringField[] recurrenceFrequencyField;

        private SearchColumnLongField[] repeatEveryField;

        private SearchColumnBooleanField[] splitEvenlyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateDriven")]
        public SearchColumnBooleanField[] dateDriven {
            get {
                return this.dateDrivenField;
            }
            set {
                this.dateDrivenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dayDiscountExpires")]
        public SearchColumnLongField[] dayDiscountExpires {
            get {
                return this.dayDiscountExpiresField;
            }
            set {
                this.dayDiscountExpiresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dayOfMonthNetDue")]
        public SearchColumnLongField[] dayOfMonthNetDue {
            get {
                return this.dayOfMonthNetDueField;
            }
            set {
                this.dayOfMonthNetDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysUntilExpiry")]
        public SearchColumnLongField[] daysUntilExpiry {
            get {
                return this.daysUntilExpiryField;
            }
            set {
                this.daysUntilExpiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysUntilNetDue")]
        public SearchColumnLongField[] daysUntilNetDue {
            get {
                return this.daysUntilNetDueField;
            }
            set {
                this.daysUntilNetDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("discountPercent")]
        public SearchColumnDoubleField[] discountPercent {
            get {
                return this.discountPercentField;
            }
            set {
                this.discountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("discountPercentDateDriven")]
        public SearchColumnDoubleField[] discountPercentDateDriven {
            get {
                return this.discountPercentDateDrivenField;
            }
            set {
                this.discountPercentDateDrivenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dueNextMonthIfWithinDays")]
        public SearchColumnLongField[] dueNextMonthIfWithinDays {
            get {
                return this.dueNextMonthIfWithinDaysField;
            }
            set {
                this.dueNextMonthIfWithinDaysField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("installment")]
        public SearchColumnBooleanField[] installment {
            get {
                return this.installmentField;
            }
            set {
                this.installmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferred")]
        public SearchColumnBooleanField[] preferred {
            get {
                return this.preferredField;
            }
            set {
                this.preferredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurrenceCount")]
        public SearchColumnLongField[] recurrenceCount {
            get {
                return this.recurrenceCountField;
            }
            set {
                this.recurrenceCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurrenceFrequency")]
        public SearchColumnStringField[] recurrenceFrequency {
            get {
                return this.recurrenceFrequencyField;
            }
            set {
                this.recurrenceFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeatEvery")]
        public SearchColumnLongField[] repeatEvery {
            get {
                return this.repeatEveryField;
            }
            set {
                this.repeatEveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("splitEvenly")]
        public SearchColumnBooleanField[] splitEvenly {
            get {
                return this.splitEvenlyField;
            }
            set {
                this.splitEvenlyField = value;
            }
        }
    }
}