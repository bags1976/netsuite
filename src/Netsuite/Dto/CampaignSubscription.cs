namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignSubscription : Record {

        private string nameField;

        private string descriptionField;

        private bool subscribedByDefaultField;

        private bool subscribedByDefaultFieldSpecified;

        private bool unsubscribedField;

        private bool unsubscribedFieldSpecified;

        private string externalNameField;

        private string externalDescriptionField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool subscribedByDefault {
            get {
                return this.subscribedByDefaultField;
            }
            set {
                this.subscribedByDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subscribedByDefaultSpecified {
            get {
                return this.subscribedByDefaultFieldSpecified;
            }
            set {
                this.subscribedByDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool unsubscribed {
            get {
                return this.unsubscribedField;
            }
            set {
                this.unsubscribedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unsubscribedSpecified {
            get {
                return this.unsubscribedFieldSpecified;
            }
            set {
                this.unsubscribedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string externalName {
            get {
                return this.externalNameField;
            }
            set {
                this.externalNameField = value;
            }
        }

        /// <remarks/>
        public string externalDescription {
            get {
                return this.externalDescriptionField;
            }
            set {
                this.externalDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}