namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingRoutingRoutingComponentList {

        private ManufacturingRoutingRoutingComponent[] manufacturingRoutingRoutingComponentField;

        private bool replaceAllField;

        public ManufacturingRoutingRoutingComponentList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingRoutingRoutingComponent")]
        public ManufacturingRoutingRoutingComponent[] manufacturingRoutingRoutingComponent {
            get {
                return this.manufacturingRoutingRoutingComponentField;
            }
            set {
                this.manufacturingRoutingRoutingComponentField = value;
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