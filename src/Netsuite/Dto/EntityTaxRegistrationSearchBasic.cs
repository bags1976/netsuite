namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EntityTaxRegistrationSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField addressField;

        private SearchLongField idField;

        private SearchEnumMultiSelectField nexusCountryField;

        private SearchStringField taxRegistrationNumberField;

        /// <remarks/>
        public SearchMultiSelectField address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public SearchLongField id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField nexusCountry {
            get {
                return this.nexusCountryField;
            }
            set {
                this.nexusCountryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField taxRegistrationNumber {
            get {
                return this.taxRegistrationNumberField;
            }
            set {
                this.taxRegistrationNumberField = value;
            }
        }
    }
}