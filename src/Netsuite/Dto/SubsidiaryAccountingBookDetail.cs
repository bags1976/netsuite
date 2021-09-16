namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class SubsidiaryAccountingBookDetail {

        private RecordRef accountingBookField;

        private RecordRef currencyField;

        private AccountingBookStatus bookStatusField;

        private bool bookStatusFieldSpecified;

        /// <remarks/>
        public RecordRef accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public AccountingBookStatus bookStatus {
            get {
                return this.bookStatusField;
            }
            set {
                this.bookStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bookStatusSpecified {
            get {
                return this.bookStatusFieldSpecified;
            }
            set {
                this.bookStatusFieldSpecified = value;
            }
        }
    }
}