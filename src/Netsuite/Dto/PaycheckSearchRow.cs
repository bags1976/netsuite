namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckSearchRow : SearchRow {

        private PaycheckSearchRowBasic basicField;

        private EmployeeSearchRowBasic employeeJoinField;

        private PayrollItemSearchRowBasic payrollItemJoinField;

        /// <remarks/>
        public PaycheckSearchRowBasic basic {
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
        public PayrollItemSearchRowBasic payrollItemJoin {
            get {
                return this.payrollItemJoinField;
            }
            set {
                this.payrollItemJoinField = value;
            }
        }
    }
}