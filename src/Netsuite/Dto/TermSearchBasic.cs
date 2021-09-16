namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TermSearchBasic : SearchRecordBasic {

        private SearchBooleanField dateDrivenField;

        private SearchLongField dayDiscountExpiresField;

        private SearchLongField dayOfMonthNetDueField;

        private SearchLongField daysUntilExpiryField;

        private SearchLongField daysUntilNetDueField;

        private SearchDoubleField discountPercentField;

        private SearchDoubleField discountPercentDateDrivenField;

        private SearchLongField dueNextMonthIfWithinDaysField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField installmentField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchStringField nameField;

        private SearchBooleanField preferredField;

        private SearchLongField recurrenceCountField;

        private SearchEnumMultiSelectField recurrenceFrequencyField;

        private SearchLongField repeatEveryField;

        private SearchBooleanField splitEvenlyField;

        /// <remarks/>
        public SearchBooleanField dateDriven {
            get {
                return this.dateDrivenField;
            }
            set {
                this.dateDrivenField = value;
            }
        }

        /// <remarks/>
        public SearchLongField dayDiscountExpires {
            get {
                return this.dayDiscountExpiresField;
            }
            set {
                this.dayDiscountExpiresField = value;
            }
        }

        /// <remarks/>
        public SearchLongField dayOfMonthNetDue {
            get {
                return this.dayOfMonthNetDueField;
            }
            set {
                this.dayOfMonthNetDueField = value;
            }
        }

        /// <remarks/>
        public SearchLongField daysUntilExpiry {
            get {
                return this.daysUntilExpiryField;
            }
            set {
                this.daysUntilExpiryField = value;
            }
        }

        /// <remarks/>
        public SearchLongField daysUntilNetDue {
            get {
                return this.daysUntilNetDueField;
            }
            set {
                this.daysUntilNetDueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField discountPercent {
            get {
                return this.discountPercentField;
            }
            set {
                this.discountPercentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField discountPercentDateDriven {
            get {
                return this.discountPercentDateDrivenField;
            }
            set {
                this.discountPercentDateDrivenField = value;
            }
        }

        /// <remarks/>
        public SearchLongField dueNextMonthIfWithinDays {
            get {
                return this.dueNextMonthIfWithinDaysField;
            }
            set {
                this.dueNextMonthIfWithinDaysField = value;
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
        public SearchBooleanField installment {
            get {
                return this.installmentField;
            }
            set {
                this.installmentField = value;
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
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField preferred {
            get {
                return this.preferredField;
            }
            set {
                this.preferredField = value;
            }
        }

        /// <remarks/>
        public SearchLongField recurrenceCount {
            get {
                return this.recurrenceCountField;
            }
            set {
                this.recurrenceCountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField recurrenceFrequency {
            get {
                return this.recurrenceFrequencyField;
            }
            set {
                this.recurrenceFrequencyField = value;
            }
        }

        /// <remarks/>
        public SearchLongField repeatEvery {
            get {
                return this.repeatEveryField;
            }
            set {
                this.repeatEveryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField splitEvenly {
            get {
                return this.splitEvenlyField;
            }
            set {
                this.splitEvenlyField = value;
            }
        }
    }
}