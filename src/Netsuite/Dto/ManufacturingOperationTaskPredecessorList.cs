namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingOperationTaskPredecessorList {

        private ManufacturingOperationTaskPredecessor[] manufacturingOperationTaskPredecessorField;

        private bool replaceAllField;

        public ManufacturingOperationTaskPredecessorList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingOperationTaskPredecessor")]
        public ManufacturingOperationTaskPredecessor[] manufacturingOperationTaskPredecessor {
            get {
                return this.manufacturingOperationTaskPredecessorField;
            }
            set {
                this.manufacturingOperationTaskPredecessorField = value;
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