namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BillingScheduleSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] applyToSubtotalField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] frequencyField;

        private SearchColumnBooleanField[] inArrearsField;

        private SearchColumnStringField[] initialAmountField;

        private SearchColumnStringField[] initialTermsField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isPublicField;

        private SearchColumnStringField[] nameField;

        private SearchColumnLongField[] recurrenceCountField;

        private SearchColumnEnumSelectField[] recurrencePatternField;

        private SearchColumnStringField[] recurrenceTermsField;

        private SearchColumnLongField[] repeatEveryField;

        private SearchColumnEnumSelectField[] typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyToSubtotal")]
        public SearchColumnBooleanField[] applyToSubtotal {
            get {
                return this.applyToSubtotalField;
            }
            set {
                this.applyToSubtotalField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("frequency")]
        public SearchColumnEnumSelectField[] frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inArrears")]
        public SearchColumnBooleanField[] inArrears {
            get {
                return this.inArrearsField;
            }
            set {
                this.inArrearsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("initialAmount")]
        public SearchColumnStringField[] initialAmount {
            get {
                return this.initialAmountField;
            }
            set {
                this.initialAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("initialTerms")]
        public SearchColumnStringField[] initialTerms {
            get {
                return this.initialTermsField;
            }
            set {
                this.initialTermsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isPublic")]
        public SearchColumnBooleanField[] isPublic {
            get {
                return this.isPublicField;
            }
            set {
                this.isPublicField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("recurrencePattern")]
        public SearchColumnEnumSelectField[] recurrencePattern {
            get {
                return this.recurrencePatternField;
            }
            set {
                this.recurrencePatternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurrenceTerms")]
        public SearchColumnStringField[] recurrenceTerms {
            get {
                return this.recurrenceTermsField;
            }
            set {
                this.recurrenceTermsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public SearchColumnEnumSelectField[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}