namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class MerchandiseHierarchyNodeSearchAdvanced : SearchRecord {

        private MerchandiseHierarchyNodeSearch criteriaField;

        private MerchandiseHierarchyNodeSearchRow columnsField;

        private string savedSearchIdField;

        private string savedSearchScriptIdField;

        /// <remarks/>
        public MerchandiseHierarchyNodeSearch criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }

        /// <remarks/>
        public MerchandiseHierarchyNodeSearchRow columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string savedSearchId {
            get {
                return this.savedSearchIdField;
            }
            set {
                this.savedSearchIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string savedSearchScriptId {
            get {
                return this.savedSearchScriptIdField;
            }
            set {
                this.savedSearchScriptIdField = value;
            }
        }
    }
}