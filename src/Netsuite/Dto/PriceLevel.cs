namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class PriceLevel : Record {

        private string nameField;

        private double discountpctField;

        private bool discountpctFieldSpecified;

        private bool updateExistingPricesField;

        private bool updateExistingPricesFieldSpecified;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string internalIdField;

        private string externalIdField;

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
        public double discountpct {
            get {
                return this.discountpctField;
            }
            set {
                this.discountpctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountpctSpecified {
            get {
                return this.discountpctFieldSpecified;
            }
            set {
                this.discountpctFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool updateExistingPrices {
            get {
                return this.updateExistingPricesField;
            }
            set {
                this.updateExistingPricesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updateExistingPricesSpecified {
            get {
                return this.updateExistingPricesFieldSpecified;
            }
            set {
                this.updateExistingPricesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
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