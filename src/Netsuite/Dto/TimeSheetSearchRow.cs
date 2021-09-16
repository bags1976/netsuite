namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeSheetSearchRow : SearchRow {

        private TimeSheetSearchRowBasic basicField;

        private EmployeeSearchRowBasic employeeJoinField;

        private TimeBillSearchRowBasic timeBillJoinField;

        private TimeEntrySearchRowBasic timeEntryJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public TimeSheetSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
            }
        }

        /// <remarks/>
        public TimeBillSearchRowBasic timeBillJoin {
            get {
                return this.timeBillJoinField;
            }
            set {
                this.timeBillJoinField = value;
            }
        }

        /// <remarks/>
        public TimeEntrySearchRowBasic timeEntryJoin {
            get {
                return this.timeEntryJoinField;
            }
            set {
                this.timeEntryJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}