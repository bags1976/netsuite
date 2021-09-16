namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeCorporateCards {

        private string embossedNameField;

        private System.DateTime expirationField;

        private bool expirationFieldSpecified;

        private RecordRef corporateCardProfileField;

        /// <remarks/>
        public string embossedName {
            get {
                return this.embossedNameField;
            }
            set {
                this.embossedNameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expiration {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationSpecified {
            get {
                return this.expirationFieldSpecified;
            }
            set {
                this.expirationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef corporateCardProfile {
            get {
                return this.corporateCardProfileField;
            }
            set {
                this.corporateCardProfileField = value;
            }
        }
    }
}