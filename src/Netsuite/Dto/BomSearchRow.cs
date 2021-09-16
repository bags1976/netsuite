namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BomSearchRow : SearchRow {

        private BomSearchRowBasic basicField;

        private AssemblyItemBomSearchRowBasic assemblyItemJoinField;

        private BomRevisionSearchRowBasic revisionJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public BomSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AssemblyItemBomSearchRowBasic assemblyItemJoin {
            get {
                return this.assemblyItemJoinField;
            }
            set {
                this.assemblyItemJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionSearchRowBasic revisionJoin {
            get {
                return this.revisionJoinField;
            }
            set {
                this.revisionJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
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