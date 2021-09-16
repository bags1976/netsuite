namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class ItemReceiptExpenseList {

        private ItemReceiptExpense[] expenseField;

        private bool replaceAllField;

        public ItemReceiptExpenseList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expense")]
        public ItemReceiptExpense[] expense {
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