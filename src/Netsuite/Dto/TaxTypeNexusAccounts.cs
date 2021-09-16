namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TaxTypeNexusAccounts {

        private RecordRef nexusField;

        private RecordRef payablesAccountField;

        private RecordRef receivablesAccountField;

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
        public RecordRef payablesAccount {
            get {
                return this.payablesAccountField;
            }
            set {
                this.payablesAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }
    }
}