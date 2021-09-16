namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EntityTaxRegistrationSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] addressField;

        private SearchColumnLongField[] idField;

        private SearchColumnEnumSelectField[] nexusCountryField;

        private SearchColumnStringField[] taxRegistrationNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address")]
        public SearchColumnSelectField[] address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public SearchColumnLongField[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nexusCountry")]
        public SearchColumnEnumSelectField[] nexusCountry {
            get {
                return this.nexusCountryField;
            }
            set {
                this.nexusCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxRegistrationNumber")]
        public SearchColumnStringField[] taxRegistrationNumber {
            get {
                return this.taxRegistrationNumberField;
            }
            set {
                this.taxRegistrationNumberField = value;
            }
        }
    }
}