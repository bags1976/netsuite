namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class DataCenterUrls {

        private string restDomainField;

        private string webservicesDomainField;

        private string systemDomainField;

        /// <remarks/>
        public string restDomain {
            get {
                return this.restDomainField;
            }
            set {
                this.restDomainField = value;
            }
        }

        /// <remarks/>
        public string webservicesDomain {
            get {
                return this.webservicesDomainField;
            }
            set {
                this.webservicesDomainField = value;
            }
        }

        /// <remarks/>
        public string systemDomain {
            get {
                return this.systemDomainField;
            }
            set {
                this.systemDomainField = value;
            }
        }
    }
}