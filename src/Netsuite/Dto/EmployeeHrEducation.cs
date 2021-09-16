namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeHrEducation {

        private RecordRef educationField;

        private string degreeField;

        private System.DateTime degreeDateField;

        private bool degreeDateFieldSpecified;

        /// <remarks/>
        public RecordRef education {
            get {
                return this.educationField;
            }
            set {
                this.educationField = value;
            }
        }

        /// <remarks/>
        public string degree {
            get {
                return this.degreeField;
            }
            set {
                this.degreeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime degreeDate {
            get {
                return this.degreeDateField;
            }
            set {
                this.degreeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool degreeDateSpecified {
            get {
                return this.degreeDateFieldSpecified;
            }
            set {
                this.degreeDateFieldSpecified = value;
            }
        }
    }
}