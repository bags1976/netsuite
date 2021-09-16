namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class MerchandiseHierarchyNodeHierarchyVersionsList {

        private MerchandiseHierarchyNodeHierarchyVersions[] merchandiseHierarchyNodeHierarchyVersionsField;

        private bool replaceAllField;

        public MerchandiseHierarchyNodeHierarchyVersionsList() {
            this.replaceAllField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("merchandiseHierarchyNodeHierarchyVersions")]
        public MerchandiseHierarchyNodeHierarchyVersions[] merchandiseHierarchyNodeHierarchyVersions {
            get {
                return this.merchandiseHierarchyNodeHierarchyVersionsField;
            }
            set {
                this.merchandiseHierarchyNodeHierarchyVersionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool replaceAll {
            get {
                return this.replaceAllField;
            }
            set {
                this.replaceAllField = value;
            }
        }
    }
}