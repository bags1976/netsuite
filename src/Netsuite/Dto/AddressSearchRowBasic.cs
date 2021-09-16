namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class AddressSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] addressField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] addresseeField;

        private SearchColumnStringField[] attentionField;

        private SearchColumnStringField[] cityField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countryCodeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] overrideField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnStringField[] stateField;

        private SearchColumnStringField[] zipField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address")]
        public SearchColumnStringField[] address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address1")]
        public SearchColumnStringField[] address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address2")]
        public SearchColumnStringField[] address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address3")]
        public SearchColumnStringField[] address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressee")]
        public SearchColumnStringField[] addressee {
            get {
                return this.addresseeField;
            }
            set {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attention")]
        public SearchColumnStringField[] attention {
            get {
                return this.attentionField;
            }
            set {
                this.attentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public SearchColumnStringField[] city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public SearchColumnStringField[] countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("override")]
        public SearchColumnBooleanField[] @override {
            get {
                return this.overrideField;
            }
            set {
                this.overrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnStringField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zip")]
        public SearchColumnStringField[] zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
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