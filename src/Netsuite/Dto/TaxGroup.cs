namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TaxGroup : Record {

        private string itemIdField;

        private string descriptionField;

        private string stateField;

        private RecordRef[] subsidiaryListField;

        private RecordRef taxitem1Field;

        private string unitprice1Field;

        private RecordRef taxitem2Field;

        private string unitprice2Field;

        private bool piggybackField;

        private bool piggybackFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private double rateField;

        private bool rateFieldSpecified;

        private RecordRef taxTypeField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private string countyField;

        private string cityField;

        private string zipField;

        private RecordRef nexusCountryField;

        private bool isDefaultField;

        private bool isDefaultFieldSpecified;

        private TaxGroupTaxItemList taxItemListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
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
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] subsidiaryList {
            get {
                return this.subsidiaryListField;
            }
            set {
                this.subsidiaryListField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxitem1 {
            get {
                return this.taxitem1Field;
            }
            set {
                this.taxitem1Field = value;
            }
        }

        /// <remarks/>
        public string unitprice1 {
            get {
                return this.unitprice1Field;
            }
            set {
                this.unitprice1Field = value;
            }
        }

        /// <remarks/>
        public RecordRef taxitem2 {
            get {
                return this.taxitem2Field;
            }
            set {
                this.taxitem2Field = value;
            }
        }

        /// <remarks/>
        public string unitprice2 {
            get {
                return this.unitprice2Field;
            }
            set {
                this.unitprice2Field = value;
            }
        }

        /// <remarks/>
        public bool piggyback {
            get {
                return this.piggybackField;
            }
            set {
                this.piggybackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool piggybackSpecified {
            get {
                return this.piggybackFieldSpecified;
            }
            set {
                this.piggybackFieldSpecified = value;
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
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public RecordRef nexusCountry {
            get {
                return this.nexusCountryField;
            }
            set {
                this.nexusCountryField = value;
            }
        }

        /// <remarks/>
        public bool isDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultSpecified {
            get {
                return this.isDefaultFieldSpecified;
            }
            set {
                this.isDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TaxGroupTaxItemList taxItemList {
            get {
                return this.taxItemListField;
            }
            set {
                this.taxItemListField = value;
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