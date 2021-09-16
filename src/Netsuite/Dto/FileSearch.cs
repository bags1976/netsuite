namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:filecabinet_2021_1.documents.webservices.netsuite.com")]
    public partial class FileSearch : SearchRecord {

        private FileSearchBasic basicField;

        private CustomerSearchBasic shopperJoinField;

        private EmployeeSearchBasic userJoinField;

        /// <remarks/>
        public FileSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchBasic shopperJoin {
            get {
                return this.shopperJoinField;
            }
            set {
                this.shopperJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}