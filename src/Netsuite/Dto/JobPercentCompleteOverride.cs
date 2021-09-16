namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobPercentCompleteOverride {

        private RecordRef periodField;

        private double percentField;

        private bool percentFieldSpecified;

        private string commentsField;

        /// <remarks/>
        public RecordRef period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public double percent {
            get {
                return this.percentField;
            }
            set {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentSpecified {
            get {
                return this.percentFieldSpecified;
            }
            set {
                this.percentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    }
}