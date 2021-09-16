namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class AccountingTransactionSearch : SearchRecord {

        private AccountingTransactionSearchBasic basicField;

        private AccountSearchBasic accountJoinField;

        private RevRecScheduleSearchBasic revRecScheduleJoinField;

        private TransactionSearchBasic transactionJoinField;

        /// <remarks/>
        public AccountingTransactionSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic accountJoin {
            get {
                return this.accountJoinField;
            }
            set {
                this.accountJoinField = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleSearchBasic revRecScheduleJoin {
            get {
                return this.revRecScheduleJoinField;
            }
            set {
                this.revRecScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
            }
        }
    }
}