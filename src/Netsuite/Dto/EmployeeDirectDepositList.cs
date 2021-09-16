namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeDirectDepositList {

        private EmployeeDirectDeposit[] employeeDirectDepositField;

        private bool replaceAllField;

        public EmployeeDirectDepositList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employeeDirectDeposit")]
        public EmployeeDirectDeposit[] employeeDirectDeposit {
            get {
                return this.employeeDirectDepositField;
            }
            set {
                this.employeeDirectDepositField = value;
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