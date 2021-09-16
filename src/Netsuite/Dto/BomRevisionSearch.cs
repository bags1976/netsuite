namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BomRevisionSearch : SearchRecord {

        private BomRevisionSearchBasic basicField;

        private BomSearchBasic billOfMaterialsJoinField;

        private BomRevisionComponentSearchBasic componentJoinField;

        private TransactionSearchBasic transactionJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public BomRevisionSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BomSearchBasic billOfMaterialsJoin {
            get {
                return this.billOfMaterialsJoinField;
            }
            set {
                this.billOfMaterialsJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionComponentSearchBasic componentJoin {
            get {
                return this.componentJoinField;
            }
            set {
                this.componentJoinField = value;
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