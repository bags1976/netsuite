namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:website_2021_1.lists.webservices.netsuite.com")]
    public partial class SiteCategorySearchAdvanced : SearchRecord {

        private SiteCategorySearch criteriaField;

        private SiteCategorySearchRow columnsField;

        private string savedSearchIdField;

        private string savedSearchScriptIdField;

        /// <remarks/>
        public SiteCategorySearch criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }

        /// <remarks/>
        public SiteCategorySearchRow columns {
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