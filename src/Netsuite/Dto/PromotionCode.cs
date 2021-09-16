namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class PromotionCode : Record {

        private RecordRef implementationField;

        private RecordRef customFormField;

        private PromotionCodeUseType useTypeField;

        private bool useTypeFieldSpecified;

        private bool displayLineDiscountsField;

        private bool displayLineDiscountsFieldSpecified;

        private string codeField;

        private string codePatternField;

        private long numberToGenerateField;

        private bool numberToGenerateFieldSpecified;

        private string descriptionField;

        private RecordRef[] locationListField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef discountField;

        private string rateField;

        private bool discountTypeField;

        private bool discountTypeFieldSpecified;

        private PromotionCodeApplyDiscountTo applyDiscountToField;

        private bool applyDiscountToFieldSpecified;

        private RecordRef freeShipMethodField;

        private double minimumOrderAmountField;

        private bool minimumOrderAmountFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private bool isPublicField;

        private bool isPublicFieldSpecified;

        private PromotionCodeCurrencyList currencyListField;

        private bool excludeItemsField;

        private bool excludeItemsFieldSpecified;

        private string nameField;

        private PromotionCodeItemsList itemsListField;

        private PromotionCodePartnersList partnersListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef implementation {
            get {
                return this.implementationField;
            }
            set {
                this.implementationField = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public PromotionCodeUseType useType {
            get {
                return this.useTypeField;
            }
            set {
                this.useTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useTypeSpecified {
            get {
                return this.useTypeFieldSpecified;
            }
            set {
                this.useTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool displayLineDiscounts {
            get {
                return this.displayLineDiscountsField;
            }
            set {
                this.displayLineDiscountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayLineDiscountsSpecified {
            get {
                return this.displayLineDiscountsFieldSpecified;
            }
            set {
                this.displayLineDiscountsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string codePattern {
            get {
                return this.codePatternField;
            }
            set {
                this.codePatternField = value;
            }
        }

        /// <remarks/>
        public long numberToGenerate {
            get {
                return this.numberToGenerateField;
            }
            set {
                this.numberToGenerateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberToGenerateSpecified {
            get {
                return this.numberToGenerateFieldSpecified;
            }
            set {
                this.numberToGenerateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] locationList {
            get {
                return this.locationListField;
            }
            set {
                this.locationListField = value;
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
        public RecordRef discount {
            get {
                return this.discountField;
            }
            set {
                this.discountField = value;
            }
        }

        /// <remarks/>
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public bool discountType {
            get {
                return this.discountTypeField;
            }
            set {
                this.discountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountTypeSpecified {
            get {
                return this.discountTypeFieldSpecified;
            }
            set {
                this.discountTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PromotionCodeApplyDiscountTo applyDiscountTo {
            get {
                return this.applyDiscountToField;
            }
            set {
                this.applyDiscountToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyDiscountToSpecified {
            get {
                return this.applyDiscountToFieldSpecified;
            }
            set {
                this.applyDiscountToFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef freeShipMethod {
            get {
                return this.freeShipMethodField;
            }
            set {
                this.freeShipMethodField = value;
            }
        }

        /// <remarks/>
        public double minimumOrderAmount {
            get {
                return this.minimumOrderAmountField;
            }
            set {
                this.minimumOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumOrderAmountSpecified {
            get {
                return this.minimumOrderAmountFieldSpecified;
            }
            set {
                this.minimumOrderAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isPublic {
            get {
                return this.isPublicField;
            }
            set {
                this.isPublicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPublicSpecified {
            get {
                return this.isPublicFieldSpecified;
            }
            set {
                this.isPublicFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PromotionCodeCurrencyList currencyList {
            get {
                return this.currencyListField;
            }
            set {
                this.currencyListField = value;
            }
        }

        /// <remarks/>
        public bool excludeItems {
            get {
                return this.excludeItemsField;
            }
            set {
                this.excludeItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeItemsSpecified {
            get {
                return this.excludeItemsFieldSpecified;
            }
            set {
                this.excludeItemsFieldSpecified = value;
            }
        }

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
        public PromotionCodeItemsList itemsList {
            get {
                return this.itemsListField;
            }
            set {
                this.itemsListField = value;
            }
        }

        /// <remarks/>
        public PromotionCodePartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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