namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SubsidiaryTaxRegistration {

        private long idField;

        private bool idFieldSpecified;

        private Country nexusCountryField;

        private bool nexusCountryFieldSpecified;

        private RecordRef nexusField;

        private RecordRef taxAgencyField;

        private string taxRegistrationNumberField;

        private RecordRef taxEngineField;

        private System.DateTime effectiveFromField;

        private bool effectiveFromFieldSpecified;

        private System.DateTime validUntilField;

        private bool validUntilFieldSpecified;

        /// <remarks/>
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Country nexusCountry {
            get {
                return this.nexusCountryField;
            }
            set {
                this.nexusCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nexusCountrySpecified {
            get {
                return this.nexusCountryFieldSpecified;
            }
            set {
                this.nexusCountryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
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
        public string taxRegistrationNumber {
            get {
                return this.taxRegistrationNumberField;
            }
            set {
                this.taxRegistrationNumberField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxEngine {
            get {
                return this.taxEngineField;
            }
            set {
                this.taxEngineField = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveFrom {
            get {
                return this.effectiveFromField;
            }
            set {
                this.effectiveFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveFromSpecified {
            get {
                return this.effectiveFromFieldSpecified;
            }
            set {
                this.effectiveFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime validUntil {
            get {
                return this.validUntilField;
            }
            set {
                this.validUntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validUntilSpecified {
            get {
                return this.validUntilFieldSpecified;
            }
            set {
                this.validUntilFieldSpecified = value;
            }
        }
    }
}