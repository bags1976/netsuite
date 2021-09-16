namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AccountSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountingContextField;

        private SearchColumnDoubleField[] balanceField;

        private SearchColumnEnumSelectField[] cashFlowRateTypeField;

        private SearchColumnSelectField[] category1099MiscField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnStringField[] displayNameField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] generalRateTypeField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnStringField[] legalNameField;

        private SearchColumnStringField[] localeField;

        private SearchColumnStringField[] localizedLegalNameField;

        private SearchColumnStringField[] localizedNameField;

        private SearchColumnStringField[] localizedNumberField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] numberField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnEnumSelectField[] typeField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingContext")]
        public SearchColumnStringField[] accountingContext {
            get {
                return this.accountingContextField;
            }
            set {
                this.accountingContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("balance")]
        public SearchColumnDoubleField[] balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cashFlowRateType")]
        public SearchColumnEnumSelectField[] cashFlowRateType {
            get {
                return this.cashFlowRateTypeField;
            }
            set {
                this.cashFlowRateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category1099Misc")]
        public SearchColumnSelectField[] category1099Misc {
            get {
                return this.category1099MiscField;
            }
            set {
                this.category1099MiscField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("displayName")]
        public SearchColumnStringField[] displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("generalRateType")]
        public SearchColumnEnumSelectField[] generalRateType {
            get {
                return this.generalRateTypeField;
            }
            set {
                this.generalRateTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("legalName")]
        public SearchColumnStringField[] legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locale")]
        public SearchColumnStringField[] locale {
            get {
                return this.localeField;
            }
            set {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("localizedLegalName")]
        public SearchColumnStringField[] localizedLegalName {
            get {
                return this.localizedLegalNameField;
            }
            set {
                this.localizedLegalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("localizedName")]
        public SearchColumnStringField[] localizedName {
            get {
                return this.localizedNameField;
            }
            set {
                this.localizedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("localizedNumber")]
        public SearchColumnStringField[] localizedNumber {
            get {
                return this.localizedNumberField;
            }
            set {
                this.localizedNumberField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("number")]
        public SearchColumnStringField[] number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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