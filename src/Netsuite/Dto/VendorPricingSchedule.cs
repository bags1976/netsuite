namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorPricingSchedule {

        private string scheduleNameField;

        private double scheduleDiscountField;

        private bool scheduleDiscountFieldSpecified;

        /// <remarks/>
        public string scheduleName {
            get {
                return this.scheduleNameField;
            }
            set {
                this.scheduleNameField = value;
            }
        }

        /// <remarks/>
        public double scheduleDiscount {
            get {
                return this.scheduleDiscountField;
            }
            set {
                this.scheduleDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduleDiscountSpecified {
            get {
                return this.scheduleDiscountFieldSpecified;
            }
            set {
                this.scheduleDiscountFieldSpecified = value;
            }
        }
    }
}