namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:bank_2021_1.transactions.webservices.netsuite.com")]
    public partial class CheckExpenseList {

        private CheckExpense[] expenseField;

        private bool replaceAllField;

        public CheckExpenseList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expense")]
        public CheckExpense[] expense {
            get {
                return this.expenseField;
            }
            set {
                this.expenseField = value;
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