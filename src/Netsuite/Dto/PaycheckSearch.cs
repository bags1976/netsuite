namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckSearch : SearchRecord {

        private PaycheckSearchBasic basicField;

        private EmployeeSearchBasic employeeJoinField;

        private PayrollItemSearchBasic payrollItemJoinField;

        /// <remarks/>
        public PaycheckSearchBasic basic {
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
        public PayrollItemSearchBasic payrollItemJoin {
            get {
                return this.payrollItemJoinField;
            }
            set {
                this.payrollItemJoinField = value;
            }
        }
    }
}