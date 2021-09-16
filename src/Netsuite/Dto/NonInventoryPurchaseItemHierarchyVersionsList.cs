namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class NonInventoryPurchaseItemHierarchyVersionsList {

        private NonInventoryPurchaseItemHierarchyVersions[] nonInventoryPurchaseItemHierarchyVersionsField;

        private bool replaceAllField;

        public NonInventoryPurchaseItemHierarchyVersionsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nonInventoryPurchaseItemHierarchyVersions")]
        public NonInventoryPurchaseItemHierarchyVersions[] nonInventoryPurchaseItemHierarchyVersions {
            get {
                return this.nonInventoryPurchaseItemHierarchyVersionsField;
            }
            set {
                this.nonInventoryPurchaseItemHierarchyVersionsField = value;
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