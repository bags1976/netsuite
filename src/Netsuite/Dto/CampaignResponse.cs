namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignResponse : Record {

        private RecordRef entityField;

        private RecordRef leadSourceField;

        private RecordRef campaignEventField;

        private System.DateTime campaignResponseDateField;

        private bool campaignResponseDateFieldSpecified;

        private string channelField;

        private CampaignResponseResponse responseField;

        private bool responseFieldSpecified;

        private string noteField;

        private CampaignResponseResponsesList responsesListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public RecordRef campaignEvent {
            get {
                return this.campaignEventField;
            }
            set {
                this.campaignEventField = value;
            }
        }

        /// <remarks/>
        public System.DateTime campaignResponseDate {
            get {
                return this.campaignResponseDateField;
            }
            set {
                this.campaignResponseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool campaignResponseDateSpecified {
            get {
                return this.campaignResponseDateFieldSpecified;
            }
            set {
                this.campaignResponseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
            }
        }

        /// <remarks/>
        public CampaignResponseResponse response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool responseSpecified {
            get {
                return this.responseFieldSpecified;
            }
            set {
                this.responseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }

        /// <remarks/>
        public CampaignResponseResponsesList responsesList {
            get {
                return this.responsesListField;
            }
            set {
                this.responsesListField = value;
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