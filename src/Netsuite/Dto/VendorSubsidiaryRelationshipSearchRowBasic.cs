namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class VendorSubsidiaryRelationshipSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] balanceField;

        private SearchColumnDoubleField[] balancebaseField;

        private SearchColumnSelectField[] baseCurrencyField;

        private SearchColumnDoubleField[] creditlimitField;

        private SearchColumnSelectField[] entityField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnDoubleField[] inTransitBalanceField;

        private SearchColumnDoubleField[] inTransitBalanceBaseField;

        private SearchColumnBooleanField[] isprimarysubField;

        private SearchColumnSelectField[] primaryCurrencyField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] taxitemField;

        private SearchColumnDoubleField[] unbilledordersField;

        private SearchColumnDoubleField[] unbilledordersbaseField;

        private SearchColumnCustomField[] customFieldListField;

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
        [System.Xml.Serialization.XmlElementAttribute("balancebase")]
        public SearchColumnDoubleField[] balancebase {
            get {
                return this.balancebaseField;
            }
            set {
                this.balancebaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseCurrency")]
        public SearchColumnSelectField[] baseCurrency {
            get {
                return this.baseCurrencyField;
            }
            set {
                this.baseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditlimit")]
        public SearchColumnDoubleField[] creditlimit {
            get {
                return this.creditlimitField;
            }
            set {
                this.creditlimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entity")]
        public SearchColumnSelectField[] entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("inTransitBalance")]
        public SearchColumnDoubleField[] inTransitBalance {
            get {
                return this.inTransitBalanceField;
            }
            set {
                this.inTransitBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inTransitBalanceBase")]
        public SearchColumnDoubleField[] inTransitBalanceBase {
            get {
                return this.inTransitBalanceBaseField;
            }
            set {
                this.inTransitBalanceBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isprimarysub")]
        public SearchColumnBooleanField[] isprimarysub {
            get {
                return this.isprimarysubField;
            }
            set {
                this.isprimarysubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primaryCurrency")]
        public SearchColumnSelectField[] primaryCurrency {
            get {
                return this.primaryCurrencyField;
            }
            set {
                this.primaryCurrencyField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("taxitem")]
        public SearchColumnSelectField[] taxitem {
            get {
                return this.taxitemField;
            }
            set {
                this.taxitemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unbilledorders")]
        public SearchColumnDoubleField[] unbilledorders {
            get {
                return this.unbilledordersField;
            }
            set {
                this.unbilledordersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unbilledordersbase")]
        public SearchColumnDoubleField[] unbilledordersbase {
            get {
                return this.unbilledordersbaseField;
            }
            set {
                this.unbilledordersbaseField = value;
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