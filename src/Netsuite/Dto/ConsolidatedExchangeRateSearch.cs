namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ConsolidatedExchangeRateSearch : SearchRecord {

        private ConsolidatedExchangeRateSearchBasic basicField;

        private SubsidiarySearchBasic fromSubsidiaryJoinField;

        private AccountingPeriodSearchBasic periodJoinField;

        private SubsidiarySearchBasic toSubsidiaryJoinField;

        private EmployeeSearchBasic userJoinField;

        /// <remarks/>
        public ConsolidatedExchangeRateSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchBasic fromSubsidiaryJoin {
            get {
                return this.fromSubsidiaryJoinField;
            }
            set {
                this.fromSubsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public AccountingPeriodSearchBasic periodJoin {
            get {
                return this.periodJoinField;
            }
            set {
                this.periodJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchBasic toSubsidiaryJoin {
            get {
                return this.toSubsidiaryJoinField;
            }
            set {
                this.toSubsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}