namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BillingScheduleSearchBasic : SearchRecordBasic {

        private SearchBooleanField applyToSubtotalField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField frequencyField;

        private SearchBooleanField inArrearsField;

        private SearchDoubleField initialAmountField;

        private SearchMultiSelectField initialTermsField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isPublicField;

        private SearchStringField nameField;

        private SearchLongField recurrenceCountField;

        private SearchEnumMultiSelectField recurrencePatternField;

        private SearchMultiSelectField recurrenceTermsField;

        private SearchLongField repeatEveryField;

        private SearchEnumMultiSelectField typeField;

        /// <remarks/>
        public SearchBooleanField applyToSubtotal {
            get {
                return this.applyToSubtotalField;
            }
            set {
                this.applyToSubtotalField = value;
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
        public SearchEnumMultiSelectField frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField inArrears {
            get {
                return this.inArrearsField;
            }
            set {
                this.inArrearsField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField initialAmount {
            get {
                return this.initialAmountField;
            }
            set {
                this.initialAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField initialTerms {
            get {
                return this.initialTermsField;
            }
            set {
                this.initialTermsField = value;
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
        public SearchBooleanField isPublic {
            get {
                return this.isPublicField;
            }
            set {
                this.isPublicField = value;
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
        public SearchLongField recurrenceCount {
            get {
                return this.recurrenceCountField;
            }
            set {
                this.recurrenceCountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField recurrencePattern {
            get {
                return this.recurrencePatternField;
            }
            set {
                this.recurrencePatternField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField recurrenceTerms {
            get {
                return this.recurrenceTermsField;
            }
            set {
                this.recurrenceTermsField = value;
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
        public SearchEnumMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}