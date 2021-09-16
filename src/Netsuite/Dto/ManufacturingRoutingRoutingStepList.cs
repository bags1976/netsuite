namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingRoutingStepList {

        private ManufacturingRoutingRoutingStep[] manufacturingRoutingRoutingStepField;

        private bool replaceAllField;

        public ManufacturingRoutingRoutingStepList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingRoutingRoutingStep")]
        public ManufacturingRoutingRoutingStep[] manufacturingRoutingRoutingStep {
            get {
                return this.manufacturingRoutingRoutingStepField;
            }
            set {
                this.manufacturingRoutingRoutingStepField = value;
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