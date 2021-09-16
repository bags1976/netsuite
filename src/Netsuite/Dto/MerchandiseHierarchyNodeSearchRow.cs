namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class MerchandiseHierarchyNodeSearchRow : SearchRow {

        private MerchandiseHierarchyNodeSearchRowBasic basicField;

        private MerchandiseHierarchyNodeSearchRowBasic parentNodeJoinField;

        /// <remarks/>
        public MerchandiseHierarchyNodeSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public MerchandiseHierarchyNodeSearchRowBasic parentNodeJoin {
            get {
                return this.parentNodeJoinField;
            }
            set {
                this.parentNodeJoinField = value;
            }
        }
    }
}