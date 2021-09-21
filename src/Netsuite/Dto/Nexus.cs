using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Nexus : Record {

        private Country countryField;

        private bool countryFieldSpecified;

        private RecordRef stateField;

        private RecordRef taxAgencyField;

        private RecordRef taxAgencyPstField;

        private RecordRef taxCodeField;

        private string descriptionField;

        private RecordRef parentNexusField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool taxDateFromFulfillmentField;

        private bool taxDateFromFulfillmentFieldSpecified;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxAgency {
            get {
                return this.taxAgencyField;
            }
            set {
                this.taxAgencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxAgencyPst {
            get {
                return this.taxAgencyPstField;
            }
            set {
                this.taxAgencyPstField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
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
        public RecordRef parentNexus {
            get {
                return this.parentNexusField;
            }
            set {
                this.parentNexusField = value;
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
        public bool taxDateFromFulfillment {
            get {
                return this.taxDateFromFulfillmentField;
            }
            set {
                this.taxDateFromFulfillmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxDateFromFulfillmentSpecified {
            get {
                return this.taxDateFromFulfillmentFieldSpecified;
            }
            set {
                this.taxDateFromFulfillmentFieldSpecified = value;
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