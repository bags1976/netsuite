namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class ContactAddressbook {

        private bool defaultShippingField;

        private bool defaultShippingFieldSpecified;

        private bool defaultBillingField;

        private bool defaultBillingFieldSpecified;

        private string labelField;

        private Address addressbookAddressField;

        private string internalIdField;

        /// <remarks/>
        public bool defaultShipping {
            get {
                return this.defaultShippingField;
            }
            set {
                this.defaultShippingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultShippingSpecified {
            get {
                return this.defaultShippingFieldSpecified;
            }
            set {
                this.defaultShippingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool defaultBilling {
            get {
                return this.defaultBillingField;
            }
            set {
                this.defaultBillingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultBillingSpecified {
            get {
                return this.defaultBillingFieldSpecified;
            }
            set {
                this.defaultBillingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public Address addressbookAddress {
            get {
                return this.addressbookAddressField;
            }
            set {
                this.addressbookAddressField = value;
            }
        }

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }
    }
}