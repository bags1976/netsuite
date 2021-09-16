namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomerSubsidiaryRelationshipSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] balanceField;

        private SearchColumnDoubleField[] depositbalanceField;

        private SearchColumnSelectField[] entityField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isprimarysubField;

        private SearchColumnSelectField[] primaryCurrencyField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnDoubleField[] unbilledordersField;

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
        [System.Xml.Serialization.XmlElementAttribute("depositbalance")]
        public SearchColumnDoubleField[] depositbalance {
            get {
                return this.depositbalanceField;
            }
            set {
                this.depositbalanceField = value;
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