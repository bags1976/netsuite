namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayDeductList {

        private PaycheckPayDeduct[] paycheckPayDeductField;

        private bool replaceAllField;

        public PaycheckPayDeductList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paycheckPayDeduct")]
        public PaycheckPayDeduct[] paycheckPayDeduct {
            get {
                return this.paycheckPayDeductField;
            }
            set {
                this.paycheckPayDeductField = value;
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