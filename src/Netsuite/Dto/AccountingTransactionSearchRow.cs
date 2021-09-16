namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class AccountingTransactionSearchRow : SearchRow {

        private AccountingTransactionSearchRowBasic basicField;

        private AccountSearchRowBasic accountJoinField;

        private RevRecScheduleSearchRowBasic revRecScheduleJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        /// <remarks/>
        public AccountingTransactionSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic accountJoin {
            get {
                return this.accountJoinField;
            }
            set {
                this.accountJoinField = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleSearchRowBasic revRecScheduleJoin {
            get {
                return this.revRecScheduleJoinField;
            }
            set {
                this.revRecScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
            }
        }
    }
}