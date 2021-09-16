namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class AsyncStatusResult {

        private string jobIdField;

        private AsyncStatusType statusField;

        private double percentCompletedField;

        private double estRemainingDurationField;

        /// <remarks/>
        public string jobId {
            get {
                return this.jobIdField;
            }
            set {
                this.jobIdField = value;
            }
        }

        /// <remarks/>
        public AsyncStatusType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public double percentCompleted {
            get {
                return this.percentCompletedField;
            }
            set {
                this.percentCompletedField = value;
            }
        }

        /// <remarks/>
        public double estRemainingDuration {
            get {
                return this.estRemainingDurationField;
            }
            set {
                this.estRemainingDurationField = value;
            }
        }
    }
}