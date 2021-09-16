namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ServiceItemTaskTemplates {

        private string taskNameField;

        private long taskStartOffsetField;

        private bool taskStartOffsetFieldSpecified;

        private Duration taskDurationField;

        /// <remarks/>
        public string taskName {
            get {
                return this.taskNameField;
            }
            set {
                this.taskNameField = value;
            }
        }

        /// <remarks/>
        public long taskStartOffset {
            get {
                return this.taskStartOffsetField;
            }
            set {
                this.taskStartOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taskStartOffsetSpecified {
            get {
                return this.taskStartOffsetFieldSpecified;
            }
            set {
                this.taskStartOffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration taskDuration {
            get {
                return this.taskDurationField;
            }
            set {
                this.taskDurationField = value;
            }
        }
    }
}