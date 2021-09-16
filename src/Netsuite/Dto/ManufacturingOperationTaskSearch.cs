namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingOperationTaskSearch : SearchRecord {

        private ManufacturingOperationTaskSearchBasic basicField;

        private ManufacturingOperationTaskSearchBasic predecessorJoinField;

        private EmployeeSearchBasic userJoinField;

        private TransactionSearchBasic workOrderJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ManufacturingOperationTaskSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskSearchBasic predecessorJoin {
            get {
                return this.predecessorJoinField;
            }
            set {
                this.predecessorJoinField = value;
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

        /// <remarks/>
        public TransactionSearchBasic workOrderJoin {
            get {
                return this.workOrderJoinField;
            }
            set {
                this.workOrderJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}