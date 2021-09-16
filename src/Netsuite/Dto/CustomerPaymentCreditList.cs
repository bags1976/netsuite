namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class CustomerPaymentCreditList {

        private CustomerPaymentCredit[] creditField;

        private bool replaceAllField;

        public CustomerPaymentCreditList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public CustomerPaymentCredit[] credit {
            get {
                return this.creditField;
            }
            set {
                this.creditField = value;
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