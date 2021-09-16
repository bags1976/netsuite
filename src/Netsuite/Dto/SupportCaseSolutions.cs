namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class SupportCaseSolutions {

        private RecordRef solutionField;

        private string messageField;

        private System.DateTime dateAppliedField;

        private bool dateAppliedFieldSpecified;

        /// <remarks/>
        public RecordRef solution {
            get {
                return this.solutionField;
            }
            set {
                this.solutionField = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateApplied {
            get {
                return this.dateAppliedField;
            }
            set {
                this.dateAppliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateAppliedSpecified {
            get {
                return this.dateAppliedFieldSpecified;
            }
            set {
                this.dateAppliedFieldSpecified = value;
            }
        }
    }
}