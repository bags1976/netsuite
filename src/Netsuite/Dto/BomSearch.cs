namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BomSearch : SearchRecord {

        private BomSearchBasic basicField;

        private AssemblyItemBomSearchBasic assemblyItemJoinField;

        private BomRevisionSearchBasic revisionJoinField;

        private TransactionSearchBasic transactionJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public BomSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AssemblyItemBomSearchBasic assemblyItemJoin {
            get {
                return this.assemblyItemJoinField;
            }
            set {
                this.assemblyItemJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionSearchBasic revisionJoin {
            get {
                return this.revisionJoinField;
            }
            set {
                this.revisionJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
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