namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class RevRecTemplateSearchBasic : SearchRecordBasic {

        private SearchEnumMultiSelectField amorMethodField;

        private SearchLongField amorPeriodField;

        private SearchLongField amorStartOffsetField;

        private SearchEnumMultiSelectField amorTermSrcField;

        private SearchEnumMultiSelectField amorTypeField;

        private SearchMultiSelectField contraAccountField;

        private SearchMultiSelectField deferralAccountField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchStringField nameField;

        private SearchLongField periodOffsetField;

        private SearchMultiSelectField targetAccountField;

        private SearchBooleanField useForeignAmountsField;

        /// <remarks/>
        public SearchEnumMultiSelectField amorMethod {
            get {
                return this.amorMethodField;
            }
            set {
                this.amorMethodField = value;
            }
        }

        /// <remarks/>
        public SearchLongField amorPeriod {
            get {
                return this.amorPeriodField;
            }
            set {
                this.amorPeriodField = value;
            }
        }

        /// <remarks/>
        public SearchLongField amorStartOffset {
            get {
                return this.amorStartOffsetField;
            }
            set {
                this.amorStartOffsetField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField amorTermSrc {
            get {
                return this.amorTermSrcField;
            }
            set {
                this.amorTermSrcField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField amorType {
            get {
                return this.amorTypeField;
            }
            set {
                this.amorTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField contraAccount {
            get {
                return this.contraAccountField;
            }
            set {
                this.contraAccountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField deferralAccount {
            get {
                return this.deferralAccountField;
            }
            set {
                this.deferralAccountField = value;
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
        public SearchLongField periodOffset {
            get {
                return this.periodOffsetField;
            }
            set {
                this.periodOffsetField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField targetAccount {
            get {
                return this.targetAccountField;
            }
            set {
                this.targetAccountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useForeignAmounts {
            get {
                return this.useForeignAmountsField;
            }
            set {
                this.useForeignAmountsField = value;
            }
        }
    }
}