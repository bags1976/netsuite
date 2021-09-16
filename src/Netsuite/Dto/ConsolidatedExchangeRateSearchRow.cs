namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ConsolidatedExchangeRateSearchRow : SearchRow {

        private ConsolidatedExchangeRateSearchRowBasic basicField;

        private SubsidiarySearchRowBasic fromSubsidiaryJoinField;

        private AccountingPeriodSearchRowBasic periodJoinField;

        private SubsidiarySearchRowBasic toSubsidiaryJoinField;

        private EmployeeSearchRowBasic userJoinField;

        /// <remarks/>
        public ConsolidatedExchangeRateSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchRowBasic fromSubsidiaryJoin {
            get {
                return this.fromSubsidiaryJoinField;
            }
            set {
                this.fromSubsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public AccountingPeriodSearchRowBasic periodJoin {
            get {
                return this.periodJoinField;
            }
            set {
                this.periodJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchRowBasic toSubsidiaryJoin {
            get {
                return this.toSubsidiaryJoinField;
            }
            set {
                this.toSubsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }
    }
}