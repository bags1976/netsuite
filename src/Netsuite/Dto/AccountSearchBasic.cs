namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountingContextField;

        private SearchDoubleField balanceField;

        private SearchEnumMultiSelectField cashFlowRateTypeField;

        private SearchMultiSelectField category1099MiscField;

        private SearchStringField descriptionField;

        private SearchStringField displayNameField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField generalRateTypeField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isInactiveField;

        private SearchStringField legalNameField;

        private SearchEnumMultiSelectField localeField;

        private SearchStringField localizedLegalNameField;

        private SearchStringField localizedNameField;

        private SearchStringField localizedNumberField;

        private SearchStringField nameField;

        private SearchStringField numberField;

        private SearchMultiSelectField parentField;

        private SearchMultiSelectField subsidiaryField;

        private SearchEnumMultiSelectField typeField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField accountingContext {
            get {
                return this.accountingContextField;
            }
            set {
                this.accountingContextField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField cashFlowRateType {
            get {
                return this.cashFlowRateTypeField;
            }
            set {
                this.cashFlowRateTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField category1099Misc {
            get {
                return this.category1099MiscField;
            }
            set {
                this.category1099MiscField = value;
            }
        }

        /// <remarks/>
        public SearchStringField description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
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
        public SearchEnumMultiSelectField generalRateType {
            get {
                return this.generalRateTypeField;
            }
            set {
                this.generalRateTypeField = value;
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
        public SearchStringField legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField localizedLegalName {
            get {
                return this.localizedLegalNameField;
            }
            set {
                this.localizedLegalNameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField localizedName {
            get {
                return this.localizedNameField;
            }
            set {
                this.localizedNameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField localizedNumber {
            get {
                return this.localizedNumberField;
            }
            set {
                this.localizedNumberField = value;
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
        public SearchStringField number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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