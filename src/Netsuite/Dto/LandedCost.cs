namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class LandedCost : Record {

        private LandedCostDataList landedCostDataListField;

        /// <remarks/>
        public LandedCostDataList landedCostDataList {
            get {
                return this.landedCostDataListField;
            }
            set {
                this.landedCostDataListField = value;
            }
        }
    }
}