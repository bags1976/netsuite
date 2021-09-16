namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckPayExpList {

        private PaycheckPayExp[] paycheckPayExpField;

        private bool replaceAllField;

        public PaycheckPayExpList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paycheckPayExp")]
        public PaycheckPayExp[] paycheckPayExp {
            get {
                return this.paycheckPayExpField;
            }
            set {
                this.paycheckPayExpField = value;
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