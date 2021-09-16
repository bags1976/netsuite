namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeSheetSearch : SearchRecord {

        private TimeSheetSearchBasic basicField;

        private EmployeeSearchBasic employeeJoinField;

        private TimeBillSearchBasic timeBillJoinField;

        private TimeEntrySearchBasic timeEntryJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public TimeSheetSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
            }
        }

        /// <remarks/>
        public TimeBillSearchBasic timeBillJoin {
            get {
                return this.timeBillJoinField;
            }
            set {
                this.timeBillJoinField = value;
            }
        }

        /// <remarks/>
        public TimeEntrySearchBasic timeEntryJoin {
            get {
                return this.timeEntryJoinField;
            }
            set {
                this.timeEntryJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}