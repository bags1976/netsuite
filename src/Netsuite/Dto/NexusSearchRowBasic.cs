namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class NexusSearchRowBasic : SearchRowBasic {

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnSelectField[] parentNexusField;

        private SearchColumnSelectField[] stateField;

        private SearchColumnSelectField[] taxAgencyField;

        private SearchColumnBooleanField[] taxDateFromFulfillmentField;

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
        [System.Xml.Serialization.XmlElementAttribute("parentNexus")]
        public SearchColumnSelectField[] parentNexus {
            get {
                return this.parentNexusField;
            }
            set {
                this.parentNexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnSelectField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxAgency")]
        public SearchColumnSelectField[] taxAgency {
            get {
                return this.taxAgencyField;
            }
            set {
                this.taxAgencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxDateFromFulfillment")]
        public SearchColumnBooleanField[] taxDateFromFulfillment {
            get {
                return this.taxDateFromFulfillmentField;
            }
            set {
                this.taxDateFromFulfillmentField = value;
            }
        }
    }
}