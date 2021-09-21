using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class StatusDetail {

        private StatusDetailCodeType codeField;

        private bool codeFieldSpecified;

        private string messageField;

        private bool afterSubmitFailedField;

        private bool afterSubmitFailedFieldSpecified;

        private StatusDetailType typeField;

        public StatusDetail() {
            this.typeField = StatusDetailType.ERROR;
        }

        /// <remarks/>
        public StatusDetailCodeType code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeSpecified {
            get {
                return this.codeFieldSpecified;
            }
            set {
                this.codeFieldSpecified = value;
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
        public bool afterSubmitFailed {
            get {
                return this.afterSubmitFailedField;
            }
            set {
                this.afterSubmitFailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool afterSubmitFailedSpecified {
            get {
                return this.afterSubmitFailedFieldSpecified;
            }
            set {
                this.afterSubmitFailedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatusDetailType.ERROR)]
        public StatusDetailType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}