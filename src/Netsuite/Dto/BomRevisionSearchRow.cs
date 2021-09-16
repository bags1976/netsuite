namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BomRevisionSearchRow : SearchRow {

        private BomRevisionSearchRowBasic basicField;

        private BomSearchRowBasic billOfMaterialsJoinField;

        private BomRevisionComponentSearchRowBasic componentJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public BomRevisionSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BomSearchRowBasic billOfMaterialsJoin {
            get {
                return this.billOfMaterialsJoinField;
            }
            set {
                this.billOfMaterialsJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionComponentSearchRowBasic componentJoin {
            get {
                return this.componentJoinField;
            }
            set {
                this.componentJoinField = value;
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