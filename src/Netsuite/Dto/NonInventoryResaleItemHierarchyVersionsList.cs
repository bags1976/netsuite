namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class NonInventoryResaleItemHierarchyVersionsList {

        private NonInventoryResaleItemHierarchyVersions[] nonInventoryResaleItemHierarchyVersionsField;

        private bool replaceAllField;

        public NonInventoryResaleItemHierarchyVersionsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nonInventoryResaleItemHierarchyVersions")]
        public NonInventoryResaleItemHierarchyVersions[] nonInventoryResaleItemHierarchyVersions {
            get {
                return this.nonInventoryResaleItemHierarchyVersionsField;
            }
            set {
                this.nonInventoryResaleItemHierarchyVersionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
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