namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InventoryDetail : Record {

        private InventoryAssignmentList inventoryAssignmentListField;

        private RecordRef customFormField;

        /// <remarks/>
        public InventoryAssignmentList inventoryAssignmentList {
            get {
                return this.inventoryAssignmentListField;
            }
            set {
                this.inventoryAssignmentListField = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }
    }
}