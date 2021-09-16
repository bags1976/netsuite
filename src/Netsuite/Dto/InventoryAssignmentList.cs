namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InventoryAssignmentList {

        private InventoryAssignment[] inventoryAssignmentField;

        private bool replaceAllField;

        public InventoryAssignmentList() {
            this.replaceAllField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventoryAssignment")]
        public InventoryAssignment[] inventoryAssignment {
            get {
                return this.inventoryAssignmentField;
            }
            set {
                this.inventoryAssignmentField = value;
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