using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class Address : Record {

        private string internalIdField;

        private Country countryField;

        private bool countryFieldSpecified;

        private string attentionField;

        private string addresseeField;

        private string addrPhoneField;

        private string addr1Field;

        private string addr2Field;

        private string addr3Field;

        private string cityField;

        private string stateField;

        private string zipField;

        private string addrTextField;

        private bool overrideField;

        private bool overrideFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public Country country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countrySpecified {
            get {
                return this.countryFieldSpecified;
            }
            set {
                this.countryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string attention {
            get {
                return this.attentionField;
            }
            set {
                this.attentionField = value;
            }
        }

        /// <remarks/>
        public string addressee {
            get {
                return this.addresseeField;
            }
            set {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        public string addrPhone {
            get {
                return this.addrPhoneField;
            }
            set {
                this.addrPhoneField = value;
            }
        }

        /// <remarks/>
        public string addr1 {
            get {
                return this.addr1Field;
            }
            set {
                this.addr1Field = value;
            }
        }

        /// <remarks/>
        public string addr2 {
            get {
                return this.addr2Field;
            }
            set {
                this.addr2Field = value;
            }
        }

        /// <remarks/>
        public string addr3 {
            get {
                return this.addr3Field;
            }
            set {
                this.addr3Field = value;
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
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
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
        public string addrText {
            get {
                return this.addrTextField;
            }
            set {
                this.addrTextField = value;
            }
        }

        /// <remarks/>
        public bool @override {
            get {
                return this.overrideField;
            }
            set {
                this.overrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideSpecified {
            get {
                return this.overrideFieldSpecified;
            }
            set {
                this.overrideFieldSpecified = value;
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
    }
}