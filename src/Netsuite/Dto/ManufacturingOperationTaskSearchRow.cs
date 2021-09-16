namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingOperationTaskSearchRow : SearchRow {

        private ManufacturingOperationTaskSearchRowBasic basicField;

        private ManufacturingOperationTaskSearchRowBasic predecessorJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private TransactionSearchRowBasic workOrderJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ManufacturingOperationTaskSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskSearchRowBasic predecessorJoin {
            get {
                return this.predecessorJoinField;
            }
            set {
                this.predecessorJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic workOrderJoin {
            get {
                return this.workOrderJoinField;
            }
            set {
                this.workOrderJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}