using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Term : Record {

        private string nameField;

        private bool dateDrivenField;

        private bool dateDrivenFieldSpecified;

        private long daysUntilNetDueField;

        private bool daysUntilNetDueFieldSpecified;

        private double discountPercentField;

        private bool discountPercentFieldSpecified;

        private long daysUntilExpiryField;

        private bool daysUntilExpiryFieldSpecified;

        private long dayOfMonthNetDueField;

        private bool dayOfMonthNetDueFieldSpecified;

        private long dueNextMonthIfWithinDaysField;

        private bool dueNextMonthIfWithinDaysFieldSpecified;

        private double discountPercentDateDrivenField;

        private bool discountPercentDateDrivenFieldSpecified;

        private long dayDiscountExpiresField;

        private bool dayDiscountExpiresFieldSpecified;

        private bool preferredField;

        private bool preferredFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool installmentField;

        private bool installmentFieldSpecified;

        private TermRecurrenceFrequency recurrenceFrequencyField;

        private bool recurrenceFrequencyFieldSpecified;

        private long recurrenceCountField;

        private bool recurrenceCountFieldSpecified;

        private long repeatEveryField;

        private bool repeatEveryFieldSpecified;

        private bool splitEvenlyField;

        private bool splitEvenlyFieldSpecified;

        private TermPercentagesList percentagesListField;

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
        public bool dateDriven {
            get {
                return this.dateDrivenField;
            }
            set {
                this.dateDrivenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateDrivenSpecified {
            get {
                return this.dateDrivenFieldSpecified;
            }
            set {
                this.dateDrivenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long daysUntilNetDue {
            get {
                return this.daysUntilNetDueField;
            }
            set {
                this.daysUntilNetDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysUntilNetDueSpecified {
            get {
                return this.daysUntilNetDueFieldSpecified;
            }
            set {
                this.daysUntilNetDueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discountPercent {
            get {
                return this.discountPercentField;
            }
            set {
                this.discountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountPercentSpecified {
            get {
                return this.discountPercentFieldSpecified;
            }
            set {
                this.discountPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long daysUntilExpiry {
            get {
                return this.daysUntilExpiryField;
            }
            set {
                this.daysUntilExpiryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysUntilExpirySpecified {
            get {
                return this.daysUntilExpiryFieldSpecified;
            }
            set {
                this.daysUntilExpiryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long dayOfMonthNetDue {
            get {
                return this.dayOfMonthNetDueField;
            }
            set {
                this.dayOfMonthNetDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dayOfMonthNetDueSpecified {
            get {
                return this.dayOfMonthNetDueFieldSpecified;
            }
            set {
                this.dayOfMonthNetDueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long dueNextMonthIfWithinDays {
            get {
                return this.dueNextMonthIfWithinDaysField;
            }
            set {
                this.dueNextMonthIfWithinDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueNextMonthIfWithinDaysSpecified {
            get {
                return this.dueNextMonthIfWithinDaysFieldSpecified;
            }
            set {
                this.dueNextMonthIfWithinDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discountPercentDateDriven {
            get {
                return this.discountPercentDateDrivenField;
            }
            set {
                this.discountPercentDateDrivenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountPercentDateDrivenSpecified {
            get {
                return this.discountPercentDateDrivenFieldSpecified;
            }
            set {
                this.discountPercentDateDrivenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long dayDiscountExpires {
            get {
                return this.dayDiscountExpiresField;
            }
            set {
                this.dayDiscountExpiresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dayDiscountExpiresSpecified {
            get {
                return this.dayDiscountExpiresFieldSpecified;
            }
            set {
                this.dayDiscountExpiresFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool preferred {
            get {
                return this.preferredField;
            }
            set {
                this.preferredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredSpecified {
            get {
                return this.preferredFieldSpecified;
            }
            set {
                this.preferredFieldSpecified = value;
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
        public bool installment {
            get {
                return this.installmentField;
            }
            set {
                this.installmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool installmentSpecified {
            get {
                return this.installmentFieldSpecified;
            }
            set {
                this.installmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TermRecurrenceFrequency recurrenceFrequency {
            get {
                return this.recurrenceFrequencyField;
            }
            set {
                this.recurrenceFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceFrequencySpecified {
            get {
                return this.recurrenceFrequencyFieldSpecified;
            }
            set {
                this.recurrenceFrequencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long recurrenceCount {
            get {
                return this.recurrenceCountField;
            }
            set {
                this.recurrenceCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurrenceCountSpecified {
            get {
                return this.recurrenceCountFieldSpecified;
            }
            set {
                this.recurrenceCountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long repeatEvery {
            get {
                return this.repeatEveryField;
            }
            set {
                this.repeatEveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool repeatEverySpecified {
            get {
                return this.repeatEveryFieldSpecified;
            }
            set {
                this.repeatEveryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool splitEvenly {
            get {
                return this.splitEvenlyField;
            }
            set {
                this.splitEvenlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool splitEvenlySpecified {
            get {
                return this.splitEvenlyFieldSpecified;
            }
            set {
                this.splitEvenlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TermPercentagesList percentagesList {
            get {
                return this.percentagesListField;
            }
            set {
                this.percentagesListField = value;
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