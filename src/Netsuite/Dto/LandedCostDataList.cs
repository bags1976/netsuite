namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class LandedCostDataList {

        private LandedCostData[] landedCostDataField;

        private bool replaceAllField;

        public LandedCostDataList() {
            this.replaceAllField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostData")]
        public LandedCostData[] landedCostData {
            get {
                return this.landedCostDataField;
            }
            set {
                this.landedCostDataField = value;
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