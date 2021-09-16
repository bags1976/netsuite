namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Subscriptions {

        private bool subscribedField;

        private bool subscribedFieldSpecified;

        private RecordRef subscriptionField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        /// <remarks/>
        public bool subscribed {
            get {
                return this.subscribedField;
            }
            set {
                this.subscribedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subscribedSpecified {
            get {
                return this.subscribedFieldSpecified;
            }
            set {
                this.subscribedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }
    }
}