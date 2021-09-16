namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class WorkOrderIssueComponentList {

        private WorkOrderIssueComponent[] workOrderIssueComponentField;

        private bool replaceAllField;

        public WorkOrderIssueComponentList() {
            this.replaceAllField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workOrderIssueComponent")]
        public WorkOrderIssueComponent[] workOrderIssueComponent {
            get {
                return this.workOrderIssueComponentField;
            }
            set {
                this.workOrderIssueComponentField = value;
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