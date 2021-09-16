namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SerializedInventoryItemHierarchyVersionsList {

        private SerializedInventoryItemHierarchyVersions[] serializedInventoryItemHierarchyVersionsField;

        private bool replaceAllField;

        public SerializedInventoryItemHierarchyVersionsList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serializedInventoryItemHierarchyVersions")]
        public SerializedInventoryItemHierarchyVersions[] serializedInventoryItemHierarchyVersions {
            get {
                return this.serializedInventoryItemHierarchyVersionsField;
            }
            set {
                this.serializedInventoryItemHierarchyVersionsField = value;
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