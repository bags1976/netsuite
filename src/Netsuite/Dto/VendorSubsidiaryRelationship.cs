namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorSubsidiaryRelationship : Record {

        private RecordRef baseCurrencyField;

        private double creditLimitField;

        private bool creditLimitFieldSpecified;

        private RecordRef entityField;

        private bool isPrimarySubField;

        private bool isPrimarySubFieldSpecified;

        private RecordRef primaryCurrencyField;

        private RecordRef subsidiaryField;

        private RecordRef taxItemField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef baseCurrency {
            get {
                return this.baseCurrencyField;
            }
            set {
                this.baseCurrencyField = value;
            }
        }

        /// <remarks/>
        public double creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditLimitSpecified {
            get {
                return this.creditLimitFieldSpecified;
            }
            set {
                this.creditLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public bool isPrimarySub {
            get {
                return this.isPrimarySubField;
            }
            set {
                this.isPrimarySubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimarySubSpecified {
            get {
                return this.isPrimarySubFieldSpecified;
            }
            set {
                this.isPrimarySubFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef primaryCurrency {
            get {
                return this.primaryCurrencyField;
            }
            set {
                this.primaryCurrencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxItem {
            get {
                return this.taxItemField;
            }
            set {
                this.taxItemField = value;
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