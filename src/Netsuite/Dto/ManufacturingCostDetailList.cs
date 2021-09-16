namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingCostDetailList {

        private ManufacturingCostDetail[] manufacturingCostDetailField;

        private bool replaceAllField;

        public ManufacturingCostDetailList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingCostDetail")]
        public ManufacturingCostDetail[] manufacturingCostDetail {
            get {
                return this.manufacturingCostDetailField;
            }
            set {
                this.manufacturingCostDetailField = value;
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